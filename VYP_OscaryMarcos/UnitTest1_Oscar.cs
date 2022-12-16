using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using UBUClases;

namespace VYP_OscaryMarcos
{
    [TestClass]
    public class UnitTest1_Oscar
    {
        Validador validador = new Validador();
        Estadistica estadistica = new Estadistica();


        [TestInitialize]
        public void Init()
        {
            
        }

        /**************************************************************************
        * 
        * METODO DE PRUEBA PARA EL CÓDIGO POSTAL.
        * 
        * Los dos primeros digitos del codigo postal tienen que ir desde 01 hasta 52
        * Los codigos postales tienen que tener 5 digitos 
        * Existen 3 excepciones que son 070, 071 y 080 que son codigos postales de correspondencia de 
        * Correos y Telégrafos, organismos oficiales, apartados y lista de correos
        * 
        **************************************************************************/

        [TestMethod]
        [DataTestMethod]
        [DataRow("09007", 0, DisplayName = "Codigo postal correcto")]
        [DataRow("0900", -1, DisplayName = "Longitud Codigo Postal Erroneo (Faltan digitos)")]
        [DataRow("900107", -1, DisplayName = "Codigo Postal Incorrecto (No existe el inicio del codigo)")]
        [DataRow("09a7", -1, DisplayName = "Codigo Postal Incorrecto (Contiene una o mas letras)")]
        [DataRow("090074", -1, DisplayName = "Longitud Codigo Postal Erroneo (Sobran digitos)")]
        public void ValidacióCódigoPostal(string CodigoPostal, int previsto)
        {
            Assert.AreEqual(previsto, validador.EsCodigoPostal(CodigoPostal));
        }

        /**************************************************************************
        * 
        * METODO DE PRUEBA PARA EL CORREO ELECTRÓNICO.
        * 
        * El correo debe de empezar por [a–zA-Z]+. No puede empezar por un numero o por un caracter espercial
        * El correo debe de tener un @ seguido de [a–zA-Z]+
        * El correo debe de tener un dominio del tipo (.[a–zA-Z]+)*
        * El correo no puede contener espacios
        * 
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
        [DataRow("sfd_srgh@fgh.es", 0, DisplayName = "EMail Correcto")]
        [DataRow("kjhhkj@iutt.es", 0, DisplayName = "EMail Correcto 2")]
        public void ValidaciónCorreoElectrónico(string eMail, int previsto)
        {
            Assert.AreEqual(previsto, validador.EsEmailValido(eMail));
        }

        /**************************************************************************
        * 
        * METODO DE PRUEBA PARA EL CORREO ELECTRÓNICO.
        * 
        * El NIF de Nacionales menores de 14 años que carezcan de DNI,
        *   debe de ser de la forma [Kk]{1}[0-9]{7}[a-zA-Z]{1}.
        * El NIF de Nacionales mayores de 14 años residentes en el extranjero 
        *   y que no tengan DNI que se trasladan a España por un tiempo inferior a seis meses,
        *   debe de ser de la forma [Ll]{1}[0-9]{7}[a-zA-Z]{1}.
        * El NIF de Extranjeros sin NIE, de forma transitoria por estar obligados a tenerlo,
        *   o bien de forma definitiva al no estar obligados a ello, 
        *   debe de ser de la forma [Mm]{1}[0-9]{7}[a-zA-Z]{1}.
        * EL DNI debe de ser de la forma [0-9]{8}[a-zA-Z]{1}.
        * El NIE de Extranjeros residentes en España e identificados por la Policía con un número de identidad de extranjero, 
        *   debe de ser de la forma [Xx]{1}[0-9]{7}[a-zA-Z]{1}. 
        * El NIE de Extranjeros residentes en España e identificados por la Policía con un NIE,
        *   debe de ser de la forma [Yy]{1}[0-9]{7}[a-zA-Z]{1}.
        * El NIE para cuando se agoten los 'NIE Y' debe ser de la forma [Zz]{1}[0-9]{7}[a-zA-Z]{1}.
        * 
        * 
        **************************************************************************/
        [TestMethod]
        [DataTestMethod]
        [DataRow("09876543K", 0, DisplayName = "DNI Correcto")]
        [DataRow("K2642736J", 1, DisplayName = "NIF Correcto (Tipo K)")]
        [DataRow("L4462976X", 2, DisplayName = "NIF Correcto (Tipo L)")]
        [DataRow("M7439875L", 3, DisplayName = "NIF Correcto (Tipo M)")]
        [DataRow("X1234566H", 4, DisplayName = "NIE Correcto (Tipo X)")]
        [DataRow("Y8967453C", 5, DisplayName = "NIE Correcto (Tipo Y)")]
        [DataRow("Z2749351M", 6, DisplayName = "NIE Correcto (Tipo Z)")]
        [DataRow("09876543F", -1, DisplayName = "DNI InCorrecto")]
        [DataRow("X1234566G", -1, DisplayName = "NIE InCorrecto (Tipo X)")]
        [DataRow("Y8967453H", -1, DisplayName = "NIE InCorrecto (Tipo Y)")]
        [DataRow("Z2749351I", -1, DisplayName = "NIE InCorrecto (Tipo Z)")]
        [DataRow("K2642736K", -1, DisplayName = "NIF InCorrecto (Tipo K)")]
        [DataRow("L4462976A", -1, DisplayName = "NIF InCorrecto (Tipo L)")]
        [DataRow("M7439875S", -1, DisplayName = "NIF InCorrecto (Tipo M)")]
        [DataRow("09873F", -1, DisplayName = "DNI InCorrecto (Longitud Incorrecta)")]

        public void ValidaciónNIF(string nif, int previsto)
        {
            Assert.AreEqual(previsto, validador.EsNIF(nif));
        }

        /**************************************************************************
        * 
        * METODO DE PRUEBA PARA LA TARJETA DE CREDITO (VISA, MASTERCARD).
        * 
        * Las tarjetas MASTERCARD pueden empezar por [54] o [55]
        * Las tarjetas MASTERCARD pueden empezar por 2 siendo el rango de digitos entre (222100 a 272099)
        * Las tarjetas MASTERCARD tienen que tener una longitud de 16 digitos obligatoriamente
        * Las tarjetas VSIA deben de empezar por [4]
        * Las tarjetas VISA pueden ser de 13 digitos o de 16 digitos
        * 
        **************************************************************************/

        [TestMethod]
        [DataTestMethod]
        [DataRow("5112 3162 8908 4398", 0, DisplayName = "Tarjeta de Credito Correcta (TIPO MASTERCAD)")]
        [DataRow("4008 9466 9185 3566", 0, DisplayName = "Tarjeta de Credito Correcta (TIPO VISA)")]
        [DataRow("5478 9827 7625 7859", -1, DisplayName = "Tarjeta de Credito incorrecta (TIPO MASTERCAD)")]
        [DataRow("5578 9827 7625 7859", -1, DisplayName = "Tarjeta de Credito incorrecta (TIPO MASTERCAD)")]
        [DataRow("2221 1103 0418 4012", -1, DisplayName = "Tarjeta de Credito incorrecta (TIPO MASTERCAD)")]
        [DataRow("2720 9903 0418 4012", -1, DisplayName = "Tarjeta de Credito incorrecta (TIPO MASTERCAD)")]
        [DataRow("5478 9827 7625 7859 5433", -1, DisplayName = "Tarjeta de Credito Incorrecta (longitud incorrecta)")]
        [DataRow("5478 9827", -1, DisplayName = "Tarjeta de Credito Incorrecta (longitud incorrecta)")]
        [DataRow("AS78 9827 7625 7859", -1, DisplayName = "Tarjeta de Credito Incorrecta (formato incorrecto)")]
        [DataRow("6778 9827 7625 7859", -1, DisplayName = "Tarjeta de Credito Incorrecta (no se reconoce ni como VISA ni como MASTERCAD)")]

        public void ValidaciónDeUnaTarjetaDeCrédito(string tarjetaCredito, int previsto)
        {
            Assert.AreEqual(previsto, validador.EsTarjetaCredito(tarjetaCredito));
        }

        /**************************************************************************
        * 
        * METODO DE PRUEBA PARA EL IBAN ESPAÑOL.
        * 
        * El IBAN español de ser de la forma [Ee]{1}[Ss]{1}[0-9]{2}[" "]([0-9]{4}[" "]){5}.
        * Esto se traduce en: la letra E tanto minuscula o mayuscula 1 vez
        * La letra S tanto minuscula o mayuscula 1 vez
        * 2 digitos seguidos de 1 espacio
        * 4 digitos y 1 espacio 5 veces
        * 
        **************************************************************************/

        //[TestMethod]
        //[DataTestMethod]
        //[DataRow("ES66 2100 0418 4012 3456 7891", 0, DisplayName = "IBAN Español correcto")]
        //[DataRow("ES66 2100 0418 4012 3456", -1, DisplayName = "IBAN incorrecto (longitud incorrecta)")]
        //[DataRow("ES66 2100 0418 4012 3456 7891 5684", -1, DisplayName = "IBAN incorrecto (longitud incorrecta")]
        //[DataRow("ET66 2100 0418 4012 3456 7891", -1, DisplayName = "IBAN incorrecto (no es español)")]
        //[DataRow("3466 2100 0418 4012 3456 7891", -1, DisplayName = "IBAN incorrecto (no se identifica con ningun pais)")]
        //[DataRow("ES66 2100 0418 AS12 3456 7891", -1, DisplayName = "IBAN incorrecto (formato incorrecto)")]
        //[DataRow("ES6621000418AS1234567891", -1, DisplayName = "IBAN incorrecto (formato incorrecto)")]
        //public void ValidaciónDeUnIBANEspañol(string ibanespanol, int previsto)
        //{
        //    Assert.AreEqual(previsto, validador.EsIBANEspanol(ibanespanol));
        //}

        /**************************************************************************
        * 
        * METODO DE PRUEBA PARA EL CCC BANCARIO.
        * 
        * El CCC bancario de ser de la forma ([0-9]{4}[-]{1}){2}[0-9]{2}[-]{1}[0-9]{10}.
        * Esto se traduce en: 4 digitos iniciales seguidos de un - 2 veces
        * 2 digitos seguidos de - 1 vez
        * 10 digitos
        * 
        **************************************************************************/
        [TestMethod]
        [DataTestMethod]
        [DataRow("00789684042474678719", 0, DisplayName = "CCC Español correcto")]
        [DataRow("2103-2885-28-7531379877", 0, DisplayName = "CCC Español correcto con guiones")]
        [DataRow("0011 2400 54 3450567542", 0, DisplayName = "CCC Español correcto con espaciow")]
        [DataRow("20200000-11-2233445566", -1, DisplayName = "CCC incorrecto (formato incorrecto)")]
        [DataRow("2020-0000-11-22335", -1, DisplayName = "CCC incorrecto (longitud incorrecta")]
        [DataRow("2020-0000-11-22334455345465", -1, DisplayName = "CCC incorrecto (longitud incorrecta) 2")]
        [DataRow("2020-0000-11-qw33445566", -1, DisplayName = "CCC incorrecto (formato incorrecto) 2")]
        public void ValidaciónDeUnCCCBancario(string cccbancario, int previsto)
        {
            Assert.AreEqual(previsto, validador.EsCCCBancario(cccbancario));
        }

        /**************************************************************************
        * 
        * METODOS DE CALCULOS
        * 
        * El formato introducido debe de ser del tipo ([0-9][,])+.
        * Es decir, se introduciran digitos separados por comas 1 o mas veces.
        * El formato de los digitos tendra que ser doubles
        * Este formato se aplicara para todos los metodos de calculos 
        * 
        **************************************************************************/

        [TestMethod]
        [DataTestMethod]
        [DataRow(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 3.0, DisplayName = "Media aritmética correcta (test 1)")]
        [DataRow(new double[] { 1.0, 2.0, 3.0, 4.0, 4.0 }, 2.8, DisplayName = "Media aritmética correcta (test 2)")]
        [DataRow(new double[] { 1.0, 2.0, 3.0, double.NaN }, double.NaN, DisplayName = "Media aritmética correcta")]
        public void CalculeLaMediaAritmética(double[] datos, double previsto)
        {
            Assert.AreEqual(previsto, Math.Round(estadistica.MediaAritmetica(datos),2));
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.61, DisplayName = "Media geométrica correcta (test 1)")]
        [DataRow(new double[] { 1.0, 2.0, 3.0, 4.0, 4.0 }, 2.49, DisplayName = "Media geométrica correcta (test 2)")]
        [DataRow(new double[] { 1.0, 2.0, 3.0, double.NaN }, double.NaN, DisplayName = "Media geométrica correcta")]
        public void CalculeLaMediaGeométrica(double[] datos, double previsto)
        {
            Assert.AreEqual(previsto, Math.Round(estadistica.MediaGeometrica(datos),2));
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.19, DisplayName = "Media armónica correcta (test 1)")]
        [DataRow(new double[] { 1.0, 2.0, 3.0, 4.0, 4.0 }, 2.14, DisplayName = "Media armónica correcta (test 2)")]
        [DataRow(new double[] { 1.0, 2.0, 3.0, double.NaN }, double.NaN, DisplayName = "Media armónica incalculable por contener NaN")]
        public void CalculeLaMediaArmónica(double[] datos, double previsto)
        {
            Assert.AreEqual(previsto, Math.Round(estadistica.MediaArmonica(datos),2));
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(new double[] { 2.0, 2.0, 3.0, 4.0, 6.0, 4.0, 3.0 }, 3.0, DisplayName = "Mediana correcta: Cantidad de datos pares")]
        [DataRow(new double[] { 2.0, 2.0, 3.0, 4.0, 6.0, 4.0 }, 3.5, DisplayName = "Mediana correcta: Cantidad de datos impares")]
        [DataRow(new double[] { 1.0, 2.0, 3.0, double.NaN }, double.NaN, DisplayName = "Mediana incalculable por contener NaN")]
        public void CalculeLaMediana(double[] datos, double previsto)
        {
            Assert.AreEqual(previsto, Math.Round(estadistica.Mediana(datos),2));
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(new double[] { 2.0, 2.0, 3.0, 4.0, 6.0 }, new double[] { 2.0 }, DisplayName = "Moda correcta: 1 moda")]
        [DataRow(new double[] { 2.0, 2.0, 3.0, 4.0, 6.0, 4.0 }, new double[] { 2.0, 4.0 }, DisplayName = "Moda correcta: 2 modas")]
        [DataRow(new double[] { 1.0, 2.0, 3.0, double.NaN }, new double[] { double.NaN }, DisplayName = "Moda incalculable por contener NaN")]
        public void CalculeLaModa(double[] datos, double[] previsto)
        {
            double[] resultado = estadistica.Moda(datos);
            double[] intersecion = resultado.Intersect(previsto).ToArray<double>();
            Assert.AreEqual(previsto.Length, intersecion.Length);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 5.0}, new double[] { 2.71, 1.71, 0.71, 0.29, 1.29, 2.29, 1.29 }, DisplayName = "Desviación sin signo o Absoluta correcta")]
        [DataRow(new double[] { 1.0, 2.0, 3.0, double.NaN }, new double[] { double.NaN }, DisplayName = "Desviación sin signo o Absoluta incalculable por contener NaN")]
        public void CalculaLaDesviaciónSinSignoOAbsoluta(double[] datos, double[] previsto)
        {
            double[] resultado = estadistica.DesviacionSinSingoOAbsoluta(datos);
            Assert.AreEqual(previsto.Length, resultado.Length);
            int contador = 0;
            while(contador < resultado.Length)
            {
                Assert.AreEqual(previsto[contador], Math.Round(resultado[contador],2));
                contador++;
            }
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 5.0, 3.0, 5.0, 5.0, 6.0, 4.0, 3.0, 2.0, 4.0, 5.0, 7.0, 8.0, 4.0, 5.0, 5.0, 4.0, 12.0, 12.0, 12.0, 31.0, 5.0, 3.0, 26.0, 3.0, 748.0, 4.0, 63.0, 2.0, 1.0, 41.0, 5.0, 26.0, 3.0 }, 39.53, DisplayName = "Desviacion media con signo correcta")]
        [DataRow(new double[] { 1.0, 2.0, 3.0, double.NaN }, double.NaN, DisplayName = "Desviación media con signo incalculable por contener NaN")]
        public void CalculaLaDesviaciónMediaConSigno(double[] datos, double previsto)
        {
            Assert.AreEqual(previsto, Math.Round(estadistica.DesviacionMediaConSigno(datos),2));
        }
    }
}