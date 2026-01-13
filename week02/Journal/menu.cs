using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
public class Menu
{

    public void ShowMenu()
    {
        Options _opt = new Options();
        string option;
        do
        {
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Exit");
            Console.WriteLine("=====CHOOSE AN OPTION =====");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    _opt.Write();
                    break;
                case "2":
                    _opt.Display();
                    break;
                case "3":
                    _opt.Load();
                    break;
                case "4":
                    _opt.Save();
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    Console.ReadKey();
                    break;
            }

        } while (option != "5");



    }

}
