using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterCraftLibrary
{
    class MidModelTrailerPackage : TrailerDecorater
    {
        public MidModelTrailerPackage(WaterCraft watercraft) : base(watercraft) 
        { 
        }

        public override string Description
        {
            get 
            { 
                return string.Concat(base.WaterCraft.Description, ", Mid Model Trailer Package.");
            }
        }

        public override decimal RetailPrice
        {
            get { return base.WaterCraft.RetailPrice + 8000; }
        }

        public override decimal WholeSalePrice
        {
            get { return base.WaterCraft.WholeSalePrice + 4000; }
        }
    }
}
