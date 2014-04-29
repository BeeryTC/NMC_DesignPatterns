using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterCraftLibrary
{
    class DeluxeModelTrailerPackage : TrailerDecorater
    {
        public DeluxeModelTrailerPackage(WaterCraft watercraft) : base(watercraft) 
        { 
        }

        public override string Description
        {
            get 
            { 
                return string.Concat(base.WaterCraft.Description, ", Deluxe Model Trailer Package.");
            }
        }

        public override decimal RetailPrice
        {
            get { return base.WaterCraft.RetailPrice + 16000; }
        }

        public override decimal WholeSalePrice
        {
            get { return base.WaterCraft.WholeSalePrice + 6000; }
        }
    }
}
