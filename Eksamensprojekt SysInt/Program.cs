using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.Text.Json;

namespace Eksamensprojekt_SysInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContentFilter filter = new ContentFilter();
            EUBlanket eUBlanket = new EUBlanket("Clara", "Johnson", "01121990-xxxxxx", "Female", "Ravine Road 67", "", "Greater Manchester", "Salford", "UK", "UK");
            string nummerAtSende = filter.GemData(eUBlanket);

            Message m = new Message();
            m.Body = nummerAtSende;
            MessageQueue mqEU = new MessageQueue(@".\Private$\EUQueueEksamen");
            mqEU.Send(m);

            Console.WriteLine("Besked sendt til køen med nummeret: " + nummerAtSende);
            Console.WriteLine();

            Message mesaggeFromEu = mqEU.Receive();
            mesaggeFromEu.Formatter = new XmlMessageFormatter(new String[] { "System.String" });

            string nummer = (string)mesaggeFromEu.Body;
            EUBlanket hentetEUBlanket = filter.FindData(int.Parse(nummer));

            Console.WriteLine("nummer: " + nummer);
            Console.WriteLine("Eublanket hentet: " + hentetEUBlanket);


            DanskCPRBlanket danskCPRBlanket = Translator.TransformEUBlanket(hentetEUBlanket);
            Console.WriteLine();
            Console.WriteLine("Transformeret til CPRBlanket: " + danskCPRBlanket);



        }
    }
}
