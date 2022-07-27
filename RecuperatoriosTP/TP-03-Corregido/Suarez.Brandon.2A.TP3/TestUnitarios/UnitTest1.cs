using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
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
