/************************************************************************
 * Bethany Beery
 * L5-HW, Implement Interfaces and Dictionary collection
 * 10/31/2013
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using WaterCraftLibrary;   // Added to access attached library
using System.Windows.Forms;

namespace Beery_WaterCrafts_Ltd
{
    /// <summary>
    /// Form1 class
    /// </summary>
    public partial class Form1 : Form
    {
        Dictionary<string, List<WaterCraft>> Inventory = new Dictionary<string, List<WaterCraft>>();

        /// <summary>
        /// Form1 class
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            WaterCraft jetski = new JetSki();
            jetski = new TrailerDecorater(jetski);

            Console.WriteLine(jetski.Description);
            Console.WriteLine("Price: {0}", jetski.RetailPrice);

            #region [Panels]
            PHome.Visible = true;
            PanelInvent.Visible = false;
            PanelViewInventory.Visible = false;
            #endregion

            #region [Populate list box with inventory]
            Inventory.Add("Canoes", new List<WaterCraft>());
            Inventory["Canoes"].Add(new Canoe("C-5001", 9000, "Adventure 16", Canoe.CBrand.Blue_Water_Canoe, Canoe.CType.Classic_Wood, Canoe.PType.Lakewater));
            Inventory["Canoes"].Add(new Canoe("C-5001", 7000, "Winter Odyssey", Canoe.CBrand.Mad_River_Canoe, Canoe.CType.Expendtion, Canoe.PType.Recreational));
            Inventory["Canoes"].Add(new Canoe("CA-1000", 8500, "Trek - 14", Canoe.CBrand.Mohawk_Canoe, Canoe.CType.Recreation, Canoe.PType.Recreational));
            Inventory["Canoes"].Add(new Canoe("CZ- 01", 9500, "T90 Z", Canoe.CBrand.Clipper_Canoe, Canoe.CType.Sporting, Canoe.PType.Whitewater));
            
            Inventory.Add("Sailing Yachts", new List<WaterCraft>());
            Inventory["Sailing Yachts"].Add(new SailingYacht("SY-550", "Testing Sailing Yachts 1", 25, 10000, 15000, SailingYacht.SYType.Cruising, SailingYacht.SYBrand.Catalina));
            Inventory["Sailing Yachts"].Add(new SailingYacht("SY-800", "Beery Racing", SailingYacht.SYBrand.LaurieDavidson, SailingYacht.SYType.Racing, 50000));
            Inventory["Sailing Yachts"].Add(new SailingYacht("SY-990", "Bling Bling", SailingYacht.SYBrand.Sydney, SailingYacht.SYType.Luxury, 100000));
            Inventory["Sailing Yachts"].Add(new SailingYacht("SA-000", "Wind Chaser SZ", SailingYacht.SYBrand.Farr, SailingYacht.SYType.Weekender, 30000));

            Inventory.Add("Motor Yachts", new List<WaterCraft>());
            Inventory["Motor Yachts"].Add(new MotorYacht("MY-3000", 30000, "YST MAX", MotorYacht.MYBrand.Lazzarra, MotorYacht.MYType.Sport_Fishing, 5, 10));
            Inventory["Motor Yachts"].Add(new MotorYacht("MY-5000", 500000, "World Lux -30W", MotorYacht.MYBrand.Royal_Huisman, MotorYacht.MYType.Luxury, 10, 25));
            Inventory["Motor Yachts"].Add(new MotorYacht("MZ-2000", 40999, "A-9000", MotorYacht.MYBrand.Azimut, MotorYacht.MYType.Sport_Fishing, 2, 3));

            Inventory.Add("Jet Skis", new List<WaterCraft>());
            Inventory["Jet Skis"].Add(new JetSki("JS-550", 5000, "Ultra 310R", JetSki.JSBrand.Yamaha, JetSki.JStype.ThreeSeater, 925, 40, 5));
            Inventory["Jet Skis"].Add(new JetSki("JS-900", 8000, "Sun LX", JetSki.JSBrand.Honda, JetSki.JStype.FourSeater, 800, 55, 5));
            Inventory["Jet Skis"].Add(new JetSki("JS-900", 10000, "STX - 15F", JetSki.JSBrand.Kawasaki, JetSki.JStype.SportCraft, 957, 60, 5));
            Inventory["Jet Skis"].Add(new JetSki("JA-94A", 2000, "JS Bling", JetSki.JSBrand.Polaris, JetSki.JStype.SoloCraft, 875, 45, 10));
            #endregion

            #region [Total retail price and water crafts in inventory labels]
            decimal totalPrice = 0m;
            int totalCount = 0;
            foreach (KeyValuePair<string, List<WaterCraft>> kvp in Inventory)
            {
                foreach (WaterCraft w in kvp.Value)
                {
                    totalPrice += w.RetailPrice;
                }
                totalCount += kvp.Value.Count;
            }
            LabelTotalPrice.Text = totalPrice.ToString("c0");
            LabelTotalCount.Text = totalCount.ToString(); 
            #endregion
        }

        #region [Welcome Screen]
        // Home screen button to add inventory items
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PHome.Visible = false;              // Show view inventory panel and navigation button
            PanelAddInventory.Visible = true;
            PanelViewInventory.Visible = false;
            PAddHome.Visible = true;
        }

        // Home screen button to view inventory
        private void btnView_Click(object sender, EventArgs e)
        {
            PHome.Visible = false;         // Show view inventory panel and navigation button
            PanelAddInventory.Visible = false;
            PanelViewInventory.Visible = true;

            // Load all categories of inventory into left list box (lstBox_Categories)
            foreach (var category in Inventory)
            {
                lstBox_Categories.Items.Add(category.Key);
            }
        }
        #endregion

        #region [Navigation]
        // User clicks on ADD buton, take them to add inventory panel
        private void btnNavADD_Click(object sender, EventArgs e)
        {
            PHome.Visible = false;         // Show view inventory panel and navigation button
            PanelAddInventory.Visible = true;
            PanelViewInventory.Visible = false;
            PAddHome.Visible = true;
        }

        // User clicks on VIEW button, take them to view inventory panel
        private void btnNavVIEW_Click(object sender, EventArgs e)
        {
            PHome.Visible = false;         // Show view inventory panel and navigation button
            PanelAddInventory.Visible = false;
            PanelViewInventory.Visible = true;

            // Load all categories of inventory into left list box (lstBox_Categories)
            foreach (var category in Inventory)
            {
                lstBox_Categories.Items.Add(category.Key);
            }
        }

        // User clicks on company logo - take them to home screen panel
        private void picLOGO_Click(object sender, EventArgs e)
        {
            PHome.Visible = true;
            PanelAddInventory.Visible = false;
            PanelViewInventory.Visible = false;
        } 
        #endregion

        #region [Inventory]
        private void lstBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = lstBox_Categories.SelectedItem.ToString();
            lstBox_WaterCraftsInInventory.Items.Clear();

            // When an inventory category is selected in lstBox_Categories, show corresponding water crafts in inventory in right list box (lstBox_WaterCraftsInInventory)
            foreach (WaterCraft item in Inventory[category])
            {
                lstBox_WaterCraftsInInventory.Items.Add(item);
            }
        }

        // Sort items in inventory
        private void btnSort_Click(object sender, EventArgs e)
        {
            lstBox_WaterCraftsInInventory.Sorted = true;
        }

        private void picBoxMotorYacht_Click(object sender, EventArgs e)
        {
            PHome.Visible = false;
            PanelAddInventory.Visible = false;
            PanelViewInventory.Visible = false;
            PAddHome.Visible = false;
            panelADD_Canoe.Visible = false;
            panelADD_MotorY.Visible = true;
            panelADD_SailingY.Visible = false;
        }

        private void picBoxCanoe_Click(object sender, EventArgs e)
        {
            PHome.Visible = false;
            PanelAddInventory.Visible = false;
            PanelViewInventory.Visible = false;
            PAddHome.Visible = false;
            panelADD_Canoe.Visible = true;
            panelADD_MotorY.Visible = false;
            panelADD_SailingY.Visible = false;
        }

        private void picBoxJetSki_Click(object sender, EventArgs e)
        {
            Add_SailingYacht JetSki = new Add_SailingYacht();

            if(JetSki.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void picBoxSailingYacht_Click(object sender, EventArgs e)
        {
            panelADD_SailingY.Visible = true;
            PHome.Visible = false;
            PanelAddInventory.Visible = false;
            PanelViewInventory.Visible = false;
            PAddHome.Visible = false;
            panelADD_Canoe.Visible = false;
            panelADD_MotorY.Visible = false;
        }
        #endregion
    }  
}
