using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex > -1 && cbDec.SelectedIndex > -1 && cbCon.SelectedIndex > -1)
            {
                btnGenerate.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Display_form primalmat = new Display_form(); //the new form
            String type = cbType.SelectedItem.ToString();
            int con = Convert.ToInt16(cbCon.SelectedItem.ToString());
            int dec = Convert.ToInt16(cbDec.SelectedItem.ToString());
            primalmat.setMatrix(con, dec, type);
            primalmat.ShowDialog();
           

            
        }

        private void CbCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex > -1 && cbDec.SelectedIndex > -1 && cbCon.SelectedIndex > -1)
            {
                btnGenerate.Enabled = true;
            }
        }

        private void CbDec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex > -1 && cbDec.SelectedIndex > -1 && cbCon.SelectedIndex > -1)
            {
                btnGenerate.Enabled = true;
            }
        }

    }
}
