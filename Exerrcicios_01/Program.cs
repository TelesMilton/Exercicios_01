using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerrcicios_01
{
    class Program
    /* 1)  Valkiria é uma empreendedora que vende produtos naturais, 
*     ela está querendo fazer um mini programa para vender lentilha 
*     Faça um programa que calcule, o valor da lentilha vs o preço do peso.
*     Valor do peso da lentilha: 1,50 o KG
*     No final do programa, mostrar o valor total e quantos KG a pessoa    
*     Detalhe o pedido também pode ser vendido em gramas
*/
    {
        static void Main(string[] args)
        {
            double peso, valorTotal, pesoEmGramas;
            double preco = 1.50;
            

            Console.WriteLine("Digite o peso da lentilha : ");
            peso =  Convert.ToDouble(Console.ReadLine());

            pesoEmGramas = (peso * 1000) % 1000;
            valorTotal = peso * preco;

            Console.WriteLine(" peso do produto :" + (int)peso + "Kg" + " e " + pesoEmGramas + "gramas"
                              + "\n" + "valor a pagar = " + valorTotal);
            Console.ReadKey();
        }
    }
}
