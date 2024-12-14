namespace WinFormsAppMacKadrosu
{
    public partial class Form1 : Form
    {
        private int kaleciSayisi = 0;
        private int defansSayisi = 0;
        private int ortaSahaSayisi = 0;
        private int forvetSayisi = 0;

        private int maxKaleci = 1;
        private int maxDefans = 4;
        private int maxOrtaSaha = 4;
        private int maxForvet = 2;

        private bool dizilisSecildiMi = false;

        public Form1()
        {
            InitializeComponent();

            // Diziliþ seçeneklerini ComboBox'a ekle
            comboBoxDizilis.Items.Add("4-4-2");
            comboBoxDizilis.Items.Add("4-3-3");
            comboBoxDizilis.Items.Add("3-5-2");
            comboBoxDizilis.SelectedIndex = -1; // Varsayýlan olarak boþ býrakýlýr

            // Oyuncularý mevkilere göre ayýr
            List<string> kaleciler = new List<string> { "Dominik Livakovic", "Ýrfancan Eðribayat" };
            List<string> defanslar = new List<string> { "Samet Akaydin", "Çaðlar Söyüncü", "Alexander Djiku", "Mert Müldür", "Jayden Oosterwolde", "Rodrigo Becao" };
            List<string> ortaSahalar = new List<string> { "Ýsmail Yüksek", "Mert Hakan Yandaþ", "Fred", "Ýrfan Can Kahveci", "Sofyan Amrabat", "Sebastian Szymanski" };
            List<string> forvetler = new List<string> { "Edin Dzeko", "Dusan Tadic", "Youssef En-Nesyri", "Cengiz Ünder", "Bright Osayi-Samuel", "Cenk Tosun", "Allan Saint-Maximin" };

            foreach (var oyuncu in kaleciler) comboBoxKaleciler.Items.Add(oyuncu);
            foreach (var oyuncu in defanslar) comboBoxDefanslar.Items.Add(oyuncu);
            foreach (var oyuncu in ortaSahalar) comboBoxOrtaSaha.Items.Add(oyuncu);
            foreach (var oyuncu in forvetler) comboBoxForvetler.Items.Add(oyuncu);

            // Diziliþ deðiþikliðini algýla
            comboBoxDizilis.SelectedIndexChanged += ComboBoxDizilis_SelectedIndexChanged;
        }

        private void ComboBoxDizilis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDizilis.SelectedIndex != -1)
            {
                dizilisSecildiMi = true;

                string selectedDizilis = comboBoxDizilis.SelectedItem.ToString();

                if (selectedDizilis == "4-4-2")
                {
                    maxKaleci = 1;
                    maxDefans = 4;
                    maxOrtaSaha = 4;
                    maxForvet = 2;
                }
                else if (selectedDizilis == "4-3-3")
                {
                    maxKaleci = 1;
                    maxDefans = 4;
                    maxOrtaSaha = 3;
                    maxForvet = 3;
                }
                else if (selectedDizilis == "3-5-2")
                {
                    maxKaleci = 1;
                    maxDefans = 3;
                    maxOrtaSaha = 5;
                    maxForvet = 2;
                }

                MessageBox.Show($"Diziliþ seçildi: {selectedDizilis}. Þimdi diziliþe göre oyucu seçimi yapabilirsiniz");
            }
        }

        private void buttonKadroyaEkle_Click(object sender, EventArgs e)
        {
            if (!dizilisSecildiMi)
            {
                MessageBox.Show("Lütfen önce bir diziliþ seçin!");
                return;
            }

            string secilenOyuncu = null;

            if (comboBoxKaleciler.SelectedItem != null && kaleciSayisi < maxKaleci)
            {
                secilenOyuncu = comboBoxKaleciler.SelectedItem.ToString();
                kaleciSayisi++;
            }
            else if (comboBoxDefanslar.SelectedItem != null && kaleciSayisi == maxKaleci && defansSayisi < maxDefans)
            {
                secilenOyuncu = comboBoxDefanslar.SelectedItem.ToString();
                defansSayisi++;
            }
            else if (comboBoxOrtaSaha.SelectedItem != null && defansSayisi == maxDefans && ortaSahaSayisi < maxOrtaSaha)
            {
                secilenOyuncu = comboBoxOrtaSaha.SelectedItem.ToString();
                ortaSahaSayisi++;
            }
            else if (comboBoxForvetler.SelectedItem != null && ortaSahaSayisi == maxOrtaSaha && forvetSayisi < maxForvet)
            {
                secilenOyuncu = comboBoxForvetler.SelectedItem.ToString();
                forvetSayisi++;
            }
            else
            {
                MessageBox.Show("Oyuncu ekleme sýrasýna dikkat edin! Seçilen diziliþe göre kadroyu tamamlayýn.");
                return;
            }

            if (listBoxMacKadrosu.Items.Contains(secilenOyuncu))
            {
                MessageBox.Show("Bu oyuncu zaten maç kadrosunda!");
                return;
            }

            if (listBoxMacKadrosu.Items.Count < 11)
            {
                listBoxMacKadrosu.Items.Add(secilenOyuncu);
            }
            else
            {
                MessageBox.Show("Maç kadrosunda maksimum 11 oyuncu olabilir!");
            }
        }

        private void buttonKadrodanCikar_Click(object sender, EventArgs e)
        {
            if (listBoxMacKadrosu.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen kadrodan çýkarýlacak bir oyuncu seçin!");
                return;
            }

            string secilenOyuncu = listBoxMacKadrosu.SelectedItem.ToString();

            if (comboBoxKaleciler.Items.Contains(secilenOyuncu)) kaleciSayisi--;
            else if (comboBoxDefanslar.Items.Contains(secilenOyuncu)) defansSayisi--;
            else if (comboBoxOrtaSaha.Items.Contains(secilenOyuncu)) ortaSahaSayisi--;
            else if (comboBoxForvetler.Items.Contains(secilenOyuncu)) forvetSayisi--;

            listBoxMacKadrosu.Items.RemoveAt(listBoxMacKadrosu.SelectedIndex);
        }

        private void buttonKadroyuTemizle_Click(object sender, EventArgs e)
        {
            listBoxMacKadrosu.Items.Clear();
            kaleciSayisi = 0;
            defansSayisi = 0;
            ortaSahaSayisi = 0;
            forvetSayisi = 0;
            dizilisSecildiMi = false;
            comboBoxDizilis.SelectedIndex = -1;
        }        
    }
}
