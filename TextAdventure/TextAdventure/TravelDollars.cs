using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace TextAdventure
{
    public class TravelDollars
    {
        public TravelDollars()
        {

        }

        private double allInCost = 0;

        public void TransactionTotal (double totalAfterTaxes)
        {
            allInCost = totalAfterTaxes;
        }

        public double TripTotal ()
        {
            return allInCost;  
        }
    }
}
