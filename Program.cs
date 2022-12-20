using LINQLeftJoin.Model;
using System.Security.Cryptography.X509Certificates;

namespace LINQLeftJoin
{
    public class Program
    {

        public string ClientName;
        public string CityName;

        static void Main(string[] args)
        {

            var result = Client.GetClients().GroupJoin(
                City.GetCities(),client => client.CityId,city => city.Id,
                (client, city) => new { client, city })
                    .SelectMany(x => x.city.DefaultIfEmpty(),
                    (Client, City) => new { ClientName = Client.client.Name, CityName = City?.Name });

            foreach(var r in result)
            {
                Console.WriteLine($">>> Client: {r.ClientName} | City: {r.CityName}");
            }
            
            Console.ReadLine();

        }
    }
}