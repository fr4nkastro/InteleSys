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
    public class ModelMaquinaTests
    {
        [TestMethod()]
        public void AddMaquinaTest()
        {
            var modelMaquinas = new ModelMaquina();
            var modelRegMaquinas = new ModelRegMantenimientoMqns();
            var modelArticulo = new ModelArticulos();

            var objArticulo = new ARTICULO();
            objArticulo.articulo_id = 999999;
            objArticulo.tipo_articulo_id = 2002;
            modelArticulo.Add(objArticulo);

            var objMaquina = new MAQUINA();
            objMaquina.articulo_id = 999999;
            objMaquina.serialno = "00000000";
            objMaquina.modelo_id = 3004;
            objMaquina.estado_mqn_id = 4001;
            objMaquina.cliente_id = 5003;
            modelMaquinas.Add(objMaquina);

            var actual= modelMaquinas.GetAll().Where(x=> x.articulo_id== 999999).First().articulo_id;
            var expected = objMaquina.articulo_id;
            Assert.AreEqual(expected, actual);


        }
    }
}