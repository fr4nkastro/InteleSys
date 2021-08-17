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
        List<REG_MANTENIMIENTO_MQNs> lstRegistroMantenimiento;
        List<MAQUINA> lstMaquinas;
        RepositoryRegMantenimientoMqns objRepository;
        RepositoryMaquinas objRepositoryMaquinas;
        List<MantenimientoMaquinas> lstMantenimienotMaquinas;
        public ModelRegMantenimientoMqns()
        {
            lstRegistroMantenimiento = new List<REG_MANTENIMIENTO_MQNs>();

            objRepository = new RepositoryRegMantenimientoMqns();
            objRepositoryMaquinas = new RepositoryMaquinas();

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
                                            //id= mqn.articulo_id,
                                            serialNO = mqn.serialno
                                        }).ToList();
            return lstMantenimienotMaquinas;
        }
    }
}
