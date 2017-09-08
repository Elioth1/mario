using System;
namespace programa
{
    public class Program
    {
        static void Main(string[] args)
        {
       int altura, actual, esp, hash;

       Console.WriteLine("programadores: MENDOZA MERCADO CRISTINA CECILIA Y DELGADO VALENCIA BLANCA GUADALUPE");
       Console.WriteLine("dibujar piramide");
       Console.WriteLine("ingresa la altura de la piramide no mayor de 23 ni numero negativo");
       altura = Convert.ToInt32(Console.ReadLine());
       while( altura > 23 || altura < 1)
       {
           Console.Write("Altura: ");
           int.TryParse(Console.ReadLine(),out altura);
       }
     
   for (esp = 0; esp < altura - actual; esp++)
       {
            for (hash =0; hash < (actual*2)-1; hash++)
           {
           Console.Write(" ");
           }
           for (hash =0; hash < (actual*2)-1; hash++)
           {
               Console.Write("#");
           }
           Console.WriteLine();
       }
  

     Console.ReadKey();
    
     





        }
    }
}
