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
    public class RegistroMantenimientoTest
    {
        [TestMethod]
        public void GetMaquinasObservacionesTareasByMantenimientoTest()
        {
            //Seleccionar mantenimientos según fecha
            var modelMantenimiento = new ModelMantenimiento();
            DateTime startDate = Convert.ToDateTime("6/6/2021");
            DateTime endDate = Convert.ToDateTime("9/6/2021");
            var mantenimientos = modelMantenimiento.GetByDateRange(startDate, endDate);
            Assert.IsNotNull(mantenimientos);
            //Seleccionar un mantenimiento
            var mantenimiento = mantenimientos.Where(x => x.fecha.Equals(Convert.ToDateTime("6/6/2021"))).First() ;
            Assert.AreEqual(mantenimiento.fecha, Convert.ToDateTime("6/6/2021"));

            var modelRegMaquinas = new ModelRegMantenimientoMqns();
            List<MantenimientoMaquinas> maquinas = modelRegMaquinas.GetMaquinaByMantenimiento(mantenimiento.id);
            Assert.IsNotNull(maquinas);


            //Seleccionar una máquina
            var maquina= maquinas.Where(x=> x.serialNO.Equals("1567022")).First();
            Assert.AreEqual(maquina.serialNO, "1567022");

            //Seleccionar las observaciones de la maquina
            List<MantenimientoObservaciones> observaciones = modelRegMaquinas.GetObservacion(mantenimiento.id, maquina.id);
            Assert.IsNotNull (observaciones);

            //Seleccionar las tareas de la máquina
            List < TAREAS >  tareas= modelRegMaquinas.SearchTareas(maquina.id);
            Assert.IsNotNull(tareas);
        }
    }
}
