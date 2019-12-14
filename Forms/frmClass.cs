using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SnippetGenerator.Forms;

namespace SnippetGenerator.Forms
{
    public partial class frmClass : Form
    {
        private string strClass = string.Empty;

        private string strAccessModifier = "public";
        private string strOtherModifier = string.Empty;

        public frmClass()
        {
            InitializeComponent();
        }

        public string ClassText
        {
            get
            {
                return this.strClass;
            }
        }

        public string ClassName
        {
            get
            {
                return this.txtClassName.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.strClass = SetClassText();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        #region [ GetClassText ]
        private string SetClassText()
        {
            StringBuilder sbClass = new StringBuilder(string.Empty);

            sbClass.Append(strAccessModifier + " " + strOtherModifier + " class " + txtClassName.Text);

            if (chkInheritance.Checked)
            {
                if (!txtBaseClassName.Text.Equals(String.Empty))
                    sbClass.Append(" : " + txtBaseClassName.Text + ", ");

                if (lstInterfaces.Items.Count > 0 && sbClass.ToString().IndexOf(":") < 0)
                    sbClass.Append(" : ");
                for (Int32 index = 0; index < lstInterfaces.Items.Count; index++)
                {
                    if (!lstInterfaces.Items[index].ToString().Trim().Equals(string.Empty))
                        sbClass.Append(lstInterfaces.Items[index] + ", ");
                }
                sbClass.Replace(",", "", sbClass.Length - 2, 1);
            }
            sbClass.Append("\n{");
            if (chkGenerateDefaultConstructor.Checked)
                sbClass.Append("\n\t" + "public " + txtClassName.Text + "()\n\t{\n\t}");
            sbClass.Append("\n}");
            return sbClass.ToString();
        }
        #endregion

        #region [ txtClassName_TextChanged ]
        private void txtClassName_TextChanged(object sender, EventArgs e)
        {
            btnInsertClass.Enabled = txtClassName.Text.Length > 0 ? true : false;
            if (txtClassName.Text.Length > 0)
                this.Text = "Class - " + txtClassName.Text;
            else
                this.Text = "Class";
        }
        #endregion

        private void txtInterfaceName_TextChanged(object sender, EventArgs e)
        {
            btnAddInterface.Enabled = txtInterfaceName.Text.Length > 0 ? true : false;
        }

        #region [ lstInterfaces_SelectedIndexChanged ]
        private void lstInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpInterface.Enabled = lstInterfaces.SelectedIndex > 0 ? true : false;
            btnDownInterface.Enabled = lstInterfaces.SelectedIndex < (lstInterfaces.Items.Count - 1) ? true : false;

            btnDeleteInterface.Enabled = lstInterfaces.SelectedIndex >= 0 ? true : false;
            btnDeleteAllInterfaces.Enabled = btnDeleteAllInterfaces.Enabled;
        }
        #endregion

        #region [ btnAddInterface_Click ]
        private void btnAddInterface_Click(object sender, EventArgs e)
        {
            if (!lstInterfaces.Items.Contains(txtInterfaceName.Text))
            {
                lstInterfaces.Items.Add(txtInterfaceName.Text);
                txtInterfaceName.Text = string.Empty;
                txtInterfaceName.Focus();
                if (lstInterfaces.SelectedIndex < 0)
                    lstInterfaces.SelectedIndex = 0;
                if (lstInterfaces.Items.Count == 1)
                {
                    btnDeleteInterface.Enabled = true;
                    btnDeleteAllInterfaces.Enabled = true;
                }
                else
                {
                    btnUpInterface.Enabled = lstInterfaces.SelectedIndex > 0 ? true : false;
                    btnDownInterface.Enabled = lstInterfaces.SelectedIndex < (lstInterfaces.Items.Count - 1) ? true : false;
                }
            }
            else
            {
                MessageBox.Show("Interface '" + txtInterfaceName.Text + "' already implemented.",
                                "Implement Intrerface", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region [ txtName_KeyPress ]
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int32 key = Convert.ToInt32(e.KeyChar);
            Boolean validKey = false;

            if (e.KeyChar == '_')
                validKey = true;
            if (13 == key && ((TextBox)sender).TextLength > 0)
            {
                if (!((TextBox)sender).Name.Equals("txtBaseClassName"))
                    btnAddInterface_Click(btnAddInterface, new EventArgs());
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

        #region [ btnDelete_Click ]
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 selectedIndex = lstInterfaces.SelectedIndex;
            lstInterfaces.Items.RemoveAt(lstInterfaces.SelectedIndex);
            lstInterfaces.Focus();
            if (lstInterfaces.Items.Count == 0)
            {
                btnUpInterface.Enabled = false;
                btnDownInterface.Enabled = false;
                btnDeleteInterface.Enabled = false;
                btnDeleteAllInterfaces.Enabled = false;
                txtInterfaceName.Focus();
            }
            if (selectedIndex >= lstInterfaces.Items.Count)
                lstInterfaces.SelectedIndex = selectedIndex - 1;
            else
                lstInterfaces.SelectedIndex = selectedIndex;
        }
        #endregion

        #region [ btnDeleteAll_Click ]
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            lstInterfaces.Items.Clear();
            btnUpInterface.Enabled = false;
            btnDownInterface.Enabled = false;
            btnDeleteInterface.Enabled = false;
            btnDeleteAllInterfaces.Enabled = false;
            txtInterfaceName.Focus();
        }
        #endregion

        private void radioAccessModifier_CheckedChanged(object sender, EventArgs e)
        {
            strAccessModifier = ((RadioButton)sender).Text;
        }

        private void radioOtherModifiers_CheckedChanged(object sender, EventArgs e)
        {
            strOtherModifier = ((RadioButton)sender).Text;
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            webClassInfo.Url = new Uri(Application.StartupPath + "\\Info\\class.htm");
            cboAccessModifier.SelectedIndex = 0;
            cboOtherModifier.SelectedIndex = 0;
            chkInheritance.Checked = false;
        }

        #region [ btnUpInterface_Click ]
        private void btnUpInterface_Click(object sender, EventArgs e)
        {
            if (lstInterfaces.SelectedIndex > 0)
            {
                Int32 selectedIndex = lstInterfaces.SelectedIndex;
                string strInterface = lstInterfaces.Items[selectedIndex].ToString();
                lstInterfaces.Items.RemoveAt(selectedIndex);
                lstInterfaces.Items.Insert(selectedIndex - 1, strInterface);
                lstInterfaces.SelectedIndex = selectedIndex - 1;
            }
        }
        #endregion

        #region [ btnDownInterface_Click ]
        private void btnDownInterface_Click(object sender, EventArgs e)
        {
            if (lstInterfaces.SelectedIndex < lstInterfaces.Items.Count - 1)
            {
                Int32 selectedIndex = lstInterfaces.SelectedIndex;
                string strInterface = lstInterfaces.Items[selectedIndex].ToString();
                lstInterfaces.Items.RemoveAt(selectedIndex);
                lstInterfaces.Items.Insert(selectedIndex + 1, strInterface);
                lstInterfaces.SelectedIndex = selectedIndex + 1;
            }
        }
        #endregion

        #region [ btnInfo_Click ]
        private void btnInfo_Click(object sender, EventArgs e)
        {
            Button b = ((Button)sender);
            switch (b.Text)
            {
                case "  &Hide":
                    this.Height = 400;
                    b.Text = "  &Show";
                    b.ImageIndex = 1;
                    break;
                case "  &Show":
                    this.Height = 766;
                    b.Text = "  &Hide";
                    b.ImageIndex = 0;
                    break;
            }
        }
        #endregion

        private void chkInheritance_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = chkInheritance.Checked;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (webClassInfo.CanGoBack)
            {
                webClassInfo.GoBack();
            }
        }

        private void WebClassInfo_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            btnBack.Enabled = webClassInfo.CanGoBack;
        }
    }
}