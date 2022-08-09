using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TurkHavaYollarıKayıtSistemi
{
    class ConstValue
    {
        //Kullanci adini alan degisken
        public static string KullanciAdi { get; set; }
        public static string KullanciSifre { get; set; }
        public static int KullanciID { get; set; }
        public static int YolcuBulID { get; set; }
        public static int YolculukID { get; set; }

        public static string connectionString = "Data Source=DESKTOP-7RAAP8M\\SQLEXPRESS;Initial Catalog=THY;Integrated Security=True";
    }
}