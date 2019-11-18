using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnippetGenerator.Forms
{
    public partial class frmDelegate : Form
    {
        private string strDelegate = string.Empty;

        private Int32 intParameterCount = 0;

        private List<string> mlstParameterName = new List<string>();
        private List<string> mlstDataType = new List<string>();
        private List<string> mlstInitValue = new List<string>();

        public string Delegate
        {
            get
            {
                return this.strDelegate;
            }
        }

        public string DelegateName
        {
            get
            {
                return this.txtDelegateName.Text;
            }
        }

        public frmDelegate()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnInsertDelegate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.strDelegate = GetDelegateText();
            this.Close();
        }

        #region [ GetDelegateText ]
        private string GetDelegateText()
        {
            StringBuilder sbDelegate = new StringBuilder(string.Empty);
            sbDelegate.Append("public delegate void " + txtDelegateName.Text + "(");
            for (Int32 index = 0; index < intParameterCount; index++)
            {
                sbDelegate.Append(mlstDataType[index] + " ");
                sbDelegate.Append(mlstParameterName[index] + " ");
                if (!mlstDataType[index].Equals("string") && !mlstInitValue[index].Equals("type"))
                    sbDelegate.Append(" = " + mlstInitValue[index] + ", ");
                else
                    sbDelegate.Append(", ");
            }
            if (intParameterCount > 0)
                return sbDelegate.ToString().Substring(0, sbDelegate.Length - 2) + ");";
            return sbDelegate.ToString() + ");";
        }
        #endregion

        private void txtDelegateName_TextChanged(object sender, EventArgs e)
        {
            btnInsertDelegate.Enabled = txtDelegateName.Text.Length > 0 ? true : false;
            this.Text = txtDelegateName.Text.Length > 0 ? "Delegate - " + txtDelegateName.Text : "Delegate";
        }

        private void txtParameterName_TextChanged(object sender, EventArgs e)
        {
            btnAddParameter.Enabled = txtParameterName.TextLength > 0 ? true : false;
        }

        #region [ cboDataType_SelectedIndexChanged ]
        private void cboDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDataTypeDescription.ForeColor = Color.Black;
            txtDataType.Text = string.Empty;
            txtDataType.Visible = false;
            switch (cboDataType.Text)
            {
                case "(Other)":
                    lblDataTypeDescription.Text = "A Class, Struct, Enum type.";
                    txtDataType.Visible = true;
                    txtDataType.Focus();
                    break;
                case "byte":
                    lblDataTypeDescription.Text = "An 8-bit unsigned integer.";
                    break;
                case "sbyte":
                    lblDataTypeDescription.Text = "An 8-bit signed integer.";
                    break;
                case "short":
                    lblDataTypeDescription.Text = "A 16-bit signed integer.";
                    break;
                case "int":
                    lblDataTypeDescription.Text = "A 32-bit signed integer.";
                    break;
                case "long":
                    lblDataTypeDescription.Text = "A 64-bit signed integer.";
                    break;
                case "ushort":
                    lblDataTypeDescription.Text = "A 16-bit unsigned integer. Not CLS-compliant.";
                    lblDataTypeDescription.ForeColor = Color.Red;
                    break;
                case "uint":
                    lblDataTypeDescription.Text = "A 32-bit unsigned integer. Not CLS-compliant.";
                    lblDataTypeDescription.ForeColor = Color.Red;
                    break;
                case "ulong":
                    lblDataTypeDescription.Text = "A 64-bit unsigned integer. Not CLS-compliant.";
                    lblDataTypeDescription.ForeColor = Color.Red;
                    break;
                case "float":
                    lblDataTypeDescription.Text = "A single-precision (32-bit) floating-point number.";
                    break;
                case "double":
                    lblDataTypeDescription.Text = "A double-precision (64-bit) floating-point number.";
                    break;
                case "bool":
                    lblDataTypeDescription.Text = "A Boolean value (true or false).";
                    break;
                case "char":
                    lblDataTypeDescription.Text = "A Unicode (16-bit) character.";
                    break;
                case "decimal":
                    lblDataTypeDescription.Text = "A decimal (128-bit) value.";
                    break;
                case "IntPtr":
                    lblDataTypeDescription.Text = "A signed integer whose size depends on the underlying platform " +
                                                  "(a 32-bit value on a 32-bit platform and a 64-bit value on a 64-bit platform)." +
                                                  "Not CLS-compliant.";
                    lblDataTypeDescription.ForeColor = Color.Red;
                    break;
                case "UIntPtr":
                    lblDataTypeDescription.Text = "An unsigned integer whose size depends on the underlying platform " +
                                                  "(a 32- bit value on a 32-bit platform and a 64-bit value on a 64-bit platform)." +
                                                  "Not CLS-compliant.";
                    lblDataTypeDescription.ForeColor = Color.Red;
                    break;
                case "object":
                    lblDataTypeDescription.Text = "The root of the object hierarchy.";
                    txtDataType.Text = cboDataType.Text;
                    break;
                case "string":
                    lblDataTypeDescription.Text = "An immutable, fixed-length string of Unicode characters.";
                    break;
                default:
                    lblDataTypeDescription.Text = string.Empty;
                    break;
            }
        }
        #endregion

        #region [ txtParameterName_KeyPress ]
        private void txtParameterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int32 key = Convert.ToInt32(e.KeyChar);
            Boolean validKey = false;

            if (e.KeyChar == '_')
                validKey = true;
            if (13 == key)
            {
                btnAddParameter_Click(btnAddParameter, new EventArgs());
                validKey = true;
            }
            if (false == validKey)
            {
                if (key < 31)
                    validKey = true;
                else
                {
                    if (key >= 48 && key <= 57 && ((TextBox)sender).SelectionStart > 0)
                        validKey = true;
                    else if ((key >= 65 && key <= 90) || (key >= 97 && key <= 122))
                        validKey = true;
                    else
                        validKey = false;
                }
            }
            if (validKey == false)
                e.KeyChar = char.MinValue;
        }
        #endregion

        #region [ btnAddParameter_Click ]
        private void btnAddParameter_Click(object sender, EventArgs e)
        {
            if (cboDataType.SelectedIndex == 0 && txtDataType.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Data type for parameter.", "Paramter Data Type",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDataType.Focus();
                return;
            }
            if (!lstParameters.Items.Contains(txtParameterName.Text))
            {
                lstParameters.Items.Add(txtParameterName.Text);
                mlstParameterName.Add(txtParameterName.Text);
                // Types.
                if (cboDataType.SelectedIndex == 0 || cboDataType.Text.Equals("object"))
                {
                    mlstDataType.Add(txtDataType.Text);
                    mlstInitValue.Add("type");
                }
                else
                {
                    // Built-in types.
                    mlstDataType.Add(cboDataType.Text);                    
                }
                intParameterCount++;
                if (lstParameters.SelectedIndex < 0)
                    lstParameters.SelectedIndex = 0;

                txtDataType.Text = string.Empty;
                cboDataType.SelectedIndex = 7;
            }
            else
                MessageBox.Show("Parameter '" + txtParameterName.Text + "' already added.");
            ClearFields();
        }
        #endregion

        #region [ ClearFields ]
        private void ClearFields()
        {
            txtParameterName.Text = string.Empty;
            cboDataType.SelectedIndex = 0;
            txtParameterName.Focus();
        }
        #endregion

        private void frmDelegate_Load(object sender, EventArgs e)
        {
            cboDataType.SelectedIndex = 0; 
        }

        #region [ frmParameterizedConstructor_FormClosing ]
        private void frmParameterizedConstructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            mlstDataType.Clear();
            mlstDataType = null;
            mlstInitValue.Clear();
            mlstInitValue = null;
            mlstParameterName.Clear();
            mlstParameterName = null;
        }
        #endregion

        #region [ lstParameters_SelectedIndexChanged ]
        private void lstParameters_SelectedIndexChanged(object sender, EventArgs e)
        { 
            btnDeleteParameter.Enabled = lstParameters.SelectedIndex >= 0 ? true : false;
            btnDeleteAllParameters.Enabled = btnDeleteParameter.Enabled;
        }
        #endregion

        #region [ btnDeleteParameter_Click ]
        private void btnDeleteParameter_Click(object sender, EventArgs e)
        {
            Int32 selectedIndex = lstParameters.SelectedIndex;
            lstParameters.Items.RemoveAt(lstParameters.SelectedIndex);
            lstParameters.Focus();
            if (lstParameters.Items.Count == 0)
            {
                btnDeleteParameter.Enabled = false;
                btnDeleteAllParameters.Enabled = false;
                txtParameterName.Focus();
            }
            if (selectedIndex >= lstParameters.Items.Count)
                lstParameters.SelectedIndex = selectedIndex - 1;
            else
                lstParameters.SelectedIndex = selectedIndex;

            intParameterCount--;
            mlstParameterName.RemoveAt(selectedIndex);
            mlstDataType.RemoveAt(selectedIndex);
            mlstInitValue.RemoveAt(selectedIndex);
        }
        #endregion

        #region [ btnDeleteAllParameters_Click ]
        private void btnDeleteAllParameters_Click(object sender, EventArgs e)
        {
            lstParameters.Items.Clear();
            btnDeleteParameter.Enabled = false;
            btnDeleteAllParameters.Enabled = false;
            txtParameterName.Focus();
        }
        #endregion

        private void cboDataType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (13 == Convert.ToInt32(e.KeyChar))
                btnAddParameter_Click(btnAddParameter, new EventArgs());
        }

        #region [ txtDelegateName_KeyPress ]
        private void txtDelegateName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int32 key = Convert.ToInt32(e.KeyChar);
            Boolean validKey = false;

            if (e.KeyChar == '_')
                validKey = true;
            if (13 == key && ((TextBox)sender).TextLength > 0)
            {
                btnInsertDelegate_Click(btnInsertDelegate, new EventArgs());
                validKey = true;
            }
            if (false == validKey)
            {
                if (key < 31)
                    validKey = true;
                else
                {
                    if (key >= 48 && key <= 57 && ((TextBox)sender).SelectionStart > 0)
                        validKey = true;
                    else if ((key >= 65 && key <= 90) || (key >= 97 && key <= 122))
                        validKey = true;
                    else
                        validKey = false;
                }
            }
            if (validKey == false)
                e.KeyChar = char.MinValue;
        }
        #endregion
    }
}