using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WaterCraftLibrary; 
using System.Windows.Forms;

namespace Beery_WaterCrafts_Ltd
{
    /// <summary>
    /// Form to add a new jet ski item
    /// </summary>
    public partial class Add_SailingYacht : Form
    {
        /// <summary>
        /// jetski field
        /// </summary>
        public JetSki jetski = null;

        /// <summary>
        /// Add_JetSki class
        /// </summary>
        public Add_SailingYacht()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxJS_SN.Clear();
            txtBoxJS_ModelName.Clear();
            txtBoxJS_Thrust.Clear();
            txtBoxJS_RetailPrice.Clear();
            txtBoxJS_WholesalePrice.Clear();
            txtBoxJS_Passengers.Clear();
            txtBoxJS_MaxSpeed.Clear();
            txtBoxJS_HorsePower.Clear();
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    jetski = new JetSki(txtBoxJS_SN.Text, txtBoxJS_ModelName.Text, txtBoxJS_Passengers.Text, txtBoxJS_WholesalePrice, txtBoxJS_RetailPrice, txtBoxJS_Length, txtBoxJS_Weight, txtBoxJS_MaxSpeed, txtBoxJS_HorsePower, coBoxJS_Type.SelectedText, txtBoxJS_Thrust, coBoxJS_Brand.SelectedText);
        //}
    }
}
