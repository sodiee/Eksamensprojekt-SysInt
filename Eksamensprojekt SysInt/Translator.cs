using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt_SysInt
{
    internal class Translator
    {
        public static DanskCPRBlanket TransformEUBlanket(EUBlanket euBlanket)
        {
            string fornavn = euBlanket.ChristianName;
            string efternavn = euBlanket.FamilyName;
            string eUCCID = euBlanket.EUCCID;
            string køn = euBlanket.Gender;
            string adresse1 = euBlanket.StreetAndNumberOfHouse;
            string adresse2 = euBlanket.ApartmentNumber;
            int postnummer = 80235; //API kald for at fremkalde byens nummer;
            string by = euBlanket.County;
            string ægteskabeligStatus = ContentEnricher.GetÆgteskabeligStatus();
            string ægtefælleCprNr = ContentEnricher.GetÆgteFælleCprNr();
            List<string> børnsCprNr = ContentEnricher.GetBørnsCprNr();
            List<string> forældresCprNr = ContentEnricher.GetForældresCprNr();
            int lægeCvrNr = ContentEnricher.GetLægeCvr();

            DanskCPRBlanket danskCPRBlanket = new DanskCPRBlanket(fornavn, efternavn, eUCCID, køn,adresse1, adresse2, postnummer, by, ægteskabeligStatus, ægtefælleCprNr, børnsCprNr, forældresCprNr, lægeCvrNr);
            return danskCPRBlanket;
        }
    }
}
