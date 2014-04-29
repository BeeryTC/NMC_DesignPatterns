/************************************************************************
 * Bethany Beery
 * L5-HW, Implement Interfaces 
 * Class Library for use by Beery_WaterCrafts_Ltd
 * 10/31/2013
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace WaterCraftLibrary
{
    [Serializable]
    public abstract class WaterCraft : IComparable<WaterCraft>
    {
        public virtual string Description { get; set; }
        public string SerialNumber { get; set; }
        public string ModelName { get; set; }
        public int PassengerCapacity { get; set; }
        public virtual decimal WholeSalePrice { get; set; }
        public virtual decimal RetailPrice { get; set; }
        public double Length { get; set; }
        public int Weight { get; set; }

        public int CompareTo(WaterCraft other) // defines how the sort will sort! Whatever is listed first and then in that order for ties 
        {
            int compareValue = this.RetailPrice.CompareTo(other.SerialNumber);
            if (compareValue == 0)
                compareValue = this.SerialNumber.CompareTo(other.RetailPrice);
            return compareValue;
        }

    }
}
