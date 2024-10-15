namespace Lap_Giuaki
{
    partial class frmsinhvien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvsinhvien = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnfix = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpngaysinh);
            this.groupBox1.Controls.Add(this.cmbkhoa);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmsv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(96, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Location = new System.Drawing.Point(82, 87);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(198, 20);
            this.dtpngaysinh.TabIndex = 8;
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Location = new System.Drawing.Point(377, 83);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(188, 21);
            this.cmbkhoa.TabIndex = 7;
            this.cmbkhoa.SelectedIndexChanged += new System.EventHandler(this.cmbkhoa_SelectedIndexChanged);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(377, 34);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(188, 20);
            this.txthoten.TabIndex = 5;
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(82, 34);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(198, 20);
            this.txtmsv.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // dgvsinhvien
            // 
            this.dgvsinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsinhvien.Location = new System.Drawing.Point(12, 238);
            this.dgvsinhvien.Name = "dgvsinhvien";
            this.dgvsinhvien.Size = new System.Drawing.Size(776, 200);
            this.dgvsinhvien.TabIndex = 1;
            this.dgvsinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsinhvien_CellClick);
            this.dgvsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsinhvien_CellContentClick);
            this.dgvsinhvien.SelectionChanged += new System.EventHandler(this.dgvsinhvien_SelectionChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(178, 157);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btnfix
            // 
            this.btnfix.Location = new System.Drawing.Point(259, 157);
            this.btnfix.Name = "btnfix";
            this.btnfix.Size = new System.Drawing.Size(75, 23);
            this.btnfix.TabIndex = 3;
            this.btnfix.Text = "Sửa";
            this.btnfix.UseVisualStyleBackColor = true;
            this.btnfix.Click += new System.EventHandler(this.btnfix_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(346, 157);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(627, 184);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(146, 202);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(188, 20);
            this.txttimkiem.TabIndex = 7;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btntimkiem
            // 
            this.btntimkiem.AutoSize = true;
            this.btntimkiem.Location = new System.Drawing.Point(364, 199);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 8;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // frmsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnfix);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvsinhvien);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmsinhvien";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.frmsinhvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvsinhvien;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnfix;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
    }
}

