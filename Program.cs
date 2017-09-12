using System;

namespace mario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la altura de la piramide no mayor de 23 ni un numero que sea negativo");
            Console.Write("Altura de la piramide: ");
            int niveles;
            /// Tryparse convierte la representación de una cadena (string) a su equivalente entero (int). Un valor devuelto indica si la conversión tuvo éxito.
            //  devuelve 0 si no se pudo convertir
            int.TryParse( Console.ReadLine(), out niveles);

             dibujarPiramide(niveles);

        }
        //Todo el código va aquí
        static void dibujarPiramide(int niveles)
        {
            
        
       

       
      
       
      
       while( niveles > 23 || niveles < 1)
       {
           Console.Write("Altura no compatible con el límite, ingrese de nuevo: ");
           int.TryParse(Console.ReadLine(),out niveles);
       }
       for (int i = 1; i <= niveles; i++)  //Aquí me ayudó usted xD
       {                                   //No sé si jala porque me aparece System.FormatException sabe que y no sé moverle :b
           var esc = new String('#',i);
           System.Console.Write(esc.PadLeft(niveles));
           System.Console.Write(" ");
           System.Console.WriteLine(esc);
       }    

     
   
  
     Console.WriteLine("Lizette Alejandra Gómez Tamayo y Eioth Marrujo de la Vega");
     Console.ReadKey();
    
     





            
            
            
        }
    }
}
