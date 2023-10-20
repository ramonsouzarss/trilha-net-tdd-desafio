using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        string data = "19/10/2023";
        public CalculadoraImp(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            listahistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }

        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            listahistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }

        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            listahistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }

        public int Dividir(int num1, int num2)
        {
            int res = num1 / num2;
            listahistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }

        // Histórico das últimas 3 operações
        private List<string> listahistorico;

        public CalculadoraImp()
        {
            listahistorico = new List<string>();
        }
        public List<string> Historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3); 
            return listahistorico;
        }
    }
}
