using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    //LEER:

    //Esta clase tiene como unica responsabilidad el imprimir la receta
    
    public class PrintRecipe
    {
        public void PrintOnSrean(Recipe rec)
        {
            Console.WriteLine($"Receta de {rec.FinalProduct.Description}:");
            foreach (Step step in rec.getSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}