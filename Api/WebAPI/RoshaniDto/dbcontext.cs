using Roshani.data.Contract;
namespace Roshani.data.provider
{
    public class dbContext : IdatamodelContext
    {
        public string MySQLConnectionString { get; set; }
        public dbContext(string connectionsstring)
        {
            MySQLConnectionString = connectionsstring;
        }
    }
}