using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                //appsetting.json kullanmak için
                ConfigurationManager configuringManager = new();
                configuringManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretApi.API"));
                configuringManager.AddJsonFile("appsettings.json");

                return configuringManager.GetConnectionString("PostgreSQL");
            } 
        }
    }
}
