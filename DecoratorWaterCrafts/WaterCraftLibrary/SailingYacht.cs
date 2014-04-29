/************************************************************************
 * Bethany Beery
 * L5-HW, Implement Interfaces 
 * Inherited child class of Yacht
 * 11/01/2013
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace WaterCraftLibrary
{
    /// <summary>
    /// Sailing Yacht category of water crafts, inherited from Yachtv which inherits from Watercrafts
    /// </summary>
    public class SailingYacht : Yacht
    {
        #region [Default Fields]
        // Fields inherited from WaterCraft Class
        private const string DefaultSN = "SA-1500";                         // Serial number
        private const string DefaultModelName = "Bethany Sun Odyssey 509";  // Represents a top seller
        private const int DefaultPassengers = 25;                           // Holds up to x passengers
        private const decimal DefaultWholeSalePrice = 100000;               // Purchase price from manufacturer
        private const decimal DefaultRetailPrice = 350000;                  // Selling price to retail store
        private const int DefaultLength = 50;                               // In feet
        private const int DefaultWeight = 57;                               // In pounds

        // Fields Inherited from Yacht class
        private const int DefaultFuelCapacity = 63;               // In gallons
        private const int DefaultWaterCapacity = 162;             // In gallons
        private const int DefaultCabins = 5;

        // Fields
        private const SYType DefaultSYType = SYType.Luxury;
        private const SYBrand DefaultSailingYBrand = SYBrand.FerrettiGroup;
        private const int DefaultHullLength = 49;           // In feet
        private const int DefualtHullBeam = 15;             // In feet 
        #endregion

        #region [Public Properties]
        public int HullLength { get; set; }
        public int HullBeam { get; set; }
        public SYType SailingYachtType { get; set; }
        public SYBrand SailingYachtBrand { get; set; }
        #endregion
        
        #region [Sailing Yacht Enums]
        public enum SYType
        {
            Day_Sailing,
            Weekender,
            Cruising,
            Luxury,
            Racing
        }

        public enum SYBrand
        {
            Amel,
            Catalina,
            Farr,
            LaurieDavidson,
            Horizon,
            FerrettiGroup,
            Sydney
        } 
        #endregion

        #region [Public Constructors]
        /// <summary>
        /// Fully qualified SailingYacht constructor
        /// </summary>
        /// <param name="serialNumber">serial number of a sailing yacht</param>
        /// <param name="modelName">model name of a sailing yacht</param>
        /// <param name="capacity">max number of passengers</param>
        /// <param name="wholesalePrice">price we pay manufacturer for a sailing yacht</param>
        /// <param name="retailPrice">price we charge retail stores for a sailing yacht</param>
        /// <param name="length">length of a sailing yacht</param>
        /// <param name="weight">weight of a sailing yacht</param>
        /// <param name="sailingYachtType">types of a sailing yacht</param>
        /// <param name="sailingYachtBrand">brands of a sailing yacht</param>
        public SailingYacht(string serialNumber, string modelName, int capacity, decimal wholesalePrice, decimal retailPrice, int length, int weight, SYType sailingYachtType, SYBrand sailingYachtBrand)
        {
            // WaterCraft
            this.SerialNumber = serialNumber;
            this.ModelName = modelName;
            this.PassengerCapacity = capacity;
            this.WholeSalePrice = wholesalePrice;
            this.RetailPrice = retailPrice;
            this.Length = length;
            this.Weight = weight;

            // Specific to Jet Ski
            this.SailingYachtBrand = sailingYachtBrand;
            this.SailingYachtType = sailingYachtType;
        }

        /// <summary>
        /// Default constructor of a Sailing Yacht
        /// </summary>
        /// <param name="serialNumber">serial number of a sailing yacht</param>
        /// <param name="modelName">model name of a sailing yacht </param>
        /// <param name="capacity">max number of passengers</param>
        /// <param name="wholesalePrice">price we pay manufacturer</param>
        /// <param name="retailPrice">price we charge retail stores for a sailing yacht</param>
        /// <param name="sailingYachtType">type of a sailing yacht</param>
        /// <param name="sailingYachtBrand">brand of a sailing yacht</param>
        public SailingYacht(string serialNumber, string modelName, int capacity, decimal wholesalePrice, decimal retailPrice, SYType sailingYachtType, SYBrand sailingYachtBrand)
        {
            // WaterCraft
            this.SerialNumber = DefaultSN;
            this.ModelName = DefaultModelName;
            this.PassengerCapacity = DefaultPassengers;
            this.WholeSalePrice = DefaultWholeSalePrice;
            this.RetailPrice = DefaultRetailPrice;
            this.Length = DefaultLength;
            this.Weight = DefaultWeight;

            // Specific to Jet Ski
            this.SailingYachtBrand = DefaultSailingYBrand;
            this.SailingYachtType = DefaultSYType;
            this.SailingYachtBrand = DefaultSailingYBrand;
            this.SailingYachtType = DefaultSYType;
        } 

        /// <summary>
        /// 5 parameter constructor of a sailing yacht, matches ToString method
        /// </summary>
        /// <param name="serialNumber">serial number of a sailing yacht</param>
        /// <param name="modelName">model name of a sailing yacht</param>
        /// <param name="sailingYachtBrand">brand of a sailing yacht</param>
        /// <param name="sailingYachtType">type of a sailing yacht</param>
        /// <param name="retailPrice">price we charge retail stores for a sailing yacht</param>
        public SailingYacht(string serialNumber, string modelName,SYBrand sailingYachtBrand, SYType sailingYachtType, decimal retailPrice)
        {
            this.SerialNumber = serialNumber;
            this.ModelName = modelName;
            this.SailingYachtBrand = sailingYachtBrand;
            this.SailingYachtType = sailingYachtType;
            this.RetailPrice = retailPrice;
        }
        #endregion

        #region [Public Methods]
        /// <summary>
        /// ToString method of SailingYacht class
        /// </summary>
        /// <returns>details of a sailing yacht item in inventory</returns>
        public override string ToString()
        {
            return string.Format("+ {0}, Model: {1}, Brand: {2}, {3} Yacht, Wholesale Price: ${4}",
                this.SerialNumber,
                this.ModelName,
                this.SailingYachtBrand,
                this.SailingYachtType,
                this.RetailPrice);
        } 
        #endregion
    }
}
