using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt_SysInt
{
    internal class DanskCPRBlanket
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string EUCCID { get; set; }
        public string Køn { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public int Postnummer { get; set; }
        public string By { get; set; }
        public string ÆgteskabeligStatus { get; set; }
        public string ÆgtefælleCprNr { get; set; }
        public List<string> BørnsCprNr { get; set; }
        public List<string> ForældresCprNr { get; set; }
        public int LægeCvrNr { get; set; }

        public DanskCPRBlanket(string fornavn, string efternavn, string eUCCID, string køn, string adresse1, string adresse2, int postnummer, string by, string ægteskabeligStatus, string ægtefælleCprNr, List<string> børnsCprNr, List<string> forældresCprNr, int lægeCvrNr)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            EUCCID = eUCCID;
            this.Køn = køn;
            Adresse1 = adresse1;
            Adresse2 = adresse2;
            Postnummer = postnummer;
            By = by;
            ÆgteskabeligStatus = ægteskabeligStatus;
            ÆgtefælleCprNr = ægtefælleCprNr;
            BørnsCprNr = børnsCprNr;
            ForældresCprNr = forældresCprNr;
            LægeCvrNr = lægeCvrNr;
        }

        public override string ToString()
        {
            string børnsCprNrStr = BørnsCprNr != null ? string.Join(", ", BørnsCprNr) : "None";
            string forældresCprNrStr = ForældresCprNr != null ? string.Join(", ", ForældresCprNr) : "None";

            return $"Fornavn: {Fornavn}, Efternavn: {Efternavn}, EUCCID: {EUCCID}, Køn: {Køn}, Adresse1: {Adresse1}, Adresse2: {Adresse2}, Postnummer: {Postnummer}, By: {By}, ÆgteskabeligStatus: {ÆgteskabeligStatus}, ÆgtefælleCprNr: {ÆgtefælleCprNr}, BørnsCprNr: [{børnsCprNrStr}], ForældresCprNr: [{forældresCprNrStr}], LægeCvrNr: {LægeCvrNr}";
        }
    }
}
