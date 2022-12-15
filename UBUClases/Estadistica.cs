using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBUClases
{
    public class Estadistica
    {

        public double MediaAritmetica(double[] datos)
        {
            double resultado = 0;
            if (datos != null)
            {
                if (datos.Length > 0)
                {
                    foreach (double elemento in datos)
                    {
                        if (elemento.Equals(double.NaN))
                        {
                            resultado = double.NaN;
                            break;
                        }
                        else
                            resultado += elemento;
                    }
                    resultado /= datos.Length;
                }
            }
            else
                resultado = double.NaN;
            return resultado;
        }

        public double MediaGeometrica(double[] datos)
        {
            double resultado = 0;
            if (datos != null)
            {
                if (datos.Length > 0)
                {
                    resultado = 1;
                    foreach (double elemento in datos)
                    {
                        if (elemento.Equals(double.NaN))
                        {
                            resultado = double.NaN;
                            break;
                        }
                        else
                            resultado *= elemento;
                    }
                    resultado = (double)Math.Pow(resultado, 1.0 / datos.Length);
                }
            }
            else
                resultado = double.NaN;
            return resultado;
        }

        public double MediaArmonica(double[] datos)
        {
            double resultado = 0;
            if (datos != null)
            {
                if (datos.Length > 0)
                {
                    foreach (double elemento in datos)
                    {
                        if (elemento.Equals(double.NaN))
                        {
                            resultado = double.NaN;
                            break;
                        }
                        else
                            resultado += (1 / elemento);
                    }
                    resultado = datos.Length / resultado;
                }
            }
            else
                resultado = double.NaN;
            return resultado;
        }

        public double Mediana(double[] datos)
        {
            double resultado = double.NaN;
            if (datos != null)
            {
                if (datos.Length > 0)
                {
                    bool flag = true;
                    foreach (double elemento in datos)
                    {
                        if (elemento.Equals(double.NaN))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        Array.Sort(datos);
                        int posicion = 0;
                        if (datos.Length % 2 == 1)
                        {
                            posicion = (int)(datos.Length / 2);
                            resultado = datos[posicion];
                        }
                        else
                        {
                            posicion = datos.Length / 2;
                            resultado = (datos[posicion] + datos[posicion - 1]) / 2;
                        }
                    }
                }
            }
            return resultado;
        }


        public double[] Moda(double[] datos)
        {
            Dictionary<double, int> calculos = new Dictionary<double, int>();
            double[] resultado = new double[] { double.NaN };
            List<double> lista = new List<double>();
            bool flag = true;
            if (datos != null)
            {
                if (datos.Length > 0)
                {
                    int cantidad = 0;
                    int cantidad_maxima = 0;
                    foreach (double elemento in datos)
                    {
                        if (elemento.Equals(double.NaN))
                        {
                            flag = false;
                            break;
                        }
                        if (calculos.ContainsKey(elemento))
                        {
                            cantidad = calculos[elemento] + 1;
                            calculos[elemento] = cantidad;
                            if (cantidad == cantidad_maxima)
                            {
                                lista.Add(elemento);
                            }
                            else if (cantidad > cantidad_maxima)
                            {
                                cantidad_maxima = cantidad;
                                lista.Clear();
                                lista.Add(elemento);
                            }
                        }
                        else
                            calculos[elemento] = 1;
                    }
                    if (flag)
                    {
                        resultado = lista.ToArray<double>();
                    }
                }
            }
            return resultado;
        }

        public double[] DesviacionSinSingoOAbsoluta(double[] datos)
        {
            double[] resultado = new double[] { double.NaN };
            List<double> lista = new List<double>();
            double media = MediaAritmetica(datos);
            if (datos != null && !media.Equals(double.NaN))
            {
                if (datos.Length > 0)
                {
                    foreach (double elemento in datos)
                    {
                        lista.Add(Math.Abs(elemento - media));
                    }
                    resultado = lista.ToArray<double>();
                }
            }
            return resultado;
        }

        public double DesviacionMediaConSigno(double[] datos)
        {
            double resultado = 0;
            double media = MediaAritmetica(datos);
            if (datos != null && !media.Equals(double.NaN))
            {
                if (datos.Length > 0)
                {
                    foreach (double elemento in datos)
                    {
                        resultado += Math.Abs(elemento - media);
                    }
                    resultado /= datos.Length;
                }
            }
            else
                resultado = double.NaN;
            return resultado;
        }
    }
}
