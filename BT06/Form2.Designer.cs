namespace BT06
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNs = new System.Windows.Forms.DateTimePicker();
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.grbHoSo = new System.Windows.Forms.GroupBox();
            this.checkCCCD = new System.Windows.Forms.CheckBox();
            this.checkHocBa = new System.Windows.Forms.CheckBox();
            this.checkAnh = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbLopSh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.grbHoSo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lớp SH";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Enabled = false;
            this.txtMSSV.Location = new System.Drawing.Point(144, 112);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(121, 22);
            this.txtMSSV.TabIndex = 4;
            this.txtMSSV.Tag = "MSSV";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 157);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 22);
            this.txtName.TabIndex = 5;
            this.txtName.Tag = "Name";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(456, 249);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(100, 22);
            this.txtDTB.TabIndex = 6;
            this.txtDTB.Tag = "DTB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "ĐTB";
            // 
            // dtNs
            // 
            this.dtNs.Location = new System.Drawing.Point(144, 249);
            this.dtNs.Name = "dtNs";
            this.dtNs.Size = new System.Drawing.Size(200, 22);
            this.dtNs.TabIndex = 8;
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.rbtnFemale);
            this.grbGioiTinh.Controls.Add(this.rbtnMale);
            this.grbGioiTinh.Location = new System.Drawing.Point(395, 115);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Size = new System.Drawing.Size(200, 103);
            this.grbGioiTinh.TabIndex = 9;
            this.grbGioiTinh.TabStop = false;
            this.grbGioiTinh.Text = "Giới tính";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(7, 65);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(45, 20);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Nữ";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(6, 39);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(57, 20);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Nam";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // grbHoSo
            // 
            this.grbHoSo.Controls.Add(this.checkCCCD);
            this.grbHoSo.Controls.Add(this.checkHocBa);
            this.grbHoSo.Controls.Add(this.checkAnh);
            this.grbHoSo.Location = new System.Drawing.Point(395, 297);
            this.grbHoSo.Name = "grbHoSo";
            this.grbHoSo.Size = new System.Drawing.Size(200, 135);
            this.grbHoSo.TabIndex = 10;
            this.grbHoSo.TabStop = false;
            this.grbHoSo.Text = "Hồ sơ";
            // 
            // checkCCCD
            // 
            this.checkCCCD.AutoSize = true;
            this.checkCCCD.Location = new System.Drawing.Point(7, 97);
            this.checkCCCD.Name = "checkCCCD";
            this.checkCCCD.Size = new System.Drawing.Size(66, 20);
            this.checkCCCD.TabIndex = 2;
            this.checkCCCD.Tag = "CCCD";
            this.checkCCCD.Text = "CCCD";
            this.checkCCCD.UseVisualStyleBackColor = true;
            // 
            // checkHocBa
            // 
            this.checkHocBa.AutoSize = true;
            this.checkHocBa.Location = new System.Drawing.Point(7, 71);
            this.checkHocBa.Name = "checkHocBa";
            this.checkHocBa.Size = new System.Drawing.Size(73, 20);
            this.checkHocBa.TabIndex = 1;
            this.checkHocBa.Tag = "Hocba";
            this.checkHocBa.Text = "Học bạ";
            this.checkHocBa.UseVisualStyleBackColor = true;
            // 
            // checkAnh
            // 
            this.checkAnh.AutoSize = true;
            this.checkAnh.Location = new System.Drawing.Point(6, 45);
            this.checkAnh.Name = "checkAnh";
            this.checkAnh.Size = new System.Drawing.Size(52, 20);
            this.checkAnh.TabIndex = 0;
            this.checkAnh.Tag = "Anh";
            this.checkAnh.Text = "Ảnh";
            this.checkAnh.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(67, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(497, 461);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 36);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // cbLopSh
            // 
            this.cbLopSh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLopSh.FormattingEnabled = true;
            this.cbLopSh.Location = new System.Drawing.Point(144, 201);
            this.cbLopSh.Name = "cbLopSh";
            this.cbLopSh.Size = new System.Drawing.Size(121, 24);
            this.cbLopSh.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(194, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cập nhật thông tin";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 556);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbLopSh);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbHoSo);
            this.Controls.Add(this.grbGioiTinh);
            this.Controls.Add(this.dtNs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.grbHoSo.ResumeLayout(false);
            this.grbHoSo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNs;
        private System.Windows.Forms.GroupBox grbGioiTinh;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbHoSo;
        private System.Windows.Forms.CheckBox checkCCCD;
        private System.Windows.Forms.CheckBox checkHocBa;
        private System.Windows.Forms.CheckBox checkAnh;
        private System.Windows.Forms.ComboBox cbLopSh;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label6;
    }
}