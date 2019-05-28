using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Domain
{
    public class CityCompany
    {
        public int CityId { get; set; }
        public City City { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
