using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Domain
{
    public class City
    {
        public City()
        {
            CityCompanies = new List<CityCompany>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string AreaCode { get; set; }

        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        public List<CityCompany> CityCompanies { get; set; }
        public Mayor Mayor { get; set; }
    }
}
