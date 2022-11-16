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
        public void ValidacióCódigoPostal()
        {
            String codigoPostal = "09007";
            Assert.IsTrue(validador.EsCodigoPostal(codigoPostal));

        }

        [TestMethod]
        public void ValidaciónCorreoElectrónico()
        {

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