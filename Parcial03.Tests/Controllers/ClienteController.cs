using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Parcial03.Models;
using Parcial03.Controllers;

namespace Parcial03.Tests.Controllers
{
    [TestClass]
    public class ClienteController
    {
        [TestMethod]
        public void SiIngresoId()
        {
            ClientesController controlador = new ClientesController();
            var clie = new Clientes()
            {
                id_Clie = 1,
                nombres = "Luis",
                fechaNaci = Convert.ToDateTime("03/19/1998")
            };
            var result = controlador.agregar(clie);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void NombreIdentico()
        {
           ClientesController controlador = new ClientesController();
            var clie = new Clientes()
            {
                
                nombres = "Luis",
                fechaNaci = Convert.ToDateTime("12/09/1993")
            };
            var result = controlador.agregar(clie);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void DuiRepetido()
        {
            ClientesController controlador = new ClientesController();
            var clie = new Clientes()
            {
                dui="01234567-8"
            };
            var result = controlador.agregar(clie);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void MayorEdad()
        {
            ClientesController controlador = new ClientesController();
            var clie = new Clientes()
            {
               fechaNaci=Convert.ToDateTime( "03/19/1998")
            };
            var result = controlador.agregar(clie);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TodoCorrecto()
        {
            ClientesController controlador = new ClientesController();
            var clie = new Clientes()
            {
                nombres = "Luis",
                apellidos = "Chevez",
                dui = "01234567-8",
                fechaNaci = Convert.ToDateTime("03/19/1998")
            };
            var result = controlador.agregar(clie);
            Assert.AreEqual(0, result);
        }
    }
}
