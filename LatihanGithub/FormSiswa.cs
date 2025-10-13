using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanGithub
{
    public partial class FormSiswa : Form
    {
        string connectionString = "server=localhost;database=dbsekolah;uid=root;pwd=;";
        int selectedId = 0;

        public FormSiswa()
        {
            InitializeComponent();
        }

        private void TampilData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, nisn, nama, kelas, telepon, tanggal_lahir FROM siswa";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSiswa.DataSource = dt;

                    if (dgvSiswa.Columns["id"] != null)
                        dgvSiswa.Columns["id"].Visible = false;

                    if (dgvSiswa.Columns["nisn"] != null) dgvSiswa.Columns["nisn"].HeaderText = "NISN";
                    if (dgvSiswa.Columns["nama"] != null) dgvSiswa.Columns["nama"].HeaderText = "Nama";
                    if (dgvSiswa.Columns["kelas"] != null) dgvSiswa.Columns["kelas"].HeaderText = "Kelas";
                    if (dgvSiswa.Columns["telepon"] != null) dgvSiswa.Columns["telepon"].HeaderText = "Telepon";
                    if (dgvSiswa.Columns["tanggal_lahir"] != null) dgvSiswa.Columns["tanggal_lahir"].HeaderText = "Tanggal Lahir";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }


        private void txtNISN_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSiswa.Rows[e.RowIndex];

                if (row.Cells["id"].Value != DBNull.Value)
                    selectedId = Convert.ToInt32(row.Cells["id"].Value);
                else
                    selectedId = 0;

                txtNISN.Text = row.Cells["nisn"].Value?.ToString();
                txtNama.Text = row.Cells["nama"].Value?.ToString();
                cmbKelas.Text = row.Cells["kelas"].Value?.ToString(); // ← ini yang diganti
                txtTelepon.Text = row.Cells["telepon"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["tanggal_lahir"].Value?.ToString(), out DateTime dt))
                    dtpTanggalLahir.Value = dt;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nisn = txtNISN.Text.Trim();
            string nama = txtNama.Text.Trim();
            string kelas = cmbKelas.Text.Trim();
            string telepon = txtTelepon.Text.Trim();
            string tanggal = dtpTanggalLahir.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(nisn) || string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Isi minimal NISN dan Nama.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();

                    if (selectedId == 0)
                    {
                        cmd.CommandText = @"INSERT INTO siswa (nisn, nama, kelas, telepon, tanggal_lahir)
                                            VALUES (@nisn, @nama, @kelas, @telepon, @tanggal)";
                        cmd.Parameters.AddWithValue("@nisn", nisn);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@kelas", kelas);
                        cmd.Parameters.AddWithValue("@telepon", telepon);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil ditambahkan.");
                    }
                    else
                    {
                        cmd.CommandText = @"UPDATE siswa 
                                            SET nisn=@nisn, nama=@nama, kelas=@kelas, telepon=@telepon, tanggal_lahir=@tanggal
                                            WHERE id=@id";
                        cmd.Parameters.AddWithValue("@nisn", nisn);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@kelas", kelas);
                        cmd.Parameters.AddWithValue("@telepon", telepon);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil diubah.");
                    }
                }

                TampilData();
                BersihkanForm();
            }
            catch (MySqlException mex)
            {
                MessageBox.Show("Kesalahan database: " + mex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.");
                return;
            }

            var konfirmasi = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (konfirmasi != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM siswa WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil dihapus.");
                TampilData();
                BersihkanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
            }
        }

        private void BersihkanForm()
        {
            selectedId = 0;
            txtNISN.Clear();
            txtNama.Clear();
            cmbKelas.SelectedIndex = -1;
            txtTelepon.Clear();
            dtpTanggalLahir.Value = DateTime.Now;

            if (dgvSiswa.CurrentRow != null)
                dgvSiswa.ClearSelection();
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            TampilData();
            dgvSiswa.CellClick += dgvSiswa_CellClick;
        }
        private void dgvSiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSiswa.Rows[e.RowIndex];

                if (row.Cells["id"].Value != DBNull.Value)
                    selectedId = Convert.ToInt32(row.Cells["id"].Value);
                else
                    selectedId = 0;

                txtNISN.Text = row.Cells["nisn"].Value?.ToString();
                txtNama.Text = row.Cells["nama"].Value?.ToString();
                cmbKelas.Text = row.Cells["kelas"].Value?.ToString(); // ← ini yang diganti
                txtTelepon.Text = row.Cells["telepon"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["tanggal_lahir"].Value?.ToString(), out DateTime dt))
                    dtpTanggalLahir.Value = dt;
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }
    }
}