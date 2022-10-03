using System;
using System.Collections.Generic;
using System.Text;

namespace desafio
{
    class Rendas
    {
        public double Salario_minimo { get; private set; } // Salário Mínimo do Contribuinte​
          public double Renda_mensa { get; private set; }   // Renda Mensal do Contribuinte​
        public double Desconto { get; private set; }      // Desconto a ser efetuado do Imposto para cada dependente do Contribuinte​
        public double Renda_liquida { get; private set; }  // É a Renda Mensal menos o Desconto​
        public double Imposto_renda { get; private set; } // Imposto de Renda do Contribuinte​
        public int Ndep { get; private set; }


        public Rendas(double renda_mensa, double desconto, double renda_liquida)
        {
      
            Renda_mensa = renda_mensa;
            Desconto = desconto;
            Renda_liquida = renda_liquida;
   

        }

        public Rendas(int ndep, double salario_minimo)
        {
            Ndep = ndep;
            Salario_minimo = salario_minimo;
            Imposto_renda = 0;
        }

        public double CalcDesconto()
        {
            return Ndep * 0.05 * Salario_minimo;
        }

        public double RendaLiq()
        {
            return Renda_mensa - Desconto;
        }

            



    }
}
