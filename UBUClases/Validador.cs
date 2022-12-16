using System.Text.RegularExpressions;

namespace UBUClases
{
    public class Validador
    {
        public int EsCodigoPostal(string codigo_postal)
        {
            int resultado = -1;
            if (codigo_postal != null)
            {
                string patron = "^[0-9]{5}$";
                if (Regex.IsMatch(codigo_postal, patron))
                {
                    string path_archivo = "..\\..\\..\\..\\UBUClases\\codigos_postales.csv";
                    System.IO.StreamReader archivo = new System.IO.StreamReader(path_archivo);
                    string separador = ",";
                    string linea;
                    string[] fila;
                    List<string> codigos_postales_validos = new List<string>();
                    archivo.ReadLine();
                    while ((linea = archivo.ReadLine()) != null)
                    {
                        fila = linea.Split(separador);
                        codigos_postales_validos.Add(fila[0]);
                    }
                    if (codigos_postales_validos.Contains(codigo_postal))
                        resultado = 0;
                }
            }
            return resultado;
        }

        public int EsEmailValido(string eMail)
        {
            int resultado = -1;
            if (eMail != null)
            {
                string usuario = "^" + "([a-zA-Z0-9]|-|_)+";
                string host = "[@]" + "([a-zA-Z0-9]|-|_)+";
                string dominio = "[.]" + "([a-zA-Z0-9]|-|_|.)+" + "$";
                string patron = usuario + host + dominio;
                if (Regex.IsMatch(eMail, patron))
                {
                    string path_archivo = "..\\..\\..\\..\\UBUClases\\dominios_internet.csv";
                    System.IO.StreamReader archivo = new System.IO.StreamReader(path_archivo);
                    string separador = ",";
                    string linea;
                    List<string> dominios_validos = new List<string>();
                    archivo.ReadLine();
                    while ((linea = archivo.ReadLine()) != null)
                    {
                        dominios_validos.Add(linea.Split(separador)[0]);
                    }
                    string[] partes_dominio_email = eMail.Split(".");
                    string dominio_email = "";
                    for (int i = 1; i < partes_dominio_email.Length; i++)
                    {
                        dominio_email = dominio_email + "." + partes_dominio_email[i];
                    }
                    if (dominios_validos.Contains(dominio_email))
                        resultado = 0;
                }
            }
            return resultado;
        }

        public int EsNIF(string nif)
        {
            int resultado = -1;
            if (nif != null)
            {
                string NIF = nif.ToUpper();
                string inicio = "^" + "[0-9KLMXYZ]";
                string numero = "[0-9]{7}";
                string control = "[TRWAGMYFPDXBNJZSQVHLCKE]" + "$";
                string patron = inicio + numero + control;
                string[] letras_de_control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                if (Regex.IsMatch(NIF, patron))
                {
                    string ini = NIF.Substring(0, 1);
                    string num = NIF.Substring(1, 7);
                    string ctr = NIF.Substring(8, 1);
                    int numero_nif = int.Parse(num);
                    int ini_nif = 0;
                    switch (ini)
                    {
                        case "K":
                            resultado = 1;
                            ini_nif = 0;
                            break;
                        case "L":
                            resultado = 2;
                            ini_nif = 0;
                            break;
                        case "M":
                            resultado = 3;
                            ini_nif = 0;
                            break;
                        case "X":
                            resultado = 4;
                            ini_nif = 0;
                            break;
                        case "Y":
                            resultado = 5;
                            ini_nif = 1;
                            break;
                        case "Z":
                            resultado = 6;
                            ini_nif = 2;
                            break;
                        default:
                            resultado = 0;
                            ini_nif = int.Parse(ini);
                            break;
                    }
                    numero_nif += (ini_nif * 10000000);
                    if (!ctr.Equals(letras_de_control[numero_nif % 23]))
                        resultado = -1;
                }
            }
            return resultado;
        }

        public int EsTarjetaCredito(string tarjeta_credito)
        {
            int resultado = -1;
            if (tarjeta_credito != null)
            {
                string patron_tarjeta = "^" + "[0-9]{4}[- ]?[0-9]{4}[- ]?[0-9]{4}[- ]?[0-9]{1,4}" + "$";
                if (Regex.IsMatch(tarjeta_credito, patron_tarjeta))
                {
                    string tarjeta = tarjeta_credito.Replace(" ", "");
                    tarjeta = tarjeta.Replace("-", "");
                    string visa = "^" + "4[0-9]{12,15}" + "$";
                    string mastercard = "^" + "(5[1-5][0-9]{14})" + "$";
                    string mastercard_nueva = "^" + "(2[0-9]{15})" + "$";
                    bool flag_mastercard_nueva = false;
                    if (Regex.IsMatch(tarjeta, mastercard_nueva))
                    {
                        int IIN = int.Parse(tarjeta.Substring(0, 6));
                        if (222100 <= IIN || IIN <= 272099)
                            flag_mastercard_nueva = true;
                    }
                    if (flag_mastercard_nueva || Regex.IsMatch(tarjeta, mastercard) || Regex.IsMatch(tarjeta, visa))
                    {
                        int calculo = 0;
                        string cuenta = tarjeta.Substring(0);
                        for (int i = cuenta.Length - 2; i >= 0; i--)
                        {
                            int digito = int.Parse(cuenta.Substring(i, 1));
                            if (i % 2 == 0)
                                digito *= 2;
                            if (digito > 9)
                                digito = digito - 10 + 1;
                            calculo += digito;
                        }
                        calculo *= 9;
                        int digito_control = int.Parse(cuenta.Substring(cuenta.Length - 1, 1));
                        if (calculo % 10 == digito_control)
                            resultado = 0;
                    }
                }
            }
            return resultado;
        }

        public int EsCCCBancario(string CCC)
        {
            int resultado = -1;
            if (CCC != null)
            {
                string patron_CCC = "^" + "[0-9]{4}[- ]?[0-9]{4}[- ]?[0-9]{2}[- ]?[0-9]{10}" + "$";
                if (Regex.IsMatch(CCC, patron_CCC))
                {
                    string ccc = CCC.Replace(" ", "");
                    ccc = ccc.Replace("-", "");
                    String digitos1 = "00" + ccc.Substring(0, 8);
                    string digitos2 = ccc.Substring(10, 10);
                    int control1 = int.Parse(ccc.Substring(8, 1));
                    int control2 = int.Parse(ccc.Substring(9, 1));
                    if (CalcControlCCC(digitos1) == control1 && CalcControlCCC(digitos2) == control2)
                        resultado = 0;
                }
            }
            return resultado;
        }

        private int CalcControlCCC(string cadena)
        {
            int[] factores = { 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int calculo = 0;
            for (int i = 0; i < 10; i++)
            {
                calculo += (int.Parse(cadena.Substring(i, 1))* factores[i]);
            }
            calculo = calculo % 11;
            calculo = 11 - calculo;
            if (calculo == 10)
                calculo = 1;
            else if (calculo == 11)
                calculo = 0;
            return calculo;
        }

        public int EsIBANEspanol(string IVAN)
        {
            int resultado = -1;
            if (IVAN != null)
            {
                string patron_IVAN = "^" + "ES[0-9]{2}[- ]?[0-9]{4}[- ]?[0-9]{4}[- ]?[0-9]{2}[- ]?[0-9]{10}" + "$";
                if (Regex.IsMatch(IVAN, patron_IVAN))
                {
                    string ivan = IVAN.Replace(" ", "");
                    ivan = ivan.Replace("-", "");
                    string ccc = ivan.Substring(4);
                    resultado = EsCCCBancario(ccc);
                }
            }
            return resultado;
        }
    }
}