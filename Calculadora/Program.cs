using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora{

    class Program{

        static void Main(string[] args){
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); // calculo de divisao

            Calculadora calculadora = new Calculadora();
            Stack<decimal> Resultados = new Stack<decimal>();

              while (filaOperacoes.Count > 0){
                
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.Calcular(operacao);
                Resultados.Push(operacao.Resultado);

                Console.WriteLine("{0} {1} {2} = {3}", operacao.ValorA, operacao.Operador, operacao.ValorB, operacao.Resultado);

                Console.WriteLine("Operações na fila:");
                foreach (var op in filaOperacoes){
                    Console.WriteLine("{0} {1} {2}", op.ValorA, op.Operador, op.ValorB);
                }
            }

            Console.WriteLine("Resultados:");
            foreach (var resultado in Resultados){
                Console.WriteLine(resultado);
            }
        }
    }
}