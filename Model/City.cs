using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLeftJoin.Model
{
    public class City
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public int Population { get; set; }

        public static List<City> GetCities()
        {
            return new List<City>()
            {
                new City {Id= 1, Name = "Brazil", Population = 345048473},
                new City {Id= 2, Name = "China", Population = 1560358243},
                new City {Id= 3, Name = "Japan", Population = 250748474},
                new City {Id= 4, Name = "Spain", Population = 64738392},
                new City {Id= 5, Name = "Canada", Population = 102748448}
            };
        }
    }
}
