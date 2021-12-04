using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace ReconocimientoFacial
{
    public partial class Form1 : Form
    {

        #region variables 
        private Capture video = null;
        private Image<Bgr, Byte> CurrentFrame = null;
        Mat frame = new Mat();
        private bool detectarRostros = false;
        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabels = new List<int>();
        bool guardarCara = false;
        private static bool isTrained = false;
        EigenFaceRecognizer reg;
        List<string> PersonsNames = new List<string>();
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void btCapturar_Click(object sender, EventArgs e)
        {
            video = new Capture();
            video.ImageGrabbed += ProcessFrame;
            video.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            // CAPTURAR VIDEO
            if (video != null && video.Ptr != IntPtr.Zero)
            {
                video.Retrieve(frame, 0);
                CurrentFrame = frame.ToImage<Bgr, Byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);

                // DETECTAR CARAS
                if (detectarRostros)
                {

                    // CONVERTIR BGR A GrayImage
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(CurrentFrame, grayImage, ColorConversion.Bgr2Gray);
                    CvInvoke.EqualizeHist(grayImage, grayImage);
                    Rectangle[] caras = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

                    // CONDICIONAL SI LAS CARAS SE ESTÁN DETECTANDO
                    if (caras.Length > 0)
                    {

                        foreach (var cara in caras)
                        {
                            // SE DIBUJA UN RECTÁNGULO EN LA CARA
                            CvInvoke.Rectangle(CurrentFrame, cara, new Bgr(Color.BlanchedAlmond).MCvScalar, 2);


                            // PONER EL ROSTRO EN EL PICTUREBOX2
                            Image<Bgr, Byte> resultImage = CurrentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = cara;
                            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox4.Image = resultImage.Bitmap;

                            if (guardarCara)
                            {
                                // SI EL ROSTRO NO EXISTE, SE CREA UN DIRECTORIO
                                string dir = Directory.GetCurrentDirectory() + @"\imgs";
                                if (!Directory.Exists(dir))
                                    Directory.CreateDirectory(dir);

                                Task.Factory.StartNew(() =>
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        resultImage.Resize(200, 200, Inter.Cubic).Save(dir + @"\" + textBox1.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                        Thread.Sleep(1000);
                                    }

                                });

                            }
                            guardarCara = false;

                            if (btAgregar.InvokeRequired)
                            {
                                btAgregar.Invoke(new ThreadStart(delegate
                                {
                                    btAgregar.Enabled = true;
                                }));

                            }

                            // RECONOCER CARAS

                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var res = reg.Predict(grayFaceResult);
                                pictureBox2.Image = grayFaceResult.Bitmap;
                                pictureBox3.Image = TrainedFaces[res.Label].Bitmap;

                                // SI RECONOCE LAS CARAS Y LAS ENCUENTRA
                                if (res.Label > 0)
                                {
                                    CvInvoke.PutText(CurrentFrame, PersonsNames[res.Label], new Point(cara.X - 2, cara.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                }

                                // SI NO RECONOCE LA CARA
                                else
                                {
                                    CvInvoke.PutText(CurrentFrame, "Priscila", new Point(cara.X - 2, cara.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                }

                            }


                        }
                    }
                }              

                // RENDERIZAR EL VIDEO DEL PICTUREBOX1
                pictureBox1.Image = CurrentFrame.Bitmap;
            }

            if (CurrentFrame != null)
                CurrentFrame.Dispose();
        }

        private void btDetectar_Click(object sender, EventArgs e)
        {
            //DETECTAR ROSTROS
            detectarRostros = true;
        }


        private void btAgregar_Click_1(object sender, EventArgs e)
        {
            btGuardar.Enabled = true;
            btAgregar.Enabled = false;
            guardarCara = true;

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            btGuardar.Enabled = false;
            btAgregar.Enabled = true;
            guardarCara = false;
            textBox1.Text = "";
        }

        private void btReconocer_Click(object sender, EventArgs e)
        {
            recImgDelDir();
        }

        private bool recImgDelDir()
        { 
            int ImagesCount = 0;
            double timg = 2000;
            TrainedFaces.Clear();
            PersonsLabels.Clear();
            PersonsNames.Clear();

            try
            {
                string dir = Directory.GetCurrentDirectory() + @"\imgs";
                string[] arch = Directory.GetFiles(dir, "*.jpg", SearchOption.AllDirectories);

                foreach(var file in arch)
                {

                    Image<Gray, Byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic); ;
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);

                    TrainedFaces.Add(trainedImage);
                    PersonsLabels.Add(ImagesCount);
                    string nombre = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(nombre);
                    ImagesCount++;
                    Debug.WriteLine(nombre);

                }
                if (TrainedFaces.Count() > 0)
                {
                    reg = new EigenFaceRecognizer(ImagesCount, timg);
                    reg.Train(TrainedFaces.ToArray(), PersonsLabels.ToArray());

                    isTrained = true;
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error al reconocer la imagen: " + ex.Message);
                return false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void uI_ButtonImage1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
