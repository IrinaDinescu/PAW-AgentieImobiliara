using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Controls;
using System.Linq.Expressions;
using System.Drawing.Printing;

namespace WpfApp1
{
    public partial class Form_SalvareAnunturi : Form
    {

        List<Class_Anunt> anunturi_salvate = new List<Class_Anunt>();

        int id;

      //  private string documentContents;
      //  private string stringToPrint;

        private StringReader myReader;

        public Form_SalvareAnunturi(List<Class_Anunt> _anuturi_salvate, int _id)
        {
            InitializeComponent();
            anunturi_salvate = _anuturi_salvate;
            id = _id;
            
            

        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            this.userControl21.Id_us2 = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg1 = new SaveFileDialog();
            dlg1.Filter = "(*.txt)|*.txt";
            if (dlg1.ShowDialog() == DialogResult.OK)
            {
                string sir = "";

                FileStream fs = new FileStream(dlg1.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                for(int i = 0; i < listBox1.Items.Count;i++)
                {
                    sir += listBox1.Items[i].ToString() + Environment.NewLine;
                }
                sw.WriteLine(sir);
                listBox1.Items.Clear();
                sw.Close();
                fs.Close();
            }

        }

        private void Form_SalvareAnunturi_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < anunturi_salvate.Count; i++)
                listBox1.Items.Add(anunturi_salvate[i].ToString());
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            foreach (Class_Anunt anunt_salvat in anunturi_salvate)
                    listBox1.Items.Add(anunt_salvat.ToString());
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            printDialog1.Document = printDocument1;
            string strText = "";
            foreach(object x in listBox1.Items)
            {
                strText = strText + x.ToString() + "\n";
            }
            

            myReader = new StringReader(strText);

            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }

            

            

        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = this.listBox1.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);


            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));

                ev.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }

            
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
            

            myBrush.Dispose();

            

        }

        private void printPreviewDialog1_Load(object sender, EventArgs ev)
        {
            


        }

        private void button3_Click(object sender, EventArgs ev)
        {


            printDialog1.Document = printDocument1;
            string strText = "";
            foreach (object x in listBox1.Items)
            {
                strText = strText + x.ToString() + "\n";
            }

            myReader = new StringReader(strText);

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void userControl31_Load(object sender, EventArgs e)
        {
            this.userControl31.Us3_id = id;
        }
    }
}
