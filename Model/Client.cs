using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLeftJoin.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int? CityId { get; set; }

        public static List<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client {Id = 1, Name = "Cathrine", Age = 19, CityId = 1},
                new Client {Id = 2, Name = "John", Age = 32, CityId = 2},
                new Client {Id = 3, Name = "Yan", Age = 27, CityId = null},
                new Client {Id = 4, Name = "Jeniffer", Age = 34, CityId = 5},
                new Client {Id = 5, Name = "Patrick", Age = 22, CityId = 2}
            };
        }
    }
}
