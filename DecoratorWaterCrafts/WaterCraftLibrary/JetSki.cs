/************************************************************************
 * Bethany Beery
 * L5-HW, Implement Interfaces 
 * Inheritated child class of WaterCraft, implements IPowered interface
 * 10/31/2013
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterCraftLibrary
{
    /// <summary>
    /// Jet Ski class, child of WaterCraft and implements IPowered
    /// </summary>
    public class JetSki : WaterCraft, IPowered
    {
        #region [Default Fields]
        // Default values specific to JetSki, inherited from WaterCraft Class
        private const string DefaultSN = "JS1000";
        private const string DefaultModelName = "800 SX-R";    // Represents a top seller
        private const int DefaultCapacity = 1;          // How many riders
        private const decimal DefaultWholeSalePrice = 2000;    // Purchase price from manufacture
        private const decimal DefaultRetailPrice = 4000;       // Price to retail shops
        private const double DefaultLength = 7.6;       // In feet
        private const int DefaultWeight = 397;          // In pounds


        // Default fields inheritated from IPowered Interface
        private const int DefaultMaxSpeed = 60;         // mph
        private const int DefaultHorsePower = 5;            

        // Default values of JetSki class
        private const JStype DefaultJSType = JStype.SportCraft;
        private const int DefaultThrust = 799;                 // In pounds
        private const JSBrand DefaultJetSkiBrand = JSBrand.Kawasaki; 
        #endregion

        #region [Public Properties]
        public int Thrust { get; set; }
        public JStype JetSkiType { get; set; }
        public JSBrand JetSkiBrand { get; set; }
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
  
        #endregion

        #region [Enums for JetSkis]
        /// <summary>
        /// Types of Jet skis we carry
        /// </summary>
        public enum JStype
        {
            SoloCraft,      // Stand-ups
            SportCraft,     // One rider, sit down, for the athletic
            TwoSeater,      // Sits two
            ThreeSeater,    // Sits three
            FourSeater      // Sits four
        }

        /// <summary>
        /// Brands of Jet skis we carry
        /// </summary>
        public enum JSBrand
        {
            Seadoo,
            Kawasaki,
            Yamaha,
            Honda,
            Polaris
        }
        #endregion

        #region [Public Constructors]
        /// <summary>
        /// Fully qualified JetSki constructor
        /// </summary>
        /// <param name="serialNumber">serial number of a jet ski</param>
        /// <param name="modelName">model name of a jet ski</param>
        /// <param name="capacity">number of passengers jet ski is intended to carry</param>
        /// <param name="wholesalePrice">purchase price we pay manufacturer </param>
        /// <param name="retailPrice">price we charge retail stores to purchase a jet ski</param>
        /// <param name="length">length of jet ski in feet</param>
        /// <param name="weight">weight of jet ski in pounds</param>
        /// <param name="maxSpeed">max speed of jet ski in miles per hour</param>
        /// <param name="horsePower">horse power of jet ski</param>
        /// <param name="jstype">type/use of jet ski</param>
        /// <param name="thrust">thrust power of jet ski</param>
        /// <param name="jsbrand">brand of jet ski</param>
        public JetSki(string serialNumber, string modelName, int capacity, decimal wholesalePrice, decimal retailPrice, int length, int weight, int maxSpeed, int horsePower, JStype jstype, int thrust, JSBrand jsbrand)
        {
            // WaterCraft
            this.SerialNumber = serialNumber;
            this.ModelName = modelName;
            this.PassengerCapacity = capacity;
            this.WholeSalePrice = wholesalePrice;
            this.RetailPrice = retailPrice;
            this.Length = length;
            this.Weight = weight;

            // IPowered
            this.MaxSpeed = maxSpeed;
            this.HorsePower = horsePower;

            // Specific to Jet Ski
            this.JetSkiType = jstype;
            this.JetSkiBrand = jsbrand;
            this.Thrust = thrust;

        }

        /// <summary>
        /// Default jet ski constructor
        /// </summary>
        public JetSki()
        {
            // WaterCraft
            this.SerialNumber = DefaultSN;
            this.ModelName = DefaultModelName;
            this.PassengerCapacity = DefaultCapacity;
            this.WholeSalePrice = DefaultWholeSalePrice;
            this.RetailPrice = DefaultRetailPrice;
            this.Length = DefaultLength;
            this.Weight = DefaultWeight;

            // IPowered
            this.MaxSpeed = DefaultMaxSpeed;
            this.HorsePower = DefaultHorsePower;

            // Specific to Jet Ski
            this.JetSkiType = DefaultJSType;
            this.JetSkiBrand = DefaultJetSkiBrand;
            this.Thrust = DefaultThrust;
        }

        /// <summary>
        /// Jet ski constructor to match toString method
        /// </summary>
        /// <param name="serialNumber">serial number of jet ski</param>
        /// <param name="retailPrice">price we charge retail stores to purchase a jet ski</param>
        /// <param name="modelName">model name of jet ski</param>
        /// <param name="jsbrand">brand of jet ski</param>
        /// <param name="jstype">type/use of a jet ski</param>
        /// <param name="thrust">thrust power of a jet ski</param>
        /// <param name="maxSpeed">max speed in miles per hour</param>
        /// <param name="horsePower">horse power of jet ski</param>
        public JetSki(string serialNumber, decimal retailPrice, string modelName, JSBrand jsbrand, JStype jstype, int thrust, int maxSpeed, int horsePower)
        {
            this.SerialNumber = serialNumber;
            this.RetailPrice = retailPrice;
            this.ModelName = modelName;
            this.JetSkiBrand = jsbrand;
            this.JetSkiType = jstype;
            this.Thrust = thrust;
            this.MaxSpeed = maxSpeed;
            this.HorsePower = horsePower;
        } 
        #endregion

        #region [Public methods]
        /// <summary>
        /// ToString method to display jet ski inventory details in list box
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("+ {0}, Retail Price: ${1}, Model: {2}, Brand: {3}, {4} Jet Ski, Thrust: {5} lb, Max Speed: {6} mph, Horsepower: {7}",
                this.SerialNumber,
                this.RetailPrice,
                this.ModelName,
                this.JetSkiBrand,
                this.JetSkiType,
                this.Thrust,
                this.MaxSpeed,
                this.HorsePower
                );
        } 
        #endregion
    }
}
