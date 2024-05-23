using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt_SysInt
{
    internal class EUBlanket
    {
        public string ChristianName { get; set; }
        public string FamilyName { get; set; }
        public string EUCCID { get; set; }
        public string Gender { get; set; }
        public string StreetAndNumberOfHouse { get; set; }
        public string ApartmentNumber { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string BirthCountry { get; set; }
        public string CurrentLivingInCountry { get; set; }

        public EUBlanket(string christianName, string familyName, string eUCCID, string gender, string streetAndNumberOfHouse, string apartmentNumber, string county, string city, string birthCountry, string currentLivingInCountry)
        {
            ChristianName = christianName;
            FamilyName = familyName;
            EUCCID = eUCCID;
            Gender = gender;
            StreetAndNumberOfHouse = streetAndNumberOfHouse;
            ApartmentNumber = apartmentNumber;
            County = county;
            City = city;
            BirthCountry = birthCountry;
            CurrentLivingInCountry = currentLivingInCountry;
        }

        public override string ToString()
        {
            return $"ChristianName: {ChristianName}, FamilyName: {FamilyName}, EUCCID: {EUCCID}, Gender: {Gender}, StreetAndNumberOfHouse: {StreetAndNumberOfHouse}, ApartmentNumber: {ApartmentNumber}, County: {County}, City: {City}, BirthCountry: {BirthCountry}, CurrentLivingInCountry: {CurrentLivingInCountry}";
        }
    }
}
