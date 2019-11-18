namespace SnippetGenerator.Forms
{
    partial class frmDelegate
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsertDelegate = new System.Windows.Forms.Button();
            this.lblDelegate = new System.Windows.Forms.Label();
            this.txtDelegateName = new System.Windows.Forms.TextBox();
            this.btnDeleteAllParameters = new System.Windows.Forms.Button();
            this.btnDeleteParameter = new System.Windows.Forms.Button();
            this.txtDataType = new System.Windows.Forms.TextBox();
            this.lstParameters = new System.Windows.Forms.ListBox();
            this.btnAddParameter = new System.Windows.Forms.Button();
            this.txtParameterName = new System.Windows.Forms.TextBox();
            this.lblParameterName = new System.Windows.Forms.Label();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.lblDataTypeDescription = new System.Windows.Forms.Label();
            this.lblParameters = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(440, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 25);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertDelegate
            // 
            this.btnInsertDelegate.Enabled = false;
            this.btnInsertDelegate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertDelegate.Location = new System.Drawing.Point(352, 330);
            this.btnInsertDelegate.Name = "btnInsertDelegate";
            this.btnInsertDelegate.Size = new System.Drawing.Size(82, 25);
            this.btnInsertDelegate.TabIndex = 19;
            this.btnInsertDelegate.Text = "&Insert";
            this.btnInsertDelegate.UseVisualStyleBackColor = true;
            this.btnInsertDelegate.Click += new System.EventHandler(this.btnInsertDelegate_Click);
            // 
            // lblDelegate
            // 
            this.lblDelegate.AutoSize = true;
            this.lblDelegate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelegate.Location = new System.Drawing.Point(10, 16);
            this.lblDelegate.Name = "lblDelegate";
            this.lblDelegate.Size = new System.Drawing.Size(100, 16);
            this.lblDelegate.TabIndex = 17;
            this.lblDelegate.Text = "Delegate Name:";
            // 
            // txtDelegateName
            // 
            this.txtDelegateName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelegateName.Location = new System.Drawing.Point(115, 13);
            this.txtDelegateName.MaxLength = 100;
            this.txtDelegateName.Name = "txtDelegateName";
            this.txtDelegateName.Size = new System.Drawing.Size(406, 23);
            this.txtDelegateName.TabIndex = 18;
            this.txtDelegateName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDelegateName_KeyPress);
            this.txtDelegateName.TextChanged += new System.EventHandler(this.txtDelegateName_TextChanged);
            // 
            // btnDeleteAllParameters
            // 
            this.btnDeleteAllParameters.Enabled = false;
            this.btnDeleteAllParameters.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllParameters.Location = new System.Drawing.Point(436, 238);
            this.btnDeleteAllParameters.Name = "btnDeleteAllParameters";
            this.btnDeleteAllParameters.Size = new System.Drawing.Size(86, 26);
            this.btnDeleteAllParameters.TabIndex = 34;
            this.btnDeleteAllParameters.Text = "Delete &All";
            this.btnDeleteAllParameters.UseVisualStyleBackColor = true;
            this.btnDeleteAllParameters.Click += new System.EventHandler(this.btnDeleteAllParameters_Click);
            // 
            // btnDeleteParameter
            // 
            this.btnDeleteParameter.Enabled = false;
            this.btnDeleteParameter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteParameter.Location = new System.Drawing.Point(436, 207);
            this.btnDeleteParameter.Name = "btnDeleteParameter";
            this.btnDeleteParameter.Size = new System.Drawing.Size(86, 26);
            this.btnDeleteParameter.TabIndex = 33;
            this.btnDeleteParameter.Text = "&Delete";
            this.btnDeleteParameter.UseVisualStyleBackColor = true;
            this.btnDeleteParameter.Click += new System.EventHandler(this.btnDeleteParameter_Click);
            // 
            // txtDataType
            // 
            this.txtDataType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataType.Location = new System.Drawing.Point(326, 89);
            this.txtDataType.MaxLength = 100;
            this.txtDataType.Name = "txtDataType";
            this.txtDataType.Size = new System.Drawing.Size(196, 22);
            this.txtDataType.TabIndex = 25;
            this.txtDataType.Visible = false;
            this.txtDataType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParameterName_KeyPress);
            // 
            // lstParameters
            // 
            this.lstParameters.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstParameters.FormattingEnabled = true;
            this.lstParameters.ItemHeight = 14;
            this.lstParameters.Location = new System.Drawing.Point(12, 198);
            this.lstParameters.Name = "lstParameters";
            this.lstParameters.Size = new System.Drawing.Size(419, 116);
            this.lstParameters.TabIndex = 32;
            this.lstParameters.SelectedIndexChanged += new System.EventHandler(this.lstParameters_SelectedIndexChanged);
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.Enabled = false;
            this.btnAddParameter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParameter.Location = new System.Drawing.Point(437, 58);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(86, 26);
            this.btnAddParameter.TabIndex = 30;
            this.btnAddParameter.Text = "&Add";
            this.btnAddParameter.UseVisualStyleBackColor = true;
            this.btnAddParameter.Click += new System.EventHandler(this.btnAddParameter_Click);
            // 
            // txtParameterName
            // 
            this.txtParameterName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParameterName.Location = new System.Drawing.Point(117, 61);
            this.txtParameterName.MaxLength = 100;
            this.txtParameterName.Name = "txtParameterName";
            this.txtParameterName.Size = new System.Drawing.Size(314, 22);
            this.txtParameterName.TabIndex = 22;
            this.txtParameterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParameterName_KeyPress);
            this.txtParameterName.TextChanged += new System.EventHandler(this.txtParameterName_TextChanged);
            // 
            // lblParameterName
            // 
            this.lblParameterName.AutoSize = true;
            this.lblParameterName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameterName.Location = new System.Drawing.Point(12, 64);
            this.lblParameterName.Name = "lblParameterName";
            this.lblParameterName.Size = new System.Drawing.Size(102, 14);
            this.lblParameterName.TabIndex = 21;
            this.lblParameterName.Text = "Parameter &Name:";
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
            "ushort",
            "void"});
            this.cboDataType.Location = new System.Drawing.Point(117, 89);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(203, 22);
            this.cboDataType.Sorted = true;
            this.cboDataType.TabIndex = 24;
            this.cboDataType.SelectedIndexChanged += new System.EventHandler(this.cboDataType_SelectedIndexChanged);
            this.cboDataType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDataType_KeyPress);
            // 
            // lblDataTypeDescription
            // 
            this.lblDataTypeDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDataTypeDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataTypeDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTypeDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDataTypeDescription.Location = new System.Drawing.Point(117, 116);
            this.lblDataTypeDescription.Name = "lblDataTypeDescription";
            this.lblDataTypeDescription.Size = new System.Drawing.Size(405, 56);
            this.lblDataTypeDescription.TabIndex = 26;
            this.lblDataTypeDescription.Text = "Description";
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameters.Location = new System.Drawing.Point(12, 179);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(72, 14);
            this.lblParameters.TabIndex = 31;
            this.lblParameters.Text = "Para&meters:";
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataType.Location = new System.Drawing.Point(12, 93);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(68, 14);
            this.lblDataType.TabIndex = 23;
            this.lblDataType.Text = "Data &Type:";
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNote.Location = new System.Drawing.Point(12, 322);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(337, 33);
            this.lblNote.TabIndex = 35;
            this.lblNote.Text = "Note: Delagate and Parameter names must start with alphabet or underscore.";
            // 
            // lblSeparator
            // 
            this.lblSeparator.BackColor = System.Drawing.Color.Gray;
            this.lblSeparator.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparator.Location = new System.Drawing.Point(10, 49);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(508, 1);
            this.lblSeparator.TabIndex = 21;
            // 
            // frmDelegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 361);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnDeleteAllParameters);
            this.Controls.Add(this.btnDeleteParameter);
            this.Controls.Add(this.txtDataType);
            this.Controls.Add(this.lstParameters);
            this.Controls.Add(this.btnAddParameter);
            this.Controls.Add(this.txtParameterName);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.lblParameterName);
            this.Controls.Add(this.cboDataType);
            this.Controls.Add(this.lblDataTypeDescription);
            this.Controls.Add(this.lblParameters);
            this.Controls.Add(this.lblDataType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsertDelegate);
            this.Controls.Add(this.txtDelegateName);
            this.Controls.Add(this.lblDelegate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelegate";
            this.Text = "Delegate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmParameterizedConstructor_FormClosing);
            this.Load += new System.EventHandler(this.frmDelegate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsertDelegate;
        private System.Windows.Forms.Label lblDelegate;
        private System.Windows.Forms.TextBox txtDelegateName;
        private System.Windows.Forms.Button btnDeleteAllParameters;
        private System.Windows.Forms.Button btnDeleteParameter;
        private System.Windows.Forms.TextBox txtDataType;
        private System.Windows.Forms.ListBox lstParameters;
        private System.Windows.Forms.Button btnAddParameter;
        private System.Windows.Forms.TextBox txtParameterName;
        private System.Windows.Forms.Label lblParameterName;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.Label lblDataTypeDescription;
        private System.Windows.Forms.Label lblParameters;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblSeparator;
    }
}