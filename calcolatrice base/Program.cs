using Microsoft.VisualBasic;
using System.Diagnostics;

namespace calcolatrice_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type="";
            int check = 0;
            double risult = 0 ;
            do
            {
                if (check!=0)
                {
                    Console.WriteLine("formato errato, selezionare un formato corretto");
                }
                Console.WriteLine("Che tipo di operazione vuoi effettuare");
                Console.WriteLine("digita + - * / radice potenza");
                        type = Console.ReadLine();
                        type= type.ToLower();
                check = check+1;

            } while (type==""||(type!="+" && type != "-" && type != "*" && type != "/" && type != "potenza" && type != "radice"));

            switch (type)
            {
                case "+":
                    Console.WriteLine("hai selezionato addizione");
                    risult = Somma();
                    break;
                case "-":
                    Console.WriteLine("hai selezionato sottrazione");
                    risult = Differenza();
                    break;
                case "*":
                    Console.WriteLine("hai selezionato moltiplicazione");
                    risult = prodotto();
                    break;
                case "/":
                    Console.WriteLine("hai selezionato divisione");
                    risult = Diviso();
                    break;
                case "radice":
                    Console.WriteLine("hai selezionato radice quadrata");
                    
                    risult = radice();
                    break;
                case "potenza":
                    Console.WriteLine("hai selezionato elevamento a potenza");

                    risult = elevamento();
                    break;
            }
            Console.WriteLine("il risultato è " + risult);
        }
    static double Somma()
        {
            double risult;
            double num1= -500000000000000002.0;
            double num2=0;

            do
            {

                Console.WriteLine("scrivi il primo numero");
                try
                    {
                     num1 = double.Parse(Console.ReadLine());
                    }
                catch (Exception)
                    {
                    Console.WriteLine("c'è stato un errore, riprova");
                
                    }
            } while (num1<(-50000000000000000.0));
            do
            {
                Console.WriteLine("scrivi il secondo numero"); 
                try
                    {
                     num2 = double.Parse(Console.ReadLine());
                    }
                catch (Exception)
                {
                Console.WriteLine("c'è stato un errore, riprova");
                   
            }
            } while (num2 < -50000000000000000);
            risult = num1 + num2;
            Console.WriteLine(num1);
                return risult;

        }

    static double Differenza()
        {
            double risult;
            double num1 = -500000000000000002.0;
            double num2 = 0;

            do
            {

                Console.WriteLine("scrivi il primo numero");
                try
                {
                    num1 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("c'è stato un errore, riprova");

                }
            } while (num1 < (-50000000000000000.0));
            do
            {
                Console.WriteLine("scrivi il secondo numero");
                try
                {
                    num2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("c'è stato un errore, riprova");

                }
            } while (num2 < -50000000000000000);
            risult = num1 - num2;
            Console.WriteLine(num1);
            return risult;

        }

        static double prodotto()
        {
            double risult;
            double num1 = -500000000000000002.0;
            double num2 = 0;

            do
            {

                Console.WriteLine("scrivi il primo numero");
                try
                {
                    num1 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("c'è stato un errore, riprova");

                }
            } while (num1 < (-50000000000000000.0));
            do
            {
                Console.WriteLine("scrivi il secondo numero");
                try
                {
                    num2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("c'è stato un errore, riprova");

                }
            } while (num2 < -50000000000000000);
            risult = num1 * num2;
            Console.WriteLine(num1);
            return risult;

        }

        static double Diviso()
        {
            double risult;
            double num1 = -500000000000000002.0;
            double num2 = 0;

            do
            {

                Console.WriteLine("scrivi il primo numero");
                try
                {
                    num1 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("c'è stato un errore, riprova");

                }
            } while (num1 < (-50000000000000000.0));
            do
            {
                Console.WriteLine("scrivi il secondo numero");
                try
                {
                    num2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("c'è stato un errore, riprova");

                }
            } while (num2 < -50000000000000000);
            risult = num1 / num2;
            Console.WriteLine(num1);
            return risult;

        }

        static double elevamento()
        {
            double risult;
            double num1 = -500000000000000002.0;
            double num2 = 0;

            do
            {

                Console.WriteLine("scrivi il primo numero");
                try
                {
                    num1 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("c'è stato un errore, riprova");

                }
            } while (num1 < (-50000000000000000.0));
            do
            {
                Console.WriteLine("scrivi il secondo numero");
                try
                {
                    num2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("c'è stato un errore, riprova");

                }
            } while (num2 < -50000000000000000);
            risult = Math.Pow(num1, num2);
            Console.WriteLine(num1);
            return risult;

        }

        static double radice()
        {
            double risult;
            double num1 = 0;
            do
            {
                Console.WriteLine("scrivi il primo numero");
                try
                    {
                        num1 = double.Parse(Console.ReadLine());
                    }
                catch (Exception)
                    {
                        Console.WriteLine("c'è stato un errore, riprova");
                    }
            } while (num1 < -50000000000000000);
            risult = Math.Sqrt(num1);
            return risult;
        }
    }
}