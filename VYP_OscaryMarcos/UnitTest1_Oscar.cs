using System.ComponentModel.DataAnnotations;

namespace VYP_OscaryMarcos
{
    [TestClass]
    public class UnitTest1_Oscar
    {
        [TestInitialize]
        public void Init()
        {
            //Validador validador = new Validador();
        }

        [TestMethod]
        public void ValidacióCódigoPostal()
        {
            String codigoPostal = "09007";
            //Assert.IsTrue(validador.EsCodigoPostal(codigoPostal));



        }

        /**************************************************************************
         * 
         * La dirección de correo tiene que tener "usuario" seguido de "@" seguido de "dominio"
         * 
         **************************************************************************/

        [TestMethod]
        [DataTestMethod]

        [DataRow("", -1, DisplayName = "EMail longitud 0")]
        [DataRow("hafs.jsdh.es", -1, DisplayName = "EMail Incorrecto sin @")]       
        [DataRow("@djkfsk.es", -1, DisplayName = "EMail Incorrecto sin usuario")]
        [DataRow("bfehjwe@", -1, DisplayName = "EMail Incorrecto sin dominio")]
        [DataRow("bfehjwe@fjkhke", -1, DisplayName = "EMail Incorrecto con dominio incompleto")]
        [DataRow("bfehjwe@.es", -1, DisplayName = "EMail Incorrecto con dominio incompleto")]
        [DataRow("sfd.srgh@fgh.es", 0, DisplayName = "EMail Correcto")]
        [DataRow("kjhhkj@iutt.es", 0, DisplayName = "EMail Correcto")]
        public void ValidaciónCorreoElectrónico(string eMail, int previsto)
        {
            Assert.AreEqual(previsto,validador.EsEmailValido(eMail));
        }




        [TestMethod]
        public void ValidaciónNIF()
        {

        }

        /**************************************************************************
         * 
         * El número de una tarjeta mastercard tiene que empezar por 222100-272099 o por 51-55
         * El número de una tarjeta visa tiene que empezar por 4
         * 
         * Ambas tarjetas utilizan el algoritmo de Luhn para comprobar la validez del número de tarjeta
         * 
         **************************************************************************/
        [TestMethod]
        public void ValidaciónDeUnaTarjetaDeCrédito()
        {

        }

        [TestMethod]
        public void ValidaciónDeUnCCCBancario()
        {

        }

        [TestMethod]
        public void ValidaciónDeUnIBANEspañol()
        {

        }
        
        [TestMethod]
        public void CalculeLaMediaAritmética()
        {

        }

        [TestMethod]
        public void CalculeLaMediaGeométrica()
        {

        }

        [TestMethod]
        public void CalculeLaMediaArmónica()
        {

        }

        [TestMethod]
        public void CalculeLaMediana()
        {

        }

        [TestMethod]
        public void CalculeLaModa()
        {

        }

        [TestMethod]
        public void CalculaLaDesviaciónSinSignoOAbsoluta()
        {

        }

        [TestMethod]
        public void CalculaLaDesviaciónMediaConSigno()
        {

        }
    }
}