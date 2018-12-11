using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Cafe_Magagement_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            txtAfricanCoffee.Text = "0";
            txtAmericanCoffee.Text = "0";
            txtBlackForestCake.Text = "0";
            txtBostonCreamCake.Text = "0";
            txtCappuccino.Text = "0";
            txtCarltonHillChocolateCake.Text = "0";
            txtCoffeeCake.Text = "0";
            txtExpresso.Text = "0";
            txtIcedCappuccino.Text = "0";
            txtIcedLatte.Text = "0";
            txtKilburnChocolateCake.Text = "0";
            txtLagosChocolateCake.Text = "0";
            txtLatte.Text = "0";
            txtQueensParkChocolateCake.Text = "0";
            txtRedVelvet.Text = "0";
            txtValeCoffee.Text = "0";
            lblCostCakes.Text = "0";
            lblCostDrinks.Text = "0";
            lblService.Text = "1.75";

            txtLatte.Enabled = false;
            txtExpresso.Enabled = false;
            txtIcedLatte.Enabled = false;
            txtValeCoffee.Enabled = false;
            txtAmericanCoffee.Enabled = false;
            txtAfricanCoffee.Enabled = false;
            txtIcedCappuccino.Enabled = false;
            txtCoffeeCake.Enabled = false;
            txtBlackForestCake.Enabled = false;
            txtBostonCreamCake.Enabled = false;
            txtLagosChocolateCake.Enabled = false;
            txtKilburnChocolateCake.Enabled = false;
            txtCarltonHillChocolateCake.Enabled = false;
            txtQueensParkChocolateCake.Enabled = false;
            txtCappuccino.Enabled = false;
            txtRedVelvet.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void button4_Click(object sender, EventArgs e)
        //{

        //}

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkLagosChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLagosChocolateCake.Checked == true)
            {
                txtLagosChocolateCake.Enabled = true;
            }
            if (chkLagosChocolateCake.Checked == false)
            {
                txtLagosChocolateCake.Enabled = false;
                txtLagosChocolateCake.Text = "0";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAfricanCoffee.Text = "0";
            txtAmericanCoffee.Text = "0";
            txtBlackForestCake.Text = "0";
            txtBostonCreamCake.Text = "0";
            txtCappuccino.Text = "0";
            txtCarltonHillChocolateCake.Text = "0";
            txtCoffeeCake.Text = "0";
            txtExpresso.Text = "0";
            txtIcedCappuccino.Text = "0";
            txtIcedLatte.Text = "0";
            txtKilburnChocolateCake.Text = "0";
            txtLagosChocolateCake.Text = "0";
            txtLatte.Text = "0";
            txtQueensParkChocolateCake.Text = "0";
            txtRedVelvet.Text = "0";
            txtValeCoffee.Text = "0";
            lblCostCakes.Text = "0";
            lblCostDrinks.Text = "0";
            lblService.Text = "1.75";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            chkAfricanCoffee.Checked = false;
            chkAmericanCoffee.Checked = false;
            chkBlackForestCake.Checked = false;
            chkBostonCreamCake.Checked = false;
            chkCappuccino.Checked = false;
            chkCarltonHillChocolateCake.Checked = false;
            chkCoffee.Checked = false;
            chkEspresso.Checked = false;
            chkIcedCappuccino.Checked = false;
            chkIcedLatte.Checked = false;
            chkKilburnChocolateCake.Checked = false;
            chkRedValvet.Checked = false;
            chkQueensParkChocolateCake.Checked = false;
            chkLagosChocolateCake.Checked = false;
            chkLatte.Checked = false;
            chkValeCoffee.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked == true)
            {
                txtLatte.Enabled = true;
            }
            if (chkLatte.Checked == false)
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }

        //private void chkCarltonHillChocolate_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                txtExpresso.Enabled = true;
            }
            if (chkEspresso.Checked == false)
            {
                txtExpresso.Enabled = false;
                txtExpresso.Text = "0";
            }
        }

        private void chkIcedLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedLatte.Checked == true)
            {
                txtIcedLatte.Enabled = true;
            }
            if (chkIcedLatte.Checked == false)
            {
                txtIcedLatte.Enabled = false;
                txtIcedLatte.Text = "0";
            }
        }

        private void chkValeCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValeCoffee.Checked == true)
            {
                txtValeCoffee.Enabled = true;
            }
            if (chkValeCoffee.Checked == false)
            {
                txtValeCoffee.Enabled = false;
                txtValeCoffee.Text = "0";
            }
        }

        private void chkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                txtCappuccino.Enabled = true;
            }
            if (chkCappuccino.Checked == false)
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void chkAfricanCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfricanCoffee.Checked == true)
            {
                txtAfricanCoffee.Enabled = true;
            }
            if (chkAfricanCoffee.Checked == false)
            {
                txtAfricanCoffee.Enabled = false;
                txtAfricanCoffee.Text = "0";
            }
        }

        private void chkAmericanCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmericanCoffee.Checked == true)
            {
                txtAmericanCoffee.Enabled = true;
            }
            if (chkAmericanCoffee.Checked == false)
            {
                txtAmericanCoffee.Enabled = false;
                txtAmericanCoffee.Text = "0";
            }
        }

        private void chkIcedCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedCappuccino.Checked == true)
            {
                txtIcedCappuccino.Enabled = true;
            }
            if (chkIcedCappuccino.Checked == false)
            {
                txtIcedCappuccino.Enabled = false;
                txtIcedCappuccino.Text = "0";
            }
        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked == true)
            {
                txtCoffeeCake.Enabled = true;
            }
            if (chkCoffee.Checked == false)
            {
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.Text = "0";
            }
        }

        private void chkRedValvet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedValvet.Checked == true)
            {
                txtRedVelvet.Enabled = true;
            }
            if (chkRedValvet.Checked == false)
            {
                txtRedVelvet.Enabled = false;
                txtRedVelvet.Text = "0";
            }
        }

        private void chkBlackForestCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackForestCake.Checked == true)
            {
                txtBlackForestCake.Enabled = true;
            }
            if (chkBlackForestCake.Checked == false)
            {
                txtBlackForestCake.Enabled = false;
                txtBlackForestCake.Text = "0";
            }
        }

        private void chkBostonCreamCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBostonCreamCake.Checked == true)
            {
                txtBostonCreamCake.Enabled = true;
            }
            if (chkBostonCreamCake.Checked == false)
            {
                txtBostonCreamCake.Enabled = false;
                txtBostonCreamCake.Text = "0";
            }
        }

        private void chkKilburnChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKilburnChocolateCake.Checked == true)
            {
                txtKilburnChocolateCake.Enabled = true;
            }
            if (chkKilburnChocolateCake.Checked == false)
            {
                txtKilburnChocolateCake.Enabled = false;
                txtKilburnChocolateCake.Text = "0";
            }
        }

        private void chkCarltonHillChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarltonHillChocolateCake.Checked == true)
            {
                txtCarltonHillChocolateCake.Enabled = true;
            }
            if (chkCarltonHillChocolateCake.Checked == false)
            {
                txtCarltonHillChocolateCake.Enabled = false;
                txtCarltonHillChocolateCake.Text = "0";
            }
        }

        private void chkQueensParkChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQueensParkChocolateCake.Checked == true)
            {
                txtQueensParkChocolateCake.Enabled = true;
            }
            if (chkQueensParkChocolateCake.Checked == false)
            {
                txtQueensParkChocolateCake.Enabled = false;
                txtQueensParkChocolateCake.Text = "0";
            }
        }

        private void txtExpresso_Click(object sender, EventArgs e)
        {
            txtExpresso.Text = "";
            txtExpresso.Focus();
        }

        private void txtIcedLatte_Click(object sender, EventArgs e)
        {
            txtIcedLatte.Text = "";
            txtIcedLatte.Focus();
        }

        private void txtValeCoffee_Click(object sender, EventArgs e)
        {
            txtValeCoffee.Text = "";
            txtValeCoffee.Focus();
        }

        private void txtCappuccino_Click(object sender, EventArgs e)
        {
            txtCappuccino.Text = "";
            txtCappuccino.Focus();
        }

        private void txtAfricanCoffee_Click(object sender, EventArgs e)
        {
            txtAfricanCoffee.Text = "";
            txtAfricanCoffee.Focus();
        }

        private void txtAmericanCoffee_Click(object sender, EventArgs e)
        {
            txtAmericanCoffee.Text = "";
            txtAmericanCoffee.Focus();
        }

        private void txtIcedCappuccino_Click(object sender, EventArgs e)
        {
            txtIcedCappuccino.Text = "";
            txtIcedCappuccino.Focus();
        }

        private void txtCoffeeCake_Click(object sender, EventArgs e)
        {
            txtCoffeeCake.Text = "";
            txtCoffeeCake.Focus();
        }

        private void txtRedVelvet_Click(object sender, EventArgs e)
        {
            txtRedVelvet.Text = "";
            txtRedVelvet.Focus();
        }

        private void txtBlackForestCake_Click(object sender, EventArgs e)
        {
            txtBlackForestCake.Text = "";
            txtBlackForestCake.Focus();
        }

        private void txtBostonCreamCake_Click(object sender, EventArgs e)
        {
            txtBostonCreamCake.Text = "";
            txtBostonCreamCake.Focus();
        }

        private void txtLagosChocolateCake_Click(object sender, EventArgs e)
        {
            txtLagosChocolateCake.Text = "";
            txtLagosChocolateCake.Focus();

        }

        private void txtKilburnChocolateCake_Click(object sender, EventArgs e)
        {
            txtKilburnChocolateCake.Text = "";
            txtKilburnChocolateCake.Focus();
        }

        private void txtCarltonHillChocolateCake_Click(object sender, EventArgs e)
        {
            txtCarltonHillChocolateCake.Text = "";
            txtCarltonHillChocolateCake.Focus();
        }

        private void txtQueensParkChocolateCake_Click(object sender, EventArgs e)
        {
            txtQueensParkChocolateCake.Text = "";
            txtQueensParkChocolateCake.Focus();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t\t" + "Just Do Cafe" + Environment.NewLine);
            rtfReceipt.AppendText("------------------------------------------------------------------------------------------------------------"
                + Environment.NewLine + Environment.NewLine);
            rtfReceipt.AppendText("Latte \t\t\t\t\t" + txtLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Espresso \t\t\t\t\t" + txtExpresso.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Latte \t\t\t\t" + txtIcedLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Vale Coffee \t\t\t\t" + txtValeCoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cappuccino \t\t\t\t" + txtCappuccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("African Coffee \t\t\t\t" + txtAfricanCoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("American Coffee \t\t\t\t" + txtAmericanCoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Cappuccino \t\t\t\t" + txtIcedCappuccino.Text + Environment.NewLine);

            rtfReceipt.AppendText("Coffee Cake \t\t\t\t" + txtCoffeeCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Red Velet Cake \t\t\t\t" + txtRedVelvet.Text + Environment.NewLine);
            rtfReceipt.AppendText("Black Forest Cake \t\t\t\t" + txtBlackForestCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Boston Cream Cake \t\t\t" + txtBostonCreamCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Lagos Chocolate Cake \t\t\t" + txtLagosChocolateCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Kilburn Chocolate Cake \t\t\t" + txtKilburnChocolateCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Carlton Hill Chocolate Cake \t\t\t" + txtCarltonHillChocolateCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Queen's Park Chocolate \t\t\t" + txtQueensParkChocolateCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("------------------------------------------------------------------------------------------------------------"
                            + Environment.NewLine + Environment.NewLine);
            rtfReceipt.AppendText("ServiceCharge \t\t\t\t" + lblService.Text + Environment.NewLine);
            rtfReceipt.AppendText("------------------------------------------------------------------------------------------------------------"
                            + Environment.NewLine + Environment.NewLine);
            rtfReceipt.AppendText("Tax \t\t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total \t\t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total Cost \t\t\t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("------------------------------------------------------------------------------------------------------------"
                                       + Environment.NewLine + Environment.NewLine);
            rtfReceipt.AppendText(lblTime.Text + "\t\t\t\t" + lblDate.Text);



        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double tax = 0.45;
            double latte, ilatte, espresso, capp, iCapp, aCoffee, amCoffee, vale;
            double cCake, rVelvet, bForest, cBoston, cLagos, cKilburn, cCaelton, cQueen;

            latte = 1.20; espresso = 1.29; ilatte = 1.50; vale = 1.45; aCoffee = 1.50; amCoffee = 1.45; capp = 1.70; iCapp = 1.10;

            double latte_Coffee = Convert.ToDouble(txtLatte.Text);
            double espresson = Convert.ToDouble(txtExpresso.Text);
            double IcedLatte = Convert.ToDouble(txtIcedLatte.Text);
            double vale_Coff = Convert.ToDouble(txtValeCoffee.Text);
            double Afri_Coff = Convert.ToDouble(txtAfricanCoffee.Text);
            double Amer_Coff = Convert.ToDouble(txtAmericanCoffee.Text);
            double Capp_Coff = Convert.ToDouble(txtCappuccino.Text);
            double iCapp_Coff = Convert.ToDouble(txtIcedCappuccino.Text);

            cCake = 1.30; rVelvet = 1.20; bForest = 1.30; cBoston = 1.90; cLagos = 1.50; cKilburn = 1.40; cCaelton = 1.30; cQueen = 1.10;

            double c_Cakes = Convert.ToDouble(txtCoffeeCake.Text);
            double vl_Cakes = Convert.ToDouble(txtRedVelvet.Text);
            double bF_Cakes = Convert.ToDouble(txtBlackForestCake.Text);
            double cB_Cakes = Convert.ToDouble(txtBostonCreamCake.Text);
            double cL_Cakes = Convert.ToDouble(txtLagosChocolateCake.Text);
            double cK_Cakes = Convert.ToDouble(txtKilburnChocolateCake.Text);
            double cC_Cakes = Convert.ToDouble(txtCarltonHillChocolateCake.Text);
            double cQ_Cakes = Convert.ToDouble(txtQueensParkChocolateCake.Text);

            Cafe eat_in_Cafe = new Cafe(latte_Coffee, espresson, IcedLatte, vale_Coff, Afri_Coff, Amer_Coff, Capp_Coff, iCapp_Coff,
                c_Cakes, vl_Cakes, bF_Cakes, cB_Cakes, cL_Cakes, cK_Cakes, cC_Cakes, cQ_Cakes);

            double cost_of_drinks = (latte_Coffee * latte) + (espresson * espresso) + (IcedLatte * ilatte)
                + (vale * vale_Coff) + (aCoffee * Afri_Coff) + (amCoffee * Amer_Coff) + (capp * Capp_Coff) + (iCapp * iCapp_Coff);
            lblCostDrinks.Text = Convert.ToString(cost_of_drinks);

            double cost_of_cakes = (cCake * c_Cakes) + (rVelvet * vl_Cakes) + (bForest * bF_Cakes)
                + (cBoston * cB_Cakes) + (cLagos * cL_Cakes) + (cKilburn * cK_Cakes)
                + (cCaelton * cCaelton) + (cQueen * cQ_Cakes);
            lblCostCakes.Text = Convert.ToString(cost_of_cakes);

            double service_charge = Convert.ToDouble(lblService.Text);

            lblSubTotal.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + service_charge);
            lblTax.Text = Convert.ToString(((cost_of_cakes + cost_of_drinks + service_charge) * tax) / 100);
            double iTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + iTax);

            lblCostCakes.Text = string.Format("{0:C}", cost_of_cakes);
            lblCostDrinks.Text = string.Format("{0:C}", cost_of_drinks);
            lblService.Text = string.Format("{0:C}", service_charge);
            lblSubTotal.Text = string.Format("{0:C}", (cost_of_cakes + cost_of_drinks + service_charge));
            lblTax.Text = string.Format("{0:C}", iTax);
            lblTotal.Text = string.Format("{0:C}", (cost_of_cakes + cost_of_drinks + service_charge + iTax));

        }
    }
}
