using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Tests
{
    [TestClass()]
    public class ModelRegMantenimientoMqnsTests
    {
        [TestMethod()]
        public void GetMaquinaByMantenimientoTest()
        {

            var modelMantenimiento = new ModelMantenimiento();
            DateTime startDate = Convert.ToDateTime("6/6/2021");
            DateTime endDate = Convert.ToDateTime("6/6/2021");
            var mantenimiento = modelMantenimiento.GetByDateRange(startDate, endDate).Last();


            var modelRegMaquinas = new ModelRegMantenimientoMqns();
            var maquina = modelRegMaquinas.GetMaquinaByMantenimiento(mantenimiento.id).ElementAt(1);

            var expected = 1567022.ToString();
            var actual = maquina.serialNO;

            Assert.AreEqual(expected, actual);

        }


        [TestMethod()]
        public void GetObservacionByMaquinaTest()
        {
            var modelRegMantenimiento = new ModelRegMantenimientoMqns();
            var modelMantenimiento = new ModelMantenimiento();
            DateTime startDate = Convert.ToDateTime("6/6/2021");
            DateTime endDate = Convert.ToDateTime("6/6/2021");
            var mantenimiento = modelMantenimiento.GetByDateRange(startDate, endDate).Last();
            var maquina = modelRegMantenimiento.GetMaquinaByMantenimiento(mantenimiento.id).ElementAt(1);


            var observaciones = modelRegMantenimiento.GetObservacion(mantenimiento.id, maquina.id);
            var expected = 1000055;
            var actual = observaciones.ElementAt(0).id;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTareasTest()
        {
            var modelRegMantenimiento = new ModelRegMantenimientoMqns();
            var modelMantenimiento = new ModelMantenimiento();
            DateTime startDate = Convert.ToDateTime("6/6/2021");
            DateTime endDate = Convert.ToDateTime("6/6/2021");
            var mantenimiento = modelMantenimiento.GetByDateRange(startDate, endDate).Last();
            var maquina = modelRegMantenimiento.GetMaquinaByMantenimiento(mantenimiento.id).ElementAt(1);


            var tareas= modelRegMantenimiento.SearchTareas(maquina.id);
            var expected = 40000004;
            var actual= tareas.ElementAt(0).id;

            Assert.AreEqual(expected,actual);   
            
        }
    }
}