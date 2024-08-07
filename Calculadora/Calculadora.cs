namespace Calculadora{
    public class Calculadora{
        public Operacoes Calcular(Operacoes operacao){
            switch (operacao.Operador){
                case '+': operacao.Resultado = Soma(operacao); break;
                case '-': operacao.Resultado = Subtracao(operacao); break;
                case '*': operacao.Resultado = Multiplicacao(operacao); break;
                case '/': operacao.Resultado = Divisao(operacao); break;
                default: operacao.Resultado = 0; break;
            }
            return operacao;
        }

        public int Soma(Operacoes operacao){
            return operacao.ValorA + operacao.ValorB;
        }

        public int Subtracao(Operacoes operacao){
            return operacao.ValorA - operacao.ValorB;
        }

        public int Multiplicacao(Operacoes operacao){
            return operacao.ValorA * operacao.ValorB;
        }

        public int Divisao(Operacoes operacao){
            return operacao.ValorA / operacao.ValorB;
        }
    }
}
