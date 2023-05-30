using DataAccessLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public User user = new User();
        public Film film = new Film();
        private Film SecFilm(DataGridView d)
        {
            Film film = new Film();
            int secilen = d.SelectedCells[0].RowIndex;
            film.Id = int.Parse(d.Rows[secilen].Cells[0].Value.ToString());
            film.Ad = d.Rows[secilen].Cells[1].Value.ToString();
            film.Yonetmen = d.Rows[secilen].Cells[2].Value.ToString();
            film.Yil = int.Parse(d.Rows[secilen].Cells[3].Value.ToString());
            return film;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            button1.Text = user.Username;
            dataGridView1.DataSource = FilmRepository.Get();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            film = SecFilm(dataGridView1);
            label5.Text = film.Id.ToString();
            label6.Text = film.Ad;
            label7.Text = film.Yonetmen;
            label8.Text = film.Yil.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıForm kullanıcıForm = new KullanıcıForm();
            kullanıcıForm.user = user;
            kullanıcıForm.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (FilmRepository.Addİzlediklerim(user.Id, film.Id) > 0)
                MessageBox.Show("eklendi");
            else
                MessageBox.Show("zaten listenizde");
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FilmRepository.Addİzleyeceklerim(user.Id, film.Id) > 0)
                MessageBox.Show("eklendi", "Ok");
            else
                MessageBox.Show("Zaten Listenizde", "Cancel");
            panel1.Visible = false;
        }
    }
}
