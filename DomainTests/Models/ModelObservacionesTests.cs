using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace Domain.Models.Tests
{
    [TestClass()]
    public class ModelObservacionesTests
    {
        



        [TestMethod()]
        public void AddObservacionTest()
        {
            ModelObservaciones model= new ModelObservaciones();
            OBSERVACIONES observacion= new OBSERVACIONES();
            var observaciones = model.GetAll();
            OBSERVACIONES last = observaciones.Last();


            observacion.tecnico_id = last.tecnico_id;
            observacion.descripcion = "test";
            observacion.id = last.id + 1;
            observacion.mantenimiento_id = last.mantenimiento_id;
            observacion.maquina_id = last.maquina_id;
            model.Add(observacion);

            decimal expected = observacion.id;
            decimal actual = model.GetAll().Last().id;
            Assert.AreEqual(expected, actual);
            model.Remove(observacion.id);
        }
    }
}



            //decimal expected = 1;
            //decimal actual = 1;

            //Assert.AreEqual(expected, actual);
            //var observaciones= model.GetAll();
            //OBSERVACIONES last= observaciones.Last();


            //observacion.tecnico_id = last.tecnico_id;
            //observacion.descripcion = "test";
            //observacion.id = last.id + 1;
            //observacion.mantenimiento_id= last.mantenimiento_id;

            //model.Add(observacion);
            ////decimal expected = observacion.id;
            ////decimal actual = model.GetAll().Last().id;

            //model.Remove(observacion.id);
