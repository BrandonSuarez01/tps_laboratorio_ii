using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void EscribirArchivos_CuandoRecibeUnaLista_DeberiaRetornarTrue()
        {
            //Arrange
            Archivos archivo = new Archivos();
            List<Cliente> listaPrueba = new List<Cliente>();
            Cliente clientePrueba = new Cliente("Jose Perez", "43309222", "TECLADO", "13/05/2021", "$2000");
            listaPrueba.Add(clientePrueba);
            bool expected = true;
            bool actual;
            //Act
            actual = archivo.EscribirArchivo(listaPrueba);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LeerArchivos__DeberiaRetornarUnaListaEscrita()
        {
            //Arrange
            Archivos archivo = new Archivos();
            List<string> actual;
            //Act
            actual = archivo.LeerArchivo();
            //Assert
            Assert.IsNotNull(actual);
            
        }
    }
}
