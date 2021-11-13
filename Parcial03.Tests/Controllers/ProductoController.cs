using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Parcial03.Models;
using Parcial03.Controllers;

namespace Parcial03.Tests.Controllers
{
    [TestClass]
    public class ProductoController
    {
        [TestMethod]
        public void SiIngresoId()
        {
            ProductosController controlador = new ProductosController();
            var prod = new Productos()
            {
              
                nombre = "Edwin",
                stock = 15,
                valor = 10.55
            };
            var result = controlador.agregar(prod);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NombreIgual()
        {
            ProductosController controlador = new ProductosController();
            var prod = new Productos()
            {
                id_Pro = 1,
                nombre = "Edwin",
                stock = 15,
                valor = 10.55
            };
            var result = controlador.agregar(prod);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void IngresoCorrecto()
        {
            ProductosController controlador = new ProductosController();
            var prod = new Productos()
            {
                id_Pro = 1,
                nombre = "Edwin2",
                stock = -15,
                valor = -10.55
            };
            var result = controlador.agregar(prod);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ValorCorrecto()
        {
            ProductosController controlador = new ProductosController();
            var prod = new Productos()
            {
                id_Pro = 1,
                nombre = "Edwin2",
                stock = 15,
                valor = 1
            };
            var result = controlador.agregar(prod);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void StockCorrecto()
        {
            ProductosController controlador = new ProductosController();
            var prod = new Productos()
            {
                id_Pro = 1,
                nombre = "Edwin2",
                stock = 15,
                valor = -1
            };
            var result = controlador.agregar(prod);
            Assert.AreEqual(4, result);
        }
    }
}


