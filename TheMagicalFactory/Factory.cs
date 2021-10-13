using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicalFactory
{
    public class Factory
    {
        List<Products> ProductBlueprints = new List<Products>();
        List<Material> MaterialsToUse = new List<Material>();
        public Factory()
        {
            ProductBlueprints.Add(Products.Car);
            ProductBlueprints.Add(Products.Frame);
            ProductBlueprints.Add(Products.Steeringwheel);
            ProductBlueprints.Add(Products.Tiers);

        }

        public void ProductMatch()
        {

        }

        public void CreateProduct()
        {

        }
         
        public void GetMaterials(List<Material> materialsToFactory)
        {
            MaterialsToUse = materialsToFactory;
        }

        public void ShowMaterialsInFactory()
        {
            List<int> amountOfMaterial = new();
            int rightIndex = -1;
            Console.WriteLine("Materials sent to factory: ");
            MaterialsToUse.Sort();
            for (int i = 0; i < MaterialsToUse.Count; i++)
            {
                if (i<0 && MaterialsToUse[i] == MaterialsToUse[i-1])
                {
                    amountOfMaterial[rightIndex]++;
                    Console.WriteLine($"{amountOfMaterial[rightIndex]} {MaterialsToUse[i]}");
                }
                else
                {
                    rightIndex++;
                    amountOfMaterial.Add(1);
                    Console.WriteLine($"{amountOfMaterial[rightIndex]} {MaterialsToUse[i]}");
                }
            }
        }
    }
}
