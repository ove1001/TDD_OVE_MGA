namespace VYP_OscaryMarcos
{
    [TestClass]
    public class UnitTest1
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