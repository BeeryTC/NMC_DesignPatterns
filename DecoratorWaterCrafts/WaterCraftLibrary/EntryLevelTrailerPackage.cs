using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterCraftLibrary
{
    class EntryLevelTrailerPackage : TrailerDecorater
    {
        public EntryLevelTrailerPackage(WaterCraft watercraft) : base(watercraft) 
        { 
        }

        public override string Description
        {
            get 
            { 
                return string.Concat(base.WaterCraft.Description, ", Entry Level Trailer Package.");
            }
        }

        public override decimal RetailPrice
        {
            get { return base.WaterCraft.RetailPrice + 4000; }
        }

        public override decimal WholeSalePrice
        {
            get { return base.WaterCraft.WholeSalePrice + 2000; }
        }
    }
}
