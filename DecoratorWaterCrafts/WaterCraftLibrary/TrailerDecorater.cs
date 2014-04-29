using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterCraftLibrary
{
    public class TrailerDecorater : WaterCraft
    {
        private WaterCraft _watercraft;

        public TrailerDecorater(WaterCraft watercraft)
        {
            _watercraft = watercraft;
        }

        public WaterCraft WaterCraft
        {
            get { return _watercraft; }
        }

        public override string Description
        {
            get { return base.Description; }
        }

        public override decimal RetailPrice
        {
            get { return _watercraft.RetailPrice; }
        }
 
        public override decimal WholeSalePrice
        {
            get { return _watercraft.WholeSalePrice; }
        }

        public TrailerDecorater(){}
    }
}
