/************************************************************************
 * Bethany Beery
 * L5-HW
 * Interface class to be used with MotorYacht and JetSki class
 * 10/31/2013
 * **********************************************************************/
using System;

namespace WaterCraftLibrary
{
    /// <summary>
    /// Interface class to be used with MotorYacht and JetSki class
    /// </summary>
    public interface IPowered
    {
       int MaxSpeed { get; set; }
       int HorsePower { get; set; }
    }
}
