namespace SnippetGenerator.Forms
{
    partial class frmField
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
            this.cboInitialValue = new System.Windows.Forms.ComboBox();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.txtInitialValue = new System.Windows.Forms.TextBox();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsertField = new System.Windows.Forms.Button();
            this.lblDataTypeDescription = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.lblInitialValue = new System.Windows.Forms.Label();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.txtOtherDataType = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.cboAccessModifier = new System.Windows.Forms.ComboBox();
            this.lblAccessModifier = new System.Windows.Forms.Label();
            this.cboOtherDataType = new System.Windows.Forms.ComboBox();
            this.lblOtherModifier = new System.Windows.Forms.Label();
            this.lblBorder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboInitialValue
            // 
            this.cboInitialValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInitialValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInitialValue.FormattingEnabled = true;
            this.cboInitialValue.Items.AddRange(new object[] {
            "false",
            "true"});
            this.cboInitialValue.Location = new System.Drawing.Point(101, 116);
            this.cboInitialValue.Name = "cboInitialValue";
            this.cboInitialValue.Size = new System.Drawing.Size(362, 22);
            this.cboInitialValue.Sorted = true;
            this.cboInitialValue.TabIndex = 7;
            this.cboInitialValue.Visible = false;
            // 
            // cboDataType
            // 
            this.cboDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Items.AddRange(new object[] {
            "(Other)",
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
            this.cboDataType.Location = new System.Drawing.Point(101, 35);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(186, 22);
            this.cboDataType.Sorted = true;
            this.cboDataType.TabIndex = 3;
            this.cboDataType.SelectedIndexChanged += new System.EventHandler(this.cboDataType_SelectedIndexChanged);
            // 
            // txtInitialValue
            // 
            this.txtInitialValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialValue.Location = new System.Drawing.Point(101, 116);
            this.txtInitialValue.MaxLength = 100;
            this.txtInitialValue.Name = "txtInitialValue";
            this.txtInitialValue.Size = new System.Drawing.Size(363, 22);
            this.txtInitialValue.TabIndex = 8;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldName.Location = new System.Drawing.Point(101, 8);
            this.txtFieldName.MaxLength = 100;
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(362, 22);
            this.txtFieldName.TabIndex = 1;
            this.txtFieldName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFieldName_KeyPress);
            this.txtFieldName.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(487, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 24);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertField
            // 
            this.btnInsertField.Enabled = false;
            this.btnInsertField.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertField.Location = new System.Drawing.Point(487, 11);
            this.btnInsertField.Name = "btnInsertField";
            this.btnInsertField.Size = new System.Drawing.Size(86, 24);
            this.btnInsertField.TabIndex = 15;
            this.btnInsertField.Text = "&Insert";
            this.btnInsertField.UseVisualStyleBackColor = true;
            this.btnInsertField.Click += new System.EventHandler(this.btnInsertField_Click);
            // 
            // lblDataTypeDescription
            // 
            this.lblDataTypeDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDataTypeDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataTypeDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTypeDescription.Location = new System.Drawing.Point(101, 62);
            this.lblDataTypeDescription.Name = "lblDataTypeDescription";
            this.lblDataTypeDescription.Size = new System.Drawing.Size(362, 48);
            this.lblDataTypeDescription.TabIndex = 5;
            this.lblDataTypeDescription.Text = "Description";
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataType.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDataType.Location = new System.Drawing.Point(6, 39);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(68, 13);
            this.lblDataType.TabIndex = 2;
            this.lblDataType.Text = "Data &Type:";
            // 
            // lblInitialValue
            // 
            this.lblInitialValue.AutoSize = true;
            this.lblInitialValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialValue.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblInitialValue.Location = new System.Drawing.Point(6, 119);
            this.lblInitialValue.Name = "lblInitialValue";
            this.lblInitialValue.Size = new System.Drawing.Size(77, 13);
            this.lblInitialValue.TabIndex = 6;
            this.lblInitialValue.Text = "Initial &Value:";
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblFieldName.Location = new System.Drawing.Point(6, 11);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(71, 13);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field &Name:";
            // 
            // txtOtherDataType
            // 
            this.txtOtherDataType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherDataType.Location = new System.Drawing.Point(293, 35);
            this.txtOtherDataType.MaxLength = 100;
            this.txtOtherDataType.Name = "txtOtherDataType";
            this.txtOtherDataType.Size = new System.Drawing.Size(170, 22);
            this.txtOtherDataType.TabIndex = 4;
            this.txtOtherDataType.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNote.Location = new System.Drawing.Point(6, 181);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(441, 26);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "Note: Field names must start with alphabet or underscore.";
            // 
            // cboAccessModifier
            // 
            this.cboAccessModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccessModifier.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAccessModifier.FormattingEnabled = true;
            this.cboAccessModifier.Items.AddRange(new object[] {
            "(default- private)",
            "internal",
            "protected",
            "protected internal",
            "public"});
            this.cboAccessModifier.Location = new System.Drawing.Point(102, 147);
            this.cboAccessModifier.Name = "cboAccessModifier";
            this.cboAccessModifier.Size = new System.Drawing.Size(139, 22);
            this.cboAccessModifier.Sorted = true;
            this.cboAccessModifier.TabIndex = 10;
            // 
            // lblAccessModifier
            // 
            this.lblAccessModifier.AutoSize = true;
            this.lblAccessModifier.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessModifier.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAccessModifier.Location = new System.Drawing.Point(7, 150);
            this.lblAccessModifier.Name = "lblAccessModifier";
            this.lblAccessModifier.Size = new System.Drawing.Size(98, 13);
            this.lblAccessModifier.TabIndex = 9;
            this.lblAccessModifier.Text = "Access Modifier:";
            this.lblAccessModifier.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboOtherDataType
            // 
            this.cboOtherDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOtherDataType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOtherDataType.FormattingEnabled = true;
            this.cboOtherDataType.Items.AddRange(new object[] {
            "(none)",
            "readonly",
            "static"});
            this.cboOtherDataType.Location = new System.Drawing.Point(353, 147);
            this.cboOtherDataType.Name = "cboOtherDataType";
            this.cboOtherDataType.Size = new System.Drawing.Size(111, 22);
            this.cboOtherDataType.Sorted = true;
            this.cboOtherDataType.TabIndex = 12;
            // 
            // lblOtherModifier
            // 
            this.lblOtherModifier.AutoSize = true;
            this.lblOtherModifier.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherModifier.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblOtherModifier.Location = new System.Drawing.Point(256, 150);
            this.lblOtherModifier.Name = "lblOtherModifier";
            this.lblOtherModifier.Size = new System.Drawing.Size(91, 13);
            this.lblOtherModifier.TabIndex = 11;
            this.lblOtherModifier.Text = "Other Modifier:";
            // 
            // lblBorder
            // 
            this.lblBorder.BackColor = System.Drawing.Color.Transparent;
            this.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBorder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorder.Location = new System.Drawing.Point(474, 8);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(2, 190);
            this.lblBorder.TabIndex = 14;
            // 
            // frmField
            // 
            this.AcceptButton = this.btnInsertField;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(579, 208);
            this.Controls.Add(this.cboOtherDataType);
            this.Controls.Add(this.cboAccessModifier);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.cboDataType);
            this.Controls.Add(this.txtOtherDataType);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsertField);
            this.Controls.Add(this.lblBorder);
            this.Controls.Add(this.lblDataTypeDescription);
            this.Controls.Add(this.lblDataType);
            this.Controls.Add(this.lblFieldName);
            this.Controls.Add(this.cboInitialValue);
            this.Controls.Add(this.lblOtherModifier);
            this.Controls.Add(this.txtInitialValue);
            this.Controls.Add(this.lblAccessModifier);
            this.Controls.Add(this.lblInitialValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Field";
            this.Load += new System.EventHandler(this.frmField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboInitialValue;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.TextBox txtInitialValue;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsertField;
        private System.Windows.Forms.Label lblDataTypeDescription;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.Label lblInitialValue;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.TextBox txtOtherDataType;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cboAccessModifier;
        private System.Windows.Forms.Label lblAccessModifier;
        private System.Windows.Forms.ComboBox cboOtherDataType;
        private System.Windows.Forms.Label lblOtherModifier;
        private System.Windows.Forms.Label lblBorder;
    }
}