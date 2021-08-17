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

//namespace Domain.Models
//{
//    public class ModeloMantenimientoFecha
//    {
//        MANTENIMIENTO objMantenimiento;
//        RepositoryMantenimientoFecha Repository;
//        public List<Maquina> maquina;
//        public RepositoryDTOMantenimientoFecha repository;


//        public ModeloMantenimientoFecha()
//        {
//            objMantenimiento = new MANTENIMIENTO();
//            Repository = new RepositoryMantenimientoFecha();
//            repository = new RepositoryDTOMantenimientoFecha();
//            maquina = repository.GetMaquina();
//        }

//        public List<TableMantenimientoFecha> GetAllFechas()
//        {

//            return repository.GetAll();
//        }
//        public List<TableMaquina> GetAllMaquina()
//        {

//            return repository.GetAllMaquina();
//        }
//        public List<MANTENIMIENTO> GetAll()
//        {

//            using (var context = new InteleSysEntities())
//            {
//                return context.MANTENIMIENTO.ToList();

//            }
//        }
//        public ArrayList GetMaquina()
//        {
//            ArrayList arrayListModelos = new ArrayList();

//            foreach (var item in maquina)
//            {
//                arrayListModelos.Add(item.Serie);
//            }
//            return arrayListModelos;
//        }
//            public void Add(MANTENIMIENTO objAVERIAS)
//            {
//                Repository.Add(objAVERIAS);
//            }

//            public void Edit(MANTENIMIENTO objAVERIAS)
//            {
//                Repository.Edit(objAVERIAS);
//            }
//            public void Remove(int ID)
//            {
//                Repository.Remove(ID);
//            }
        
//    }
//}
