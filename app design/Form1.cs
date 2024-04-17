using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace app_design
{
    public partial class Form1 : Form
    {
        struct adat
        {
            public string sku;
            public string nev;
            public int ar;
            public string keputvonal;
            public string leiras;
        }






        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Biztos, hogy ki akarsz lépni?";
            string caption = "Kilépés";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);
            e.Cancel = !(result == DialogResult.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Biztos, hogy törlöd az utazást";
            string caption = "Törlés";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.OK) MessageBox.Show("Utazás törölve", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Adatok elmentve.";
            string caption = "Mentés";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg),(*.jpeg),(*.png)|*.jpg;*.jpeg;*.png";
            ofd.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            adat a = (adat)listBox1.SelectedItem;
            textBox1.Text = a.nev;
            textBox2.Text = a.sku;
            numericUpDown1.Value = a.ar;
            pictureBox1.Image = Image.FromFile(a.keputvonal);
            listBox4.Items.Add(a.leiras);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("..//..//..//kepek/japan_rural.jpg");
            List<adat> adatList = new List<adat>();
            adat jpn;
            jpn.sku = "japanutazas";
            jpn.nev = "Utazás japánba";
            jpn.ar = 1654370;
            jpn.keputvonal = "..//..//..//kepek/japan_rural.jpg";
            jpn.leiras = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.";

            adat indo;
            indo.sku = "indoneziaiutazas";
            indo.nev = "Utazás indonéziába";
            indo.ar = 954362;
            indo.keputvonal = "..//..//..//kepek/indonesia_bali.jpg";
            indo.leiras = "n ex turpis, tempor nec rutrum vel, sagittis vitae felis. Duis fringilla massa ut elit hendrerit, sed sollicitudin massa viverra. Fusce vestibulum ligula nibh, in dapibus neque placerat elementum. Donec fermentum ac libero nec pretium. Nulla ut posuere dolor, at tincidunt felis.";

            adat tokyo;
            tokyo.sku = "tokyoutazas";
            tokyo.nev = "Utazás Tokyoba";
            tokyo.ar = 1368843;
            tokyo.keputvonal = "..//..//..//kepek/japan_tokyo.jpg";
            tokyo.leiras = "Proin sit amet ex pellentesque, aliquam massa ac, sodales quam. Maecenas aliquam magna ut erat tempus, non euismod sem porta. Vivamus pharetra sapien sed arcu iaculis congue. Phasellus sed mattis orci, et tristique ante. Sed sagittis, ligula quis malesuada laoreet, ex diam tincidunt mauris, eget auctor risus ex eget metus.";
            adatList.Add(jpn);
            adatList.Add(tokyo);
            adatList.Add(indo);

            listBox1.DataSource = adatList;
        }
    }
}
