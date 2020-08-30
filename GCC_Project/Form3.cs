using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCC_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "Dashboard";
            Name = "Dashboard";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            //MEDICINE MANUFACTURING  BUTTONS VISIBILITY....................
            MedicineManufactureSubMenuLable.Visible = false;
            MMViewBtn.Visible = false;
            MMInsert.Visible = false;
            MMEdit.Visible = false;
            MMRemove.Visible = false;

            //MEDICINE STOCK BUTTONS VISIBILITY...........................
            MedicineStockLable.Visible = false;
            MSAvail.Visible = false;
            MSOrigin.Visible = false;
            MSUpcomingStock.Visible = false;
            MSStockOut.Visible = false;
            MSEditInsert.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            DiseaseCureInfoSubMenuLable.Visible = false;
            DCDiseaseInfo.Visible = false;
            DCUpcomingCure.Visible = false;
            DCDiseaseOrigin.Visible = false;
            DCDiseaseCureStatistics.Visible = false;
            DCEdxitInsertInfo.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            HSLable.Visible = false;
            HSDiseaseStats.Visible = false;
            HSUpdateInsert.Visible = false;
            HSGlobalStats.Visible = false;
           
            HSWorldHealthStaff.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            WorldHealthStaffLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseMenuBtn_Click(object sender, EventArgs e)
        {
            //MEDICINE MANUFACTURING  BUTTONS VISIBILITY....................
            MedicineManufactureSubMenuLable.Visible = false;
            MMViewBtn.Visible = false;
            MMInsert.Visible = false;
            MMEdit.Visible = false;
            MMRemove.Visible = false;

            //MEDICINE STOCK BUTTONS VISIBILITY...........................
            MedicineStockLable.Visible = false;
            MSAvail.Visible = false;
            MSOrigin.Visible = false;
            MSUpcomingStock.Visible = false;
            MSStockOut.Visible = false;
            MSEditInsert.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            DiseaseCureInfoSubMenuLable.Visible = false;
            DCDiseaseInfo.Visible = false;
            DCUpcomingCure.Visible = false;
            DCDiseaseOrigin.Visible = false;
            DCDiseaseCureStatistics.Visible = false;
            DCEdxitInsertInfo.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            HSLable.Visible = false;
            HSDiseaseStats.Visible = false;
            HSUpdateInsert.Visible = false;
            HSGlobalStats.Visible = false;
            
            HSWorldHealthStaff.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            WorldHealthStaffLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void manufacturingGoodsBtn_Click(object sender, EventArgs e)
        {
            //MEDICINE MANUFACTURING  BUTTONS VISIBILITY....................
            MedicineManufactureSubMenuLable.Visible = true;
            MMViewBtn.Visible = true;
            MMInsert.Visible = true;
            MMEdit.Visible = true;
            MMRemove.Visible = true;

            //MEDICINE STOCK BUTTONS VISIBILITY...........................
            MedicineStockLable.Visible = false;
            MSAvail.Visible = false;
            MSOrigin.Visible = false;
            MSUpcomingStock.Visible = false;
            MSStockOut.Visible = false;
            MSEditInsert.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            DiseaseCureInfoSubMenuLable.Visible = false;
            DCDiseaseInfo.Visible = false;
            DCUpcomingCure.Visible = false;
            DCDiseaseOrigin.Visible = false;
            DCDiseaseCureStatistics.Visible = false;
            DCEdxitInsertInfo.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            HSLable.Visible = false;
            HSDiseaseStats.Visible = false;
            HSUpdateInsert.Visible = false;
            HSGlobalStats.Visible = false;
           
            HSWorldHealthStaff.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            WorldHealthStaffLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void SellingGoodsBtn_Click(object sender, EventArgs e)
        {
            //MEDICINE STOCK BUTTONS VISIBILITY...........................
            MedicineStockLable.Visible = true;
            MSAvail.Visible = true;
            MSOrigin.Visible = true;
            MSUpcomingStock.Visible = true;
            MSStockOut.Visible = true;
            MSEditInsert.Visible = true;

            //MEDICINE MANUFACTURING  BUTTONS VISIBILITY....................
            MedicineManufactureSubMenuLable.Visible = false;
            MMViewBtn.Visible = false;
            MMInsert.Visible = false;
            MMEdit.Visible = false;
            MMRemove.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            DiseaseCureInfoSubMenuLable.Visible = false;
            DCDiseaseInfo.Visible = false;
            DCUpcomingCure.Visible = false;
            DCDiseaseOrigin.Visible = false;
            DCDiseaseCureStatistics.Visible = false;
            DCEdxitInsertInfo.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            HSLable.Visible = false;
            HSDiseaseStats.Visible = false;
            HSUpdateInsert.Visible = false;
            HSGlobalStats.Visible = false;
           
            HSWorldHealthStaff.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            WorldHealthStaffLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StockAvailBtn_Click(object sender, EventArgs e)
        {
            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            DiseaseCureInfoSubMenuLable.Visible = true;
            DCDiseaseInfo.Visible = true;
            DCUpcomingCure.Visible = true;
            DCDiseaseOrigin.Visible = true;
            DCDiseaseCureStatistics.Visible = true;
            DCEdxitInsertInfo.Visible = true;

            //MEDICINE MANUFACTURING  BUTTONS VISIBILITY....................
            MedicineManufactureSubMenuLable.Visible = false;
            MMViewBtn.Visible = false;
            MMInsert.Visible = false;
            MMEdit.Visible = false;
            MMRemove.Visible = false;

            //MEDICINE STOCK BUTTONS VISIBILITY...........................
            MedicineStockLable.Visible = false;
            MSAvail.Visible = false;
            MSOrigin.Visible = false;
            MSUpcomingStock.Visible = false;
            MSStockOut.Visible = false;
            MSEditInsert.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            HSLable.Visible = false;
            HSDiseaseStats.Visible = false;
            HSUpdateInsert.Visible = false;
            HSGlobalStats.Visible = false;
     
            HSWorldHealthStaff.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            WorldHealthStaffLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void VendorBuyrInfoBtn_Click(object sender, EventArgs e)
        {
            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            HSLable.Visible = true;
            HSDiseaseStats.Visible = true;
            HSUpdateInsert.Visible = true;
            HSGlobalStats.Visible = true;
           
            HSWorldHealthStaff.Visible = true;

            //MEDICINE MANUFACTURING  BUTTONS VISIBILITY....................
            MedicineManufactureSubMenuLable.Visible = false;
            MMViewBtn.Visible = false;
            MMInsert.Visible = false;
            MMEdit.Visible = false;
            MMRemove.Visible = false;

            //MEDICINE STOCK BUTTONS VISIBILITY...........................
            MedicineStockLable.Visible = false;
            MSAvail.Visible = false;
            MSOrigin.Visible = false;
            MSUpcomingStock.Visible = false;
            MSStockOut.Visible = false;
            MSEditInsert.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            DiseaseCureInfoSubMenuLable.Visible = false;
            DCDiseaseInfo.Visible = false;
            DCUpcomingCure.Visible = false;
            DCDiseaseOrigin.Visible = false;
            DCDiseaseCureStatistics.Visible = false;
            DCEdxitInsertInfo.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            WorldHealthStaffLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void AboutUsBtn_Click(object sender, EventArgs e)
        {
            //ABOUT US BUTTONS VISIBILITY...........................
            WorldHealthStaffLable.Visible = true;
            AUApp.Visible = true;
            AUContactUs.Visible = true;
            AUDeveloper.Visible = true;

            //MEDICINE MANUFACTURING  BUTTONS VISIBILITY....................
            MedicineManufactureSubMenuLable.Visible = false;
            MMViewBtn.Visible = false;
            MMInsert.Visible = false;
            MMEdit.Visible = false;
            MMRemove.Visible = false;

            //SELLING GOODS BUTTONS VISIBILITY...........................
            MedicineStockLable.Visible = false;
            MSAvail.Visible = false;
            MSOrigin.Visible = false;
            MSUpcomingStock.Visible = false;
            MSStockOut.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            DiseaseCureInfoSubMenuLable.Visible = false;
            DCDiseaseInfo.Visible = false;
            DCUpcomingCure.Visible = false;
            DCDiseaseOrigin.Visible = false;
            DCDiseaseCureStatistics.Visible = false;
            DCEdxitInsertInfo.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            HSLable.Visible = false;
            HSDiseaseStats.Visible = false;
            HSUpdateInsert.Visible = false;
            HSGlobalStats.Visible = false;
            
            HSWorldHealthStaff.Visible = false;
        }
    }
}
