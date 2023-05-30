using DataAccessLayer;
using Entity;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
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


        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void btnGiriþ_Click(object sender, EventArgs e)
        {
            user = UserRepository.GetUser(TxtUsername.Text.ToString(), TxtPassword.Text);

            if (user.Id > 0)
            {
                AnaSayfa a = new AnaSayfa();
                a.user = UserRepository.GetUser(TxtUsername.Text, TxtPassword.Text);
                a.Show();
                this.Hide();
            }

            else
                MessageBox.Show("baþarýsýz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Ad = textBox8.Text;
            u.Username = textBox9.Text;
            u.Email = textBox10.Text;
            u.Password = textBox11.Text;
            UserRepository.Add(u);
            AnaSayfa a = new AnaSayfa();
            a.user = UserRepository.GetUser(u.Username, u.Password);
            a.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;

        }
    }
}