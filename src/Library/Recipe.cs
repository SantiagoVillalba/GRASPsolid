//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    /* Expert: la clase Recipe es experta en conocer los objetos Steps para poder calcular el costo total de la produccion total.
       SRP: se aplica ya que la clase Recipe tiene una unica razon de cambio es imprimir la receta. 
     */
    public class Recipe
    {
        private List<Step> steps = new List<Step>();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        public double GetProductionCost()
        {
            double cost = 0;   
            foreach(Step step in steps)
            {
                //Costos del step
                cost += step.GetCost();
            }
            
            return cost;
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"Costo total de la receta: ${this.GetProductionCost()}");
        }
    }
}