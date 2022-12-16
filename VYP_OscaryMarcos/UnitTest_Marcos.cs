using System.ComponentModel.DataAnnotations;

namespace VYP_OscaryMarcos
{
    [TestClass]
    public class UnitTest_Marcos
    {
        //        [TestInitialize]
        //        public void Init()
        //        {
        //            Validador validador = new Validador();
        //        }

        //        /**************************************************************************
        //        * 
        //        * METODO DE PRUEBA PARA EL CÓDIGO POSTAL.
        //        * 
        //        * Los dos primeros digitos del codigo postal tienen que ir desde 01 hasta 52
        //        * Los codigos postales tienen que tener 5 digitos 
        //        * Existen 3 excepciones que son 070, 071 y 080 que son codigos postales de correspondencia de 
        //        * Correos y Telégrafos, organismos oficiales, apartados y lista de correos
        //        * 
        //        **************************************************************************/

        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow("09007", 0, DisplayName = "Codigo postal correcto")]
        //        [DataRow("0900", -1, DisplayName = "Longitud Codigo Postal Erroneo (Faltan digitos)")]
        //        [DataRow("90007", -1, DisplayName = "Codigo Postal Incorrecto (No existe el inicio del codigo)")]
        //        [DataRow("09a7", -1, DisplayName = "Codigo Postal Incorrecto (Contiene una o mas letras)")]
        //        [DataRow("090074", -1, DisplayName = "Longitud Codigo Postal Erroneo (Sobran digitos)")]
        //        public void ValidacióCódigoPostal(string CodigoPostal, int previsto)
        //        {
        //            Assert.AreEqual(previsto, validador.EsCodigoPostal(CodigoPostal));
        //        }

        //        /**************************************************************************
        //        * 
        //        * METODO DE PRUEBA PARA EL CORREO ELECTRÓNICO.
        //        * 
        //        * El correo debe de empezar por [a–zA-Z]+. No puede empezar por un numero o por un caracter espercial
        //        * El correo debe de tener un @ seguido de [a–zA-Z]+
        //        * El correo debe de tener un dominio del tipo (.[a–zA-Z]+)*
        //        * El correo no puede contener espacios
        //        * 
        //        * 
        //        **************************************************************************/
        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow("", -1, DisplayName = "EMail longitud 0")]
        //        [DataRow("hafs.jsdh.es", -1, DisplayName = "EMail Incorrecto sin @")]
        //        [DataRow("@djkfsk.es", -1, DisplayName = "EMail Incorrecto sin usuario")]
        //        [DataRow("bfehjwe@", -1, DisplayName = "EMail Incorrecto sin dominio")]
        //        [DataRow("bfehjwe@fjkhke", -1, DisplayName = "EMail Incorrecto con dominio incompleto")]
        //        [DataRow("bfehjwe@.es", -1, DisplayName = "EMail Incorrecto con dominio incompleto")]
        //        [DataRow("sfd.srgh@fgh.es", 0, DisplayName = "EMail Correcto")]
        //        [DataRow("kjhhkj@iutt.es", 0, DisplayName = "EMail Correcto")]
        //        public void ValidaciónCorreoElectrónico(string email, int previsto)
        //        {
        //            Assert.AreEqual(previsto, validador.EsEmailValido(eMail));
        //        }

        //        /**************************************************************************
        //        * 
        //        * METODO DE PRUEBA PARA EL CORREO ELECTRÓNICO.
        //        * 
        //        * El NIF de Nacionales menores de 14 años que carezcan de DNI,
        //        *   debe de ser de la forma [Kk]{1}[0-9]{7}[a-zA-Z]{1}.
        //        * El NIF de Nacionales mayores de 14 años residentes en el extranjero 
        //        *   y que no tengan DNI que se trasladan a España por un tiempo inferior a seis meses,
        //        *   debe de ser de la forma [Ll]{1}[0-9]{7}[a-zA-Z]{1}.
        //        * El NIF de Extranjeros sin NIE, de forma transitoria por estar obligados a tenerlo,
        //        *   o bien de forma definitiva al no estar obligados a ello, 
        //        *   debe de ser de la forma [Mm]{1}[0-9]{7}[a-zA-Z]{1}.
        //        * EL DNI debe de ser de la forma [0-9]{8}[a-zA-Z]{1}.
        //        * El NIE de Extranjeros residentes en España e identificados por la Policía con un número de identidad de extranjero, 
        //        *   debe de ser de la forma [Xx]{1}[0-9]{7}[a-zA-Z]{1}. 
        //        * El NIE de Extranjeros residentes en España e identificados por la Policía con un NIE,
        //        *   debe de ser de la forma [Yy]{1}[0-9]{7}[a-zA-Z]{1}.
        //        * El NIE para cuando se agoten los 'NIE Y' debe ser de la forma [Zz]{1}[0-9]{7}[a-zA-Z]{1}.
        //        * 
        //        * 
        //        **************************************************************************/
        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow("09876543K", 0, DisplayName = "DNI Correcto")]
        //        [DataRow("X1234566H", 1, DisplayName = "NIE Correcto (Tipo X)")]
        //        [DataRow("Y8967453C", 2, DisplayName = "NIE Correcto (Tipo Y)")]
        //        [DataRow("Z2749351M", 3, DisplayName = "NIE Correcto (Tipo Z)")]
        //        [DataRow("K2642736J", 4, DisplayName = "NIF Correcto (Tipo K)")]
        //        [DataRow("L4462976X", 5, DisplayName = "NIF Correcto (Tipo L)")]
        //        [DataRow("M7439875L", 6, DisplayName = "NIF Correcto (Tipo M)")]
        //        [DataRow("09876543F", -1, DisplayName = "DNI InCorrecto")]
        //        [DataRow("X1234566G", -1, DisplayName = "NIE InCorrecto (Tipo X)")]
        //        [DataRow("Y8967453H", -1, DisplayName = "NIE InCorrecto (Tipo Y)")]
        //        [DataRow("Z2749351I", -1, DisplayName = "NIE InCorrecto (Tipo Z)")]
        //        [DataRow("K2642736K", -1, DisplayName = "NIF InCorrecto (Tipo K)")]
        //        [DataRow("L4462976A", -1, DisplayName = "NIF InCorrecto (Tipo L)")]
        //        [DataRow("M7439875S", -1, DisplayName = "NIF InCorrecto (Tipo M)")]
        //        [DataRow("09873F", -1, DisplayName = "DNI InCorrecto (Longitud Incorrecta)")]
        //        [DataRow("X1234566G", -1, DisplayName = "NIE InCorrecto (Tipo X)")]
        //        [DataRow("Y8967453H", -1, DisplayName = "NIE InCorrecto (Tipo Y)")]
        //        [DataRow("Z2749351I", -1, DisplayName = "NIE InCorrecto (Tipo Z)")]
        //        [DataRow("K2642736K", -1, DisplayName = "NIF InCorrecto (Tipo K)")]
        //        [DataRow("L4462976A", -1, DisplayName = "NIF InCorrecto (Tipo L)")]
        //        [DataRow("M7439875S", -1, DisplayName = "NIF InCorrecto (Tipo M)")]

        //        public void ValidaciónNIF(string nif, int previsto)
        //        {
        //            Assert.AreEqual(previsto, validador.EsNIF(nif));
        //        }

        //        /**************************************************************************
        //        * 
        //        * METODO DE PRUEBA PARA LA TARJETA DE CREDITO (VISA, MASTERCARD).
        //        * 
        //        * Las tarjetas MASTERCARD pueden empezar por [54] o [55]
        //        * Las tarjetas MASTERCARD pueden empezar por 2 siendo el rango de digitos entre (222100 a 272099)
        //        * Las tarjetas MASTERCARD tienen que tener una longitud de 16 digitos obligatoriamente
        //        * Las tarjetas VSIA deben de empezar por [4]
        //        * Las tarjetas VISA pueden ser de 13 digitos o de 16 digitos
        //        * 
        //        **************************************************************************/

        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow("4345 9764 2659 5864", 0, DisplayName = "Tarjeta de Credito Correcta (TIPO VISA)")]
        //        [DataRow("4345 9764 2659", -1, DisplayName = "Tarjeta de Credito Correcta (TIPO VISA)")]
        //        [DataRow("5478 9827 7625 7859", -1, DisplayName = "Tarjeta de Credito Correcta (TIPO MASTERCAD)")]
        //        [DataRow("5578 9827 7625 7859", -1, DisplayName = "Tarjeta de Credito Correcta (TIPO MASTERCAD)")]
        //        [DataRow("2221 0003 0418 4012", -1, DisplayName = "Tarjeta de Credito Correcta (TIPO MASTERCAD)")]
        //        [DataRow("2720 9903 0418 4012", -1, DisplayName = "Tarjeta de Credito Correcta (TIPO MASTERCAD)")]
        //        [DataRow("5478 9827 7625 7859 5433", -1, DisplayName = "Tarjeta de Credito Incorrecta (longitud incorrecta)")]
        //        [DataRow("5478 9827", -1, DisplayName = "Tarjeta de Credito Incorrecta (longitud incorrecta)")]
        //        [DataRow("AS78 9827 7625 7859", -1, DisplayName = "Tarjeta de Credito Incorrecta (formato incorrecto)")]
        //        [DataRow("6778 9827 7625 7859", -1, DisplayName = "Tarjeta de Credito Incorrecta (no se reconoce ni como VISA ni como MASTERCAD)")]

        //        public void ValidaciónDeUnaTarjetaDeCrédito(string tarjetaCredito, int previsto)
        //        {
        //            if (previsto == 0) Assert.IsTrue(validador.EsTarjetaCredito(tarjetaCredito));
        //            else Assert.IsFalse(validador.EsNIF(tarjetaCredito));
        //        }

        //        /**************************************************************************
        //        * 
        //        * METODO DE PRUEBA PARA EL IBAN ESPAÑOL.
        //        * 
        //        * El IBAN español de ser de la forma [Ee]{1}[Ss]{1}[0-9]{2}[" "]([0-9]{4}[" "]){5}.
        //        * Esto se traduce en: la letra E tanto minuscula o mayuscula 1 vez
        //        * La letra S tanto minuscula o mayuscula 1 vez
        //        * 2 digitos seguidos de 1 espacio
        //        * 4 digitos y 1 espacio 5 veces
        //        * 
        //        **************************************************************************/

        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow("ES66 2100 0418 4012 3456 7891", 0, DisplayName = "IBAN Español correcto")]
        //        [DataRow("ES66 2100 0418 4012 3456", -1, DisplayName = "IBAN incorrecto (longitud incorrecta)")]
        //        [DataRow("ES66 2100 0418 4012 3456 7891 5684", -1, DisplayName = "IBAN incorrecto (longitud incorrecta")]
        //        [DataRow("ET66 2100 0418 4012 3456 7891", -1, DisplayName = "IBAN incorrecto (no es español)")]
        //        [DataRow("3466 2100 0418 4012 3456 7891", -1, DisplayName = "IBAN incorrecto (no se identifica con ningun pais)")]
        //        [DataRow("ES66 2100 0418 AS12 3456 7891", -1, DisplayName = "IBAN incorrecto (formato incorrecto)")]
        //        [DataRow("ES6621000418AS1234567891", -1, DisplayName = "IBAN incorrecto (formato incorrecto)")]
        //        public void ValidaciónDeUnIBANEspañol(string ibanespanol, int previsto)
        //        {
        //            Assert.AreEqual(previsto, validador.EsIBANEspanol(ibanespanol));
        //        }

        //        /**************************************************************************
        //        * 
        //        * METODO DE PRUEBA PARA EL CCC BANCARIO.
        //        * 
        //        * El CCC bancario de ser de la forma ([0-9]{4}[-]{1}){2}[0-9]{2}[-]{1}[0-9]{10}.
        //        * Esto se traduce en: 4 digitos iniciales seguidos de un - 2 veces
        //        * 2 digitos seguidos de - 1 vez
        //        * 10 digitos
        //        * 
        //        **************************************************************************/
        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow("2020-0000-11-22334455", 0, DisplayName = "CCC Español correcto")]
        //        [DataRow("20200000-11-22334455", -1, DisplayName = "CCC incorrecto (formato incorrecto)")]
        //        [DataRow("2020-0000-11-22335", -1, DisplayName = "CCC incorrecto (longitud incorrecta")]
        //        [DataRow("2020-0000-11-22334455345465", -1, DisplayName = "CCC incorrecto (longitud incorrecta)")]
        //        [DataRow("2020-0000-11-qw334455", -1, DisplayName = "CCC incorrecto (formatio incorrecto)")]
        //        public void ValidaciónDeUnCCCBancario(string cccbancario, int previsto)
        //        {
        //            Assert.AreEqual(previsto, validador.EsCCCBancario(cccbancario));
        //        }

        //        /**************************************************************************
        //        * 
        //        * METODOS DE CALCULOS
        //        * 
        //        * El formato introducido debe de ser del tipo ([0-9][,])+.
        //        * Es decir, se introduciran digitos separados por comas 1 o mas veces.
        //        * El formato de los digitos tendra que ser floats
        //        * Este formato se aplicara para todos los metodos de calculos 
        //        * 
        //        **************************************************************************/

        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f }, 3.0, DisplayName = "Media aritmética correcta")]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 4.0f }, 2.8, DisplayName = "Media aritmética correcta")]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, float.NaN }, float.NaN, DisplayName = "Media aritmética correcta")]
        //        public void CalculeLaMediaAritmética(float[] datos, float previsto)
        //        {
        //            Assert.AreEqual(previsto, estadistica.MediaAritmetica(datos));
        //        }

        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f }, 2.6, DisplayName = "Media geométrica correcta")]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 4.0f }, 2.4, DisplayName = "Media geométrica correcta")]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, float.NaN }, float.NaN, DisplayName = "Media geométrica correcta")]
        //        public void CalculeLaMediaGeométrica(float[] datos, float previsto)
        //        {
        //            Assert.AreEqual(previsto, estadistica.MediaGeometrica(datos));
        //        }

        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f }, 2.18, DisplayName = "Media armónica correcta")]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 4.0f }, 2.14, DisplayName = "Media armónica correcta")]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, float.NaN }, float.NaN, DisplayName = "Media armónica correcta")]
        //        public void CalculeLaMediaArmónica(float[] datos, float previsto)
        //        {
        //            Assert.AreEqual(previsto, estadistica.MediaArmonica(datos));
        //        }

        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow(new float[] { 2.0f, 2.0f, 3.0f, 4.0f, 6.0f, 4.0f, 3.0f }, 3.0, DisplayName = "Mediana correcta")]
        //        [DataRow(new float[] { 2.0f, 2.0f, 3.0f, 4.0f, 6.0f, 4.0f }, 3.5, DisplayName = "Mediana correcta")]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, float.NaN }, float.NaN, DisplayName = "Mediana correcta")]
        //        public void CalculeLaMediana(float[] datos, float previsto)
        //        {
        //            Assert.AreEqual(previsto, estadistica.Mediana(datos));
        //        }

        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow(new float[] { 2.0f, 2.0f, 3.0f, 4.0f, 6.0f }, 2.0, DisplayName = "Moda correcta")]
        //        [DataRow(new float[] { 2.0f, 2.0f, 3.0f, 4.0f, 6.0f, 4.0f }, float.NaN, DisplayName = "Moda correcta")]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, float.NaN }, float.NaN, DisplayName = "Moda correcta")]
        //        public void CalculeLaModa(float[] datos, float previsto)
        //        {
        //            Assert.AreEqual(previsto, estadistica.Moda(datos));
        //        }

        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 5.0f, 3.0f, 5.0f, 5.0f, 6.0f, 4.0f, 3.0f, 2.0f, 4.0f, 5.0f, 7.0f, 8.0f, 4.0f, 5.0f, 5.0f, 4.0f, 12.0f, 12.0f, 12.0f, 31.0f, 5.0f, 3.0f, 26.0f, 3.0f, 748.0f, 4.0f, 63.0f, 2.0f, 1.0f, 41.0f, 5.0f, 26.0f, 3.0f }, 39.5, DisplayName = "Desviación Absoluta correcta")]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, float.NaN }, float.NaN, DisplayName = "Desviación Absoluta correcta")]
        //        public void CalculaLaDesviaciónSinSignoOAbsoluta(float[] datos, float previsto)
        //        {
        //            Assert.AreEqual(previsto, estadistica.DesviacionSinSingoOAbsoluta(datos));
        //        }

        //        [TestMethod]
        //        [DataTestMethod]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 5.0f, 3.0f, 5.0f, 5.0f, 6.0f, 4.0f, 3.0f, 2.0f, 4.0f, 5.0f, 7.0f, 8.0f, 4.0f, 5.0f, 5.0f, 4.0f, 12.0f, 12.0f, 12.0f, 31.0f, 5.0f, 3.0f, 26.0f, 3.0f, 748.0f, 4.0f, 63.0f, 2.0f, 1.0f, 41.0f, 5.0f, 26.0f, 3.0f }, 118.9, DisplayName = "Desviacion media con signo correcta")]
        //        [DataRow(new float[] { 1.0f, 2.0f, 3.0f, float.NaN }, float.NaN, DisplayName = "Desviación media con signo correcta")]
        //        public void CalculaLaDesviaciónMediaConSigno(float[] datos, float previsto)
        //        {
        //            Assert.AreEqual(previsto, estadistica.DesviacionMediaConSigno(datos));
        //        }
    }
}