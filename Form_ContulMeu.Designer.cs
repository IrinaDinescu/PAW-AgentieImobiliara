namespace WpfApp1
{
    partial class Form_ContulMeu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl31 = new WpfApp1.UserControl3();
            this.userControl21 = new WpfApp1.UserControl2();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vezi Anunturi Mele ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 146);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Datele Mele ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userControl31.Location = new System.Drawing.Point(-8, -10);
            this.userControl31.Margin = new System.Windows.Forms.Padding(5);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1081, 85);
            this.userControl31.TabIndex = 1;
            this.userControl31.Us3_id = 0;
            this.userControl31.Load += new System.EventHandler(this.userControl31_Load);
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.Gainsboro;
            this.userControl21.Id_us2 = 1000;
            this.userControl21.Location = new System.Drawing.Point(-93, 57);
            this.userControl21.Margin = new System.Windows.Forms.Padding(5);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1196, 70);
            this.userControl21.TabIndex = 0;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // Form_ContulMeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ContulMeu";
            this.Text = "Form_ContulMeu";
            this.Load += new System.EventHandler(this.Form_ContulMeu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}