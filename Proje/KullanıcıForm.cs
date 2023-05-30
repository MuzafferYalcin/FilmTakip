using DataAccessLayer;
using Entity;

namespace Proje
{
    public partial class KullanıcıForm : Form
    {
        public KullanıcıForm()
        {
            InitializeComponent();
        }
        public User user = new User();
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

        private void KullanıcıForm_Load(object sender, EventArgs e)
        {
            izlediklerimDGV.DataSource = FilmRepository.Getizlediklerim(user.Id);
            izleyeceklerimDGV.DataSource = FilmRepository.getIzleyecekler(user.Id);
        }

        private void izlediklerimDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Film film = SecFilm(izlediklerimDGV);
            label8.Text = film.Ad;
            label9.Text = film.Yonetmen;
            label16.Text = film.Id.ToString();
            label10.Text = film.Yil.ToString();
            panel1.Visible = true;

        }

        private void izleyeceklerimDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Film film = SecFilm(izleyeceklerimDGV);
            label11.Text = film.Ad;
            label7.Text = film.Yonetmen;
            label3.Text = film.Yil.ToString();
            label18.Text = film.Id.ToString();
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRepository.Removeİzlediklerim(user.Id, int.Parse(label16.Text));
            izlediklerimDGV.DataSource = FilmRepository.Getizlediklerim(user.Id);
            panel1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRepository.Removeİzleyeceklerim(user.Id, int.Parse(label18.Text));
            izleyeceklerimDGV.DataSource = FilmRepository.getIzleyecekler(user.Id);
            panel2.Visible = false;
        }
    }
}
