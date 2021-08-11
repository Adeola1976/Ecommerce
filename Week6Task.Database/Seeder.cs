using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Week6Task.Model;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Week6Task.Database
{
   public  class Seeder
    {
        public static async Task SeedData(FWContext context) {
            try {
                context.Database.EnsureCreated();
                if(!context.Customer.Any())
                {
               // C:\Users\hp\Desktop\AllProjects\Week6Task\Week6Task.Database\JsonFiles\Customer.json
                    var data = File.ReadAllText(@"C:\Users\hp\Desktop\AllProjects\Week6Task\Week6Task.Database\JsonFiles\Customer.json");
                    var listofUsers = JsonConvert.DeserializeObject<List<Customer>>(data);
                    await context.Customer.AddRangeAsync(listofUsers);
                    await context.SaveChangesAsync();
                }
            }

            catch (Exception) {
                throw;
            }
        }
    }
}
