using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Parcial03.Models;
using Parcial03.Controllers;

namespace Parcial03.Tests.Controllers
{
    [TestClass]
    public class PedidoController
    {
        [TestMethod]
        public void SiIngresoId()
        {
            PedidosController controlador = new PedidosController();
            var prod = new Pedidos()
            {
                id=1,
                id_Clie = 1,
                id_Pro = 2
            };
            var result = controlador.agregar(prod);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SiIngresoIdProd()
        {
            PedidosController controlador = new PedidosController();
            var prod = new Pedidos()
            {

                id_Clie=1,
                id_Pro=2
            };
            var result = controlador.agregar(prod);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SiIngresoIdClie()
        {
            PedidosController controlador = new PedidosController();
            var prod = new Pedidos()
            {
                id_Pro = 1,
                id_Clie=2
            };
            var result = controlador.agregar(prod);
            Assert.AreEqual(3, result);
        }

        
        [TestMethod]
        public void StockCorrecto()
        {
            PedidosController controlador = new PedidosController();
            var prod = new Pedidos()
            {
                id_Pro = 1,
                id_Clie = 2
            };
            var result = controlador.agregar(prod);
            Assert.AreEqual(4, result);
        }
    }
}
