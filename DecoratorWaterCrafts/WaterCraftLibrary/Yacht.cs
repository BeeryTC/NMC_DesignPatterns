/************************************************************************
 * Bethany Beery
 * L5-HW, Implement Interfaces 
 * Inheritated child class of WaterCraft 
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
    public abstract class Yacht : WaterCraft
    {
        public int FuelCapacity { get; set; }       // In gallons
        public int Cabins { get; set; }             // Number of cabins
        public int WaterCapacity { get; set; }      // Water storage in gallons 
    }
}
