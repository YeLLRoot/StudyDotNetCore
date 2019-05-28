using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Domain
{
    public class Province
    {
        public Province()
        {
            Cities = new List<City>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

        public List<City> Cities { get; set; }
    }
}
