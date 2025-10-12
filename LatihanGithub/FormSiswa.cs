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
        string koneksi = "server=localhost;database=dbsekolah;uid=root;pwd=;";
        public FormSiswa()
        {
            InitializeComponent();
        }

        private void txtNISN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
