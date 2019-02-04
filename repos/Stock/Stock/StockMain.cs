﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class StockMain : Form
    {
        private int childFormNumber = 0;

        public StockMain()
        {
            InitializeComponent();
        }


        private void StockMain_Load(object sender, EventArgs e)
        {

        }
        bool close = true;
        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.MdiParent = this;
            pro.Show();
        }
    }
}
