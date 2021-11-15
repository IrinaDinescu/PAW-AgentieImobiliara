namespace WpfApp1
{
    partial class Form_PlaseazaAnunt
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_SpatiuComercial = new System.Windows.Forms.RadioButton();
            this.radioButton_Teren = new System.Windows.Forms.RadioButton();
            this.radioButton_Apartament = new System.Windows.Forms.RadioButton();
            this.radioButton_Casa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Inchiriere = new System.Windows.Forms.RadioButton();
            this.radioButton_Vanzare = new System.Windows.Forms.RadioButton();
            this.tb_SuprafataUtila = new System.Windows.Forms.TextBox();
            this.tb_Pret = new System.Windows.Forms.TextBox();
            this.tb_Localizare = new System.Windows.Forms.TextBox();
            this.label_SuprafataUtila = new System.Windows.Forms.Label();
            this.label_Pret = new System.Windows.Forms.Label();
            this.label_Localizare = new System.Windows.Forms.Label();
            this.label_EUR = new System.Windows.Forms.Label();
            this.label_mp2 = new System.Windows.Forms.Label();
            this.button_Salveaza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_SpatiuComercial);
            this.groupBox1.Controls.Add(this.radioButton_Teren);
            this.groupBox1.Controls.Add(this.radioButton_Apartament);
            this.groupBox1.Controls.Add(this.radioButton_Casa);
            this.groupBox1.Location = new System.Drawing.Point(16, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_SpatiuComercial
            // 
            this.radioButton_SpatiuComercial.AutoSize = true;
            this.radioButton_SpatiuComercial.Location = new System.Drawing.Point(8, 105);
            this.radioButton_SpatiuComercial.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_SpatiuComercial.Name = "radioButton_SpatiuComercial";
            this.radioButton_SpatiuComercial.Size = new System.Drawing.Size(135, 21);
            this.radioButton_SpatiuComercial.TabIndex = 3;
            this.radioButton_SpatiuComercial.TabStop = true;
            this.radioButton_SpatiuComercial.Text = "Spatiu Comercial";
            this.radioButton_SpatiuComercial.UseVisualStyleBackColor = true;
            this.radioButton_SpatiuComercial.CheckedChanged += new System.EventHandler(this.RadioButton_SpatiuComercial_CheckedChanged);
            // 
            // radioButton_Teren
            // 
            this.radioButton_Teren.AutoSize = true;
            this.radioButton_Teren.Location = new System.Drawing.Point(8, 80);
            this.radioButton_Teren.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Teren.Name = "radioButton_Teren";
            this.radioButton_Teren.Size = new System.Drawing.Size(67, 21);
            this.radioButton_Teren.TabIndex = 2;
            this.radioButton_Teren.TabStop = true;
            this.radioButton_Teren.Text = "Teren";
            this.radioButton_Teren.UseVisualStyleBackColor = true;
            this.radioButton_Teren.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton_Apartament
            // 
            this.radioButton_Apartament.AutoSize = true;
            this.radioButton_Apartament.Location = new System.Drawing.Point(8, 52);
            this.radioButton_Apartament.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Apartament.Name = "radioButton_Apartament";
            this.radioButton_Apartament.Size = new System.Drawing.Size(102, 21);
            this.radioButton_Apartament.TabIndex = 1;
            this.radioButton_Apartament.TabStop = true;
            this.radioButton_Apartament.Text = "Apartament";
            this.radioButton_Apartament.UseVisualStyleBackColor = true;
            this.radioButton_Apartament.CheckedChanged += new System.EventHandler(this.RadioButton_Apartament_CheckedChanged);
            // 
            // radioButton_Casa
            // 
            this.radioButton_Casa.AutoSize = true;
            this.radioButton_Casa.Checked = true;
            this.radioButton_Casa.Location = new System.Drawing.Point(8, 23);
            this.radioButton_Casa.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Casa.Name = "radioButton_Casa";
            this.radioButton_Casa.Size = new System.Drawing.Size(61, 21);
            this.radioButton_Casa.TabIndex = 0;
            this.radioButton_Casa.TabStop = true;
            this.radioButton_Casa.Text = "Casa";
            this.radioButton_Casa.UseVisualStyleBackColor = true;
            this.radioButton_Casa.CheckedChanged += new System.EventHandler(this.RadioButton_Casa_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Inchiriere);
            this.groupBox2.Controls.Add(this.radioButton_Vanzare);
            this.groupBox2.Location = new System.Drawing.Point(16, 159);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 85);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // radioButton_Inchiriere
            // 
            this.radioButton_Inchiriere.AutoSize = true;
            this.radioButton_Inchiriere.Location = new System.Drawing.Point(8, 52);
            this.radioButton_Inchiriere.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Inchiriere.Name = "radioButton_Inchiriere";
            this.radioButton_Inchiriere.Size = new System.Drawing.Size(87, 21);
            this.radioButton_Inchiriere.TabIndex = 1;
            this.radioButton_Inchiriere.TabStop = true;
            this.radioButton_Inchiriere.Text = "Inchiriere";
            this.radioButton_Inchiriere.UseVisualStyleBackColor = true;
            this.radioButton_Inchiriere.CheckedChanged += new System.EventHandler(this.RadioButton_Inchiriere_CheckedChanged);
            // 
            // radioButton_Vanzare
            // 
            this.radioButton_Vanzare.AutoSize = true;
            this.radioButton_Vanzare.Checked = true;
            this.radioButton_Vanzare.Location = new System.Drawing.Point(8, 23);
            this.radioButton_Vanzare.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Vanzare.Name = "radioButton_Vanzare";
            this.radioButton_Vanzare.Size = new System.Drawing.Size(82, 21);
            this.radioButton_Vanzare.TabIndex = 0;
            this.radioButton_Vanzare.TabStop = true;
            this.radioButton_Vanzare.Text = "Vanzare";
            this.radioButton_Vanzare.UseVisualStyleBackColor = true;
            this.radioButton_Vanzare.CheckedChanged += new System.EventHandler(this.RadioButton_Vanzare_CheckedChanged);
            // 
            // tb_SuprafataUtila
            // 
            this.tb_SuprafataUtila.Location = new System.Drawing.Point(16, 287);
            this.tb_SuprafataUtila.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SuprafataUtila.Name = "tb_SuprafataUtila";
            this.tb_SuprafataUtila.Size = new System.Drawing.Size(145, 22);
            this.tb_SuprafataUtila.TabIndex = 6;
            this.tb_SuprafataUtila.TextChanged += new System.EventHandler(this.Tb_SuprafataUtila_TextChanged);
            // 
            // tb_Pret
            // 
            this.tb_Pret.Location = new System.Drawing.Point(16, 332);
            this.tb_Pret.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Pret.Name = "tb_Pret";
            this.tb_Pret.Size = new System.Drawing.Size(145, 22);
            this.tb_Pret.TabIndex = 7;
            this.tb_Pret.TextChanged += new System.EventHandler(this.Tb_Pret_TextChanged);
            // 
            // tb_Localizare
            // 
            this.tb_Localizare.Location = new System.Drawing.Point(16, 382);
            this.tb_Localizare.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Localizare.Name = "tb_Localizare";
            this.tb_Localizare.Size = new System.Drawing.Size(145, 22);
            this.tb_Localizare.TabIndex = 8;
            this.tb_Localizare.TextChanged += new System.EventHandler(this.Tb_Localizare_TextChanged);
            // 
            // label_SuprafataUtila
            // 
            this.label_SuprafataUtila.AutoSize = true;
            this.label_SuprafataUtila.Location = new System.Drawing.Point(16, 266);
            this.label_SuprafataUtila.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SuprafataUtila.Name = "label_SuprafataUtila";
            this.label_SuprafataUtila.Size = new System.Drawing.Size(106, 17);
            this.label_SuprafataUtila.TabIndex = 9;
            this.label_SuprafataUtila.Text = "Suprafata Utila ";
            // 
            // label_Pret
            // 
            this.label_Pret.AutoSize = true;
            this.label_Pret.Location = new System.Drawing.Point(16, 313);
            this.label_Pret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Pret.Name = "label_Pret";
            this.label_Pret.Size = new System.Drawing.Size(34, 17);
            this.label_Pret.TabIndex = 10;
            this.label_Pret.Text = "Pret";
            // 
            // label_Localizare
            // 
            this.label_Localizare.AutoSize = true;
            this.label_Localizare.Location = new System.Drawing.Point(16, 362);
            this.label_Localizare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Localizare.Name = "label_Localizare";
            this.label_Localizare.Size = new System.Drawing.Size(73, 17);
            this.label_Localizare.TabIndex = 11;
            this.label_Localizare.Text = "Localizare";
            // 
            // label_EUR
            // 
            this.label_EUR.AutoSize = true;
            this.label_EUR.Location = new System.Drawing.Point(171, 341);
            this.label_EUR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_EUR.Name = "label_EUR";
            this.label_EUR.Size = new System.Drawing.Size(37, 17);
            this.label_EUR.TabIndex = 12;
            this.label_EUR.Text = "EUR";
            // 
            // label_mp2
            // 
            this.label_mp2.AutoSize = true;
            this.label_mp2.Location = new System.Drawing.Point(171, 295);
            this.label_mp2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mp2.Name = "label_mp2";
            this.label_mp2.Size = new System.Drawing.Size(35, 17);
            this.label_mp2.TabIndex = 13;
            this.label_mp2.Text = "mp2";
            // 
            // button_Salveaza
            // 
            this.button_Salveaza.Location = new System.Drawing.Point(824, 351);
            this.button_Salveaza.Margin = new System.Windows.Forms.Padding(4);
            this.button_Salveaza.Name = "button_Salveaza";
            this.button_Salveaza.Size = new System.Drawing.Size(164, 55);
            this.button_Salveaza.TabIndex = 14;
            this.button_Salveaza.Text = "Salveaza\r\n";
            this.button_Salveaza.UseVisualStyleBackColor = true;
            this.button_Salveaza.Click += new System.EventHandler(this.Button_Salveaza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1001, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alt + S";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 28);
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.salveazaToolStripMenuItem.Text = "Salveaza";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.SalveazaToolStripMenuItem_Click);
            // 
            // Form_PlaseazaAnunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Salveaza);
            this.Controls.Add(this.label_mp2);
            this.Controls.Add(this.label_EUR);
            this.Controls.Add(this.label_Localizare);
            this.Controls.Add(this.label_Pret);
            this.Controls.Add(this.label_SuprafataUtila);
            this.Controls.Add(this.tb_Localizare);
            this.Controls.Add(this.tb_Pret);
            this.Controls.Add(this.tb_SuprafataUtila);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_PlaseazaAnunt";
            this.Text = "Form_PlaseazaAnunt";
            this.Load += new System.EventHandler(this.Form_PlaseazaAnunt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_PlaseazaAnunt_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_SpatiuComercial;
        private System.Windows.Forms.RadioButton radioButton_Teren;
        private System.Windows.Forms.RadioButton radioButton_Apartament;
        private System.Windows.Forms.RadioButton radioButton_Casa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Inchiriere;
        private System.Windows.Forms.RadioButton radioButton_Vanzare;
        private System.Windows.Forms.TextBox tb_SuprafataUtila;
        private System.Windows.Forms.TextBox tb_Pret;
        private System.Windows.Forms.TextBox tb_Localizare;
        private System.Windows.Forms.Label label_SuprafataUtila;
        private System.Windows.Forms.Label label_Pret;
        private System.Windows.Forms.Label label_Localizare;
        private System.Windows.Forms.Label label_EUR;
        private System.Windows.Forms.Label label_mp2;
        private System.Windows.Forms.Button button_Salveaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
    }
}