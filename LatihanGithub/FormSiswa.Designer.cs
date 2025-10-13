namespace LatihanGithub
{
    partial class FormSiswa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNISN = new TextBox();
            txtTelepon = new TextBox();
            txtNama = new TextBox();
            dgvSiswa = new DataGridView();
            btnKembali = new Button();
            btnSimpan = new Button();
            btnHapus = new Button();
            dtpTanggalLahir = new DateTimePicker();
            cmbKelas = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 24);
            label1.Name = "label1";
            label1.Size = new Size(139, 29);
            label1.TabIndex = 0;
            label1.Text = "Data Siswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 98);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 1;
            label2.Text = "NISN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 144);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 2;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(179, 191);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 3;
            label4.Text = "Kelas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 237);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 4;
            label5.Text = "Nomor Telepon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(111, 285);
            label6.Name = "label6";
            label6.Size = new Size(127, 23);
            label6.TabIndex = 5;
            label6.Text = "Tanggal Lahir";
            // 
            // txtNISN
            // 
            txtNISN.Location = new Point(299, 94);
            txtNISN.Name = "txtNISN";
            txtNISN.Size = new Size(399, 31);
            txtNISN.TabIndex = 6;
            txtNISN.TextChanged += txtNISN_TextChanged;
            // 
            // txtTelepon
            // 
            txtTelepon.Location = new Point(299, 233);
            txtTelepon.Name = "txtTelepon";
            txtTelepon.Size = new Size(399, 31);
            txtTelepon.TabIndex = 8;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(299, 140);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(399, 31);
            txtNama.TabIndex = 10;
            // 
            // dgvSiswa
            // 
            dgvSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiswa.Location = new Point(12, 449);
            dgvSiswa.Name = "dgvSiswa";
            dgvSiswa.RowHeadersWidth = 62;
            dgvSiswa.Size = new Size(822, 195);
            dgvSiswa.TabIndex = 11;
            dgvSiswa.CellContentClick += dgvSiswa_CellContentClick;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(157, 373);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 12;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(359, 373);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(566, 373);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 14;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(299, 279);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(399, 31);
            dtpTanggalLahir.TabIndex = 15;
            // 
            // cmbKelas
            // 
            cmbKelas.FormattingEnabled = true;
            cmbKelas.Items.AddRange(new object[] { "", "XII RPL", "XII BUSANA", "XII KIMIA", "XII PERHOTELAN", "XII KECANTIKAN" });
            cmbKelas.Location = new Point(299, 187);
            cmbKelas.Name = "cmbKelas";
            cmbKelas.Size = new Size(399, 33);
            cmbKelas.TabIndex = 16;
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 655);
            Controls.Add(cmbKelas);
            Controls.Add(dtpTanggalLahir);
            Controls.Add(btnHapus);
            Controls.Add(btnSimpan);
            Controls.Add(btnKembali);
            Controls.Add(dgvSiswa);
            Controls.Add(txtNama);
            Controls.Add(txtTelepon);
            Controls.Add(txtNISN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSiswa";
            Text = "FormSiswa";
            Load += FormSiswa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNISN;
        private TextBox txtTelepon;
        private TextBox txtNama;
        private DataGridView dgvSiswa;
        private Button btnKembali;
        private Button btnSimpan;
        private Button btnHapus;
        private DateTimePicker dtpTanggalLahir;
        private ComboBox cmbKelas;
    }
}