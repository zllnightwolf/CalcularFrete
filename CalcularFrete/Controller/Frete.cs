using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFrete.Controller
{
    internal class Frete
    {
        private decimal valor;
        private decimal frete;
        private string UF;

        public Frete() { }

        public decimal Calcular(string uf, decimal v)
        {
            this.UF = uf;
            this.valor = v;
            this.frete = 0;

            switch (uf)
            {
                case "SP":
                    this.frete = 0.06m;
                    break;
                case "RJ":
                    this.frete = 0.07m;
                    break;
                case "BA":
                    this.frete = 0.08m;
                    break;
                case "MG":
                    this.frete = 0.06m;
                    break;
                case "PE":
                    this.frete = 0.10m;
                    break;
                case "PA":
                    this.frete = 0.08m;
                    break;
                case "RS":
                    this.frete = 0.09m;
                    break;
               
            }
            valor = frete * valor;
            
            return valor;
        }

        public string LimparTela()
        {
            return "ok";
        }
    }
}
