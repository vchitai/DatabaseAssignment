namespace LabAdd_1512406_1512474_1512595
{
    partial class MainForm
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDanhSachLop = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SVFindNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.classAddNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.classEditNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 74);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(322, 218);
            this.dgvSinhVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách sinh viên";
            // 
            // cbDanhSachLop
            // 
            this.cbDanhSachLop.FormattingEnabled = true;
            this.cbDanhSachLop.Location = new System.Drawing.Point(64, 34);
            this.cbDanhSachLop.Name = "cbDanhSachLop";
            this.cbDanhSachLop.Size = new System.Drawing.Size(189, 21);
            this.cbDanhSachLop.TabIndex = 3;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(259, 34);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tậpTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tậpTinToolStripMenuItem
            // 
            this.tậpTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.tậpTinToolStripMenuItem.Name = "tậpTinToolStripMenuItem";
            this.tậpTinToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tậpTinToolStripMenuItem.Text = "Tập tin";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // SVFindNameTB
            // 
            this.SVFindNameTB.Location = new System.Drawing.Point(354, 58);
            this.SVFindNameTB.Name = "SVFindNameTB";
            this.SVFindNameTB.Size = new System.Drawing.Size(113, 20);
            this.SVFindNameTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tìm SV theo tên";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(473, 55);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 25);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(473, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm lớp";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(415, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa lớp";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(473, 221);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa tên lớp";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.Location = new System.Drawing.Point(415, 264);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(75, 25);
            this.btnAddSV.TabIndex = 12;
            this.btnAddSV.Text = "Thêm SV vào lớp";
            this.btnAddSV.UseVisualStyleBackColor = true;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // classAddNameTB
            // 
            this.classAddNameTB.Location = new System.Drawing.Point(354, 109);
            this.classAddNameTB.Name = "classAddNameTB";
            this.classAddNameTB.Size = new System.Drawing.Size(100, 20);
            this.classAddNameTB.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên lớp";
            // 
            // classEditNameTB
            // 
            this.classEditNameTB.Location = new System.Drawing.Point(354, 226);
            this.classEditNameTB.Name = "classEditNameTB";
            this.classEditNameTB.Size = new System.Drawing.Size(100, 20);
            this.classEditNameTB.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tên lớp mới";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 301);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.classEditNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.classAddNameTB);
            this.Controls.Add(this.btnAddSV);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SVFindNameTB);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbDanhSachLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDanhSachLop;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.TextBox SVFindNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddSV;
        private System.Windows.Forms.TextBox classAddNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox classEditNameTB;
        private System.Windows.Forms.Label label5;
    }
}

