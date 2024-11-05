
namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool siradax = true; //ba�lang�� x 
        public string oyuncuadi1 { get; set; }
        public string oyuncuadi2 { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player1Name.Text = oyuncuadi1;
            Player2Name.Text = oyuncuadi2;
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Click += Button_Click;
                }
            }
        }
     


        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // T�klanan butonu al

            // Buton zaten doluysa i�lemi durdur
            if (button.Text != "")
                return;

            // Oyuncunun s�ras�na g�re X veya O atayal�m
            if (siradax)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            // S�ray� de�i�tirelim
            siradax = !siradax;

            // Her hamlede kazanma durumu kontrol edilebilir (opsiyonel)
            KontrolEt();
        }


        private void KontrolEt()
        {
            // Yatay kazanma kombinasyonlar�
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") || // 1. sat�r
                (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") || // 2. sat�r
                (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != ""))   // 3. sat�r
            {
                string kazanan = siradax ? "O" : "X"; // S�ra de�i�ti�i i�in bir �nceki oyuncu kazan�r
                MessageBox.Show($"{kazanan} kazand�!");
                OyunuSifirla();
                return;
            }

            // Dikey kazanma kombinasyonlar�
            if ((button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") || // 1. s�tun
                (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") || // 2. s�tun
                (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != ""))   // 3. s�tun
            {
                string kazanan = siradax ? "O" : "X"; // S�ra de�i�ti�i i�in bir �nceki oyuncu kazan�r
                MessageBox.Show($"{kazanan} kazand�!");
                OyunuSifirla();
                return;
            }

            // �apraz kazanma kombinasyonlar�
            if ((button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") || // �apraz 1
                (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != ""))   // �apraz 2
            {
                string kazanan = siradax ? "O" : "X"; // S�ra de�i�ti�i i�in bir �nceki oyuncu kazan�r
                MessageBox.Show($"{kazanan} kazand�!");
                OyunuSifirla();
                return;
            }

            // Beraberlik kontrol� (Opsiyonel)
            if (T�mButonlarDoluMu())
            {
                MessageBox.Show("Berabere!");
                OyunuSifirla();
            }
        }

        private bool T�mButonlarDoluMu()
        {
            // Butonlar�n hepsinin dolu olup olmad���n� kontrol etme
            return button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                   button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                   button7.Text != "" && button8.Text != "" && button9.Text != "";
        }

        private void OyunuSifirla()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Text = ""; // T�m butonlar�n metinlerini temizle
                }
            }
            siradax = true; // Oyun tekrar ba�lad���nda X ba�las�n
        }



        //private void KontrolEt()
        //{
        //    // Yatay kazanma kombinasyonlar� (3'l� gruplar)
        //    if ((button3.Text == button2.Text && button2.Text == button1.Text && button3.Text != "") || // 1. sat�r
        //        (button2.Text == button1.Text && button1.Text == button6.Text && button2.Text != "") || // 1. sat�r
        //        (button1.Text == button6.Text && button6.Text == button5.Text && button1.Text != "") || // 1. sat�r
        //        (button6.Text == button5.Text && button5.Text == button4.Text && button6.Text != "") || // 2. sat�r
        //        (button5.Text == button4.Text && button4.Text == button9.Text && button5.Text != "") || // 2. sat�r
        //        (button4.Text == button9.Text && button9.Text == button10.Text && button4.Text != "") || // 2. sat�r
        //        (button11.Text == button12.Text && button12.Text == button13.Text && button11.Text != "") || // 3. sat�r
        //        (button12.Text == button13.Text && button13.Text == button8.Text && button12.Text != "") || // 3. sat�r
        //        (button13.Text == button8.Text && button8.Text == button7.Text && button13.Text != "")) // 3. sat�r
        //    {
        //        string kazanan = siradax ? "O" : "X"; // S�ra de�i�ti�i i�in bir �nceki oyuncu kazan�r
        //        MessageBox.Show($"{kazanan} kazand�!");
        //        OyunuSifirla();
        //        return;
        //    }

        //    // Dikey kazanma kombinasyonlar� (3'l� gruplar)
        //    if ((button3.Text == button6.Text && button6.Text == button11.Text && button3.Text != "") || // 1. s�tun
        //        (button2.Text == button5.Text && button5.Text == button12.Text && button2.Text != "") || // 2. s�tun
        //        (button1.Text == button4.Text && button4.Text == button13.Text && button1.Text != "") || // 3. s�tun
        //        (button6.Text == button9.Text && button9.Text == button8.Text && button6.Text != "") || // 4. s�tun
        //        (button5.Text == button10.Text && button10.Text == button7.Text && button5.Text != ""))  // 5. s�tun
        //    {
        //        string kazanan = siradax ? "O" : "X";
        //        MessageBox.Show($"{kazanan} kazand�!");
        //        OyunuSifirla();
        //        return;
        //    }

        //    // �apraz kazanma kombinasyonlar�
        //    if ((button3.Text == button5.Text && button5.Text == button13.Text && button3.Text != "") || // Sol �stten sa� alta
        //        (button5.Text == button9.Text && button9.Text == button11.Text && button5.Text != ""))   // Sa� �stten sol alta
        //    {
        //        string kazanan = siradax ? "O" : "X";
        //        MessageBox.Show($"{kazanan} kazand�!");
        //        OyunuSifirla();
        //        return;
        //    }

        //    // Beraberlik durumu kontrol�
        //    else if (T�mButonlarDoluMu())
        //    {
        //        MessageBox.Show("Berabere!");
        //        OyunuSifirla();
        //    }
        //}

        //private void KontrolEt()
        //{
        //    // 3x5 d�zeni i�in kazanma kombinasyonlar�
        //    if ((button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == button4.Text && button4.Text == button5.Text && button1.Text != "") || // �lk sat�r
        //        (button6.Text == button7.Text && button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == button10.Text && button6.Text != "") || // �kinci sat�r
        //        (button11.Text == button12.Text && button12.Text == button13.Text && button13.Text == button14.Text && button14.Text == button15.Text && button11.Text != "") || // ���nc� sat�r
        //        (button1.Text == button6.Text && button6.Text == button11.Text && button11.Text != "") || // �lk s�tun
        //        (button2.Text == button7.Text && button7.Text == button12.Text && button12.Text != "") || // �kinci s�tun
        //        (button3.Text == button8.Text && button8.Text == button13.Text && button13.Text != "") || // ���nc� s�tun
        //        (button4.Text == button9.Text && button9.Text == button14.Text && button14.Text != "") || // D�rd�nc� s�tun
        //        (button5.Text == button10.Text && button10.Text == button15.Text && button15.Text != "") || // Be�inci s�tun
        //        (button1.Text == button7.Text && button7.Text == button13.Text && button13.Text != "") || // �apraz 1 (Sol �stten sa� alta)
        //        (button5.Text == button9.Text && button9.Text == button11.Text && button11.Text != ""))   // �apraz 2 (Sa� �stten sol alta)
        //    {
        //        string kazanan = siradax ? "O" : "X"; // S�ra de�i�ti�i i�in bir �nceki oyuncu kazan�r
        //        MessageBox.Show($"{kazanan} kazand�!");
        //        OyunuSifirla();
        //    }
        //    else if (T�mButonlarDoluMu())
        //    {
        //        MessageBox.Show("Berabere!");
        //        OyunuSifirla();
        //    }
        //}

        // T�m butonlar dolu mu diye kontrol eden yard�mc� metod
        //private bool T�mButonlarDoluMu()
        //{
        //    foreach (Control control in this.Controls)
        //    {
        //        if (control is Button button && button.Text == "")
        //            return false;
        //    }
        //    return true;
        //}

        //// Oyun bitince butonlar� s�f�rlayan metod
        //private void OyunuSifirla()
        //{
        //    foreach (Control control in this.Controls)
        //    {




        //    }
        //}



    }
}
