namespace TinhKeThua
{
    partial class FormMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXSV = new System.Windows.Forms.Button();
            this.btnSSV = new System.Windows.Forms.Button();
            this.btnTKSV = new System.Windows.Forms.Button();
            this.btnNSV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoGioiTinhSVNu = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoGioiTinhSVNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNganhHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgaySinhSV = new System.Windows.Forms.DateTimePicker();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.btnXNV = new System.Windows.Forms.Button();
            this.btnSNV = new System.Windows.Forms.Button();
            this.btnTKNV = new System.Windows.Forms.Button();
            this.btnNNV = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdoGioiTinhNVNu = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rdoGioiTinhNVNam = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSV);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnXSV);
            this.tabPage1.Controls.Add(this.btnSSV);
            this.tabPage1.Controls.Add(this.btnTKSV);
            this.tabPage1.Controls.Add(this.btnNSV);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rdoGioiTinhSVNu);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rdoGioiTinhSVNam);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtDTB);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbNganhHoc);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtNgaySinhSV);
            this.tabPage1.Controls.Add(this.txtHoTenSV);
            this.tabPage1.Controls.Add(this.txtMSSV);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(533, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QLSinhVien";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSV
            // 
            this.dgvSV.AllowUserToOrderColumns = true;
            this.dgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSV.Location = new System.Drawing.Point(3, 271);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.RowHeadersWidth = 51;
            this.dgvSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSV.Size = new System.Drawing.Size(527, 209);
            this.dgvSV.TabIndex = 32;
            this.dgvSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Form Sinh Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ tên Sinh Viên:";
            // 
            // btnXSV
            // 
            this.btnXSV.Location = new System.Drawing.Point(364, 235);
            this.btnXSV.Name = "btnXSV";
            this.btnXSV.Size = new System.Drawing.Size(75, 30);
            this.btnXSV.TabIndex = 29;
            this.btnXSV.Text = "Xóa";
            this.btnXSV.UseVisualStyleBackColor = true;
            this.btnXSV.Click += new System.EventHandler(this.btnXSV_Click);
            // 
            // btnSSV
            // 
            this.btnSSV.Location = new System.Drawing.Point(283, 235);
            this.btnSSV.Name = "btnSSV";
            this.btnSSV.Size = new System.Drawing.Size(75, 30);
            this.btnSSV.TabIndex = 28;
            this.btnSSV.Text = "Sửa";
            this.btnSSV.UseVisualStyleBackColor = true;
            // 
            // btnTKSV
            // 
            this.btnTKSV.Location = new System.Drawing.Point(183, 235);
            this.btnTKSV.Name = "btnTKSV";
            this.btnTKSV.Size = new System.Drawing.Size(92, 30);
            this.btnTKSV.TabIndex = 27;
            this.btnTKSV.Text = "Tìm kiếm";
            this.btnTKSV.UseVisualStyleBackColor = true;
            // 
            // btnNSV
            // 
            this.btnNSV.Location = new System.Drawing.Point(102, 235);
            this.btnNSV.Name = "btnNSV";
            this.btnNSV.Size = new System.Drawing.Size(75, 30);
            this.btnNSV.TabIndex = 30;
            this.btnNSV.Text = "Nhập";
            this.btnNSV.UseVisualStyleBackColor = true;
            this.btnNSV.Click += new System.EventHandler(this.btnNSV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "MSSV:";
            // 
            // rdoGioiTinhSVNu
            // 
            this.rdoGioiTinhSVNu.AutoSize = true;
            this.rdoGioiTinhSVNu.Location = new System.Drawing.Point(295, 109);
            this.rdoGioiTinhSVNu.Name = "rdoGioiTinhSVNu";
            this.rdoGioiTinhSVNu.Size = new System.Drawing.Size(41, 19);
            this.rdoGioiTinhSVNu.TabIndex = 25;
            this.rdoGioiTinhSVNu.Text = "Nữ";
            this.rdoGioiTinhSVNu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giới tính:";
            // 
            // rdoGioiTinhSVNam
            // 
            this.rdoGioiTinhSVNam.AutoSize = true;
            this.rdoGioiTinhSVNam.Checked = true;
            this.rdoGioiTinhSVNam.Location = new System.Drawing.Point(218, 109);
            this.rdoGioiTinhSVNam.Name = "rdoGioiTinhSVNam";
            this.rdoGioiTinhSVNam.Size = new System.Drawing.Size(52, 19);
            this.rdoGioiTinhSVNam.TabIndex = 26;
            this.rdoGioiTinhSVNam.TabStop = true;
            this.rdoGioiTinhSVNam.Text = "Nam";
            this.rdoGioiTinhSVNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày sinh:";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(146, 203);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(377, 21);
            this.txtDTB.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Điểm trung bình:";
            // 
            // cmbNganhHoc
            // 
            this.cmbNganhHoc.FormattingEnabled = true;
            this.cmbNganhHoc.Items.AddRange(new object[] {
            "C#",
            "API.NET",
            "SQL Server",
            "Power BI",
            "Python"});
            this.cmbNganhHoc.Location = new System.Drawing.Point(146, 171);
            this.cmbNganhHoc.Name = "cmbNganhHoc";
            this.cmbNganhHoc.Size = new System.Drawing.Size(377, 23);
            this.cmbNganhHoc.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngành học:";
            // 
            // dtNgaySinhSV
            // 
            this.dtNgaySinhSV.CustomFormat = "";
            this.dtNgaySinhSV.Location = new System.Drawing.Point(146, 136);
            this.dtNgaySinhSV.Name = "dtNgaySinhSV";
            this.dtNgaySinhSV.Size = new System.Drawing.Size(377, 21);
            this.dtNgaySinhSV.TabIndex = 22;
            this.dtNgaySinhSV.Value = new System.DateTime(2024, 9, 20, 21, 56, 41, 0);
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(146, 49);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(377, 21);
            this.txtHoTenSV.TabIndex = 20;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(146, 81);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(377, 21);
            this.txtMSSV.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvNV);
            this.tabPage2.Controls.Add(this.btnXNV);
            this.tabPage2.Controls.Add(this.btnSNV);
            this.tabPage2.Controls.Add(this.btnTKNV);
            this.tabPage2.Controls.Add(this.btnNNV);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.rdoGioiTinhNVNu);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.rdoGioiTinhNVNam);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtLuong);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.cmbChucVu);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.dtNgaySinhNV);
            this.tabPage2.Controls.Add(this.txtHoTenNV);
            this.tabPage2.Controls.Add(this.txtMSNV);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(533, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QLNhanVien";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvNV
            // 
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNV.Location = new System.Drawing.Point(3, 288);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.Size = new System.Drawing.Size(527, 192);
            this.dgvNV.TabIndex = 32;
            // 
            // btnXNV
            // 
            this.btnXNV.Location = new System.Drawing.Point(386, 250);
            this.btnXNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXNV.Name = "btnXNV";
            this.btnXNV.Size = new System.Drawing.Size(87, 30);
            this.btnXNV.TabIndex = 28;
            this.btnXNV.Text = "Xóa";
            this.btnXNV.UseVisualStyleBackColor = true;
            // 
            // btnSNV
            // 
            this.btnSNV.Location = new System.Drawing.Point(292, 250);
            this.btnSNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSNV.Name = "btnSNV";
            this.btnSNV.Size = new System.Drawing.Size(87, 30);
            this.btnSNV.TabIndex = 29;
            this.btnSNV.Text = "Sửa";
            this.btnSNV.UseVisualStyleBackColor = true;
            // 
            // btnTKNV
            // 
            this.btnTKNV.Location = new System.Drawing.Point(175, 250);
            this.btnTKNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(107, 30);
            this.btnTKNV.TabIndex = 30;
            this.btnTKNV.Text = "Tìm kiếm";
            this.btnTKNV.UseVisualStyleBackColor = true;
            // 
            // btnNNV
            // 
            this.btnNNV.Location = new System.Drawing.Point(81, 250);
            this.btnNNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNNV.Name = "btnNNV";
            this.btnNNV.Size = new System.Drawing.Size(87, 30);
            this.btnNNV.TabIndex = 31;
            this.btnNNV.Text = "Nhập";
            this.btnNNV.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Form Nhân Viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Họ tên Nhân Viên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "MSNV:";
            // 
            // rdoGioiTinhNVNu
            // 
            this.rdoGioiTinhNVNu.AutoSize = true;
            this.rdoGioiTinhNVNu.Location = new System.Drawing.Point(272, 120);
            this.rdoGioiTinhNVNu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoGioiTinhNVNu.Name = "rdoGioiTinhNVNu";
            this.rdoGioiTinhNVNu.Size = new System.Drawing.Size(41, 19);
            this.rdoGioiTinhNVNu.TabIndex = 25;
            this.rdoGioiTinhNVNu.Text = "Nữ";
            this.rdoGioiTinhNVNu.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Giới tính:";
            // 
            // rdoGioiTinhNVNam
            // 
            this.rdoGioiTinhNVNam.AutoSize = true;
            this.rdoGioiTinhNVNam.Checked = true;
            this.rdoGioiTinhNVNam.Location = new System.Drawing.Point(188, 120);
            this.rdoGioiTinhNVNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoGioiTinhNVNam.Name = "rdoGioiTinhNVNam";
            this.rdoGioiTinhNVNam.Size = new System.Drawing.Size(52, 19);
            this.rdoGioiTinhNVNam.TabIndex = 26;
            this.rdoGioiTinhNVNam.TabStop = true;
            this.rdoGioiTinhNVNam.Text = "Nam";
            this.rdoGioiTinhNVNam.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Ngày sinh:";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(133, 214);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(374, 21);
            this.txtLuong.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 222);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Lương:";
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Items.AddRange(new object[] {
            "Hiệu Trưởng",
            "Giáo Viên",
            "Thu Ngân",
            "Bảo Vệ "});
            this.cmbChucVu.Location = new System.Drawing.Point(133, 183);
            this.cmbChucVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(374, 23);
            this.cmbChucVu.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 190);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Chức vụ:";
            // 
            // dtNgaySinhNV
            // 
            this.dtNgaySinhNV.Location = new System.Drawing.Point(133, 147);
            this.dtNgaySinhNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNgaySinhNV.Name = "dtNgaySinhNV";
            this.dtNgaySinhNV.Size = new System.Drawing.Size(374, 21);
            this.dtNgaySinhNV.TabIndex = 22;
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(134, 57);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(373, 21);
            this.txtHoTenNV.TabIndex = 20;
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(134, 89);
            this.txtMSNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(374, 21);
            this.txtMSNV.TabIndex = 21;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 534);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Button btnXNV;
        private System.Windows.Forms.Button btnSNV;
        private System.Windows.Forms.Button btnTKNV;
        private System.Windows.Forms.Button btnNNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdoGioiTinhNVNu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdoGioiTinhNVNam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtNgaySinhNV;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXSV;
        private System.Windows.Forms.Button btnSSV;
        private System.Windows.Forms.Button btnTKSV;
        private System.Windows.Forms.Button btnNSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoGioiTinhSVNu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoGioiTinhSVNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNganhHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgaySinhSV;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.TextBox txtMSSV;
    }
}