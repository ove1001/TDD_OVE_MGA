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

            /**************************************************************************
             * 
             * Los dos primeros digitos del codigo postal tienen que ir desde 01 hasta 52
             * Los codigos postales tienen que tener 5 digitos 
             * Existen 3 excepciones que son 070, 071 y 080 que son codigos postales de 
             * 
             **************************************************************************/

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("asd.fgh.es", -1, DisplayName = "EMail Incorrecto sin @")]
        [DataRow("", -1, DisplayName = "EMail longitud 0")]
        [DataRow("@asdfgh.es", -1, DisplayName = "EMail Incorrecto sin usuario")]
        [DataRow("asd.asd@fgh.es", 1, DisplayName = "EMail Correcto")]
        [DataRow("asd@fgh.es", 1, DisplayName = "EMail Correcto")]

        public void ValidaciónCorreoElectrónico(string eMail, int previsto)
        {
            EmailAddressAttribute u1 = new EmailAddressAttribute();
            if (previsto > 0) Assert.IsTrue(u1.IsValid(eMail));
            else Assert.IsFalse(u1.IsValid(eMail));
        }

        [TestMethod]
        public void ValidaciónNIF()
        {

        }

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