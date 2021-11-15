namespace WpfApp1
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btVanzari = new System.Windows.Forms.Button();
            this.tbInchirieri = new System.Windows.Forms.Button();
            this.tbPlaseazaAnunt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVanzari
            // 
            this.btVanzari.Location = new System.Drawing.Point(865, 21);
            this.btVanzari.Margin = new System.Windows.Forms.Padding(4);
            this.btVanzari.Name = "btVanzari";
            this.btVanzari.Size = new System.Drawing.Size(140, 46);
            this.btVanzari.TabIndex = 0;
            this.btVanzari.Text = "Vanzari";
            this.btVanzari.UseVisualStyleBackColor = true;
            this.btVanzari.Click += new System.EventHandler(this.BtVanzari_Click);
            // 
            // tbInchirieri
            // 
            this.tbInchirieri.Location = new System.Drawing.Point(1013, 21);
            this.tbInchirieri.Margin = new System.Windows.Forms.Padding(4);
            this.tbInchirieri.Name = "tbInchirieri";
            this.tbInchirieri.Size = new System.Drawing.Size(144, 46);
            this.tbInchirieri.TabIndex = 1;
            this.tbInchirieri.Text = "Inchirieri";
            this.tbInchirieri.UseVisualStyleBackColor = true;
            this.tbInchirieri.Click += new System.EventHandler(this.TbInchirieri_Click);
            // 
            // tbPlaseazaAnunt
            // 
            this.tbPlaseazaAnunt.BackColor = System.Drawing.Color.Transparent;
            this.tbPlaseazaAnunt.Location = new System.Drawing.Point(107, 26);
            this.tbPlaseazaAnunt.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlaseazaAnunt.Name = "tbPlaseazaAnunt";
            this.tbPlaseazaAnunt.Size = new System.Drawing.Size(176, 34);
            this.tbPlaseazaAnunt.TabIndex = 2;
            this.tbPlaseazaAnunt.Text = "Pleazeaza Anunt";
            this.tbPlaseazaAnunt.UseVisualStyleBackColor = false;
            this.tbPlaseazaAnunt.Click += new System.EventHandler(this.TbPlaseazaAnunt_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.tbPlaseazaAnunt);
            this.Controls.Add(this.tbInchirieri);
            this.Controls.Add(this.btVanzari);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1161, 70);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVanzari;
        private System.Windows.Forms.Button tbInchirieri;
        private System.Windows.Forms.Button tbPlaseazaAnunt;
    }
}
