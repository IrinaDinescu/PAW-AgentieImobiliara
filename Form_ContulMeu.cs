using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp1
{
    public partial class Form_ContulMeu : Form
    {
        int id;
        List<Class_Anunt> anunturi = new List<Class_Anunt>();

        public Form_ContulMeu(int _id)
        {
            InitializeComponent();
            id = _id;
        
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form_DateleMele frm = new Form_DateleMele(id);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_AnunturileMele frm = new Form_AnunturileMele(id,anunturi);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void Form_ContulMeu_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {
            this.userControl31.Us3_id = id;
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            this.userControl21.Id_us2 = id;
        }
    }
}
