/************************************************************************
 * Bethany Beery
 * L5-HW, Implement Interfaces 
 * Inheritated child class of Yacht, uses IPowered
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
    public class MotorYacht : Yacht, IPowered
    {
        #region [Default private fields]
        // Fields inherited from WaterCraft Class
        private const string DefaultSN = "MOY1000";          // Serial number
        private const string DefaultModelName = "Big and Rich 5000";  // Represents a top seller
        private const int DefaultPassengers = 75;            // Holds up to 2 passengers
        private const decimal DefaultWholeSalePrice = 500000;       // Purchase price from manufacter
        private const decimal DefaultRetailPrice = 900000;          // Selling price to retail store
        private const int DefaultLength = 258;               // In feet
        private const int DefaultWeight = 100;               // In pounds

        // Fields Inherited from Yacht class
        private const int DefaultFuelCapacity = 90;          // In gallons
        private const int DefaultWaterCapacity = 200;        // In gallons
        private const int DefaultCabins = 6;

        // Fields inherited from IPowered
        private const int DefaultMaxSpeed = 60;              // Miles per hour
        private const int DefaultHorsePower = 1;

        // Fields
        private const MYType DefaultMYType = MYType.Luxury;
        private const MYBrand DefaultMYBrand = MYBrand.Royal_Huisman;
        private const int DefaultNumberOfDecks = 3;
        #endregion

        #region [Motor Yachts Enums]
        public enum MYType
        {
            Day_Cruiser,     // No cabin, sparse amenities
            Weekender,      // one or two basic cabins, basic galley appliances and plumbing
            Cruising,       // Sufficient amenities to allow for living abroad for extended periods
            Sport_Fishing,   // Living amenities and sporting fishing equipment
            Luxury          // more luxurious finishings/amenities
        }

        public enum MYBrand
        {
            Lazzarra,
            Royal_Huisman,
            Lurssen,
            Azimut,
            Kintner,
            Ferretti
        } 
        #endregion

        #region [Public Properties]
        public int NumberOfDecks { get; set; } 
        public MYType MotorYachtType { get; set; }
        public MYBrand MotorYachtBrand { get; set; }
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
        #endregion

        #region [Public Constructors]
        public MotorYacht(string serialNumber, string modelName, int capacity, decimal wholesalePrice, decimal retailPrice, int length, int weight, int maxSpeed, int horsePower, MYType motorYachtType, MYBrand motorTypeBrand, int numberOfDecks)
        {
            // WaterCraft
            this.SerialNumber = serialNumber;
            this.ModelName = modelName;
            this.PassengerCapacity = capacity;
            this.WholeSalePrice = wholesalePrice;
            this.RetailPrice = retailPrice;
            this.Length = length;
            this.Weight = weight;

            //  IPowered
            this.MaxSpeed = DefaultMaxSpeed;
            this.HorsePower = DefaultHorsePower;

            // Specific to Motor Yacht
            this.MotorYachtType = DefaultMYType;
            this.MotorYachtBrand = DefaultMYBrand;
            this.NumberOfDecks = DefaultNumberOfDecks;
        }

        public MotorYacht()
        {
            // WaterCraft
            this.SerialNumber = DefaultSN;
            this.ModelName = DefaultModelName;
            this.PassengerCapacity = DefaultPassengers;
            this.WholeSalePrice = DefaultWholeSalePrice;
            this.RetailPrice = DefaultRetailPrice;
            this.Length = DefaultLength;
            this.Weight = DefaultWeight;

            //  IPowered
            this.MaxSpeed = DefaultMaxSpeed;
            this.HorsePower = DefaultHorsePower;

            // Specific to Motor Yacht
            this.MotorYachtType = DefaultMYType;
            this.MotorYachtBrand = DefaultMYBrand;
            this.NumberOfDecks = DefaultNumberOfDecks;
        } 

        public MotorYacht(string serialNumber, decimal retailPrice, string modelName, MYBrand motorTypeBrand, MYType motorYachtType, int cabins, int numberOfDecks)
        {
            this.SerialNumber = serialNumber;
            this.RetailPrice = retailPrice;
            this.ModelName = modelName;
            this.MotorYachtBrand = motorTypeBrand;
            this.MotorYachtType = motorYachtType;
            this.Cabins = cabins;
            this.NumberOfDecks = numberOfDecks;
        }
        #endregion

        #region [Public Methods]
        public override string ToString()
        {
            return string.Format("+ {0}, Retail Price: ${1}, Model: {2}, Brand: {3}, {4} Motor Yacht, Cabins: {5}, Number of decks: {6}",
                this.SerialNumber,
                this.RetailPrice,
                this.ModelName,
                this.MotorYachtBrand,
                this.MotorYachtType,
                this.Cabins,
                this.NumberOfDecks);
        } 
        #endregion
    }
  }

