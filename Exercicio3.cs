class Exercicio3
  {
    public static void main(){
    {

       Console.WriteLine("Informe seu salário:");
        double salario = Convert.ToDouble(Console.ReadLine());

        double salarioMinimo = salario/1212;

        Console.WriteLine("Você recebe equivalente a " + salarioMinimo.ToString("F1")+" salario(s) mínimo." );
    }
  }
  }