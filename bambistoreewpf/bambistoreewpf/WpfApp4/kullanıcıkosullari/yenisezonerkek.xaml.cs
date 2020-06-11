using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp4.usercontrollers;

namespace WpfApp4.kullanıcıkosullari
{
    /// <summary>
    /// Interaction logic for yenisezonerkek.xaml
    /// </summary>
    public partial class yenisezonerkek : Window
    {//yenisezon
        public yenisezonerkek()
        {
            InitializeComponent();
        }
        private void Getdata()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53855/");

            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            var urun = new Urun();

            urun.isim = siyahkadinayakkabi.Content.ToString();


            var response = client.PostAsJsonAsync("api/Uruns", urun).Result;

        }
      
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Maximized;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ticimax.com/");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            scrollviewer.ScrollToVerticalOffset(0);
        }

        private void facebook_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/bambionline");
        }

        private void Twitter_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/bambiayakkabi");
        }

        private void instagram_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/bambiayakkabi/");
        }


        private void arama_Click(object sender, RoutedEventArgs e)
        {
            if (aramaborderi.Visibility == Visibility.Visible)
            {
                aramaborderi.Visibility = Visibility.Hidden;
                uyeyerigrid.Visibility = Visibility.Visible;
            }
            else if (aramaborderi.Visibility == Visibility.Hidden)
            {
                aramaborderi.Visibility = Visibility.Visible;
                uyeyerigrid.Visibility = Visibility.Hidden;
            }

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            sepetimborder.Visibility = Visibility.Visible;
            uyeyerigrid.Visibility = Visibility.Hidden;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            sepetimborder.Visibility = Visibility.Hidden;
            uyeyerigrid.Visibility = Visibility.Visible;
        }

        private void erkekbut_MouseEnter(object sender, MouseEventArgs e)
        {
            erkekkategori.Visibility = Visibility.Visible;
        }
        private void erkekbut_MouseLeave_1(object sender, MouseEventArgs e)
        {
            erkekkategori.Visibility = Visibility.Hidden;
        }

        private void kadinkategori_MouseEnter(object sender, MouseEventArgs e)
        {
            kadinkategori.Visibility = Visibility.Visible;
        }

        private void kadinkategori_MouseLeave(object sender, MouseEventArgs e)
        {
            kadinkategori.Visibility = Visibility.Hidden;
        }
        private void kullanımsart_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            Page1 main = new Page1();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void iletisim_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            iletisim main = new iletisim();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void hakkimizda_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            hakkimizda main = new hakkimizda();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void gizlilikguven_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            gizlilikguvenlik main = new gizlilikguvenlik();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void iptaliadekosul_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            iptalveiade main = new iptalveiade();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void islemrehberi_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            islemrehberi main = new islemrehberi();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void guvenlialisveris_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            guvenlialisveris main = new guvenlialisveris();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void siparislerim_Click(object sender, RoutedEventArgs e)
        {
            Window window = new siparislerim();
            window.Show();
            this.Close();

        }

        private void alisverissepetim_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepetim main = new sepetim();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void anasayfa_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            MainWindow main = new MainWindow();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }

        }



        private void siparistakip_Click_(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void uyegirisi_Click(object sender, RoutedEventArgs e)
        {

            Window window = new uyegirisi();
            window.Show();
            this.Close();

        }

        private void cikisyap_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.uyeyerigrid.Visibility = Visibility.Visible;
            main.uyeyeri44.Visibility = Visibility.Hidden;
            main.Show();
            this.Close();
        }

        private void favoriekle_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle.Visibility = Visibility.Visible;
            sepeteeklee.Visibility = Visibility.Visible;
        }

        private void favoriekle_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle.Visibility = Visibility.Hidden;
            sepeteeklee.Visibility = Visibility.Hidden;
        }
        private void favoriekle1_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle.Visibility = Visibility.Visible;
            sepeteeklee.Visibility = Visibility.Visible;
        }

        private void favoriekle1_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle.Visibility = Visibility.Hidden;
            sepeteeklee.Visibility = Visibility.Hidden;
        }
        private void favoriekle2_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle2.Visibility = Visibility.Visible;
            sepeteeklee2.Visibility = Visibility.Visible;
        }

        private void favoriekle2_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle2.Visibility = Visibility.Hidden;
            sepeteeklee2.Visibility = Visibility.Hidden;
        }
        private void favoriekle3_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle3.Visibility = Visibility.Visible;
            sepeteeklee3.Visibility = Visibility.Visible;
        }

        private void favoriekle3_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle3.Visibility = Visibility.Hidden;
            sepeteeklee3.Visibility = Visibility.Hidden;
        }
        private void favoriekle4_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle4.Visibility = Visibility.Visible;
            sepeteeklee4.Visibility = Visibility.Visible;
        }

        private void favoriekle4_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle4.Visibility = Visibility.Hidden;
            sepeteeklee4.Visibility = Visibility.Hidden;
        }
      

       


        private void favoriekle_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle2_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle3_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle4_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle5_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle6_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle7_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle8_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle9_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle10_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle11_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }

        }

        private void sepeteeklee_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "SİYAH";
            urunusepet.image0.Source = image444.Source;
            urunusepet.image2.Source = image444.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"/images/erkekbot/black-baskili-erkek-bot-k1111122601-f5d3", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = " Black Baskili Erkek Bot k1111122601";
            urunusepet.labe3.Text = label1.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati1.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee2_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "PUDRA";
            urunusepet.image0.Source = image445.Source;
            urunusepet.image2.Source = image445.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"/images/erkekbot/black-erkek-bot-k1111110403-d3ae", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "Black-erkek-bot-k1111110403-d3ae";
            urunusepet.labe3.Text = label2.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati2.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee3_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "BEYAZ";
            urunusepet.image0.Source = image446.Source;
            urunusepet.image2.Source = image446.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"/images/erkekbot/black-erkek-bot-k1111119301-f72a", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "Black-erkek-bot-k1111119301-f72";
            urunusepet.labe3.Text = label3.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati3.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee4_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "SİYAH";
            urunusepet.image0.Source = image447.Source;
            urunusepet.image2.Source = image447.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"/images/images/erkekbot/black-erkek-bot-k1111123603-8a4e", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "BLACK Erkek BOT K0777009603";
            urunusepet.labe3.Text = label4.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati4.Text;
            UrunOzellikleri ozellik = new UrunOzellikleri();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        
      


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            uyeol uyeol = new uyeol();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                uyeol.uyeyerigrid.Visibility = Visibility.Hidden;
                uyeol.uyeyeri44.Visibility = Visibility.Visible;
                uyeol.Show();
                this.Close();
            }
            else
            {
                uyeol.Show();
                this.Close();
            }
            this.Close();
        }

        private void stoktakiler_Click(object sender, RoutedEventArgs e)
        {
            YeniSezon main = new YeniSezon();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }
        private void yenisezonkadin_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            YeniSezon main = new YeniSezon();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }



        private void yenisezonerkek_Click(object sender, RoutedEventArgs e)
        {
            yenisezonerkek main = new yenisezonerkek();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void Canta_Click(object sender, RoutedEventArgs e)
        {
            canta main = new canta();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void kadinbot_Click(object sender, RoutedEventArgs e)
        {
            kadinbot main = new kadinbot();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void kadincizme_Click(object sender, RoutedEventArgs e)
        {
            kadincizme main = new kadincizme();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void kadinsneak_Click(object sender, RoutedEventArgs e)
        {
            KadinSneaker main = new KadinSneaker();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            Grid.SetColumn(BlackBaskiliErkekBotk1111122601, 1);
            Grid.SetColumn(BlackErkekBotk1111110403, 3);
            Grid.SetColumn(Blackerkekbotk11111236034f99, 5);
            Grid.SetColumn(Blackerkekbotk1111119301806b, 7);
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {//artan
            Grid.SetColumn(BlackBaskiliErkekBotk1111122601, 5);
            Grid.SetColumn(BlackErkekBotk1111110403, 1);
            Grid.SetColumn(Blackerkekbotk11111236034f99, 3);
            Grid.SetColumn(Blackerkekbotk1111119301806b, 7);
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            //aazalan
            Grid.SetColumn(BlackBaskiliErkekBotk1111122601, 3);
            Grid.SetColumn(BlackErkekBotk1111110403, 7);
            Grid.SetColumn(Blackerkekbotk11111236034f99, 5);
            Grid.SetColumn(Blackerkekbotk1111119301806b, 1);
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Grid.SetColumn(BlackBaskiliErkekBotk1111122601, 7);
            Grid.SetColumn(BlackErkekBotk1111110403, 5);
            Grid.SetColumn(Blackerkekbotk11111236034f99, 3);
            Grid.SetColumn(Blackerkekbotk1111119301806b, 1);
        }
    }
}
