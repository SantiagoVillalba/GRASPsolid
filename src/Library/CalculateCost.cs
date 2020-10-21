namespace Full_GRASP_And_SOLID.Library
{
    public class CalculateCost : ICost
    {
        private Step step;
        public CalculateCost(Step step)
        {
            this.step=step;
        }
        public double GetProductionCost()
        {
            double cost = 0;   

            //Costos de los Insumos
            cost += step.Input.UnitCost * step.Quantity;

            //Costos del Equipamiento
            cost += step.Equipment.HourlyCost * step.Time;
            
            return cost;
        }
    }
}