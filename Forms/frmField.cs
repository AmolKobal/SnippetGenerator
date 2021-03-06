using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnippetGenerator.Forms
{
    public partial class frmField : Form
    {
        private string strField = string.Empty;
        private string strFieldAccessModifier = "private";
        private string strFieldOtherModifier = string.Empty;
        
        public string Field
        {
            get
            {
                return this.strField;
            }
        }
        public frmField()
        {
            InitializeComponent();
        }

        private void txtFieldName_TextChanged(object sender, EventArgs e)
        {
            btnInsertField.Enabled = txtFieldName.TextLength > 0 ? true : false;
            this.Text = txtFieldName.TextLength > 0 ? "Field - " + txtFieldName.Text : "Field";
        }

        #region [ cboDataType_SelectedIndexChanged ]
        private void cboDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDataTypeDescription.ForeColor = Color.Black;
            txtInitialValue.Visible = true;
            cboInitialValue.Visible = false;            
            txtInitialValue.Enabled = true;
            txtOtherDataType.Visible = false;
            switch (cboDataType.Text)
            {   
                case "(Other)":
                    lblDataTypeDescription.Text = "A Class, Struct or Enum data type.";
                    txtOtherDataType.Visible = true;
                    txtOtherDataType.Focus();
                    break;
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

        private void radioFieldAccessModifier_Click(object sender, EventArgs e)
        {
            strFieldAccessModifier = ((RadioButton)sender).Text;
        }

        private void radioFieldOtherModifier_Click(object sender, EventArgs e)
        {
            strFieldOtherModifier = ((RadioButton)sender).Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        #region [ btnInsertField_Click ]
        private void btnInsertField_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (true == GetField())
                this.Close();
            else
            {
                txtInitialValue.SelectionStart = 0;
                txtInitialValue.SelectionLength = txtInitialValue.TextLength;
                txtInitialValue.Focus();
            }
        }
        #endregion

        #region [ GetField ]
        private Boolean GetField()
        {
            string fieldInfo = string.Empty;
            if (cboAccessModifier.SelectedIndex == 0)
                fieldInfo = "private";
            else
                fieldInfo = cboAccessModifier.Text;
            if (cboOtherDataType.SelectedIndex > 0)
                fieldInfo += " " + cboOtherDataType.Text;
            fieldInfo += " " + cboDataType.Text + " " + txtFieldName.Text;

            switch (cboDataType.Text)
            {
                case "byte":
                    byte byteVal;
                    if (true == Byte.TryParse(txtInitialValue.Text, out byteVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Byte value must be in range from 0 to 255.");                        
                        return false;
                    }                        
                    break;
                case "sbyte":
                    sbyte sbyteVal;
                    if (true == SByte.TryParse(txtInitialValue.Text, out sbyteVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("SByte value must be in range from -128 to 127.");
                        return false;
                    }
                    break;
                case "short":
                    short shortVal;
                    if (true == short.TryParse(txtInitialValue.Text, out shortVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from -32,768 to 32,767.");
                        return false;
                    }
                    break;
                case "int":
                    int intVal;
                    if (true == int.TryParse(txtInitialValue.Text, out intVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from -2,147,483,648 to 2,147,483,647.");
                        return false;
                    }
                    break;
                case "long":
                    int longVal;
                    if (true == int.TryParse(txtInitialValue.Text, out longVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.");
                        return false;
                    } break;
                case "ushort":
                    int ushortVal;
                    if (true == int.TryParse(txtInitialValue.Text, out ushortVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from 0 to 65,535.");
                        return false;
                    } break;
                case "uint":
                    int uintVal;
                    if (true == int.TryParse(txtInitialValue.Text, out uintVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from 0 to 4,294,967,295.");
                        return false;
                    } break;
                case "ulong":
                    int ulongVal;
                    if (true == int.TryParse(txtInitialValue.Text, out ulongVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from 0 to 18,446,744,073,709,551,615.");
                        return false;
                    } 
                    break;
                case "float":
                    int floatVal;
                    if (true == int.TryParse(txtInitialValue.Text, out floatVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from ±1.5e−45 to ±3.4e38.");
                        return false;
                    } break;
                case "double":
                    int doubleVal;
                    if (true == int.TryParse(txtInitialValue.Text, out doubleVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from ±5.0e−324 to ±1.7e308.");
                        return false;
                    } break;
                case "bool":
                    fieldInfo += " = " + cboInitialValue.Text + ";";
                    break;
                case "char":
                    int charVal;
                    if (true == int.TryParse(txtInitialValue.Text, out charVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from U+0000 to U+ffff i.e. from 0 to 65,535.");
                        return false;
                    } break;
                case "decimal":
                    int decimalVal;
                    if (true == int.TryParse(txtInitialValue.Text, out decimalVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from ±1.0 × 10e−28 to ±7.9 × 10e28.");
                        return false;
                    } break;               
                case "object":
                    int objVal;
                    if (true == int.TryParse(txtInitialValue.Text, out objVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from -2,147,483,648 to 2,147,483,647.");
                        return false;
                    } break;
                case "string":
                    int stringVal;
                    if (true == int.TryParse(txtInitialValue.Text, out stringVal))
                        fieldInfo += " = " + txtInitialValue.Text + ";";
                    else
                    {
                        MessageBox.Show("Short value must be in range from -2,147,483,648 to 2,147,483,647.");
                        return false;
                    } break;
                default:
                    break;
            }
            this.strField = fieldInfo;
            return true;
        }
        #endregion

        private void radioOtherNone_Click(object sender, EventArgs e)
        {
            strFieldOtherModifier = string.Empty;
        }

        private void frmField_Load(object sender, EventArgs e)
        {
            cboDataType.Text = "int";
            cboAccessModifier.SelectedIndex = 0;
            cboOtherDataType.SelectedIndex = 0;
            txtFieldName.Focus();
        }

        #region [ txtFieldName_KeyPress ]
        private void txtFieldName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int32 key = Convert.ToInt32(e.KeyChar);
            Boolean validKey = false;

            if (e.KeyChar == '_')
                validKey = true;
            //if (13 == key)
            //{
            //    btnAdd(btnAddInterface, new EventArgs());
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
    }
}