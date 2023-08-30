using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_do_sr.joao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            string loop = "S";

            while (loop == "S")
            {


                Console.WriteLine("1- cadastrar novos produtos");
                Console.WriteLine("2- realizar vendas de perodutos");
                Console.WriteLine("3- gerar relatorio produtos");
                menu = int.Parse(Console.ReadLine());

                if (menu == 1)
                {
                    Console.WriteLine("voce escolheu cadastrar um produto");
                }
                else if (menu == 2)
                {
                    Console.WriteLine("voce escolheu vender um produto");
                }
                else if (menu == 3)
                {
                    Console.WriteLine("voce escolheu gerar um relatorio dos produtos");
                }
                else
                {
    
                    Console.WriteLine("informe uma informacao valida");
                    
                }
                Console.Write("deseja continuar no sistema (s/n)");
                loop = Console.ReadLine();

            }

            {
                Console.ReadKey();
            }

         

            
            
            
            
            
           
           
            



        }
    }
}
