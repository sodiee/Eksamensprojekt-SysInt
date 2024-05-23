using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt_SysInt
{
    internal class ContentFilter
    {
        public EUBlanket[] array { get; set; }
        public ContentFilter() 
        {
            this.array = new EUBlanket[100];
        }

        public string GemData(EUBlanket eu)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            array[number] = eu;
            return number.ToString();
        }

        public EUBlanket FindData(int nummer)
        {
            return array[nummer];
        }
    }
}
