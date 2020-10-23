using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class CalculateCost : ICost
    {
        private List<Step> steps;
        public CalculateCost(List<Step> steps)
        {
            this.steps=steps;
        }
        public double GetProductionCost()
        {
            double cost = 0;   
            foreach(Step step in steps)
            {
                //Costos de los Insumos
                cost += step.Input.UnitCost * step.Quantity;

                //Costos del Equipamiento
                cost += step.Equipment.HourlyCost * step.Time;
            }
            
            return cost;
        }
    }
}