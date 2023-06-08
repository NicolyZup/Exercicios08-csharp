//2 - Crie um algoritmo que receba a altura e peso do usuário, calcule seu IMC e exiba seu valor.
//OBS:  Fórmula: IMC = peso/ (altura x altura)

class Exercicio2
  {
    public static void main(){
    {

        Console.WriteLine("Infome seu peso:");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe sua altura:");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura*altura);

        Console.WriteLine("Seu IMC é: "+imc.ToString("F2"));    
    }
  }
  }