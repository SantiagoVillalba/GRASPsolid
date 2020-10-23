//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        /* Expert: la clase Step es experta en conocer el costo unitario de los steps para poder calcular el costo 
        de la produccion de cada step(subtotal).
        */
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public double GetCost()
        {
            double cost=0;
            //Costos de los Insumos
            cost += this.Input.UnitCost * this.Quantity;

            //Costos del Equipamiento
            cost += this.Equipment.HourlyCost * this.Time;
            return cost;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    }
}