using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Domain.Models;
using System.Linq;
using System.Collections.Generic;
using DataAccess.Entities;
using DataAccess.Contracts;

namespace IntegrationTests
{
    [TestClass]
    public class PersistenceRegistroMantenimiento
    {
        [TestMethod]
        public void AddMaquinasObservacionesTareasByMantenimiento()
        {
            var modelMantenimiento = new ModelMantenimiento();

            //Add mantenimiento
            var objMantenimiento = new MANTENIMIENTO();
            objMantenimiento.id= 999999;
            objMantenimiento.fecha = DateTime.Today;
            objMantenimiento.cliente_id= 5001;
            objMantenimiento.ciudad_id = 101;
            modelMantenimiento.Add(objMantenimiento);


            //Add Maquina
            var modelMaquinas = new ModelMaquina();
            var modelRegMaquinas = new ModelRegMantenimientoMqns();
            var modelArticulo = new ModelArticulos();

            var objArticulo = new ARTICULO();
            objArticulo.articulo_id = 999999;
            objArticulo.tipo_articulo_id = 2002;
            modelArticulo.Add(objArticulo);

            var objMaquina= new MAQUINA();
            objMaquina.articulo_id = 999999;
            objMaquina.serialno = "00000000";
            objMaquina.modelo_id = 3004;
            objMaquina.estado_mqn_id = 4001;
            objMaquina.cliente_id = 5003;
            modelMaquinas.Add(objMaquina);


            //Add Observación
            //List<MantenimientoObservaciones> observaciones = modelRegMaquinas.GetObservacion(mantenimiento.id, objMaquina.articulo_id);
            OBSERVACIONES objObservacion = new OBSERVACIONES();
            objObservacion.id = 99999;
            objObservacion.descripcion = "test";
            objObservacion.maquina_id = 999999;
            objObservacion.tecnico_id = 307;
            objObservacion.mantenimiento_id = objMantenimiento.id;
            modelRegMaquinas.AddObservacion(objObservacion); 

            //Add Tarea
            TAREAS objTarea= new TAREAS();
            objTarea.id = 9999999;
            objTarea.descripcion= "test";
            objTarea.fecha_final = Convert.ToDateTime("12/04/2021");
            objTarea.maquina_id = objMaquina.articulo_id;
            modelRegMaquinas.AddTareas(objTarea);

            //Seleccionar mantenimientos según fecha
            
            DateTime startDate = Convert.ToDateTime("6/6/2021");
            DateTime endDate = DateTime.Today;
            var mantenimientos = modelMantenimiento.GetByDateRange(startDate, endDate);
            Assert.IsNotNull(mantenimientos);
            //Seleccionar un mantenimiento
            var mantenimiento = mantenimientos.Where(x => x.fecha.Equals(DateTime.Today)).First();
            Assert.AreEqual(mantenimiento.fecha, objMantenimiento.fecha);


            //Seleccionar una máquina
            List<MantenimientoMaquinas> maquinas = modelRegMaquinas.GetMaquinaByMantenimiento(objMantenimiento.id).ToList();
            //var lastMaquina = maquinas.Last();
            var maquina = maquinas.Where(x => x.serialNO.Equals("1567022")).First();
            Assert.AreEqual(maquina.serialNO, objMaquina.serialno);

            //Seleccionar las observaciones de la maquina
            var observaciones = modelRegMaquinas.GetObservacion(mantenimiento.id, maquina.id);
            var observacion= observaciones.ElementAt(0);
            Assert.AreEqual(objObservacion.id, observacion.id);

            //Seleccionar las tareas de la máquina
            List<TAREAS> tareas = modelRegMaquinas.SearchTareas(maquina.id);
            var tarea = tareas.ElementAt(0);
            Assert.AreEqual(objTarea.id, tarea.id);

            modelMantenimiento.Remove(objMantenimiento.id);
            modelMaquinas.Remove(objMaquina.articulo_id);
            ModelTareas modelTareas = new ModelTareas();
            modelTareas.Remove(objTarea.id);
            ModelObservaciones modelObservaciones = new ModelObservaciones();
            modelObservaciones.Remove(objObservacion.id);
            modelArticulo.Remove(objArticulo.articulo_id);

        }
    }
}
