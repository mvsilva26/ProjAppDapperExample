using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAppDapperExample
{
    public class Airport
    {
        #region Constant

        public readonly static string INSERT = "INSERT INTO Airport (City, Country, Code, Continent) VALUES (@City, @Country, @Code, @Continent)";
        public readonly static string GETALL = "SELECT Id City, Country, Code, Continent FROM Airport";

        #endregion


        #region Properties

        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public string Continent { get; set; }


        #endregion



        public override string ToString()
        {
            return "Id: " + Id + 
                   "\nCity: " + City +
                   "\nCountry: " + Country +
                   "\nCode: " + Code +
                   "\nContinent: " + Continent;
        }


    }
}
