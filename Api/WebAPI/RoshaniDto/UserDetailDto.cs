using System.Data;
using Roshani.data.Contract;
using Roshani.data.model;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace Roshani.data.provider
{
    public class RoshaniUserDto : IUsersDetailsData
    {
        IdatamodelContext _datamodelcontext;
        private IDbConnection mysqldb = null;
        public RoshaniUserDto(IdatamodelContext datacontext)
        {
            _datamodelcontext = datacontext;
        }
        public IList<UserModel> GetUserDetails()
        {
            IList<UserModel> userdetail = new List<UserModel>();
            using (mysqldb = new MySqlConnection(_datamodelcontext.MySQLConnectionString))
            {
                mysqldb.Open();
                userdetail = mysqldb.Query<UserModel>("SELECT * FROM Roshani.Ros_User;").ToList();
            }
            return userdetail;
        }
    }
}