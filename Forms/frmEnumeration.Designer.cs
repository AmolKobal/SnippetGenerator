namespace SnippetGenerator.Forms
{
    partial class frmEnumeration
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
            this.lblEnumName = new System.Windows.Forms.Label();
            this.txtEnum = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsertEnum = new System.Windows.Forms.Button();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.lblDataTypeDescription = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.btnNewConstant = new System.Windows.Forms.Button();
            this.lblCosntantName = new System.Windows.Forms.Label();
            this.txtConstantName = new System.Windows.Forms.TextBox();
            this.lblInitialValue = new System.Windows.Forms.Label();
            this.txtInitialValue = new System.Windows.Forms.TextBox();
            this.btnAddConstant = new System.Windows.Forms.Button();
            this.lblSeparator1 = new System.Windows.Forms.Label();
            this.chkFlagAttributes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConstantMembers = new System.Windows.Forms.Label();
            this.lstConstantMembers = new System.Windows.Forms.ListBox();
            this.btnDeleteConstant = new System.Windows.Forms.Button();
            this.btnDeleteAllConstants = new System.Windows.Forms.Button();
            this.chkObsolete = new System.Windows.Forms.CheckBox();
            this.chkSerializable = new System.Windows.Forms.CheckBox();
            this.grpboxAttributes = new System.Windows.Forms.GroupBox();
            this.grpboxAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnumName
            // 
            this.lblEnumName.AutoSize = true;
            this.lblEnumName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnumName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEnumName.Location = new System.Drawing.Point(12, 16);
            this.lblEnumName.Name = "lblEnumName";
            this.lblEnumName.Size = new System.Drawing.Size(76, 13);
            this.lblEnumName.TabIndex = 0;
            this.lblEnumName.Text = "Enum Name:";
            // 
            // txtEnum
            // 
            this.txtEnum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnum.Location = new System.Drawing.Point(90, 12);
            this.txtEnum.MaxLength = 100;
            this.txtEnum.Name = "txtEnum";
            this.txtEnum.Size = new System.Drawing.Size(297, 22);
            this.txtEnum.TabIndex = 1;
            this.txtEnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnum_KeyPress);
            this.txtEnum.TextChanged += new System.EventHandler(this.txtEnum_TextChanged);
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNote.Location = new System.Drawing.Point(12, 398);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(225, 30);
            this.lblNote.TabIndex = 21;
            this.lblNote.Text = "Note: Enum and constant names must start with alphabet or underscore.";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(313, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertEnum
            // 
            this.btnInsertEnum.Enabled = false;
            this.btnInsertEnum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertEnum.Location = new System.Drawing.Point(232, 398);
            this.btnInsertEnum.Name = "btnInsertEnum";
            this.btnInsertEnum.Size = new System.Drawing.Size(75, 26);
            this.btnInsertEnum.TabIndex = 22;
            this.btnInsertEnum.Text = "Insert";
            this.btnInsertEnum.UseVisualStyleBackColor = true;
            this.btnInsertEnum.Click += new System.EventHandler(this.btnInsertEnum_Click);
            // 
            // cboDataType
            // 
            this.cboDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Items.AddRange(new object[] {
            "byte",
            "int",
            "long",
            "sbyte",
            "short",
            "uint",
            "ulong",
            "ushort"});
            this.cboDataType.Location = new System.Drawing.Point(90, 93);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(186, 22);
            this.cboDataType.Sorted = true;
            this.cboDataType.TabIndex = 7;
            this.cboDataType.SelectedIndexChanged += new System.EventHandler(this.cboDataType_SelectedIndexChanged);
            // 
            // lblDataTypeDescription
            // 
            this.lblDataTypeDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDataTypeDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataTypeDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTypeDescription.Location = new System.Drawing.Point(90, 121);
            this.lblDataTypeDescription.Name = "lblDataTypeDescription";
            this.lblDataTypeDescription.Size = new System.Drawing.Size(299, 30);
            this.lblDataTypeDescription.TabIndex = 8;
            this.lblDataTypeDescription.Text = "Description";
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataType.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDataType.Location = new System.Drawing.Point(10, 97);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(68, 13);
            this.lblDataType.TabIndex = 6;
            this.lblDataType.Text = "Data Type:";
            // 
            // btnNewConstant
            // 
            this.btnNewConstant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewConstant.Location = new System.Drawing.Point(12, 165);
            this.btnNewConstant.Name = "btnNewConstant";
            this.btnNewConstant.Size = new System.Drawing.Size(100, 24);
            this.btnNewConstant.TabIndex = 10;
            this.btnNewConstant.Text = "New Constant";
            this.btnNewConstant.UseVisualStyleBackColor = true;
            this.btnNewConstant.Click += new System.EventHandler(this.btnNewConstant_Click);
            // 
            // lblCosntantName
            // 
            this.lblCosntantName.AutoSize = true;
            this.lblCosntantName.Enabled = false;
            this.lblCosntantName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosntantName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCosntantName.Location = new System.Drawing.Point(12, 200);
            this.lblCosntantName.Name = "lblCosntantName";
            this.lblCosntantName.Size = new System.Drawing.Size(96, 13);
            this.lblCosntantName.TabIndex = 11;
            this.lblCosntantName.Text = "Constant Name:";
            // 
            // txtConstantName
            // 
            this.txtConstantName.Enabled = false;
            this.txtConstantName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConstantName.Location = new System.Drawing.Point(114, 197);
            this.txtConstantName.MaxLength = 100;
            this.txtConstantName.Name = "txtConstantName";
            this.txtConstantName.Size = new System.Drawing.Size(274, 22);
            this.txtConstantName.TabIndex = 12;
            this.txtConstantName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnum_KeyPress);
            this.txtConstantName.TextChanged += new System.EventHandler(this.txtConstantName_TextChanged);
            // 
            // lblInitialValue
            // 
            this.lblInitialValue.AutoSize = true;
            this.lblInitialValue.Enabled = false;
            this.lblInitialValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialValue.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblInitialValue.Location = new System.Drawing.Point(12, 228);
            this.lblInitialValue.Name = "lblInitialValue";
            this.lblInitialValue.Size = new System.Drawing.Size(77, 13);
            this.lblInitialValue.TabIndex = 13;
            this.lblInitialValue.Text = "Initial Value:";
            // 
            // txtInitialValue
            // 
            this.txtInitialValue.Enabled = false;
            this.txtInitialValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialValue.Location = new System.Drawing.Point(114, 225);
            this.txtInitialValue.MaxLength = 100;
            this.txtInitialValue.Name = "txtInitialValue";
            this.txtInitialValue.Size = new System.Drawing.Size(274, 22);
            this.txtInitialValue.TabIndex = 14;
            this.txtInitialValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInitialValue_KeyPress);
            // 
            // btnAddConstant
            // 
            this.btnAddConstant.Enabled = false;
            this.btnAddConstant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConstant.Location = new System.Drawing.Point(313, 254);
            this.btnAddConstant.Name = "btnAddConstant";
            this.btnAddConstant.Size = new System.Drawing.Size(75, 24);
            this.btnAddConstant.TabIndex = 15;
            this.btnAddConstant.Text = "Add";
            this.btnAddConstant.UseVisualStyleBackColor = true;
            this.btnAddConstant.Click += new System.EventHandler(this.btnAddConstant_Click);
            // 
            // lblSeparator1
            // 
            this.lblSeparator1.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblSeparator1.Enabled = false;
            this.lblSeparator1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparator1.Location = new System.Drawing.Point(12, 157);
            this.lblSeparator1.Name = "lblSeparator1";
            this.lblSeparator1.Size = new System.Drawing.Size(375, 2);
            this.lblSeparator1.TabIndex = 9;
            // 
            // chkFlagAttributes
            // 
            this.chkFlagAttributes.AutoSize = true;
            this.chkFlagAttributes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFlagAttributes.Location = new System.Drawing.Point(20, 19);
            this.chkFlagAttributes.Name = "chkFlagAttributes";
            this.chkFlagAttributes.Size = new System.Drawing.Size(57, 20);
            this.chkFlagAttributes.TabIndex = 3;
            this.chkFlagAttributes.Text = "Flags";
            this.chkFlagAttributes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 2);
            this.label1.TabIndex = 20;
            // 
            // lblConstantMembers
            // 
            this.lblConstantMembers.AutoSize = true;
            this.lblConstantMembers.Enabled = false;
            this.lblConstantMembers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstantMembers.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblConstantMembers.Location = new System.Drawing.Point(12, 270);
            this.lblConstantMembers.Name = "lblConstantMembers";
            this.lblConstantMembers.Size = new System.Drawing.Size(117, 13);
            this.lblConstantMembers.TabIndex = 16;
            this.lblConstantMembers.Text = "Constant Members:";
            // 
            // lstConstantMembers
            // 
            this.lstConstantMembers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConstantMembers.FormattingEnabled = true;
            this.lstConstantMembers.ItemHeight = 14;
            this.lstConstantMembers.Location = new System.Drawing.Point(12, 289);
            this.lstConstantMembers.Name = "lstConstantMembers";
            this.lstConstantMembers.Size = new System.Drawing.Size(295, 74);
            this.lstConstantMembers.TabIndex = 17;
            this.lstConstantMembers.SelectedIndexChanged += new System.EventHandler(this.lstConstantMembers_SelectedIndexChanged);
            // 
            // btnDeleteConstant
            // 
            this.btnDeleteConstant.Enabled = false;
            this.btnDeleteConstant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteConstant.Location = new System.Drawing.Point(314, 305);
            this.btnDeleteConstant.Name = "btnDeleteConstant";
            this.btnDeleteConstant.Size = new System.Drawing.Size(75, 24);
            this.btnDeleteConstant.TabIndex = 18;
            this.btnDeleteConstant.Text = "Delete";
            this.btnDeleteConstant.UseVisualStyleBackColor = true;
            this.btnDeleteConstant.Click += new System.EventHandler(this.btnDeleteConstant_Click);
            // 
            // btnDeleteAllConstants
            // 
            this.btnDeleteAllConstants.Enabled = false;
            this.btnDeleteAllConstants.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllConstants.Location = new System.Drawing.Point(314, 334);
            this.btnDeleteAllConstants.Name = "btnDeleteAllConstants";
            this.btnDeleteAllConstants.Size = new System.Drawing.Size(75, 24);
            this.btnDeleteAllConstants.TabIndex = 19;
            this.btnDeleteAllConstants.Text = "Delete All";
            this.btnDeleteAllConstants.UseVisualStyleBackColor = true;
            this.btnDeleteAllConstants.Click += new System.EventHandler(this.btnDeleteAllConstants_Click);
            // 
            // chkObsolete
            // 
            this.chkObsolete.AutoSize = true;
            this.chkObsolete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkObsolete.Location = new System.Drawing.Point(133, 19);
            this.chkObsolete.Name = "chkObsolete";
            this.chkObsolete.Size = new System.Drawing.Size(77, 20);
            this.chkObsolete.TabIndex = 4;
            this.chkObsolete.Text = "Obsolete";
            this.chkObsolete.UseVisualStyleBackColor = true;
            // 
            // chkSerializable
            // 
            this.chkSerializable.AutoSize = true;
            this.chkSerializable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSerializable.Location = new System.Drawing.Point(266, 19);
            this.chkSerializable.Name = "chkSerializable";
            this.chkSerializable.Size = new System.Drawing.Size(93, 20);
            this.chkSerializable.TabIndex = 5;
            this.chkSerializable.Text = "Serializable";
            this.chkSerializable.UseVisualStyleBackColor = true;
            // 
            // grpboxAttributes
            // 
            this.grpboxAttributes.Controls.Add(this.chkFlagAttributes);
            this.grpboxAttributes.Controls.Add(this.chkObsolete);
            this.grpboxAttributes.Controls.Add(this.chkSerializable);
            this.grpboxAttributes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxAttributes.Location = new System.Drawing.Point(12, 45);
            this.grpboxAttributes.Name = "grpboxAttributes";
            this.grpboxAttributes.Size = new System.Drawing.Size(377, 42);
            this.grpboxAttributes.TabIndex = 2;
            this.grpboxAttributes.TabStop = false;
            this.grpboxAttributes.Text = "Attributes";
            // 
            // frmEnumeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 433);
            this.Controls.Add(this.grpboxAttributes);
            this.Controls.Add(this.lstConstantMembers);
            this.Controls.Add(this.btnDeleteAllConstants);
            this.Controls.Add(this.btnDeleteConstant);
            this.Controls.Add(this.btnAddConstant);
            this.Controls.Add(this.btnNewConstant);
            this.Controls.Add(this.cboDataType);
            this.Controls.Add(this.lblDataTypeDescription);
            this.Controls.Add(this.lblDataType);
            this.Controls.Add(this.btnInsertEnum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtInitialValue);
            this.Controls.Add(this.txtConstantName);
            this.Controls.Add(this.txtEnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeparator1);
            this.Controls.Add(this.lblInitialValue);
            this.Controls.Add(this.lblConstantMembers);
            this.Controls.Add(this.lblCosntantName);
            this.Controls.Add(this.lblEnumName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnumeration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEnumeration_FormClosing);
            this.Load += new System.EventHandler(this.frmEnumeration_Load);
            this.grpboxAttributes.ResumeLayout(false);
            this.grpboxAttributes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnumName;
        private System.Windows.Forms.TextBox txtEnum;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsertEnum;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.Label lblDataTypeDescription;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.Button btnNewConstant;
        private System.Windows.Forms.Label lblCosntantName;
        private System.Windows.Forms.TextBox txtConstantName;
        private System.Windows.Forms.Label lblInitialValue;
        private System.Windows.Forms.TextBox txtInitialValue;
        private System.Windows.Forms.Button btnAddConstant;
        private System.Windows.Forms.Label lblSeparator1;
        private System.Windows.Forms.CheckBox chkFlagAttributes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConstantMembers;
        private System.Windows.Forms.ListBox lstConstantMembers;
        private System.Windows.Forms.Button btnDeleteConstant;
        private System.Windows.Forms.Button btnDeleteAllConstants;
        private System.Windows.Forms.CheckBox chkObsolete;
        private System.Windows.Forms.CheckBox chkSerializable;
        private System.Windows.Forms.GroupBox grpboxAttributes;
    }
}