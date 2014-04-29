/************************************************************************
 * Bethany Beery
 * L5-HW
 * Inheritated child class of WaterCraft 
 * 10/31/2013
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterCraftLibrary
{
    /// <summary>
    /// Canoe class, child of WaterCraft
    /// </summary>
    public class Canoe : WaterCraft
    {
        #region [Private Default Fields]
        // Default values specific to Canoe, inherited from WaterCraft Class
        private const string DefaultSN = "CA1000";                 // Serial number
        private const string DefaultModelName = "Odyssey 15 R84";  // Represents a top seller
        private const int DefaultPassengers = 2;                   // Holds up to 2 passengers
        private const decimal DefaultWholeSalePrice = 200;         // Purchase price from manufacter
        private const decimal DefaultRetailPrice = 800;            // Selling price to retail store
        private const int DefaultLength = 15;                      // In feet
        private const int DefaultWeight = 57;                      // In pounds

        // Default values specific to Canoe class
        private const CType DefaultCanoeType = CType.Classic_Wood;
        private const PType DefaultPaddleType = PType.Recreational;
        private const CBrand DefaultCanoeBrand = CBrand.Mohawk_Canoe; 
        #endregion

        #region [Enums]
        /// <summary>
        /// Canoe types
        /// </summary>
        public enum CType
        {
            Recreation,        // suitable for a wide variety of on-water activites
            Sporting,         // versatile for paddling, rowing, or even motoring
            Expendtion,      // designed with higher volume capacity and can handle abuse of whitewater adventures
            Classic_Wood       // not so much a specific use or activity but a feeling :)
        }

        /// <summary>
        /// Different paddle types for different uses
        /// </summary>
        public enum PType
        {
            Recreational,    // for general purpose day trip paddles
            Lakewater,       // for lakewater travel requiring thousands of repetitious strokes
            Whitewater       // for whitewater rafting
        }

        /// <summary>
        /// Brands of Canoes we carry
        /// </summary>
        public enum CBrand
        {
            Mohawk_Canoe,
            Blue_Water_Canoe,
            Clipper_Canoe,
            Mad_River_Canoe,
            Old_Town_Canoe
        }
        #endregion

        #region [Public Property]
        public override string Description {get {return "Canoe";}}
        /// <summary>
        /// Types of canoes
        /// </summary>
        public CType CanoeType { get; set; }
        /// <summary>
        /// Types of paddles
        /// </summary>
        public PType PaddleType { get; set; }
        /// <summary>
        /// Canoes brands
        /// </summary>
        public CBrand CanoeBrand { get; set; }
        #endregion

        #region [Public Constructors]

        /// <summary>
        /// Fully qualified constructor of Canoe
        /// </summary>
        /// <param name="serialNumber">serial number of a canoe</param>
        /// <param name="modelName">model name of a canoe</param>
        /// <param name="capacity">max passengers that can fit in a canoe</param>
        /// <param name="wholesalePrice">price we pay manufacturer for a canoe</param>
        /// <param name="retailPrice">price we charge retail stores for a canoe</param>
        /// <param name="length">length of a canoe</param>
        /// <param name="weight">weight of a canoe</param>
        /// <param name="canoebrand">brand of canoe</param>
        /// <param name="canoetype">type of a canoe</param>
        public Canoe(string serialNumber, string modelName, int capacity, decimal wholesalePrice, decimal retailPrice, int length, int weight, CBrand canoebrand, CType canoetype)
        {
            // WaterCraft
            this.SerialNumber = serialNumber;
            this.ModelName = modelName;
            this.PassengerCapacity = capacity;
            this.WholeSalePrice = wholesalePrice;
            this.RetailPrice = retailPrice;
            this.Length = length;
            this.Weight = weight;

            // Specific to Canoe
            this.CanoeBrand = canoebrand;
            this.CanoeType = canoetype;
        }

        /// <summary>
        /// Default constructor of a canoe
        /// </summary>
        /// <param name="serialNumber">serial number of a canoe</param>
        /// <param name="modelName">model name of a canoe</param>
        /// <param name="capacity">max passengers that can fit in a canoe</param>
        /// <param name="wholesalePrice">price we pay manufacturer for a canoe</param>
        /// <param name="retailPrice">price we charge retail stores for a canoe</param>
        /// <param name="length">length of a canoe</param>
        /// <param name="weight">weight of a canoe</param>
        /// <param name="canoebrand">brand of canoe</param>
        /// <param name="canoetype">type of a canoe</param>
        /// <param name="paddleType">paddle type need for canoe</param>
        public Canoe(string serialNumber, string modelName, int capacity, decimal wholesalePrice, decimal retailPrice, int length, int weight, CBrand canoebrand, CType canoetype, PType paddleType)
        {
            // WaterCraft
            this.SerialNumber = DefaultSN;
            this.ModelName = DefaultModelName;
            this.PassengerCapacity = DefaultPassengers;
            this.WholeSalePrice = DefaultWholeSalePrice;
            this.RetailPrice = DefaultRetailPrice;
            this.Length = DefaultLength;
            this.Weight = DefaultWeight;

            // Specific to Canoe
            this.CanoeBrand = DefaultCanoeBrand;
            this.CanoeType = DefaultCanoeType;
            this.PaddleType = DefaultPaddleType;
        }

        /// <summary>
        /// 6 parameter constructor of a canoe, matches ToString Method
        /// </summary>
        /// <param name="serialNumber">serial number of a canoe</param>
        /// <param name="retailPrice">price we charge retail stores for a canoe</param>
        /// <param name="modelName">model name of a canoe</param>
        /// <param name="canoebrand">brand of a canoe</param>
        /// <param name="canoetype">type of a canoe</param>
        /// <param name="paddleType">paddle type needed with canoe</param>
        public Canoe(string serialNumber, decimal retailPrice, string modelName, CBrand canoebrand, CType canoetype, PType paddleType)
        {
            this.SerialNumber = serialNumber;
            this.RetailPrice = retailPrice;
            this.ModelName = modelName;
            this.CanoeBrand = canoebrand;
            this.CanoeType = canoetype;
            this.PaddleType = paddleType;
        }

        /// <summary>
        /// 2 parameter Constructor for a canoe
        /// </summary>
        /// <param name="serialNumber">serial number of a canoe</param>
        /// <param name="retailPrice">price we charge retail stores for a canoe</param>
        public Canoe(string serialNumber, decimal retailPrice)
        {
            this.SerialNumber = serialNumber;
            this.RetailPrice = retailPrice;
        }
        #endregion

        #region [Public Methods]
        /// <summary>
        /// ToString method of a Canoe
        /// </summary>
        /// <returns>returns details of a canoe item in inventory</returns>
        public override string ToString()
        {
            return string.Format("+ {0}, Retail Price: ${1}, Model: {2}, Brand: {3}, {4} Canoe, Paddle Type: {5}",
                this.SerialNumber,
                this.RetailPrice,
                this.ModelName,
                this.CanoeBrand,
                this.CanoeType,
                this.PaddleType);
        } 
        #endregion
    }
}
