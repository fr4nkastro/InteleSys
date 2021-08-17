using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Repositories;
using DataAccess.Entities;
using System.Collections;
using System.Windows.Forms;
using DataAccess.DTO;

namespace Domain.Models
{
    
    public class ModelTableInventarioPiezas: TableDTO
    {
        
        private RepositoryDTOInventarioPiezas repository;
        public List<ModeloMaquinas> modeloMaquinas { get; set; }
        

        public ModelTableInventarioPiezas()
        {
            repository = new RepositoryDTOInventarioPiezas();
            modeloMaquinas = repository.GetModels();
            
        }
        public List<TableInventarioPiezas> GetAll()
        {
            
            return repository.GetAll();
        }

        public List<TableInventarioPiezas> Search(string filter)
        {
            
            return GetAll().FindAll(e => e.Nombre.ToString().Contains(filter));
        }

        public ArrayList GetModels()
        {
            ArrayList arrayListModelos = new ArrayList();

            foreach (var item in modeloMaquinas)
            {
                arrayListModelos.Add(item.nombre);
            }

            return arrayListModelos;
            
        }
       
        
        
    }
}
