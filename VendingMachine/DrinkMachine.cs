
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VendingMachine;

public interface Ivending
{
    void Purchase(char selection);


    void ShowAll();


    void InsertMoney(int money);

    void EndTransaction();
   
}
<<<<<<< HEAD
public class DrinkMachine : Ivending
{



    public int minCost = 1;
    public int MoneyPool { get; set; }

    public DrinkMachine()
    {
        MoneyPool = 0;
=======
public class DrinkMachine : Ivending {



    const int CostOfDrink = 150;
    public int RunningTotal { get; set; }

    public DrinkMachine()
    {
        RunningTotal = 0;
>>>>>>> 2a6bb1d4433a485ccbc287465eeeda87ce84ee76
    }

    public void InsertMoney(int money)
    {
<<<<<<< HEAD
         
         int[] cash = { 1, 5, 10, 20, 50, 100, 500, 1000 };
       IReadOnlyCollection<int> result = Array.AsReadOnly(cash);
=======

        int[] cash = { 1, 5, 10, 20, 50, 100, 500, 100 };
>>>>>>> 2a6bb1d4433a485ccbc287465eeeda87ce84ee76

        switch (money)
        {
            case (1):
<<<<<<< HEAD
                MoneyPool += cash[0];
                break;
            case (5):
                MoneyPool += cash[1];
                break;
            case (10):
                MoneyPool += cash[2];
                break;
            case (20):
                MoneyPool += cash[3];
                break;
            case (50):
                MoneyPool += cash[4];
                break;
            case (100):
                MoneyPool += cash[5];
                break;
            case (500):
                MoneyPool += cash[6];
                break;
            case (1000):
                MoneyPool += cash[7];
=======
                RunningTotal += cash[0];
                break;
            case (5):
                RunningTotal += cash[1];
                break;
            case (10):
                RunningTotal += cash[2];
                break;
            case (20):
                RunningTotal += cash[3];
                break;
            case (50):
                RunningTotal += cash[4];
                break;
            case (100):
                RunningTotal += cash[5];
                break;
            case (500):
                RunningTotal += cash[6];
                break;
            case (1000):
                RunningTotal += cash[7];
>>>>>>> 2a6bb1d4433a485ccbc287465eeeda87ce84ee76
                break;
            default:
                Console.WriteLine("Invalid Entry.");
                break;
        }
    }

    public bool checkTotal()
    {

<<<<<<< HEAD
        if (MoneyPool >= minCost)
=======
        if (RunningTotal >= CostOfDrink)
>>>>>>> 2a6bb1d4433a485ccbc287465eeeda87ce84ee76
            return true;
        else
            return false;
    }


    Coke c = new Coke();
    Pepsi p = new Pepsi();
    Mars m = new Mars();
<<<<<<< HEAD

    public int cCost = 150;
    public int pCost = 120;
    public int mCost = 100;

    public int currPool;

=======
 
 
  
>>>>>>> 2a6bb1d4433a485ccbc287465eeeda87ce84ee76
    public void ShowAll()
    {
        c.Name = "Coke";
        c.Price = 150;

        p.Name = "Pepsi";
<<<<<<< HEAD
        p.Price = 120;

        m.Name = "Mars";
        m.Price = 100;
=======
        p.Price = 150;

        m.Name = "Mars";
        m.Price = 150;
>>>>>>> 2a6bb1d4433a485ccbc287465eeeda87ce84ee76

        Console.WriteLine("****************");
        Console.WriteLine("* C - Coke     *");
        Console.WriteLine("* P - Pepsi    *");
        Console.WriteLine("* M - Mars     *");
        Console.WriteLine("****************");
        Console.WriteLine();
        Console.WriteLine("Please make your selection");
        Purchase(Convert.ToChar(Console.ReadLine().ToUpper()));
<<<<<<< HEAD

=======
       
>>>>>>> 2a6bb1d4433a485ccbc287465eeeda87ce84ee76
    }

    public void Purchase(char selection)
    {
<<<<<<< HEAD

        Console.WriteLine();

        bool keepRun = true;

        while (keepRun)
        {
            
=======
     
        Console.WriteLine();

        bool KeepRun = true;

        while (KeepRun == true)
        {
>>>>>>> 2a6bb1d4433a485ccbc287465eeeda87ce84ee76
            switch (selection)
            {
                case 'C':

<<<<<<< HEAD
                    if (MoneyPool > cCost)
                    {

                        Console.WriteLine("Thank you for your purchase");
                        c.Examine();
                        c.Use();
                        currPool = MoneyPool - cCost;
                        EndTransaction();
                    } else
                    {
                        Console.WriteLine("Money too low");
                    }

                    keepRun = false;



                    break;

                case 'P':

                    if (MoneyPool > pCost)
                    {
                        Console.WriteLine("Thank you for your purchase");
                    p.Examine();
                    p.Use();
                    currPool = MoneyPool - pCost;
                   EndTransaction();
                    }
                    else
                    {
                        Console.WriteLine("Money too low");
                    }

                    keepRun = false;


                    break;
                case 'M':

                    if (MoneyPool > pCost)
                    {
                        Console.WriteLine("Thank you for your purchase");
                    m.Examine();
                    m.Use();
                    currPool = MoneyPool - mCost;
                    EndTransaction();
            } else
            {
                Console.WriteLine("Money too low");
            }

            keepRun = false;
                


                    break;

                default:


                    Console.WriteLine("Invalid Selection. Please re-enter your selection.");
                    selection = Convert.ToChar(Console.ReadLine().ToUpper());
                    keepRun = false;

                    break;
=======
                    Console.WriteLine("Thank you for your purchase");
                    c.Examine();
                    c.Use();
                    EndTransaction();
                    KeepRun = false;
                    this.ShowAll();
                    break;

                case 'P':
                    Console.WriteLine("Thank you for your purchase");
                    p.Examine();
                    p.Use();
                    EndTransaction();
                    KeepRun = false;
                    this.ShowAll();
                    break;
                case 'M':
                    Console.WriteLine("Thank you for your purchase");
                    m.Examine();
                    m.Use();
                    EndTransaction();
                    KeepRun = false;
                    this.ShowAll();
                    break;

                default:
                  
                  
                    Console.WriteLine("Invalid Selection. Please re-enter your selection.");
                    selection = Convert.ToChar(Console.ReadLine().ToUpper());
                    KeepRun = false;
                    break; 
>>>>>>> 2a6bb1d4433a485ccbc287465eeeda87ce84ee76
            }
        }
    }

    public void EndTransaction()
    {

<<<<<<< HEAD
        Console.WriteLine("\nCurrent credit = " + currPool);

        Console.WriteLine("\nPress E to exit or S to continue shopping");

        char printChange= Convert.ToChar(Console.ReadLine().ToUpper());

        if (printChange == 'E')
        {

            Console.WriteLine("Thank you for shopping. Your change is {0:C}", (currPool));
            
            
        }
        else if (printChange == 'S')
        {
            ShowAll();

            Console.ReadLine();
        }
        {
            Console.Clear();

            Console.WriteLine("Please insert one of the amounts: (1, 5, 10, 20, 50, 100, 500, 1000)");
            InsertMoney(Convert.ToInt32(Console.ReadLine()));

            ShowAll();

            Console.ReadLine();

        }


      



    }

}

=======
        if (RunningTotal > CostOfDrink)
            Console.WriteLine("Your change is {0:C}", (RunningTotal - CostOfDrink));

    
    }
}
>>>>>>> 2a6bb1d4433a485ccbc287465eeeda87ce84ee76
