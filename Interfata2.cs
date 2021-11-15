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

  
    public partial class Interfata2 : Form
    {
        int id;
     
        

        public Interfata2(int _id)
        {
            InitializeComponent();
            id = _id;

         
           // MessageBox.Show(Convert.ToString(id));
        }

       


        private void UserControl21_Load(object sender, EventArgs e)
        {
            this.userControl21.Id_us2= id;
        }

        private void UserControl31_Load(object sender, EventArgs e)
        {
            this.userControl31.Us3_id = id;
        }

        private void Interfata2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
