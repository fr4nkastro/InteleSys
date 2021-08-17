using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccess.Entities;
using DataAccess.Contracts;
using System.Data.Linq;
using System.Data;

namespace DataAccess.Repositories
{
    public class Repository<Entity>
    {
        private string connectionString;
        
        public Repository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["inteleSysConnStr"].ToString();
        }
        public IEnumerable<Entity> ExecuteQuery(string transactSql)
        {
            IEnumerable<Entity> list;
            var context = new DataContext(connectionString);
            list = context.ExecuteQuery<Entity>(transactSql);
            //using (var context = new DataContext(connectionString))
            //{
            // list= context.ExecuteQuery<Entity>(transactSql) ;
            //}
            
            return list;

        }
    }
}
