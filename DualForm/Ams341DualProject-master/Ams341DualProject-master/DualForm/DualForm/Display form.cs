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
        public ComboBox[] cbConBoxes;
        public ComboBox[] cbDecBoxes;
        public TextBox[,] txtArray;
        public Label[] lblDec;
        public Label[] lblCon;
        public TextBox[] eqCon;
        public Label[] eqDec;
        public TextBox[] LP;
        public int matCon;
        public int matDec;
        Label lblType;
        public void setMatrix(int con, int dec, String type)
        {
            int horizontal = 32;
            int vertical = 32;
            txtArray = new TextBox[con,dec];
            lblDec = new Label[dec];
            lblCon = new Label[con];
            eqCon = new TextBox[con];
            eqDec = new Label[dec];
            LP = new TextBox[dec];
            matCon = con;
            matDec = dec;

            lblType = new Label();
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
            btnSolve.Location = new Point(30 + (dec + 2) * (horizontal), vertical * (con + 2) + 30);
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
                eqDec[j] = new Label();
                eqDec[j].Text = "0";
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

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            Display_form dualmat = new Display_form(); //rhe dual matrix form 
           
            if (lblType.Text.Equals("Min"))
                dualmat.setMatrix(matDec, matCon, "Max");
            if (lblType.Text.Equals("Max"))
                dualmat.setMatrix(matDec, matCon, "Min");

            for(int i=0; i<matCon;i++)
            {
                for(int j=0; j<matDec;j++)
                {   
                    dualmat.eqCon[j].Text = this.LP[j].Text;
                    dualmat.LP[i].Text = this.eqCon[i].Text;
                    dualmat.txtArray[j, i].Text = this.txtArray[i, j].Text;
                }
            }

            for(int i=0; i<matCon; i++)
            {
               
                    if (this.cbConBoxes[i].Text.Equals("≥") && lblType.Text.Equals("Min"))//sets the signs for dual's decision var constraints as the signs of the regular constraints of primal, transposed
                        dualmat.cbDecBoxes[i].Text = "≥";
                    if (this.cbConBoxes[i].Text.Equals("≤") && lblType.Text.Equals("Min"))
                        dualmat.cbDecBoxes[i].Text = "≤";
                    if (this.cbConBoxes[i].Text.Equals("≥") && lblType.Text.Equals("Max"))
                        dualmat.cbDecBoxes[i].Text = "≤";
                    if (this.cbConBoxes[i].Text.Equals("≤") && lblType.Text.Equals("Max"))
                        dualmat.cbDecBoxes[i].Text = "≥";
                    if (this.cbConBoxes[i].Text.Equals("="))
                        dualmat.cbDecBoxes[i].Text = "urs";
                    //dualMatrix.ObjFunc.coefficients[i] = primalMatrix.Constraints[i].value;
                
                //  dualmat.cbDecBoxes[i].Text = this.cbConBoxes[i].Text;
            }

            for(int i=0; i<matDec; i++)
            {

                if (this.cbDecBoxes[i].Text.Equals("≥") && lblType.Text.Equals("Max")) //sets signs and values of dual constraints to the appropriate one based on priml decision constraints
                    dualmat.cbConBoxes[i].Text = "≥";
                if (this.cbDecBoxes[i].Text.Equals("≥") && lblType.Text.Equals("Min"))
                    dualmat.cbConBoxes[i].Text = "≤";
                if (this.cbDecBoxes[i].Text.Equals("≤") && lblType.Text.Equals("Max"))
                    dualmat.cbConBoxes[i].Text = "≤";
                if (this.cbDecBoxes[i].Text.Equals("≤") && lblType.Text.Equals("Min"))
                    dualmat.cbConBoxes[i].Text = "≥";
                if (this.cbDecBoxes[i].Text.Equals("urs"))
                    dualmat.cbConBoxes[i].Text = "=";

                // dualmat.cbConBoxes[i].Text = this.cbDecBoxes[i].Text;

            }

            if (this.Text.Equals("Primal"))
                dualmat.Text = "Dual";
            else
                dualmat.Text = "Primal";
            dualmat.ShowDialog();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
