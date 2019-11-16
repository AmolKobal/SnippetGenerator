using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SnippetGenerator.Forms
{
    public partial class frmConstant : Form
    {
        private string strConstants = string.Empty;
        private List<string> mlstConstantName = new List<string>();
        private List<string> mlstDataType = new List<string>();
        private List<string> mlstModifiers = new List<string>();
        private List<string> mlstInitValue = new List<string>();

        private string strAccessModifier = "public";

        private Int32 intConstantCount = 0;

        public string Constants
        {
            get
            {
                return this.strConstants;
            }
        }

        public frmConstant()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void btnInsertconstants_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            strConstants = GetConstants();
            this.Hide();
        }

        private string GetConstants()
        {
            StringBuilder sbConstants = new StringBuilder(string.Empty);
            for (Int32 index = 0; index < intConstantCount; index++)
            {
                sbConstants.Append(mlstModifiers[index] + " ");
                sbConstants.Append(mlstDataType[index] + " ");
                sbConstants.Append(mlstConstantName[index] + " ");
                sbConstants.Append(" = " + mlstInitValue[index] + ";\n");
            }            
            return sbConstants.ToString();
        }

        #region [ cboDataType_SelectedIndexChanged ]
        private void cboDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDataTypeDescription.ForeColor = Color.Black;
            txtInitialValue.Visible = true;
            cboInitialValue.Visible = false;
            txtInitialValue.Enabled = true;
            switch (cboDataType.Text)
            {
                case "byte":
                    lblDataTypeDescription.Text = "An 8-bit unsigned integer.";
                    txtInitialValue.Text = "0";
                    break;
                case "sbyte":
                    lblDataTypeDescription.Text = "An 8-bit signed integer.";
                    txtInitialValue.Text = "0";
                    break;
                case "short":
                    lblDataTypeDescription.Text = "A 16-bit signed integer.";
                    txtInitialValue.Text = "0";
                    break;
                case "int":
                    lblDataTypeDescription.Text = "A 32-bit signed integer.";
                    txtInitialValue.Text = "0";
                    break;
                case "long":
                    lblDataTypeDescription.Text = "A 64-bit signed integer.";
                    txtInitialValue.Text = "0L";
                    break;
                case "ushort":
                    lblDataTypeDescription.Text = "A 16-bit unsigned integer. Not CLS-compliant.";
                    lblDataTypeDescription.ForeColor = Color.Red;
                    txtInitialValue.Text = "0";
                    break;
                case "uint":
                    lblDataTypeDescription.Text = "A 32-bit unsigned integer. Not CLS-compliant.";
                    lblDataTypeDescription.ForeColor = Color.Red;
                    txtInitialValue.Text = "0";
                    break;
                case "ulong":
                    lblDataTypeDescription.Text = "A 64-bit unsigned integer. Not CLS-compliant.";
                    lblDataTypeDescription.ForeColor = Color.Red;
                    txtInitialValue.Text = "0";
                    break;
                case "float":
                    lblDataTypeDescription.Text = "A single-precision (32-bit) floating-point number.";
                    txtInitialValue.Text = "0.0F";
                    break;
                case "double":
                    lblDataTypeDescription.Text = "A double-precision (64-bit) floating-point number.";
                    txtInitialValue.Text = "0.0D";
                    break;
                case "bool":
                    lblDataTypeDescription.Text = "A Boolean value (true or false).";
                    cboInitialValue.Visible = true;
                    cboInitialValue.SelectedIndex = 0;
                    txtInitialValue.Visible = false;
                    break;
                case "char":
                    lblDataTypeDescription.Text = "A Unicode (16-bit) character.";
                    txtInitialValue.Text = "\0";
                    break;
                case "decimal":
                    lblDataTypeDescription.Text = "A decimal (128-bit) value.";
                    txtInitialValue.Text = "0.0M";
                    break;
                case "IntPtr":
                    lblDataTypeDescription.Text = "A signed integer whose size depends on the underlying platform " +
                                                  "(a 32-bit value on a 32-bit platform and a 64-bit value on a 64-bit platform)." +
                                                  "Not CLS-compliant.";
                    lblDataTypeDescription.ForeColor = Color.Red;
                    txtInitialValue.Enabled = false;
                    break;
                case "UIntPtr":
                    lblDataTypeDescription.Text = "An unsigned integer whose size depends on the underlying platform " +
                                                  "(a 32- bit value on a 32-bit platform and a 64-bit value on a 64-bit platform)." +
                                                  "Not CLS-compliant.";
                    lblDataTypeDescription.ForeColor = Color.Red;
                    txtInitialValue.Text = string.Empty;
                    txtInitialValue.Enabled = false;
                    break;
                case "object":
                    lblDataTypeDescription.Text = "The root of the object hierarchy.";
                    txtInitialValue.Text = "null";
                    break;
                case "string":
                    lblDataTypeDescription.Text = "An immutable, fixed-length string of Unicode characters.";
                    txtInitialValue.Text = string.Empty;
                    break;
                default:
                    lblDataTypeDescription.Text = string.Empty;
                    txtInitialValue.Enabled = false;
                    break;
            }
        }
        #endregion

        private void lstConstants_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInsertConstants.Enabled = lstConstants.Items.Count > 0 ? true : false;            
            btnDeleteConstant.Enabled = lstConstants.SelectedIndex >= 0 ? true : false;
            btnDeleteAllConstants.Enabled = btnDeleteConstant.Enabled;
        }

        #region [ btnDelete_Click ]
        private void btnDeleteConstant_Click(object sender, EventArgs e)
        {
            Int32 selectedIndex = lstConstants.SelectedIndex;
            lstConstants.Items.RemoveAt(lstConstants.SelectedIndex);
            lstConstants.Focus();
            if (lstConstants.Items.Count == 0)
            {
                btnDeleteConstant.Enabled = false;
                btnDeleteAllConstants.Enabled = false;
                txtConstantName.Focus();
            }
            if (selectedIndex >= lstConstants.Items.Count)
                lstConstants.SelectedIndex = selectedIndex - 1;
            else
                lstConstants.SelectedIndex = selectedIndex;

            intConstantCount--;
            mlstConstantName.RemoveAt(selectedIndex);
            mlstDataType.RemoveAt(selectedIndex);
            mlstInitValue.RemoveAt(selectedIndex);
            mlstModifiers.RemoveAt(selectedIndex);
        }
        #endregion

        #region [ btnDeleteAll_Click ]
        private void btnDeleteAllConstants_Click(object sender, EventArgs e)
        {
            lstConstants.Items.Clear();
            btnDeleteConstant.Enabled = false;
            btnDeleteAllConstants.Enabled = false;
            txtConstantName.Focus();
        }
        #endregion

        private void frmConstant_Load(object sender, EventArgs e)
        {
            cboDataType.SelectedIndex = 0;
        }

        private void txtConstantName_TextChanged(object sender, EventArgs e)
        {
            btnAddConstant.Enabled = txtConstantName.TextLength > 0 ? true : false;
        }

        #region [ btnAddConstant_Click ]
        private void btnAddConstant_Click(object sender, EventArgs e)
        {
            if (!lstConstants.Items.Contains(txtConstantName.Text))
            {
                lstConstants.Items.Add(txtConstantName.Text);
                mlstConstantName.Add(txtConstantName.Text);
                mlstDataType.Add(cboDataType.Text);
                if (cboDataType.Text.Equals("bool"))
                    mlstInitValue.Add(cboInitialValue.Text);
                else
                    mlstInitValue.Add(txtInitialValue.Text);
                mlstModifiers.Add(strAccessModifier);
                intConstantCount++;
                if (lstConstants.SelectedIndex < 0)
                    lstConstants.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Constant " + txtConstantName.Text + " already added.");
            ClearFields();
        }
        #endregion

        #region [ ClearFields ]
        private void ClearFields()
        {
            txtConstantName.Text = string.Empty;
            cboDataType.SelectedIndex = 0;            
            txtConstantName.Focus();
        }
        #endregion

        #region [ frmConstant_FormClosing ]
        private void frmConstant_FormClosing(object sender, FormClosingEventArgs e)
        {
            mlstConstantName.Clear();
            mlstConstantName = null;
            mlstDataType.Clear();
            mlstDataType = null;
            mlstInitValue.Clear();
            mlstInitValue = null;
            mlstModifiers.Clear();
            mlstModifiers = null;
        }
        #endregion

        #region [ TextBox_KeyPress ]
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int32 key = Convert.ToInt32(e.KeyChar);
            Boolean validKey = false;

            if (e.KeyChar == '_')
                validKey = true;
            //if (13 == key)
            //{
            //    btnAddInterface_Click(btnAddInterface, new EventArgs());
            //    validKey = true;
            //}
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

        private void radioButtonClick_Click(object sender, EventArgs e)
        {
            strAccessModifier = ((RadioButton)sender).Text;
        }
    }
}