using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt_SysInt
{
    internal class ContentEnricher
    {
        public static string GetÆgteskabeligStatus()
        {
            return "Uvist.";
        }

        public static string GetÆgteFælleCprNr()
        {
            return "Uvist.";
        }

        public static List<string> GetBørnsCprNr()
        {
            List<string> list = new List<string>();
            list.Add("Uvist");
            return list;
        }
        
        public static List<string> GetForældresCprNr()
        {
            List<string> list = new List<string>();
            list.Add("Uvist");
            return list;
        }
        
        public static int GetLægeCvr()
        {
            return 0;
        }
    }
}
