using System.Diagnostics;

namespace calcolatrice_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type;
            double num1;
             double num2;
            double risult ;
            bool othernum = true;
            Console.WriteLine("Che tipo di operazione vuoi effettuare");
            Console.WriteLine("digita + - * / radice potenza");
            type = Console.ReadLine();
            switch (type)
            {
                case "+":
                    Console.WriteLine("hai selezionato addizione");
                    
                    Console.WriteLine("scrivi il primo numero");
                    num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("scrivi il secondo numero");
                    num2 = double.Parse(Console.ReadLine());

                    risult = num1 + num2;
                    Console.WriteLine("il risultato è " + risult); 
                    break;
                case "-":
                    Console.WriteLine("hai selezionato sottrazione");
                    
                    Console.WriteLine("scrivi il primo numero");
                    num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("scrivi il secondo numero");
                    num2 = double.Parse(Console.ReadLine());

                    risult = num1 - num2;
                    Console.WriteLine("il risultato è " + risult); 
                    break;
                case "*":
                    Console.WriteLine("hai selezionato moltiplicazione");
                    
                    Console.WriteLine("scrivi il primo numero");
                    num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("scrivi il secondo numero");
                    num2 = double.Parse(Console.ReadLine());

                    risult = num1 * num2;
                    Console.WriteLine("il risultato è " + risult);
                    break;
                case "/":
                    Console.WriteLine("hai selezionato divisione");
                    
                    Console.WriteLine("scrivi il primo numero");
                    num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("scrivi il secondo numero");
                    num2 = double.Parse(Console.ReadLine());

                    risult = num1 / num2;
                    Console.WriteLine("il risultato è " + risult);
                    break;
                case "radice":
                    Console.WriteLine("hai selezionato radice quadrata");
                    
                    Console.WriteLine("scrivi il primo numero");
                    num1 = double.Parse(Console.ReadLine());

                    risult = Math.Sqrt(num1);
                    Console.WriteLine("il risultato è " + risult);
                    break;
                case "potenza":
                    Console.WriteLine("hai selezionato elevamento a potenza");

                    Console.WriteLine("scrivi il primo numero");
                    num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("scrivi il secondo numero");
                    num2 = double.Parse(Console.ReadLine());

                    risult = Math.Pow(num1, num2);
                    Console.WriteLine("il risultato è " + risult);
                    break;
            }

        }
    }
}