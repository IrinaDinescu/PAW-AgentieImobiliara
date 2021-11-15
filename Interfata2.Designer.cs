namespace WpfApp1
{
    partial class Interfata2
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
            this.userControl31 = new WpfApp1.UserControl3();
            this.userControl21 = new WpfApp1.UserControl2();
            this.SuspendLayout();
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userControl31.Location = new System.Drawing.Point(-7, -7);
            this.userControl31.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1088, 89);
            this.userControl31.TabIndex = 0;
            this.userControl31.Load += new System.EventHandler(this.UserControl31_Load);
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.Gainsboro;
       //     this.userControl21.Id = 0;
            this.userControl21.Location = new System.Drawing.Point(-93, 64);
            this.userControl21.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1161, 70);
            this.userControl21.TabIndex = 1;
            this.userControl21.Load += new System.EventHandler(this.UserControl21_Load);
            // 
            // Interfata2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Interfata2";
            this.Text = "Interfata2";
            this.Load += new System.EventHandler(this.Interfata2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl3 userControl31;
        private UserControl2 userControl21;
       
    }
}