namespace EClerx.ADO.Day14
{
    partial class Form1
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
            this.LblEmployeeCode = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblState = new System.Windows.Forms.Label();
            this.TxtEmpCode = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblSocialSecurityNumber = new System.Windows.Forms.Label();
            this.TxtSocialSecurityNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblEmployeeCode
            // 
            this.LblEmployeeCode.AutoSize = true;
            this.LblEmployeeCode.Location = new System.Drawing.Point(134, 39);
            this.LblEmployeeCode.Name = "LblEmployeeCode";
            this.LblEmployeeCode.Size = new System.Drawing.Size(81, 13);
            this.LblEmployeeCode.TabIndex = 0;
            this.LblEmployeeCode.Text = "Employee Code";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(134, 79);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(60, 13);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "First Name ";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(134, 121);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(24, 13);
            this.LblCity.TabIndex = 2;
            this.LblCity.Text = "City";
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(134, 161);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(32, 13);
            this.LblState.TabIndex = 3;
            this.LblState.Text = "State";
            // 
            // TxtEmpCode
            // 
            this.TxtEmpCode.Location = new System.Drawing.Point(283, 36);
            this.TxtEmpCode.Name = "TxtEmpCode";
            this.TxtEmpCode.Size = new System.Drawing.Size(191, 20);
            this.TxtEmpCode.TabIndex = 4;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(283, 72);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(191, 20);
            this.TxtFirstName.TabIndex = 5;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(283, 118);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(191, 20);
            this.TxtCity.TabIndex = 6;
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(283, 158);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(191, 20);
            this.TxtState.TabIndex = 7;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(501, 33);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(237, 254);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click_1);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(318, 254);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNew.TabIndex = 10;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click_1);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(399, 254);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click_1);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(501, 254);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // LblSocialSecurityNumber
            // 
            this.LblSocialSecurityNumber.AutoSize = true;
            this.LblSocialSecurityNumber.Location = new System.Drawing.Point(134, 202);
            this.LblSocialSecurityNumber.Name = "LblSocialSecurityNumber";
            this.LblSocialSecurityNumber.Size = new System.Drawing.Size(117, 13);
            this.LblSocialSecurityNumber.TabIndex = 13;
            this.LblSocialSecurityNumber.Text = "Social Security Number";
            // 
            // TxtSocialSecurityNo
            // 
            this.TxtSocialSecurityNo.Location = new System.Drawing.Point(283, 199);
            this.TxtSocialSecurityNo.Name = "TxtSocialSecurityNo";
            this.TxtSocialSecurityNo.Size = new System.Drawing.Size(191, 20);
            this.TxtSocialSecurityNo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtSocialSecurityNo);
            this.Controls.Add(this.LblSocialSecurityNumber);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtState);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.TxtEmpCode);
            this.Controls.Add(this.LblState);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblEmployeeCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmployeeCode;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.TextBox TxtEmpCode;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblSocialSecurityNumber;
        private System.Windows.Forms.TextBox TxtSocialSecurityNo;
    }
}

