using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WpfApp1
{
    public partial class UserControl2 : UserControl
    {
        bool inchirieri = false;
        private int id_us2;

        public int Id_us2 { get => id_us2; set => id_us2 = value; }

        public UserControl2()
        {
            InitializeComponent();
           // id = _id;
        }

       



        private void BtVanzari_Click(object sender, EventArgs e)
        {
            inchirieri = false;
            Form_AfisareAnunturi frm = new Form_AfisareAnunturi(inchirieri, this.id_us2);
            Form tmp = this.FindForm();
            tmp.Hide();
            frm.ShowDialog();
            tmp.Close();
        }

        private void TbPlaseazaAnunt_Click(object sender, EventArgs e)
        {
            Form_PlaseazaAnunt frm = new Form_PlaseazaAnunt(this.id_us2);

           // Form tmp = this.FindForm();
           // tmp.Hide();
            frm.ShowDialog();
          //  tmp.Close();
        }

        private void TbInchirieri_Click(object sender, EventArgs e)
        {
            inchirieri = true;
            Form_AfisareAnunturi frm = new Form_AfisareAnunturi(inchirieri, this.id_us2);
            Form tmp = this.FindForm();
            tmp.Hide();
            frm.ShowDialog();
            tmp.Close();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        public void tb_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
