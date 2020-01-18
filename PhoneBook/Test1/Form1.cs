using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form : System.Windows.Forms.Form
    {

        #region [-Ctor-]
        public Form()
        {
            InitializeComponent();
            Ref_PersonViewModel = new Models.ViewModels.PersonViewModel();
        }
        #endregion
        #region [-Props-]
        public Models.ViewModels.PersonViewModel Ref_PersonViewModel { get; set; }
        public int Id { get; set; }
        


        #endregion
        #region [-Form1_Load-]
        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();

        }
        #endregion
        #region [-FillGrid()-]
        private void FillGrid()
        {
            dgvPerson.DataSource = Ref_PersonViewModel.FillGrid();
            Clear();

        }
        #endregion
        #region [-btnRefresh_Click-]
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
            MessageBox.Show("DONE:)");
        }
        #endregion
        #region [-btnSave_Click-]
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Save(txtFName.Text, txtLName.Text, txtMobileNumber.Text, txtTelNumber2.Text, txtTelNumber1.Text, txtAddress.Text);

        }
        #endregion
        #region [-btnEdit_Click-]
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Edit(Id, txtFName.Text, txtLName.Text, txtMobileNumber.Text, txtTelNumber1.Text, txtTelNumber2.Text, txtAddress.Text);

        }
        #endregion
        #region [-dgvPerson_CellDoubleClick-]
        private void dgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = System.Convert.ToInt32(dgvPerson.CurrentRow.Cells["Id"].Value);
            txtFName.Text = dgvPerson.CurrentRow.Cells["FName"].Value.ToString();
            txtLName.Text = dgvPerson.CurrentRow.Cells["LName"].Value.ToString();
            txtMobileNumber.Text = dgvPerson.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            txtTelNumber1.Text = dgvPerson.CurrentRow.Cells["TelNumber1"].Value.ToString();
            txtTelNumber2.Text = dgvPerson.CurrentRow.Cells["TelNumber2"].Value.ToString();
            txtAddress.Text = dgvPerson.CurrentRow.Cells["HomeAddress"].Value.ToString();

        }

        #endregion
        #region [-btnDelete_Click-]
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Delete(Id, txtFName.Text, txtLName.Text, txtMobileNumber.Text, txtTelNumber1.Text, txtTelNumber2.Text, txtAddress.Text);
            Clear();

        }
        #endregion
        #region [-Clear()-]
        private void Clear()
        {

            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtMobileNumber.Text = string.Empty;
            txtTelNumber1.Text = string.Empty;
            txtTelNumber2.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtFName.Focus();
        }
        #endregion
        #region [-btnNew_Click-]
        private void BtnNew_Click(object sender, EventArgs e)
        {
            Clear();
            Ref_PersonViewModel.Save(txtFName.Text, txtLName.Text, txtMobileNumber.Text, txtTelNumber2.Text, txtTelNumber1.Text, txtAddress.Text);
        }

        #endregion
        #region [-btnExit_Click-]

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();

        }


        #endregion


        #region [-Startwith09-]
        #region [-TxtMobileNumber_TextChanged-]
        private void TxtMobileNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text != "")
            {
                if (txtMobileNumber.Text.StartsWith("09"))
                {

                }
                else
                {
                    MessageBox.Show("number should be start with 09");

                }
            }
        }
        #endregion

        #endregion

        #region [-Startwith021-]
        #region [-txtTelNumber1_TextChanged-]
        private void TxtTelNumber1_TextChanged(object sender, EventArgs e)
        {
            if (txtTelNumber1.Text != "")
            {
                if (txtTelNumber1.Text.StartsWith("021"))
                {

                }
                else
                {

                    MessageBox.Show("number should be start with 021");
                }
            }
        }
        #endregion

        #region [-TxtTelNumber2_TextChanged-]
        private void TxtTelNumber2_TextChanged(object sender, EventArgs e)
        {
            if (txtTelNumber2.Text != "")
            {
                if (txtTelNumber2.Text.StartsWith("021"))
                {

                }
                else
                {

                    MessageBox.Show("number should be start with 021");
                }
            }
        }
        #endregion

        #endregion

        #region [-OnlyCharacters-]
        #region [-TxtFName_KeyPress-]
        private void TxtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
        #endregion
        #region [-TxtLName_KeyPress-]
        private void TxtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }



        #endregion

        #endregion

        #region [-OnlyNumbers-]
        #region [-TxtMobileNumber_KeyPress-]
        private void TxtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtMobileNumber.MaxLength = 11;
           
        }
        #endregion

        #region [-TxtTelNumber1_KeyPress-]
        private void TxtTelNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtTelNumber1.MaxLength = 11;

        }
        #endregion

        #region [-txtTelNumber2_KeyPress-]
        private void txtTelNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtTelNumber2.MaxLength = 11;
        }

        #endregion
        #endregion

        #region [-ShortCutExit-]
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
            {
                Application.ExitThread();
            }
        }

        #endregion

      
    }

}
