using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;
using DataAccess.Entities;
using DataAccess.Repositories;
using static DataAccess.Contracts.TableDTO;

namespace Domain.Models
{
    public class ModeloAverias
    {
        AVERIAS objAverias;
        RepositoryAverias Repository;
        public List<Modelo> modelo { get; set; }
        public RepositorioDTOAverias repository;

        public ModeloAverias()
        {
            objAverias = new AVERIAS();
            Repository = new RepositoryAverias();
            repository = new RepositorioDTOAverias();
            modelo = repository.GetModelo();
        }

        public List<AVERIAS> GetAll()
        {

            using (var context = new InteleSysEntities())
            {
                return context.AVERIAS.ToList();

            }
        }

        public List<TablaAveriasModelo> GetAllAverias()
        {

            return repository.GetAll();
        }


        public ArrayList GetModelo()
        {
            ArrayList arrayListModelos = new ArrayList();

            foreach (var item in modelo)
            {
                arrayListModelos.Add(item.Nombre);
            }

            return arrayListModelos;
        }


        public void Add(AVERIAS objAVERIAS)
        {
            Repository.Add(objAVERIAS);
        }

        public void Edit(AVERIAS objAVERIAS)
        {
            Repository.Edit(objAVERIAS);
        }
        public void Remove(int ID)
        {
            Repository.Remove(ID);
        }


    }
}
