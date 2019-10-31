using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ForeverLand
{
    public static class FactoryAdoMySQL
    {
        public static MySqlADO GetAdo(string cadena)
        {
            var dbContextOptions = new DbContextOptionsBuilder();
            dbContextOptions.UseMySQL(cadena);            
            return new MySqlADO(dbContextOptions.Options);
        }

        public static MySqlADO GetAdoDesdeJson(string archivo, string atributoJson)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(archivo, optional: true, reloadOnChange: true)
                .Build();
            string cadena = config.GetConnectionString(atributoJson);
            return GetAdo(cadena);            
        }
    }
}