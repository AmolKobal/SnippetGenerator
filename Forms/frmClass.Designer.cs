namespace SnippetGenerator.Forms
{
    partial class frmClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClass));
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblBaseClass = new System.Windows.Forms.Label();
            this.txtBaseClassName = new System.Windows.Forms.TextBox();
            this.lblInterfaceNames = new System.Windows.Forms.Label();
            this.lstInterfaces = new System.Windows.Forms.ListBox();
            this.btnAddInterface = new System.Windows.Forms.Button();
            this.btnDeleteInterface = new System.Windows.Forms.Button();
            this.btnUpInterface = new System.Windows.Forms.Button();
            this.btnDownInterface = new System.Windows.Forms.Button();
            this.btnDeleteAllInterfaces = new System.Windows.Forms.Button();
            this.txtInterfaceName = new System.Windows.Forms.TextBox();
            this.btnInsertClass = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOtherModifier = new System.Windows.Forms.ComboBox();
            this.cboAccessModifier = new System.Windows.Forms.ComboBox();
            this.lblOtherModifier = new System.Windows.Forms.Label();
            this.lblAccessModifier = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.imglstClass = new System.Windows.Forms.ImageList(this.components);
            this.webClassInfo = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkGenerateDefaultConstructor = new System.Windows.Forms.CheckBox();
            this.chkInheritance = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblClassName.Location = new System.Drawing.Point(8, 13);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(74, 13);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "Class Name:";
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(112, 9);
            this.txtClassName.MaxLength = 100;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(350, 22);
            this.txtClassName.TabIndex = 1;
            this.txtClassName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtClassName.TextChanged += new System.EventHandler(this.txtClassName_TextChanged);
            // 
            // lblBaseClass
            // 
            this.lblBaseClass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseClass.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblBaseClass.Location = new System.Drawing.Point(8, 7);
            this.lblBaseClass.Name = "lblBaseClass";
            this.lblBaseClass.Size = new System.Drawing.Size(106, 36);
            this.lblBaseClass.TabIndex = 9;
            this.lblBaseClass.Text = "Base Class : (Inherited From)";
            // 
            // txtBaseClassName
            // 
            this.txtBaseClassName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseClassName.Location = new System.Drawing.Point(112, 7);
            this.txtBaseClassName.MaxLength = 100;
            this.txtBaseClassName.Name = "txtBaseClassName";
            this.txtBaseClassName.Size = new System.Drawing.Size(350, 22);
            this.txtBaseClassName.TabIndex = 10;
            this.txtBaseClassName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblInterfaceNames
            // 
            this.lblInterfaceNames.AutoSize = true;
            this.lblInterfaceNames.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterfaceNames.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblInterfaceNames.Location = new System.Drawing.Point(8, 42);
            this.lblInterfaceNames.Name = "lblInterfaceNames";
            this.lblInterfaceNames.Size = new System.Drawing.Size(203, 13);
            this.lblInterfaceNames.TabIndex = 11;
            this.lblInterfaceNames.Text = "Names of Interfaces to implement:";
            // 
            // lstInterfaces
            // 
            this.lstInterfaces.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInterfaces.FormattingEnabled = true;
            this.lstInterfaces.ItemHeight = 14;
            this.lstInterfaces.Location = new System.Drawing.Point(8, 93);
            this.lstInterfaces.Name = "lstInterfaces";
            this.lstInterfaces.Size = new System.Drawing.Size(373, 116);
            this.lstInterfaces.TabIndex = 14;
            this.lstInterfaces.SelectedIndexChanged += new System.EventHandler(this.lstInterfaces_SelectedIndexChanged);
            // 
            // btnAddInterface
            // 
            this.btnAddInterface.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddInterface.Enabled = false;
            this.btnAddInterface.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInterface.Location = new System.Drawing.Point(387, 57);
            this.btnAddInterface.Name = "btnAddInterface";
            this.btnAddInterface.Size = new System.Drawing.Size(75, 24);
            this.btnAddInterface.TabIndex = 13;
            this.btnAddInterface.Text = "Add";
            this.btnAddInterface.UseVisualStyleBackColor = true;
            this.btnAddInterface.Click += new System.EventHandler(this.btnAddInterface_Click);
            // 
            // btnDeleteInterface
            // 
            this.btnDeleteInterface.Enabled = false;
            this.btnDeleteInterface.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInterface.Location = new System.Drawing.Point(387, 154);
            this.btnDeleteInterface.Name = "btnDeleteInterface";
            this.btnDeleteInterface.Size = new System.Drawing.Size(75, 24);
            this.btnDeleteInterface.TabIndex = 17;
            this.btnDeleteInterface.Text = "Delete";
            this.btnDeleteInterface.UseVisualStyleBackColor = true;
            this.btnDeleteInterface.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpInterface
            // 
            this.btnUpInterface.Enabled = false;
            this.btnUpInterface.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpInterface.Location = new System.Drawing.Point(387, 92);
            this.btnUpInterface.Name = "btnUpInterface";
            this.btnUpInterface.Size = new System.Drawing.Size(75, 24);
            this.btnUpInterface.TabIndex = 15;
            this.btnUpInterface.Text = "Up";
            this.btnUpInterface.UseVisualStyleBackColor = true;
            this.btnUpInterface.Click += new System.EventHandler(this.btnUpInterface_Click);
            // 
            // btnDownInterface
            // 
            this.btnDownInterface.Enabled = false;
            this.btnDownInterface.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownInterface.Location = new System.Drawing.Point(387, 123);
            this.btnDownInterface.Name = "btnDownInterface";
            this.btnDownInterface.Size = new System.Drawing.Size(75, 24);
            this.btnDownInterface.TabIndex = 16;
            this.btnDownInterface.Text = "Down";
            this.btnDownInterface.UseVisualStyleBackColor = true;
            this.btnDownInterface.Click += new System.EventHandler(this.btnDownInterface_Click);
            // 
            // btnDeleteAllInterfaces
            // 
            this.btnDeleteAllInterfaces.Enabled = false;
            this.btnDeleteAllInterfaces.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllInterfaces.Location = new System.Drawing.Point(387, 185);
            this.btnDeleteAllInterfaces.Name = "btnDeleteAllInterfaces";
            this.btnDeleteAllInterfaces.Size = new System.Drawing.Size(75, 24);
            this.btnDeleteAllInterfaces.TabIndex = 18;
            this.btnDeleteAllInterfaces.Text = "Delete All";
            this.btnDeleteAllInterfaces.UseVisualStyleBackColor = true;
            this.btnDeleteAllInterfaces.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // txtInterfaceName
            // 
            this.txtInterfaceName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterfaceName.Location = new System.Drawing.Point(8, 58);
            this.txtInterfaceName.MaxLength = 100;
            this.txtInterfaceName.Name = "txtInterfaceName";
            this.txtInterfaceName.Size = new System.Drawing.Size(373, 22);
            this.txtInterfaceName.TabIndex = 12;
            this.txtInterfaceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtInterfaceName.TextChanged += new System.EventHandler(this.txtInterfaceName_TextChanged);
            // 
            // btnInsertClass
            // 
            this.btnInsertClass.Enabled = false;
            this.btnInsertClass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertClass.Location = new System.Drawing.Point(486, 12);
            this.btnInsertClass.Name = "btnInsertClass";
            this.btnInsertClass.Size = new System.Drawing.Size(82, 24);
            this.btnInsertClass.TabIndex = 21;
            this.btnInsertClass.Text = "&Insert";
            this.btnInsertClass.UseVisualStyleBackColor = true;
            this.btnInsertClass.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(486, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 24);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(8, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Note: Class, Interface names must start with alphabet or underscore.";
            // 
            // cboOtherModifier
            // 
            this.cboOtherModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOtherModifier.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOtherModifier.FormattingEnabled = true;
            this.cboOtherModifier.Items.AddRange(new object[] {
            "(none)",
            "abstract",
            "partial",
            "sealed",
            "static"});
            this.cboOtherModifier.Location = new System.Drawing.Point(351, 37);
            this.cboOtherModifier.Name = "cboOtherModifier";
            this.cboOtherModifier.Size = new System.Drawing.Size(111, 22);
            this.cboOtherModifier.Sorted = true;
            this.cboOtherModifier.TabIndex = 5;
            // 
            // cboAccessModifier
            // 
            this.cboAccessModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccessModifier.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAccessModifier.FormattingEnabled = true;
            this.cboAccessModifier.Items.AddRange(new object[] {
            "public",
            "protected",
            "internal",
            "protcted internal",
            "private"});
            this.cboAccessModifier.Location = new System.Drawing.Point(112, 37);
            this.cboAccessModifier.Name = "cboAccessModifier";
            this.cboAccessModifier.Size = new System.Drawing.Size(139, 22);
            this.cboAccessModifier.TabIndex = 3;
            // 
            // lblOtherModifier
            // 
            this.lblOtherModifier.AutoSize = true;
            this.lblOtherModifier.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherModifier.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblOtherModifier.Location = new System.Drawing.Point(257, 41);
            this.lblOtherModifier.Name = "lblOtherModifier";
            this.lblOtherModifier.Size = new System.Drawing.Size(91, 13);
            this.lblOtherModifier.TabIndex = 4;
            this.lblOtherModifier.Text = "Other Modifier:";
            // 
            // lblAccessModifier
            // 
            this.lblAccessModifier.AutoSize = true;
            this.lblAccessModifier.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessModifier.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAccessModifier.Location = new System.Drawing.Point(8, 39);
            this.lblAccessModifier.Name = "lblAccessModifier";
            this.lblAccessModifier.Size = new System.Drawing.Size(98, 13);
            this.lblAccessModifier.TabIndex = 2;
            this.lblAccessModifier.Text = "Access Modifier:";
            this.lblAccessModifier.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparator.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSeparator.Location = new System.Drawing.Point(473, 9);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(2, 320);
            this.lblSeparator.TabIndex = 19;
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.ImageIndex = 0;
            this.btnInfo.ImageList = this.imglstClass;
            this.btnInfo.Location = new System.Drawing.Point(504, 316);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(64, 24);
            this.btnInfo.TabIndex = 23;
            this.btnInfo.Text = "  &Hide";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // imglstClass
            // 
            this.imglstClass.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstClass.ImageStream")));
            this.imglstClass.TransparentColor = System.Drawing.Color.White;
            this.imglstClass.Images.SetKeyName(0, "Hide.bmp");
            this.imglstClass.Images.SetKeyName(1, "Show.bmp");
            // 
            // webClassInfo
            // 
            this.webClassInfo.Location = new System.Drawing.Point(9, 355);
            this.webClassInfo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webClassInfo.Name = "webClassInfo";
            this.webClassInfo.Size = new System.Drawing.Size(556, 212);
            this.webClassInfo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(8, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 215);
            this.label2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(566, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 215);
            this.label3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(8, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 2);
            this.label4.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(8, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(560, 2);
            this.label5.TabIndex = 24;
            // 
            // chkGenerateDefaultConstructor
            // 
            this.chkGenerateDefaultConstructor.AutoSize = true;
            this.chkGenerateDefaultConstructor.Checked = true;
            this.chkGenerateDefaultConstructor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenerateDefaultConstructor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenerateDefaultConstructor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkGenerateDefaultConstructor.Location = new System.Drawing.Point(8, 65);
            this.chkGenerateDefaultConstructor.Name = "chkGenerateDefaultConstructor";
            this.chkGenerateDefaultConstructor.Size = new System.Drawing.Size(193, 17);
            this.chkGenerateDefaultConstructor.TabIndex = 6;
            this.chkGenerateDefaultConstructor.Text = "Generate Default Constructor";
            this.chkGenerateDefaultConstructor.UseVisualStyleBackColor = true;
            // 
            // chkInheritance
            // 
            this.chkInheritance.AutoSize = true;
            this.chkInheritance.Checked = true;
            this.chkInheritance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInheritance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInheritance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkInheritance.Location = new System.Drawing.Point(8, 92);
            this.chkInheritance.Name = "chkInheritance";
            this.chkInheritance.Size = new System.Drawing.Size(92, 17);
            this.chkInheritance.TabIndex = 7;
            this.chkInheritance.Text = "Inheritance";
            this.chkInheritance.UseVisualStyleBackColor = true;
            this.chkInheritance.CheckedChanged += new System.EventHandler(this.chkInheritance_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBaseClassName);
            this.panel1.Controls.Add(this.lstInterfaces);
            this.panel1.Controls.Add(this.lblBaseClass);
            this.panel1.Controls.Add(this.btnDeleteInterface);
            this.panel1.Controls.Add(this.btnAddInterface);
            this.panel1.Controls.Add(this.btnDeleteAllInterfaces);
            this.panel1.Controls.Add(this.txtInterfaceName);
            this.panel1.Controls.Add(this.lblInterfaceNames);
            this.panel1.Controls.Add(this.btnUpInterface);
            this.panel1.Controls.Add(this.btnDownInterface);
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 215);
            this.panel1.TabIndex = 8;
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(577, 576);
            this.Controls.Add(this.chkInheritance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkGenerateDefaultConstructor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOtherModifier);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboAccessModifier);
            this.Controls.Add(this.btnInsertClass);
            this.Controls.Add(this.lblOtherModifier);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.lblAccessModifier);
            this.Controls.Add(this.webClassInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class";
            this.Load += new System.EventHandler(this.frmClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblBaseClass;
        private System.Windows.Forms.TextBox txtBaseClassName;
        private System.Windows.Forms.Label lblInterfaceNames;
        private System.Windows.Forms.ListBox lstInterfaces;
        private System.Windows.Forms.Button btnAddInterface;
        private System.Windows.Forms.Button btnDeleteInterface;
        private System.Windows.Forms.Button btnUpInterface;
        private System.Windows.Forms.Button btnDownInterface;
        private System.Windows.Forms.Button btnDeleteAllInterfaces;
        private System.Windows.Forms.TextBox txtInterfaceName;
        private System.Windows.Forms.Button btnInsertClass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOtherModifier;
        private System.Windows.Forms.ComboBox cboAccessModifier;
        private System.Windows.Forms.Label lblOtherModifier;
        private System.Windows.Forms.Label lblAccessModifier;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ImageList imglstClass;
        private System.Windows.Forms.WebBrowser webClassInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkGenerateDefaultConstructor;
        private System.Windows.Forms.CheckBox chkInheritance;
        private System.Windows.Forms.Panel panel1;
    }
}