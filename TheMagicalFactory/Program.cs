using System;
using System.Collections.Generic;

namespace TheMagicalFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] listOfMaterials = new string[2]
            //{
            //    [0]{"hej", "då" },
            //      [1] { "bye", "bye"}
            //};
            Storage myMagicStorage = new Storage();

            myMagicStorage._materialsToFactory.Clear();
            while (true) //Loop while user wants to pick more materials
            {
                
                Console.Title = "The Magic Storage";
                Console.Clear();
                myMagicStorage.ShowStorage();


                myMagicStorage.UserPicksMaterial();

                Console.WriteLine("Send material? y/n");
                char sendMaterial = Char.Parse(Convert.ToString(Console.ReadKey(true).KeyChar));
                if (sendMaterial == 'y')
                {
                    break;
                }

            }

            Factory myMagicFactory = new Factory();
            myMagicFactory.GetMaterials(myMagicStorage._materialsToFactory);
            Console.Clear();
            myMagicFactory.ShowMaterialsInFactory();

            //for (int i = 0; i < hej._materialAmount.Length; i++)
            //{
            //    hej._materialAmount[i] = new Random().Next(0, 26);
            //    Console.WriteLine($"{Convert.ToString(hej._listOfMaterials[i])}, {hej._materialAmount[i]}");
            //}

            //int test = Enum.GetValues(Material();


        }
    
    }
}

