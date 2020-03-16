using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace OpenProPlusConfigurator
{
    /**
    * \brief     <b>ucClosedLoopAction</b> is a user interface to display all CLA's
    * \details   This is a user interface to display all CLA's. It provides interface
    * to add multiple CLA's. The user can also modify it's parameters.
    * 
    * 
    */
    public partial class ucClosedLoopAction : UserControl
    {
        public event EventHandler btnAddClick;
        public event EventHandler btnDeleteClick;
        public event EventHandler btnDoneClick;
        public event EventHandler btnCancelClick;
        public event EventHandler btnFirstClick;
        public event EventHandler btnPrevClick;
        public event EventHandler btnNextClick;
        public event EventHandler btnLastClick;
        public event EventHandler lvCLADoubleClick;
        public event ListViewItemSelectionChangedEventHandler lvCLAItemSelectionChanged; //nikita:05/02/2020


        public ucClosedLoopAction()
        {
            InitializeComponent();
            //Utils.createPBTitleBar(pbHdr, lblHdrText, this.PointToScreen(lblHdrText.Location));
            txtCLAIndex.BackColor = System.Drawing.SystemColors.Window;//To make background white for disabled control...

            //Ajay: 23/11/2018
            if (ProtocolGateway.AppMode == ProtocolGateway.AppModes.Restricted)
            {
                if (ProtocolGateway.OppParameterLoadConfiguration_ReadOnly)
                {
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    return;
                }
                else { }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAddClick != null)
                btnAddClick(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDeleteClick != null)
                btnDeleteClick(sender, e);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (btnDoneClick != null)
                btnDoneClick(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancelClick != null)
                btnCancelClick(sender, e);
        }

        private void lvCLA_DoubleClick(object sender, EventArgs e)
        {
            if (lvCLADoubleClick != null)
                lvCLADoubleClick(sender, e);
        }

        private void pbHdr_MouseDown(object sender, MouseEventArgs e)
        {
            Utils.handleMouseDown(sender, e);
        }

        private void pbHdr_MouseMove(object sender, MouseEventArgs e)
        {
            Utils.handleMouseMove(grpCLA, sender, e);
        }

        private void lblHdrText_MouseDown(object sender, MouseEventArgs e)
        {
            Utils.handleMouseDown(sender, e);
        }

        private void lblHdrText_MouseMove(object sender, MouseEventArgs e)
        {
            Utils.handleMouseMove(grpCLA, sender, e);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (btnFirstClick != null)
                btnFirstClick(sender, e);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (btnPrevClick != null)
                btnPrevClick(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNextClick != null)
                btnNextClick(sender, e);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (btnLastClick != null)
                btnLastClick(sender, e);
        }

        private void txtAINo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, false);
        }

        private void txtAINo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, false);
        }

        private void txtDONo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, false);
        }

        private void txtHigh_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, true);
        }

        private void txtLow_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, true);
        }

        private void txtDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, false);
        }
        public event ItemCheckEventHandler lvCLAItemCheck;
        private void lvCLA_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lvCLAItemCheck != null)
                lvCLAItemCheck(sender, e);
        }

        private void grpCLA_Enter(object sender, EventArgs e)
        {

        }
        //Ajay: 03/01/2019
        private void txtbxDINo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, false);
        }

        private void lvCLA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textbxHigh_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvCLA_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvCLAItemSelectionChanged != null)
                lvCLAItemSelectionChanged(sender, e);
        }

        private void ucClosedLoopAction_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
           
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //nikita : 11/02/2020
        private void txtbx_Low_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, false);
        }
        //nikita : 11/02/2020
        private void txtbx_High_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, false);
        }
        //nikita : 11/02/2020
        private void textbx_High_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, false);
        }
        //nikita : 11/02/2020
        private void textbx_Low_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.allowNumbersOnly(sender, e, false, false);
        }
        //nikita : 11/02/2020
        private void txtbx_High_TextChanged(object sender, EventArgs e)
        {
            textbx_High.Text = txtbx_High.Text;
        }
        //nikita : 11/02/2020
        private void txtbx_Low_TextChanged(object sender, EventArgs e)
        {
            textbx_Low.Text = txtbx_Low.Text;
        }
        //nikita : 11/02/2020
        private void cb_AI1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if ((Utils.IsGreaterThanZero(Convert.ToString(cb_AI1.SelectedItem)) && Convert.ToString(cb_AI2.SelectedItem) == "0") || (Utils.IsGreaterThanZero(Convert.ToString(cb_AI2.SelectedItem)) && Convert.ToString(cb_AI1.SelectedItem) == "0"))
            {
                pbOutput.Image = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject("OR"));
                pbOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pbOutput.Image = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject("AND"));
                pbOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            }


            if (lvCLA.SelectedItems.Count != 0)
            {
                int ListIndex = lvCLA.FocusedItem.Index;
                ListViewItem lvi = lvCLA.Items[ListIndex];

                lvi.SubItems[1].Text = cb_AI1.SelectedItem;
                cb_AI2.SelectedItem = lvi.SubItems[2].Text;
            }
          //nikita : 11/02/2020
        private void cb_AI2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

                if ((Utils.IsGreaterThanZero(Convert.ToString(cb_AI1.SelectedItem)) && Convert.ToString(cb_AI2.SelectedItem) == "0") || (Utils.IsGreaterThanZero(Convert.ToString(cb_AI2.SelectedItem)) && Convert.ToString(cb_AI1.SelectedItem) == "0"))
                {
                pbOutput.Image = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject("OR"));
                pbOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pbOutput.Image = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject("AND"));
                pbOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textbx_High_TextChanged(object sender, EventArgs e)
        {
            txtbx_High.Text = textbx_High.Text;
        }

        private void textbx_Low_TextChanged(object sender, EventArgs e)
        {
            txtbx_Low.Text = textbx_Low.Text;
        }

       
    }
}
