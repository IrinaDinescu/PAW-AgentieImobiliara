using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp1
{
    class Program
    {
       

         [STAThread]
        static void Main(string [] args)
        {
            List<Class_Anunt> anunturi = new List<Class_Anunt>();

            Class_Anunt anunt1 = new Class_Anunt();
            Class_Anunt anunt2 = new Class_Anunt("Casa", "Vanzare", 340, 120000, "Pipera", 0);
            Class_Anunt anunt3 = new Class_Anunt("Casa", "Inchiriere", 100, 1500, "Bucuresti", 0);
            Class_Anunt anunt4 = new Class_Anunt("Spatiu Comercial", "Inchiriere", 500, 5000, "Timisoara", 0);
            Class_Anunt anunt5 = new Class_Anunt("Casa", "Vanzare", 240, 150000, "Snagov", 0);
            Class_Anunt anunt6 = new Class_Anunt("Apartament", "Vanzare", 85, 70000, "Cluj", 0);
            Class_Anunt anunt7 = new Class_Anunt("Teren", "Vanzare", 100, 90000, "Bucuresti", 0);

            anunturi.Add(anunt1);
            anunturi.Add(anunt5);
            anunturi.Add(anunt3);
            anunturi.Add(anunt4);
            anunturi.Add(anunt6);
            anunturi.Add(anunt7);
            anunturi.Add(anunt2);
            anunturi.Add(anunt3);


           Application.Run(new Interfata1());
           System.Diagnostics.Process.GetCurrentProcess().Kill();
           Application.Exit();
        }

    }
}
