namespace SnippetGenerator.Forms
{
    partial class frmConstant
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
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.lblDataTypeDescription = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.txtConstantName = new System.Windows.Forms.TextBox();
            this.lblConstantName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsertConstants = new System.Windows.Forms.Button();
            this.lstConstants = new System.Windows.Forms.ListBox();
            this.lblConstants = new System.Windows.Forms.Label();
            this.btnAddConstant = new System.Windows.Forms.Button();
            this.cboInitialValue = new System.Windows.Forms.ComboBox();
            this.txtInitialValue = new System.Windows.Forms.TextBox();
            this.lblInitialValue = new System.Windows.Forms.Label();
            this.btnDeleteAllConstants = new System.Windows.Forms.Button();
            this.btnDeleteConstant = new System.Windows.Forms.Button();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.cboAccessModifier = new System.Windows.Forms.ComboBox();
            this.lblAccessModifier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboDataType
            // 
            this.cboDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Items.AddRange(new object[] {
            "bool",
            "byte",
            "char",
            "decimal",
            "double",
            "float",
            "int",
            "IntPtr",
            "long",
            "object",
            "sbyte",
            "short",
            "string",
            "uint",
            "UIntPtr",
            "ulong",
            "ushort"});
            this.cboDataType.Location = new System.Drawing.Point(111, 33);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(186, 22);
            this.cboDataType.Sorted = true;
            this.cboDataType.TabIndex = 6;
            this.cboDataType.SelectedIndexChanged += new System.EventHandler(this.cboDataType_SelectedIndexChanged);
            // 
            // lblDataTypeDescription
            // 
            this.lblDataTypeDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDataTypeDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataTypeDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTypeDescription.Location = new System.Drawing.Point(109, 60);
            this.lblDataTypeDescription.Name = "lblDataTypeDescription";
            this.lblDataTypeDescription.Size = new System.Drawing.Size(417, 45);
            this.lblDataTypeDescription.TabIndex = 7;
            this.lblDataTypeDescription.Text = "Description";
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataType.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDataType.Location = new System.Drawing.Point(17, 36);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(68, 13);
            this.lblDataType.TabIndex = 5;
            this.lblDataType.Text = "Data Type:";
            // 
            // txtConstantName
            // 
            this.txtConstantName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConstantName.Location = new System.Drawing.Point(112, 7);
            this.txtConstantName.MaxLength = 100;
            this.txtConstantName.Name = "txtConstantName";
            this.txtConstantName.Size = new System.Drawing.Size(322, 22);
            this.txtConstantName.TabIndex = 9;
            this.txtConstantName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtConstantName.TextChanged += new System.EventHandler(this.txtConstantName_TextChanged);
            // 
            // lblConstantName
            // 
            this.lblConstantName.AutoSize = true;
            this.lblConstantName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstantName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblConstantName.Location = new System.Drawing.Point(16, 10);
            this.lblConstantName.Name = "lblConstantName";
            this.lblConstantName.Size = new System.Drawing.Size(96, 13);
            this.lblConstantName.TabIndex = 8;
            this.lblConstantName.Text = "Constant Name:";
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNote.Location = new System.Drawing.Point(17, 369);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(298, 33);
            this.lblNote.TabIndex = 21;
            this.lblNote.Text = "Note: Constant names must start with alphabet or underscore.";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(444, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 26);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertConstants
            // 
            this.btnInsertConstants.Enabled = false;
            this.btnInsertConstants.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertConstants.Location = new System.Drawing.Point(352, 369);
            this.btnInsertConstants.Name = "btnInsertConstants";
            this.btnInsertConstants.Size = new System.Drawing.Size(86, 26);
            this.btnInsertConstants.TabIndex = 23;
            this.btnInsertConstants.Text = "Insert";
            this.btnInsertConstants.UseVisualStyleBackColor = true;
            this.btnInsertConstants.Click += new System.EventHandler(this.btnInsertconstants_Click);
            // 
            // lstConstants
            // 
            this.lstConstants.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConstants.FormattingEnabled = true;
            this.lstConstants.ItemHeight = 14;
            this.lstConstants.Location = new System.Drawing.Point(19, 240);
            this.lstConstants.Name = "lstConstants";
            this.lstConstants.Size = new System.Drawing.Size(419, 116);
            this.lstConstants.TabIndex = 25;
            this.lstConstants.SelectedIndexChanged += new System.EventHandler(this.lstConstants_SelectedIndexChanged);
            // 
            // lblConstants
            // 
            this.lblConstants.AutoSize = true;
            this.lblConstants.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstants.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblConstants.Location = new System.Drawing.Point(16, 221);
            this.lblConstants.Name = "lblConstants";
            this.lblConstants.Size = new System.Drawing.Size(67, 13);
            this.lblConstants.TabIndex = 5;
            this.lblConstants.Text = "Constants:";
            // 
            // btnAddConstant
            // 
            this.btnAddConstant.Enabled = false;
            this.btnAddConstant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConstant.Location = new System.Drawing.Point(444, 4);
            this.btnAddConstant.Name = "btnAddConstant";
            this.btnAddConstant.Size = new System.Drawing.Size(86, 26);
            this.btnAddConstant.TabIndex = 23;
            this.btnAddConstant.Text = "Add";
            this.btnAddConstant.UseVisualStyleBackColor = true;
            this.btnAddConstant.Click += new System.EventHandler(this.btnAddConstant_Click);
            // 
            // cboInitialValue
            // 
            this.cboInitialValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInitialValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInitialValue.FormattingEnabled = true;
            this.cboInitialValue.Items.AddRange(new object[] {
            "false",
            "true"});
            this.cboInitialValue.Location = new System.Drawing.Point(111, 170);
            this.cboInitialValue.Name = "cboInitialValue";
            this.cboInitialValue.Size = new System.Drawing.Size(324, 22);
            this.cboInitialValue.Sorted = true;
            this.cboInitialValue.TabIndex = 28;
            this.cboInitialValue.Visible = false;
            // 
            // txtInitialValue
            // 
            this.txtInitialValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialValue.Location = new System.Drawing.Point(111, 170);
            this.txtInitialValue.MaxLength = 100;
            this.txtInitialValue.Name = "txtInitialValue";
            this.txtInitialValue.Size = new System.Drawing.Size(325, 22);
            this.txtInitialValue.TabIndex = 27;
            // 
            // lblInitialValue
            // 
            this.lblInitialValue.AutoSize = true;
            this.lblInitialValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialValue.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblInitialValue.Location = new System.Drawing.Point(17, 173);
            this.lblInitialValue.Name = "lblInitialValue";
            this.lblInitialValue.Size = new System.Drawing.Size(77, 13);
            this.lblInitialValue.TabIndex = 26;
            this.lblInitialValue.Text = "Initial Value:";
            // 
            // btnDeleteAllConstants
            // 
            this.btnDeleteAllConstants.Enabled = false;
            this.btnDeleteAllConstants.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllConstants.Location = new System.Drawing.Point(444, 283);
            this.btnDeleteAllConstants.Name = "btnDeleteAllConstants";
            this.btnDeleteAllConstants.Size = new System.Drawing.Size(86, 26);
            this.btnDeleteAllConstants.TabIndex = 30;
            this.btnDeleteAllConstants.Text = "Delete All";
            this.btnDeleteAllConstants.UseVisualStyleBackColor = true;
            this.btnDeleteAllConstants.Click += new System.EventHandler(this.btnDeleteAllConstants_Click);
            // 
            // btnDeleteConstant
            // 
            this.btnDeleteConstant.Enabled = false;
            this.btnDeleteConstant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteConstant.Location = new System.Drawing.Point(444, 252);
            this.btnDeleteConstant.Name = "btnDeleteConstant";
            this.btnDeleteConstant.Size = new System.Drawing.Size(86, 26);
            this.btnDeleteConstant.TabIndex = 29;
            this.btnDeleteConstant.Text = "Delete";
            this.btnDeleteConstant.UseVisualStyleBackColor = true;
            this.btnDeleteConstant.Click += new System.EventHandler(this.btnDeleteConstant_Click);
            // 
            // lblSeparator
            // 
            this.lblSeparator.BackColor = System.Drawing.Color.DimGray;
            this.lblSeparator.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparator.Location = new System.Drawing.Point(0, 210);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(540, 2);
            this.lblSeparator.TabIndex = 5;
            // 
            // cboAccessModifier
            // 
            this.cboAccessModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccessModifier.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAccessModifier.FormattingEnabled = true;
            this.cboAccessModifier.Items.AddRange(new object[] {
            "internal",
            "private",
            "protected",
            "protected internal",
            "public"});
            this.cboAccessModifier.Location = new System.Drawing.Point(112, 108);
            this.cboAccessModifier.Name = "cboAccessModifier";
            this.cboAccessModifier.Size = new System.Drawing.Size(139, 22);
            this.cboAccessModifier.Sorted = true;
            this.cboAccessModifier.TabIndex = 33;
            // 
            // lblAccessModifier
            // 
            this.lblAccessModifier.AutoSize = true;
            this.lblAccessModifier.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessModifier.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAccessModifier.Location = new System.Drawing.Point(8, 112);
            this.lblAccessModifier.Name = "lblAccessModifier";
            this.lblAccessModifier.Size = new System.Drawing.Size(98, 13);
            this.lblAccessModifier.TabIndex = 32;
            this.lblAccessModifier.Text = "Access Modifier:";
            this.lblAccessModifier.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmConstant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 403);
            this.Controls.Add(this.cboAccessModifier);
            this.Controls.Add(this.lblAccessModifier);
            this.Controls.Add(this.btnDeleteAllConstants);
            this.Controls.Add(this.btnDeleteConstant);
            this.Controls.Add(this.cboInitialValue);
            this.Controls.Add(this.txtInitialValue);
            this.Controls.Add(this.lblInitialValue);
            this.Controls.Add(this.lstConstants);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddConstant);
            this.Controls.Add(this.btnInsertConstants);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtConstantName);
            this.Controls.Add(this.lblConstantName);
            this.Controls.Add(this.cboDataType);
            this.Controls.Add(this.lblDataTypeDescription);
            this.Controls.Add(this.lblConstants);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.lblDataType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConstant";
            this.Text = "Constants";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConstant_FormClosing);
            this.Load += new System.EventHandler(this.frmConstant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.Label lblDataTypeDescription;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.TextBox txtConstantName;
        private System.Windows.Forms.Label lblConstantName;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsertConstants;
        private System.Windows.Forms.ListBox lstConstants;
        private System.Windows.Forms.Label lblConstants;
        private System.Windows.Forms.Button btnAddConstant;
        private System.Windows.Forms.ComboBox cboInitialValue;
        private System.Windows.Forms.TextBox txtInitialValue;
        private System.Windows.Forms.Label lblInitialValue;
        private System.Windows.Forms.Button btnDeleteAllConstants;
        private System.Windows.Forms.Button btnDeleteConstant;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.ComboBox cboAccessModifier;
        private System.Windows.Forms.Label lblAccessModifier;
    }
}