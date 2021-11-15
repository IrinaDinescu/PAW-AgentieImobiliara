using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   

   public class Class_DateCont
    {
        static int nr;
        static int id;
        static string username ="";
        static string password ="";

     
       
        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }

        public static int Id
        {
            get
            {
                return id;
            }

            set
            {
                Id = value;
            }
        }
       
    }
}
