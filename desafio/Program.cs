using System;
using System.Globalization;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {

         

            Console.Write("\t\tInforme o valor do Salário Mínimo: ");
            double salario_minimo = Double.Parse(Console.ReadLine());
            Console.WriteLine();    // Adiciona uma linha em branco

            // Solicita e lê o número de dependentes do Contribuinte
            Console.Write("\t\tInforme a Quantidade de Dependentes: ");
            int ndep = Int32.Parse(Console.ReadLine());
            Console.WriteLine();    // Adiciona uma linha em branco
            Console.Write("\t\tInforme o valor da Renda Mensal do Contribuinte: ");

            double renda_mensal = Double.Parse(Console.ReadLine());

            Console.WriteLine();    // Adiciona uma linha em branco​​

            // Efetua o cálculo do Desconto do Salário Mínimo por Dependente​

            // O desconto por dependente será de 5% do salário mínimo​

            double desconto = (ndep * 0.05 * salario_minimo);

            Console.WriteLine("\t\tDesconto igual a: {0}", desconto);

            Console.WriteLine();    // Adiciona uma linha em branco​
            double renda_liquida = (renda_mensal - desconto);

            Console.WriteLine("\t\tRenda líquida igual a: {0}", renda_liquida);

            Console.WriteLine();    // Adiciona uma linha em branco​​

            /* AlíquotasAlíquota​

 * Até 2 salários mínimos isento​

 * 2 a 3 salários mínimos5%​

 * 3 a 5 salários mínimos10%​

 * 5 a 7 salários mínimos15%​

 * acima de 7 salários mínimos20%​
 */

            if ((renda_liquida) <= (salario_minimo * 2))    // Utilize chaves para mais de uma instrução (blocos de instruções)​

            {
                  
                double imposto_renda = 0;

                Console.WriteLine("\t\tO valor do imposto de renda do contribuinte é: {0}", imposto_renda);

                Console.WriteLine();    // Adiciona uma linha em branco​
            }

            else

            {

                if ((renda_liquida) <= (salario_minimo * 3))

                {

                    double imposto_renda = (renda_liquida * 0.05);

                    Console.WriteLine("\t\tO valor do imposto de renda do contribuinte é: {0}", imposto_renda);

                    Console.WriteLine();    // Adiciona uma linha em branco​

                }
                


               else

                {

                    if ((renda_liquida) <= (salario_minimo * 5))

                    {

                       double imposto_renda = (renda_liquida * 0.10);

                        Console.WriteLine("\t\tO valor do imposto de renda do contribuinte é: {0}", imposto_renda);

                        Console.WriteLine();    // Adiciona uma linha em branco​

                    }

                    else

                    {

                        if ((renda_liquida) <= (salario_minimo * 7))

                        {

                            double imposto_renda = (renda_liquida * 0.15);

                            Console.WriteLine("\t\tO valor do imposto de renda do contribuinte é: {0}", imposto_renda);

                            Console.WriteLine();    // Adiciona uma linha em branco​

                        }
                    

                        else

                        {

                            double imposto_renda = (renda_liquida * 0.20);

                            Console.WriteLine("\t\tO valor do imposto de renda do contribuinte é: {0}", imposto_renda);

                            Console.WriteLine();    // Adiciona uma linha em branco​

                        }

                    }

                }

            }

        }
        }
    }
        
    
