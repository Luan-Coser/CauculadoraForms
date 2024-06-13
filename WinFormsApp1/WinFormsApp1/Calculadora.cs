using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Calculadora
    {
        decimal numero1 { get; set; }
        decimal numero2 { get; set; }
        decimal resultado { get; set; }
        public Calculadora(decimal N1, decimal N2)
        {
            numero1 = N1;
            numero2 = N2;
        }
        public decimal Somar()
        {
        resultado = 0;
        resultado = numero1 + numero2;
        return resultado;
        }
        public decimal Subitrair()
        {
        resultado = 0;
        resultado = numero1 - numero2;
        return resultado;
        }
        public decimal Multiplicar()
        {
        resultado = 0;
        resultado = numero1 * numero2;
        return resultado;
        }
        public decimal Dividir()
        {
        resultado = 0;
        resultado = numero1 / numero2;
        return resultado;
        }
    }
  
}
