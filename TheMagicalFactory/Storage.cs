using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicalFactory
{
    public class Storage
    {
        public List<Material> _listOfMaterials = new List<Material>();
        public List<string> _listOfProducts = new List<string>();
        public List<Material> _materialsToFactory = new List<Material>();
        public int[] _materialAmount = new int[6];


        public void ShowStorage()
        {
            for (int i = 0; i < _listOfMaterials.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_listOfMaterials[i]}, {_materialAmount[i]}");
            }

        }

        public Storage()
        {

            _listOfMaterials.Add(Material.Fabric);
            _listOfMaterials.Add(Material.Plastic);
            _listOfMaterials.Add(Material.RedPaint);
            _listOfMaterials.Add(Material.Screws);
            _listOfMaterials.Add(Material.Steel);
            _listOfMaterials.Add(Material.Wood);

            for (int i = 0; i < _materialAmount.Length; i++)
            {
                int randomNumber = new Random().Next(0, 26);
                _materialAmount[i] = randomNumber;
            }

        }

        public void UserPicksMaterial()
        {
            Console.WriteLine($"\nThese are the materials you've picked so far:");
            foreach (var item in _materialsToFactory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nChoose the number for which material you want to send to the factory: ");
            int inputKey = int.Parse((Convert.ToString(Console.ReadKey(true).KeyChar)));
            inputKey--;

            if (_materialAmount[inputKey] > 0)
            {
                _materialAmount[inputKey]--;
                _materialsToFactory.Add((Material)inputKey);
            }
            else
            {
                Console.WriteLine($"{(Material)inputKey} is out of stock. Press enter to continue.");
                Console.ReadKey();
            }

        }


    }
}
