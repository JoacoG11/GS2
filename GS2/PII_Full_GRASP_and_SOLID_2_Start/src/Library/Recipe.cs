//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();
  
        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        //LEER:

        // Elimino este metodo (PrintRecipe) de esta clase pues se incumpliria el SRP 
        //(mas de una responsabilidad y razon para cambair):

        /*public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }*/

        //Implemento este metodo que no suma a las responsabilidades de la clase, solo me da acceso al atributo privado
        //steps en otra seccion del programa
         public ArrayList getSteps()
        {
            return this.steps;
        }
    }
}