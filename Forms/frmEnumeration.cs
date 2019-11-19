using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnippetGenerator.Forms
{
    public partial class frmEnumeration : Form
    {
        private string strEnum = string.Empty;
        private Int32 initialvalue = 0;
        List<string> mlstConstants = new List<string>();
        List<string> mlstInitValue = new List<string>();

        public string Enum
        {
            get
            {
                return this.strEnum;
            }
        }

        public string EnumName
        {
            get
            {
                return this.txtEnum.Text;
            }
        }

        public frmEnumeration()
        {
            InitializeComponent();
        }

        #region [ txtEnum_KeyPress ]
        private void txtEnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int32 key = Convert.ToInt32(e.KeyChar);
            Boolean validKey = false;

            if (e.KeyChar == '_')
                validKey = true;
            if (13 == key)
            {
                btnAddConstant_Click(btnAddConstant, new EventArgs());
                return;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void btnInsertEnum_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.strEnum = GetEnumText();
            this.Hide();
        }

        private string GetEnumText()
        {
            /* Attributes valid for Enum.
             * Flag
             * Obsolete
             * Serializable
            */

            StringBuilder enumInfo = new StringBuilder(string.Empty);
            if (chkFlagAttributes.Checked)
                enumInfo.Append("[Flags]\n");
            if (chkObsolete.Checked)
                enumInfo.Append("[Obsolete]\n");
            if (chkSerializable.Checked)
                enumInfo.Append("[Serializable]\n");

            enumInfo.Append("public enum " + txtEnum.Text + "\n{ ");
            for (Int32 index = 0; index < mlstConstants.Count; index++)
                enumInfo.Append("\n\t" + mlstConstants[index] + " = " + mlstInitValue[index] + ",");
            return enumInfo.ToString().Substring(0, enumInfo.Length - 1) + "\n}";
        }

        #region [ cboDataType_SelectedIndexChanged ]
        private void cboDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDataType.Text)
            {
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
                default:
                    lblDataTypeDescription.Text = string.Empty;
                    break;
            }
        }
        #endregion

        private void frmEnumeration_Load(object sender, EventArgs e)
        {
            cboDataType.SelectedIndex = 1;
        }

        private void frmEnumeration_FormClosing(object sender, FormClosingEventArgs e)
        {
            mlstConstants.Clear();
            mlstConstants = null;
            mlstInitValue.Clear();
            mlstInitValue = null;
        }

        #region [ EnableConstantFileds ]
        private void EnableConstantFileds(Boolean bEnable)
        {
            lblCosntantName.Enabled = bEnable;
            txtConstantName.Enabled = bEnable;
            lblInitialValue.Enabled = bEnable;
            txtInitialValue.Enabled = bEnable;
            btnNewConstant.Enabled = !bEnable;            
            txtConstantName.Focus();
        }
        #endregion

        #region [ txtInitialValue_KeyPress ]
        private void txtInitialValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int32 key = Convert.ToInt32(e.KeyChar);
            Boolean validKey = false;

            if (13 == key)
            {
                btnAddConstant_Click(btnAddConstant, new EventArgs());
                return;
            }

            if (key < 31)
                validKey = true;
            else
            {
                if (key >= 48 && key <= 57)
                    validKey = true;
                else
                    validKey = false;
            }
            if (validKey == false)
                e.KeyChar = char.MinValue;
        }
        #endregion

         private void btnNewConstant_Click(object sender, EventArgs e)
        {
            EnableConstantFileds(true);
            txtInitialValue.Text = initialvalue.ToString();
        }

        #region [ btnAddConstant_Click ]
        private void btnAddConstant_Click(object sender, EventArgs e)
        {
            mlstConstants.Add(txtConstantName.Text);
            mlstInitValue.Add(txtInitialValue.Text);

            initialvalue = Int32.Parse(txtInitialValue.Text) + 1;

            lstConstantMembers.Items.Add(txtConstantName.Text);
            if (lstConstantMembers.SelectedIndex < 0)
                lstConstantMembers.SelectedIndex = 0;

            txtConstantName.Text = string.Empty;
            txtInitialValue.Text = string.Empty;

            EnableConstantFileds(false);
            btnNewConstant.Focus();
        }
        #endregion

        private void lstConstantMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteConstant.Enabled = lstConstantMembers.SelectedIndex >= 0 ? true : false;
            btnDeleteAllConstants.Enabled = btnDeleteConstant.Enabled;
        }

        private void txtEnum_TextChanged(object sender, EventArgs e)
        {
            btnInsertEnum.Enabled = txtEnum.TextLength > 0 ? true : false;
            this.Text = txtEnum.TextLength > 0 ? "Enum - " + txtEnum.Text : "Enum";
        }

        private void btnDeleteConstant_Click(object sender, EventArgs e)
        {
            Int32 selectedIndex = lstConstantMembers.SelectedIndex;
            lstConstantMembers.Items.RemoveAt(selectedIndex);
            mlstConstants.RemoveAt(selectedIndex);
            mlstInitValue.RemoveAt(selectedIndex);
        }

        private void btnDeleteAllConstants_Click(object sender, EventArgs e)
        {
            mlstConstants.Clear();
            mlstInitValue.Clear();
            lstConstantMembers.Items.Clear();
            btnDeleteConstant.Enabled = false;
            btnDeleteAllConstants.Enabled = false;
            btnNewConstant.Focus();
        }

        private void txtConstantName_TextChanged(object sender, EventArgs e)
        {
            btnAddConstant.Enabled = txtConstantName.TextLength > 0 ? true : false;
        }
    }
}