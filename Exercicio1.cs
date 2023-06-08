 //1 - João Papo-de-Pescador, homem de bem, comprou um microcomputador para 
 //controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso 
 //de peixes maior que o estabelecido pelo regulamento de pesca do estado de São 
 //Paulo (50 quilos) deve pagar uma multa de R$4,00 por quilo excedente. João precisa 
 //que você faça um programa que leia a variável peso (peso de peixes) e calcule o excesso. 
 //Gravar na variável excesso a quantidade de quilos além do limite e na variável multa o valor 
 //da multa que João deverá pagar. Imprima os dados do programa com as mensagens adequadas
 
 class Exercicio1
  {
    public static void main(){

        Console.WriteLine("Informe o peso de peixes pescados:");
        int kilosPeixes = Convert.ToInt32(Console.ReadLine());

        if(kilosPeixes>50){
            int excesso = kilosPeixes - 50;
            double multa = excesso * 4;
            Console.WriteLine("O execesso de peso é: "  + excesso);
            Console.WriteLine("O valor da multa pelo excesso de peso é R$" + multa);
        } else {
            Console.WriteLine("Não há multa, peso de peixes dentro do permitido.");
        }
    }
  }
  