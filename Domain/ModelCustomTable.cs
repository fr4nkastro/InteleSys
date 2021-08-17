using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using DataAccess.Entities;
using DataAccess.Contracts;

namespace Domain
{
    public class ModelCustomTable
    {
        RepositoryCustomTable repository;
        List<CustomTable> listCustomTables;
        public ModelCustomTable()
        {
            repository = new RepositoryCustomTable();
            listCustomTables = new List<CustomTable>();
        }
        public List<CustomTable>GetAll()
        {
            var customTableModel = repository.GetAll().ToList();
            
            return customTableModel;
        }
    }
}
