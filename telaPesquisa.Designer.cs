namespace devence_lobby
{
    partial class telaPesquisa
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
            label4 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 305);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 4;
            label4.Text = "tela de Pesquisa";
            // 
            // telaPesquisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 619);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "telaPesquisa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "telaPesquisa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
    }
}