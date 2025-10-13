namespace LatihanGithub
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Username tidak boleh kosong!!");
                txtUser.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Password tidak boleh kosong");
                txtPass.Focus();
                return;
            }
            if (txtUser.Text == "Admin" && txtPass.Text == "1234")
            {
                MessageBox.Show("Login Berhasil!!");
                FormMenu fd = new FormMenu();
                fd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Gagal!!");
                txtUser.Text = "";
                txtPass.Clear();
                txtUser.Clear();
            }
        }
    }
    }

