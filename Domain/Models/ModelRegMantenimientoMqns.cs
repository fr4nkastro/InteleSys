using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using DataAccess.Entities;
using DataAccess.Contracts;

namespace Domain.Models
{
    public class ModelRegMantenimientoMqns : TableDTO
    {
        private List<REGISTRO_AVERIA> lstREG_Averia;
        private List<AVERIAS> lstAverias;
        private List<MantenimientoAverias> lstMantenimientoAverias;
        List<REG_MANTENIMIENTO_MQNs> lstRegistroMantenimiento;
        List<MAQUINA> lstMaquinas;
        List<OBSERVACIONES> lstObservacion; 
        RepositoryRegMantenimientoMqns objRepository;
        RepositoryMaquinas objRepositoryMaquinas;
        public RepositorioObservaciones objRepositoryObservacion;
        List<MantenimientoMaquinas> lstMantenimienotMaquinas;
        List<MantenimientoObservaciones> lstMantenimientoObservaciones;
        public ModelRegMantenimientoMqns()
        {
            lstRegistroMantenimiento = new List<REG_MANTENIMIENTO_MQNs>();

            objRepository = new RepositoryRegMantenimientoMqns();
            objRepositoryMaquinas = new RepositoryMaquinas();
            objRepositoryObservacion = new RepositorioObservaciones();
        }

        public List<MantenimientoMaquinas> GetMaquinaByMantenimiento(decimal id)
        {
            lstRegistroMantenimiento = objRepository.GetAll().ToList().FindAll(m => m.mantenimiento_id == id);
            lstMaquinas = objRepositoryMaquinas.GetAll().ToList();
            lstMantenimienotMaquinas = (from mqn in lstMaquinas
                                        join rmqn in lstRegistroMantenimiento
                on mqn.articulo_id equals rmqn.maquina_id
                                        where rmqn.mantenimiento_id == id
                                        select new MantenimientoMaquinas
                                        {
                                            id= mqn.articulo_id,
                                            serialNO = mqn.serialno
                                        }).ToList();
            return lstMantenimienotMaquinas;
        }
        public List<MantenimientoObservaciones> GetObservacion(decimal Mantenimientoid,Decimal MaquinaID)
        {
            lstRegistroMantenimiento = objRepository.GetAll().ToList().FindAll(m => m.mantenimiento_id == Mantenimientoid);
            lstObservacion = objRepositoryObservacion.GetAll().ToList();
            lstMantenimientoObservaciones = (from obs in lstObservacion
                                             where obs.mantenimiento_id==Mantenimientoid && obs.maquina_id == MaquinaID
                                        select new MantenimientoObservaciones
                                        {
                                            id= obs.maquina_id,
                                            nombre = obs.descripcion
                                        }).ToList();
            return lstMantenimientoObservaciones;
        }

        public List<TAREAS> GetAllTareas()
        {
            using (var context = new InteleSysEntities())
            {
                return context.TAREAS.ToList();

            }
        }
        public List<TAREAS> SearchTareas(decimal filter)
        {
            return GetAllTareas().FindAll(x => x.maquina_id==filter).ToList();
        }


        List<AVERIAS> GetAllAverias()
        {
            using (var context = new InteleSysEntities())
            {
                return context.AVERIAS.ToList();

            }
        }

        List<REGISTRO_AVERIA> GetAllRegistro_Averias()
        {
            using (var context = new InteleSysEntities())
            {
                return context.REGISTRO_AVERIA.ToList();

            }
        }

        public List<MantenimientoAverias> GetRegAveriasJoined(decimal Mantenimientoid, Decimal MaquinaID)
        {
            lstRegistroMantenimiento = objRepository.GetAll().ToList().FindAll(m => m.mantenimiento_id == Mantenimientoid);
            lstREG_Averia = GetAllRegistro_Averias().ToList();
            lstAverias = GetAllAverias().ToList();
            lstMantenimientoAverias = (from REG in lstREG_Averia
                                       join AVE in lstAverias on REG.averia_id equals AVE.id
                                       where REG.mantenimiento_id == Mantenimientoid && REG.maquina_id == MaquinaID
                                       select new MantenimientoAverias
                                       {
                                           id = REG.averia_id,
                                           nombre = AVE.descripcion,
                                           Solucion = AVE.solucion
                                       }).ToList();
            return lstMantenimientoAverias;
        }

        //Funciones Para Guardar 
        //Observaciones
        public void AddObservacion(OBSERVACIONES entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.OBSERVACIONES.Add(entity);
                context.SaveChanges();
            }
        }
        //Tareas
        public void AddTareas(TAREAS entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.TAREAS.Add(entity);
                context.SaveChanges();
            }
        }

        //


        //Obtener Observaciones
        public List<OBSERVACIONES> GetAllOBSERVACION()
        {
            using (var context = new InteleSysEntities())
            {
                return context.OBSERVACIONES.ToList();

            }
        }
        //

    }
}
