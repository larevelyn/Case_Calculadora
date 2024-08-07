using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program{
        static void Main(string[] args) {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { ValorA = 2, ValorB = 3, Operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 14, ValorB = 8, Operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 5, ValorB = 6, Operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 2147483647, ValorB = 2, Operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 18, ValorB = 3, Operador = '/' }); // calculo de divisao

            Calculadora calculadora = new Calculadora();
            Stack<decimal> Resultados = new Stack<decimal>();

            while (filaOperacoes.Count > 0){
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.Calcular(operacao);
                Resultados.Push(operacao.Resultado);

                Console.WriteLine("{0} {1} {2} = {3}", operacao.ValorA, operacao.Operador, operacao.ValorB, operacao.Resultado);

                Console.WriteLine("Operações na fila:");
                foreach (var op in filaOperacoes) {
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
