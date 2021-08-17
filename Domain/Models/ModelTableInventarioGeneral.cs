using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.DTO;
using DataAccess.Contracts;
using DataAccess.Repositories;
using System.Collections;

namespace Domain.Models
{
    public class ModelTableInventarioGeneral: TableDTO
    {

        private RepositoryDTOInventarioGeneral repository;
        public List<ModeloMaquinas> modeloMaquinas { get; set; }
        public List<TableInventarioGeneral> tableInventarioGeneral { get; set; }
        public IEnumerable<TableInventarioGeneral> tableInventarioGeneralEnum { get; set; }
        public List<TableInventarioGeneral> searchResult { get; set; }
        public List<TipoArticulo> tipoArticulos;
        
        //public List<ModeloMaquinas> modeloMaquinas { get; set; }


        public ModelTableInventarioGeneral()
        {
            repository = new RepositoryDTOInventarioGeneral();
            modeloMaquinas = repository.GetModeloMaquina();
            tipoArticulos = repository.GetTipoArtilculo();
        }
        public List<TableInventarioGeneral> GetAll()
        {

            return repository.GetAll();
        }

        public List<TableInventarioGeneral> Search(string filter)
        {
            return repository.GetAll().Where<TableInventarioGeneral>(x => x.Descripción.Contains(filter)).ToList();


        }

        public ArrayList GetModeloMaquina()
        {
            ArrayList arrayListModelos = new ArrayList();

            foreach (var item in modeloMaquinas)
            {
                arrayListModelos.Add(item.nombre);
            }

            return arrayListModelos;

        }

        public ArrayList GetTipoArticulo()
        {
            ArrayList arrayListTipos = new ArrayList();

            foreach (var item in tipoArticulos)
            {
                arrayListTipos.Add(item.nombre);
            }

            return arrayListTipos;

        }


    }
}
