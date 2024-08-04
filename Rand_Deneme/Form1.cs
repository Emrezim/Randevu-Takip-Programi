using Rand_Deneme;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace MotoServisRandevuSistemi
{
    public partial class Form1 : Form
    {
        private Dictionary<DateTime, Tuple<string, string>> randevular = new Dictionary<DateTime, Tuple<string, string>>();
        private DateTime seciliGun;
        private readonly string randevuDosyaYolu = "randevular.json";

        public Form1()
        {
            InitializeComponent();
            RandevulariYukle();
            InitializeCalendar();
            InitializeTimer();
        }

        private void InitializeCalendar()
        {
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.DateSelected += monthCalendar_DateSelected_1;
            monthCalendar.BoldedDates = randevular.Keys.ToArray();
        }

        private void InitializeTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 60000; // 1 dakika
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            var geçmişRandevular = randevular.Keys.Where(k => k <= now).ToList();
            foreach (var randevu in geçmişRandevular)
            {
                randevular.Remove(randevu);
            }
            monthCalendar.BoldedDates = randevular.Keys.ToArray();
            monthCalendar.Invalidate();
            RandevulariKaydet(); // Silindikten sonra dosyaya kaydet
        }

        private void GunuGoster(DateTime gun)
        {
            listBoxSaatler.Items.Clear();
            for (int i = 9; i <= 19; i++)
            {
                string saat = $"{i}:30";
                DateTime randevuZamani = new DateTime(gun.Year, gun.Month, gun.Day, i, 30, 0);
                string bilgi = randevular.ContainsKey(randevuZamani) ? randevular[randevuZamani].Item1 : "Boş";
                listBoxSaatler.Items.Add($"{saat} - {bilgi}");
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            seciliGun = e.Start;
            GunuGoster(seciliGun);
        }

        private void monthCalendar_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            seciliGun = e.Start;
            GunuGoster(seciliGun);
        }

        private void buttonRandevuEkle_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxIsim.Text) && !string.IsNullOrEmpty(richTextBoxDetay.Text))
            {
                if (listBoxSaatler.SelectedItem != null)
                {
                    string seciliSaat = listBoxSaatler.SelectedItem.ToString().Split('-')[0].Trim();
                    DateTime randevuZamani = DateTime.Parse($"{seciliGun.ToShortDateString()} {seciliSaat}");

                    if (!randevular.ContainsKey(randevuZamani))
                    {
                        randevular[randevuZamani] = new Tuple<string, string>(textBoxIsim.Text, richTextBoxDetay.Text);
                        GunuGoster(seciliGun);
                        monthCalendar.BoldedDates = randevular.Keys.ToArray();
                        textBoxIsim.Text = string.Empty; // TextBox'ı temizle
                        richTextBoxDetay.Text = string.Empty; // RichTextBox'ı temizle
                        RandevulariKaydet(); // Randevu eklendikten sonra dosyaya kaydet
                    }
                    else
                    {
                        MessageBox.Show("Bu saat için zaten bir randevu var.");
                    }
                }
                else
                {
                    MessageBox.Show("Bir saat seçiniz.");
                }
            }
            else
            {
                MessageBox.Show("İsim ve detay alanları boş olamaz.");
            }
        }

        private void buttonRandSil_Click(object sender, EventArgs e)
        {
            if (listBoxSaatler.SelectedItem != null)
            {
                string seciliSaat = listBoxSaatler.SelectedItem.ToString().Split('-')[0].Trim();
                DateTime randevuZamani = DateTime.Parse($"{seciliGun.ToShortDateString()} {seciliSaat}");

                if (randevular.ContainsKey(randevuZamani))
                {
                    randevular.Remove(randevuZamani);
                    GunuGoster(seciliGun);
                    monthCalendar.BoldedDates = randevular.Keys.ToArray();
                    RandevulariKaydet(); // Randevu silindikten sonra dosyaya kaydet
                }
                else
                {
                    MessageBox.Show("Seçili saat için bir randevu bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Bir saat seçiniz.");
            }
        }

        private void listBoxSaatler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxSaatler.SelectedItem != null)
            {
                string seciliSaat = listBoxSaatler.SelectedItem.ToString().Split('-')[0].Trim();
                DateTime randevuZamani = DateTime.Parse($"{seciliGun.ToShortDateString()} {seciliSaat}");

                if (randevular.ContainsKey(randevuZamani))
                {
                    var randevuBilgileri = randevular[randevuZamani];
                    Form2 form2 = new Form2(randevuZamani, randevuBilgileri.Item1, randevuBilgileri.Item2);
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seçili saat için bir randevu bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Bir saat seçiniz.");
            }
        }

        private void RandevulariKaydet()
        {
            string json = JsonSerializer.Serialize(randevular);
            File.WriteAllText(randevuDosyaYolu, json);
        }

        private void RandevulariYukle()
        {
            if (File.Exists(randevuDosyaYolu))
            {
                string json = File.ReadAllText(randevuDosyaYolu);
                randevular = JsonSerializer.Deserialize<Dictionary<DateTime, Tuple<string, string>>>(json);
            }
        }
    }
}
