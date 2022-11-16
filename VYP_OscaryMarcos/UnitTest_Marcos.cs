namespace VYP_OscaryMarcos
{
    [TestClass]
    public class UnitTest_Marcos
    {
        [TestInitialize]
        public void Init()
        {
            Validador validador = new Validador();
        }

        [TestMethod]
        public void Validaci�C�digoPostal()
        {
            String codigoPostal = "09007";
            Assert.IsTrue(validador.EsCodigoPostal(codigoPostal));

            /**************************************************************************
             * 
             * Los dos primeros digitos del codigo postal tienen que ir desde 01 hasta 52
             * Los codigos postales tienen que tener 5 digitos 
             * Existen 3 excepciones que son 070, 071 y 080 que son codigos postales de 
             * 
             **************************************************************************/

        }

        [TestMethod]
        public void Validaci�nCorreoElectr�nico()
        {

        }

        [TestMethod]
        public void Validaci�nNIF()
        {

        }

        [TestMethod]
        public void Validaci�nDeUnaTarjetaDeCr�dito()
        {

        }

        [TestMethod]
        public void Validaci�nDeUnCCCBancario()
        {

        }

        [TestMethod]
        public void Validaci�nDeUnIBANEspa�ol()
        {

        }
        
        [TestMethod]
        public void CalculeLaMediaAritm�tica()
        {

        }

        [TestMethod]
        public void CalculeLaMediaGeom�trica()
        {

        }

        [TestMethod]
        public void CalculeLaMediaArm�nica()
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
        public void CalculaLaDesviaci�nSinSignoOAbsoluta()
        {

        }

        [TestMethod]
        public void CalculaLaDesviaci�nMediaConSigno()
        {

        }
    }
}