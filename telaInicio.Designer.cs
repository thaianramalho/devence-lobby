namespace devence_lobby
{
    partial class telaInicio
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
            pictureEntradas = new PictureBox();
            pictureSaidas = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            lblEntradasNumber = new Label();
            lblSaidasNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureEntradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSaidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // pictureEntradas
            // 
            pictureEntradas.Image = Properties.Resources.enter_full1;
            pictureEntradas.Location = new Point(47, 21);
            pictureEntradas.Name = "pictureEntradas";
            pictureEntradas.Size = new Size(359, 284);
            pictureEntradas.SizeMode = PictureBoxSizeMode.Zoom;
            pictureEntradas.TabIndex = 0;
            pictureEntradas.TabStop = false;
            pictureEntradas.Click += pictureEntradas_Click;
            // 
            // pictureSaidas
            // 
            pictureSaidas.Image = Properties.Resources.leave_full1;
            pictureSaidas.Location = new Point(473, 21);
            pictureSaidas.Name = "pictureSaidas";
            pictureSaidas.Size = new Size(359, 284);
            pictureSaidas.SizeMode = PictureBoxSizeMode.Zoom;
            pictureSaidas.TabIndex = 1;
            pictureSaidas.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Rectangle_card;
            pictureBox3.Location = new Point(47, 335);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(261, 113);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Rectangle_card;
            pictureBox4.Location = new Point(309, 335);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(261, 113);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Rectangle_card;
            pictureBox5.Location = new Point(571, 335);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(261, 113);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Rectangle_card;
            pictureBox6.Location = new Point(47, 451);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(261, 113);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Rectangle_card;
            pictureBox7.Location = new Point(309, 451);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(261, 113);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Rectangle_card;
            pictureBox8.Location = new Point(571, 451);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(261, 113);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // lblEntradasNumber
            // 
            lblEntradasNumber.FlatStyle = FlatStyle.Flat;
            lblEntradasNumber.Font = new Font("Roboto Medium", 24F, FontStyle.Bold);
            lblEntradasNumber.ForeColor = Color.White;
            lblEntradasNumber.Location = new Point(144, 70);
            lblEntradasNumber.Name = "lblEntradasNumber";
            lblEntradasNumber.Size = new Size(72, 52);
            lblEntradasNumber.TabIndex = 2;
            lblEntradasNumber.Text = "35";
            lblEntradasNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSaidasNumber
            // 
            lblSaidasNumber.AutoSize = true;
            lblSaidasNumber.Font = new Font("Roboto Medium", 24F, FontStyle.Bold);
            lblSaidasNumber.ForeColor = Color.White;
            lblSaidasNumber.Location = new Point(603, 95);
            lblSaidasNumber.Name = "lblSaidasNumber";
            lblSaidasNumber.Size = new Size(109, 38);
            lblSaidasNumber.TabIndex = 4;
            lblSaidasNumber.Text = "label1";
            // 
            // telaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 241);
            ClientSize = new Size(885, 619);
            Controls.Add(lblSaidasNumber);
            Controls.Add(lblEntradasNumber);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureEntradas);
            Controls.Add(pictureSaidas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "telaInicio";
            Text = "telaInicio";
            Load += telaInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureEntradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSaidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureEntradas;
        private PictureBox pictureSaidas;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label lblEntradasNumber;
        private Label lblSaidasNumber;
        
    }
}