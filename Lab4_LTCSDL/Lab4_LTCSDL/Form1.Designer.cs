
namespace Lab4_LTCSDL
{
    partial class frmSinhVien
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.gbThongTinSV = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnMatDinh = new System.Windows.Forms.Button();
            this.btnHinh = new System.Windows.Forms.Button();
            this.dtbNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.mtbSDT = new System.Windows.Forms.MaskedTextBox();
            this.mtbMa = new System.Windows.Forms.MaskedTextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbQuanLySV = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stmiLoadTatCa = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.gbThongTinSV.SuspendLayout();
            this.gbQuanLySV.SuspendLayout();
            this.ctmsListView.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(12, 12);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(171, 250);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 0;
            this.pbHinh.TabStop = false;
            // 
            // gbThongTinSV
            // 
            this.gbThongTinSV.Controls.Add(this.btnThoat);
            this.gbThongTinSV.Controls.Add(this.btnLuu);
            this.gbThongTinSV.Controls.Add(this.btnMatDinh);
            this.gbThongTinSV.Controls.Add(this.btnHinh);
            this.gbThongTinSV.Controls.Add(this.dtbNgaySinh);
            this.gbThongTinSV.Controls.Add(this.rdNu);
            this.gbThongTinSV.Controls.Add(this.rdNam);
            this.gbThongTinSV.Controls.Add(this.cbbLop);
            this.gbThongTinSV.Controls.Add(this.mtbSDT);
            this.gbThongTinSV.Controls.Add(this.mtbMa);
            this.gbThongTinSV.Controls.Add(this.txtLink);
            this.gbThongTinSV.Controls.Add(this.txtDiaChi);
            this.gbThongTinSV.Controls.Add(this.txtEmail);
            this.gbThongTinSV.Controls.Add(this.txtHoTen);
            this.gbThongTinSV.Controls.Add(this.label9);
            this.gbThongTinSV.Controls.Add(this.label8);
            this.gbThongTinSV.Controls.Add(this.label7);
            this.gbThongTinSV.Controls.Add(this.label6);
            this.gbThongTinSV.Controls.Add(this.label5);
            this.gbThongTinSV.Controls.Add(this.label4);
            this.gbThongTinSV.Controls.Add(this.label3);
            this.gbThongTinSV.Controls.Add(this.label2);
            this.gbThongTinSV.Controls.Add(this.label1);
            this.gbThongTinSV.Location = new System.Drawing.Point(189, 12);
            this.gbThongTinSV.Name = "gbThongTinSV";
            this.gbThongTinSV.Size = new System.Drawing.Size(618, 250);
            this.gbThongTinSV.TabIndex = 1;
            this.gbThongTinSV.TabStop = false;
            this.gbThongTinSV.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(512, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 39);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(378, 203);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 41);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnMatDinh
            // 
            this.btnMatDinh.Location = new System.Drawing.Point(246, 203);
            this.btnMatDinh.Name = "btnMatDinh";
            this.btnMatDinh.Size = new System.Drawing.Size(100, 41);
            this.btnMatDinh.TabIndex = 10;
            this.btnMatDinh.Text = "Mặt định";
            this.btnMatDinh.UseVisualStyleBackColor = true;
            this.btnMatDinh.Click += new System.EventHandler(this.btnMatDinh_Click);
            // 
            // btnHinh
            // 
            this.btnHinh.Location = new System.Drawing.Point(512, 174);
            this.btnHinh.Name = "btnHinh";
            this.btnHinh.Size = new System.Drawing.Size(100, 25);
            this.btnHinh.TabIndex = 9;
            this.btnHinh.Text = "Chọn hình";
            this.btnHinh.UseVisualStyleBackColor = true;
            this.btnHinh.Click += new System.EventHandler(this.btnHinh_Click);
            // 
            // dtbNgaySinh
            // 
            this.dtbNgaySinh.CustomFormat = "dd/mm/yyyy";
            this.dtbNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbNgaySinh.Location = new System.Drawing.Point(420, 23);
            this.dtbNgaySinh.Name = "dtbNgaySinh";
            this.dtbNgaySinh.Size = new System.Drawing.Size(192, 22);
            this.dtbNgaySinh.TabIndex = 4;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(528, 57);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(47, 21);
            this.rdNu.TabIndex = 6;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(420, 57);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(58, 21);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTk46"});
            this.cbbLop.Location = new System.Drawing.Point(420, 94);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(192, 24);
            this.cbbLop.TabIndex = 7;
            // 
            // mtbSDT
            // 
            this.mtbSDT.Location = new System.Drawing.Point(420, 135);
            this.mtbSDT.Mask = "0000.000.000";
            this.mtbSDT.Name = "mtbSDT";
            this.mtbSDT.Size = new System.Drawing.Size(192, 22);
            this.mtbSDT.TabIndex = 8;
            // 
            // mtbMa
            // 
            this.mtbMa.Location = new System.Drawing.Point(79, 25);
            this.mtbMa.Mask = "0000000";
            this.mtbMa.Name = "mtbMa";
            this.mtbMa.Size = new System.Drawing.Size(238, 22);
            this.mtbMa.TabIndex = 0;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(79, 175);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(427, 22);
            this.txtLink.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(79, 135);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(238, 22);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(79, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(238, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // gbQuanLySV
            // 
            this.gbQuanLySV.Controls.Add(this.lvSinhVien);
            this.gbQuanLySV.Location = new System.Drawing.Point(12, 268);
            this.gbQuanLySV.Name = "gbQuanLySV";
            this.gbQuanLySV.Size = new System.Drawing.Size(795, 236);
            this.gbQuanLySV.TabIndex = 0;
            this.gbQuanLySV.TabStop = false;
            this.gbQuanLySV.Text = "Quản lý sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvSinhVien.ContextMenuStrip = this.ctmsListView;
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 18);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(789, 215);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvSinhVien_ItemChecked);
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hình";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày sinh";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Phái";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Lớp";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Số điện thoại";
            this.columnHeader9.Width = 91;
            // 
            // ctmsListView
            // 
            this.ctmsListView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.stmiLoadTatCa});
            this.ctmsListView.Name = "ctmsListView";
            this.ctmsListView.Size = new System.Drawing.Size(211, 80);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(210, 24);
            this.tsmiDelete.Text = "Xóa tất cả";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(819, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // stmiLoadTatCa
            // 
            this.stmiLoadTatCa.Name = "stmiLoadTatCa";
            this.stmiLoadTatCa.Size = new System.Drawing.Size(210, 24);
            this.stmiLoadTatCa.Text = "Load lại tất cả";
            this.stmiLoadTatCa.Click += new System.EventHandler(this.stmiLoadTatCa_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 516);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbQuanLySV);
            this.Controls.Add(this.gbThongTinSV);
            this.Controls.Add(this.pbHinh);
            this.Name = "frmSinhVien";
            this.Text = "Quan lý thôg tin sinh viên khoa CNTT";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.gbThongTinSV.ResumeLayout(false);
            this.gbThongTinSV.PerformLayout();
            this.gbQuanLySV.ResumeLayout(false);
            this.ctmsListView.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.GroupBox gbThongTinSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnMatDinh;
        private System.Windows.Forms.Button btnHinh;
        private System.Windows.Forms.DateTimePicker dtbNgaySinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.MaskedTextBox mtbSDT;
        private System.Windows.Forms.MaskedTextBox mtbMa;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbQuanLySV;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip ctmsListView;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem stmiLoadTatCa;
    }
}

