class Exercicio4
  {
    public static void main(){
    {
        Console.WriteLine("Informe sua idade completa em anos, meses e dias respectivamente (ex: 3 anos, 2 meses e 15 dias):");
        int anos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("meses:");
        int meses =  Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("dias:");
        int dias =  Convert.ToInt32(Console.ReadLine());

        long diasAnos = anos * 365;
        int diasMeses = meses * 30;

        long resultado = diasAnos + diasMeses + dias;

        Console.WriteLine("Sua idade total em dias é: " + resultado);
    }
  }
  }