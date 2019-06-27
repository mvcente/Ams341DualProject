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
    
    public partial class Display_form : Form
    {
        public Display_form()
        {
            InitializeComponent();
        }

        private void Display_form_Load(object sender, EventArgs e)
        {

        }
        private ComboBox[] cbConBoxes;
        private ComboBox[] cbDecBoxes;
        public void setMatrix(int con, int dec, String type)
        {
            int horizontal = 32;
            int vertical = 32;
            TextBox[,] txtArray = new TextBox[con,dec];
            Label[] lblDec = new Label[dec];
            Label[] lblCon = new Label[con];
            TextBox[] eqCon = new TextBox[con];
            TextBox[] eqDec = new TextBox[dec];
            TextBox[] LP = new TextBox[dec];



        Label lblType = new Label();
            lblType.Size = new Size(60, 60);
            lblType.Location = new Point(0, 0);
            lblType.Font = new Font("Arial", 12);
            lblType.Text = type;
            lblType.Show();
            this.Controls.Add(lblType);
            InitializeComponent();
            cbConBoxes = new ComboBox[] { cbCon1, cbCon2, cbCon3, cbCon4, cbCon5, cbCon6, cbCon7};
            cbDecBoxes = new ComboBox[] { cbDec1, cbDec2, cbDec3, cbDec4, cbDec5, cbDec6, cbDec7 };
            this.Size = new System.Drawing.Size(150 + (dec + 2) * (horizontal), vertical * (con + 2) + 150);
            for (int i = 0; i < con; i++)
            {
                lblCon[i] = new Label();
                eqCon[i] = new TextBox();
                lblCon[i].Size = new Size(20, 20);
                eqCon[i].Size = new Size(30, 30);
                lblCon[i].Location = new Point(50,50+ vertical * (i+1));
                eqCon[i].Location = new Point(50+(dec+2) * (horizontal), 50+vertical * (i + 1));
                lblCon[i].Text = "c"+i;
                lblCon[i].Show();
                eqCon[i].Show();
                    this.Controls.Add(lblCon[i]);
                this.Controls.Add(eqCon[i]);
                cbConBoxes[i].Visible = true;
                

                for (int j = 0; j < dec; j++)
                {
                    txtArray[i,j] = new TextBox();
                    txtArray[i,j].Size = new Size(30, 30);
                    txtArray[i,j].Location = new Point(50+horizontal * (j+1), 50+vertical * (i+1));
                    txtArray[i,j].Show();
                    this.Controls.Add(txtArray[i,j]);
                }
                

            }
            for (int j = 0; j < dec; j++)
            {
                lblDec[j] = new Label();
                eqDec[j] = new TextBox();
                LP[j] = new TextBox();
                lblDec[j].Size = new Size(20, 20);
                eqDec[j].Size = new Size(30, 30);
                LP[j].Size = new Size(30, 30);
                lblDec[j].Location = new Point(50+horizontal * (j + 1), 50);
                eqDec[j].Location = new Point(50 + horizontal * (j + 1), vertical*(con+2) +50);
                LP[j].Location = new Point(50 + horizontal * (j + 1), 0);
                lblDec[j].Text = "x" + j;
                lblDec[j].Show();
                eqDec[j].Show();
                LP[j].Show();
                this.Controls.Add(lblDec[j]);
                this.Controls.Add(eqDec[j]);
                this.Controls.Add(LP[j]);
                cbDecBoxes[j].Visible = true;
            }
            cbLP.Location = new Point(50 + horizontal * (dec + 1), 0);
            cbLP.Visible = true;
            tbLP.Location = new Point(50 + horizontal * (dec + 2), 0);
                panelCon.Location = new Point(50+horizontal * (dec + 1),80);
                panelCon.Visible = true;
                panelDec.Location = new Point(80, 50+vertical * (con + 1));
                panelDec.Visible = true;
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbCon4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbCon5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbCon6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbCon7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbCon3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
