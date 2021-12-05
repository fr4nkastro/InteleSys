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
    public class ModelTareasTest
    {
        [TestMethod()]
        public void AddTareasTest()
        {
            var tarea = new TAREAS();
            var frm = new ModelTareas();
            var last = frm.GetAll().Last();

            tarea.id = last.id + 1;
            tarea.maquina_id = last.maquina_id;
            tarea.descripcion = "test";
            tarea.fecha_final= last.fecha_final;

            frm.Add(tarea);

            var expected = tarea.id;
            var actual  = frm.GetAll().Last().id;
            Assert.AreEqual(expected, actual);
            frm.Remove(tarea.id);
            
        }
    }
}