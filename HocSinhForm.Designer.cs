namespace BT_Tuan2
{
    partial class HocSinhForm
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
            this.gvHocSinh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpDateofbirth = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // gvHocSinh
            // 
            this.gvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHocSinh.Location = new System.Drawing.Point(459, 36);
            this.gvHocSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvHocSinh.Name = "gvHocSinh";
            this.gvHocSinh.RowHeadersWidth = 51;
            this.gvHocSinh.RowTemplate.Height = 24;
            this.gvHocSinh.Size = new System.Drawing.Size(739, 341);
            this.gvHocSinh.TabIndex = 0;
            this.gvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHocSinh_CellClick);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ho va ten";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(386, 455);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 51);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Them";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(677, 455);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 51);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sua";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(949, 455);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpDateofbirth
            // 
            this.dtpDateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateofbirth.Location = new System.Drawing.Point(141, 245);
            this.dtpDateofbirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateofbirth.Name = "dtpDateofbirth";
            this.dtpDateofbirth.Size = new System.Drawing.Size(285, 26);
            this.dtpDateofbirth.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(141, 198);
            this.txtCmnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(285, 26);
            this.txtCmnd.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(141, 146);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 26);
            this.txtAddress.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dia chi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngay Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ma hoc sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "So dien thoai";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(141, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(285, 26);
            this.txtId.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 298);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 26);
            this.txtEmail.TabIndex = 17;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(141, 353);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(285, 26);
            this.txtNumber.TabIndex = 18;
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Location = new System.Drawing.Point(116, 455);
            this.btnGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(128, 51);
            this.btnGiaoVien.TabIndex = 19;
            this.btnGiaoVien.Text = "Giao Vien";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // HocSinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1210, 562);
            this.Controls.Add(this.btnGiaoVien);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCmnd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpDateofbirth);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvHocSinh);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HocSinhForm";
            this.Text = "HocSinh";
            this.Load += new System.EventHandler(this.HocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvHocSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpDateofbirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnGiaoVien;
    }
}

