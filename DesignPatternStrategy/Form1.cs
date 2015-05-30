using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatternStrategy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double totalNum = 0;

        private void btnEnsure_Click(object sender, EventArgs e)
        {
            //double count = Convert.ToDouble(txtCount.Text);

            //double price = Convert.ToDouble(txtPrice.Text);

            //lbxList.Items.Add("C: " + count + "\tP: " + price);

            //txtCount.Text = "";

            //txtPrice.Text = "";

            //lblResult.Text = (Convert.ToDouble(lblResult.Text) + (count * price)).ToString();

            #region P1
            //double priceNum = Convert.ToDouble(txtCount.Text) * Convert.ToDouble(txtPrice.Text); ;

            //switch (comboBox.SelectedIndex)
            //{
            //    case 1: priceNum *= 0.85; break;
            //    case 2: priceNum -= Math.Floor(priceNum / 199) * 100; break;
            //} 
            #endregion

            double priceNum = Convert.ToDouble(txtCount.Text) * Convert.ToDouble(txtPrice.Text); ;

            CashContext context = new CashContext(comboBox.SelectedIndex.ToString());

            priceNum = context.GetResult(priceNum);

            lbxList.Items.Add(string.Format("Count: {0} Price:{1:c} Total:{2:c}", txtCount.Text, txtPrice.Text, priceNum));

            totalNum += priceNum;

            lblResult.Text = totalNum.ToString();
        }
              
        private void Form1_Load(object sender, EventArgs e)
        {
            lbxList.Items.Clear();

            comboBox.Items.AddRange(new object[] { "正常收费", "打八五折", "满199减100" });

            comboBox.SelectedIndex = 0;
        }
    }
}
