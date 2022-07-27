using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void EscribirReclamo_DeberiaRetornarTrue()
        {
            //Arrange
            Reclamos reclamo = new Reclamos("Jose Perez", "23456789", "No funciona el laser nuevo de la consola.");
            bool expected = true;
            bool actual;
            //Act
            actual = Archivos.EscribirReclamo(reclamo);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EscribirCliente_DeberiaRetornarTrue()
        {
            //Arrange
            Servicios servicio = new Servicios("3000", "Mantenimiento", "10", "PS4");
            Cliente cliente = new Cliente("Suarez Brandon", "43396325", "16/05/2021", servicio);
            bool expected = true;
            bool actual;
            //Act
            actual = Archivos.EscribirCliente(cliente);
            //
            Assert.AreEqual(expected, actual);

            
        }

    }
}
