
namespace ReconocimientoFacial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btCapturar = new System.Windows.Forms.Button();
            this.btDetectar = new System.Windows.Forms.Button();
            this.btReconocer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uI_ButtonImage1 = new UIDC.UI_ButtonImage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uI_DoLabel1 = new UIDC.UI_DoLabel();
            this.uI_DoLabel2 = new UIDC.UI_DoLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uI_ButtonImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btCapturar
            // 
            this.btCapturar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(22)))));
            this.btCapturar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.btCapturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btCapturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btCapturar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCapturar.Location = new System.Drawing.Point(6, 414);
            this.btCapturar.Name = "btCapturar";
            this.btCapturar.Size = new System.Drawing.Size(165, 37);
            this.btCapturar.TabIndex = 1;
            this.btCapturar.Text = "ENCENDER CÁMARA";
            this.btCapturar.UseVisualStyleBackColor = false;
            this.btCapturar.Click += new System.EventHandler(this.btCapturar_Click);
            // 
            // btDetectar
            // 
            this.btDetectar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btDetectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.btDetectar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.btDetectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btDetectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDetectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btDetectar.Location = new System.Drawing.Point(342, 414);
            this.btDetectar.Name = "btDetectar";
            this.btDetectar.Size = new System.Drawing.Size(172, 37);
            this.btDetectar.TabIndex = 2;
            this.btDetectar.Text = "DETECTAR ROSTROS";
            this.btDetectar.UseVisualStyleBackColor = false;
            this.btDetectar.Click += new System.EventHandler(this.btDetectar_Click);
            // 
            // btReconocer
            // 
            this.btReconocer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btReconocer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.btReconocer.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.btReconocer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btReconocer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btReconocer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btReconocer.Location = new System.Drawing.Point(20, 409);
            this.btReconocer.Name = "btReconocer";
            this.btReconocer.Size = new System.Drawing.Size(253, 35);
            this.btReconocer.TabIndex = 4;
            this.btReconocer.Text = "RECONOCER ROSTRO";
            this.btReconocer.UseVisualStyleBackColor = false;
            this.btReconocer.Click += new System.EventHandler(this.btReconocer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(19, 363);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 29);
            this.textBox1.TabIndex = 5;
            // 
            // btAgregar
            // 
            this.btAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.btAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.btAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAgregar.Font = new System.Drawing.Font("ELEGANT TYPEWRITER", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(19, 24);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(277, 36);
            this.btAgregar.TabIndex = 7;
            this.btAgregar.Text = "AGREGAR ROSTRO";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click_1);
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.btGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.btGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btGuardar.Font = new System.Drawing.Font("ELEGANT TYPEWRITER", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(19, 398);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(277, 46);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "GUARDAR ";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("ELEGANT TYPEWRITER", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese su nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btReconocer);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Font = new System.Drawing.Font("ELEGANT TYPEWRITER", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(849, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 457);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rostros almacenados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btDetectar);
            this.groupBox2.Controls.Add(this.btCapturar);
            this.groupBox2.Font = new System.Drawing.Font("ELEGANT TYPEWRITER", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 457);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WebCam";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btAgregar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btGuardar);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Font = new System.Drawing.Font("ELEGANT TYPEWRITER", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(539, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 457);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.uI_DoLabel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 78);
            this.panel1.TabIndex = 17;
            // 
            // uI_ButtonImage1
            // 
            this.uI_ButtonImage1.BackgroundImage = global::ReconocimientoFacial.Properties.Resources.info_information_icon_142931;
            this.uI_ButtonImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uI_ButtonImage1.Image = ((System.Drawing.Image)(resources.GetObject("uI_ButtonImage1.Image")));
            this.uI_ButtonImage1.ImageActive = null;
            this.uI_ButtonImage1.Location = new System.Drawing.Point(12, 547);
            this.uI_ButtonImage1.Name = "uI_ButtonImage1";
            this.uI_ButtonImage1.Size = new System.Drawing.Size(51, 32);
            this.uI_ButtonImage1.TabIndex = 16;
            this.uI_ButtonImage1.TabStop = false;
            this.uI_ButtonImage1.Zoom = 10;
            this.uI_ButtonImage1.Click += new System.EventHandler(this.uI_ButtonImage1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox4.BackgroundImage = global::ReconocimientoFacial.Properties.Resources.user_accounts_15362;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(19, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(277, 240);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackgroundImage = global::ReconocimientoFacial.Properties.Resources.webcam_icon_129436;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 377);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 189);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(12, 219);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(270, 182);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // uI_DoLabel1
            // 
            this.uI_DoLabel1.ColorDoText = System.Drawing.Color.DodgerBlue;
            this.uI_DoLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_DoLabel1.Location = new System.Drawing.Point(65, 551);
            this.uI_DoLabel1.Name = "uI_DoLabel1";
            this.uI_DoLabel1.Offset = 1D;
            this.uI_DoLabel1.ShadowTextColor = System.Drawing.Color.Black;
            this.uI_DoLabel1.Size = new System.Drawing.Size(121, 23);
            this.uI_DoLabel1.TabIndex = 18;
            this.uI_DoLabel1.Text = null;
            this.uI_DoLabel1.Text_1 = "ACERCA";
            this.uI_DoLabel1.Text_2 = " DE...";
            // 
            // uI_DoLabel2
            // 
            this.uI_DoLabel2.ColorDoText = System.Drawing.Color.DodgerBlue;
            this.uI_DoLabel2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_DoLabel2.Location = new System.Drawing.Point(327, 12);
            this.uI_DoLabel2.Name = "uI_DoLabel2";
            this.uI_DoLabel2.Offset = 1D;
            this.uI_DoLabel2.ShadowTextColor = System.Drawing.Color.Black;
            this.uI_DoLabel2.Size = new System.Drawing.Size(619, 48);
            this.uI_DoLabel2.TabIndex = 0;
            this.uI_DoLabel2.Text = null;
            this.uI_DoLabel2.Text_1 = "SISTEMA DE ";
            this.uI_DoLabel2.Text_2 = " RECONOCIMIENTO FACIAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1157, 591);
            this.Controls.Add(this.uI_DoLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uI_ButtonImage1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Recognition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uI_ButtonImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCapturar;
        private System.Windows.Forms.Button btDetectar;
        private System.Windows.Forms.Button btReconocer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private UIDC.UI_ButtonImage uI_ButtonImage1;
        private System.Windows.Forms.Panel panel1;
        private UIDC.UI_DoLabel uI_DoLabel1;
        private UIDC.UI_DoLabel uI_DoLabel2;
    }
}

