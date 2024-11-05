
namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool siradax = true; //baþlangýç x 
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
            Button button = (Button)sender; // Týklanan butonu al

            // Buton zaten doluysa iþlemi durdur
            if (button.Text != "")
                return;

            // Oyuncunun sýrasýna göre X veya O atayalým
            if (siradax)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            // Sýrayý deðiþtirelim
            siradax = !siradax;

            // Her hamlede kazanma durumu kontrol edilebilir (opsiyonel)
            KontrolEt();
        }


        private void KontrolEt()
        {
            // Yatay kazanma kombinasyonlarý
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") || // 1. satýr
                (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") || // 2. satýr
                (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != ""))   // 3. satýr
            {
                string kazanan = siradax ? "O" : "X"; // Sýra deðiþtiði için bir önceki oyuncu kazanýr
                MessageBox.Show($"{kazanan} kazandý!");
                OyunuSifirla();
                return;
            }

            // Dikey kazanma kombinasyonlarý
            if ((button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") || // 1. sütun
                (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") || // 2. sütun
                (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != ""))   // 3. sütun
            {
                string kazanan = siradax ? "O" : "X"; // Sýra deðiþtiði için bir önceki oyuncu kazanýr
                MessageBox.Show($"{kazanan} kazandý!");
                OyunuSifirla();
                return;
            }

            // Çapraz kazanma kombinasyonlarý
            if ((button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") || // Çapraz 1
                (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != ""))   // Çapraz 2
            {
                string kazanan = siradax ? "O" : "X"; // Sýra deðiþtiði için bir önceki oyuncu kazanýr
                MessageBox.Show($"{kazanan} kazandý!");
                OyunuSifirla();
                return;
            }

            // Beraberlik kontrolü (Opsiyonel)
            if (TümButonlarDoluMu())
            {
                MessageBox.Show("Berabere!");
                OyunuSifirla();
            }
        }

        private bool TümButonlarDoluMu()
        {
            // Butonlarýn hepsinin dolu olup olmadýðýný kontrol etme
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
                    control.Text = ""; // Tüm butonlarýn metinlerini temizle
                }
            }
            siradax = true; // Oyun tekrar baþladýðýnda X baþlasýn
        }



        //private void KontrolEt()
        //{
        //    // Yatay kazanma kombinasyonlarý (3'lü gruplar)
        //    if ((button3.Text == button2.Text && button2.Text == button1.Text && button3.Text != "") || // 1. satýr
        //        (button2.Text == button1.Text && button1.Text == button6.Text && button2.Text != "") || // 1. satýr
        //        (button1.Text == button6.Text && button6.Text == button5.Text && button1.Text != "") || // 1. satýr
        //        (button6.Text == button5.Text && button5.Text == button4.Text && button6.Text != "") || // 2. satýr
        //        (button5.Text == button4.Text && button4.Text == button9.Text && button5.Text != "") || // 2. satýr
        //        (button4.Text == button9.Text && button9.Text == button10.Text && button4.Text != "") || // 2. satýr
        //        (button11.Text == button12.Text && button12.Text == button13.Text && button11.Text != "") || // 3. satýr
        //        (button12.Text == button13.Text && button13.Text == button8.Text && button12.Text != "") || // 3. satýr
        //        (button13.Text == button8.Text && button8.Text == button7.Text && button13.Text != "")) // 3. satýr
        //    {
        //        string kazanan = siradax ? "O" : "X"; // Sýra deðiþtiði için bir önceki oyuncu kazanýr
        //        MessageBox.Show($"{kazanan} kazandý!");
        //        OyunuSifirla();
        //        return;
        //    }

        //    // Dikey kazanma kombinasyonlarý (3'lü gruplar)
        //    if ((button3.Text == button6.Text && button6.Text == button11.Text && button3.Text != "") || // 1. sütun
        //        (button2.Text == button5.Text && button5.Text == button12.Text && button2.Text != "") || // 2. sütun
        //        (button1.Text == button4.Text && button4.Text == button13.Text && button1.Text != "") || // 3. sütun
        //        (button6.Text == button9.Text && button9.Text == button8.Text && button6.Text != "") || // 4. sütun
        //        (button5.Text == button10.Text && button10.Text == button7.Text && button5.Text != ""))  // 5. sütun
        //    {
        //        string kazanan = siradax ? "O" : "X";
        //        MessageBox.Show($"{kazanan} kazandý!");
        //        OyunuSifirla();
        //        return;
        //    }

        //    // Çapraz kazanma kombinasyonlarý
        //    if ((button3.Text == button5.Text && button5.Text == button13.Text && button3.Text != "") || // Sol üstten sað alta
        //        (button5.Text == button9.Text && button9.Text == button11.Text && button5.Text != ""))   // Sað üstten sol alta
        //    {
        //        string kazanan = siradax ? "O" : "X";
        //        MessageBox.Show($"{kazanan} kazandý!");
        //        OyunuSifirla();
        //        return;
        //    }

        //    // Beraberlik durumu kontrolü
        //    else if (TümButonlarDoluMu())
        //    {
        //        MessageBox.Show("Berabere!");
        //        OyunuSifirla();
        //    }
        //}

        //private void KontrolEt()
        //{
        //    // 3x5 düzeni için kazanma kombinasyonlarý
        //    if ((button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == button4.Text && button4.Text == button5.Text && button1.Text != "") || // Ýlk satýr
        //        (button6.Text == button7.Text && button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == button10.Text && button6.Text != "") || // Ýkinci satýr
        //        (button11.Text == button12.Text && button12.Text == button13.Text && button13.Text == button14.Text && button14.Text == button15.Text && button11.Text != "") || // Üçüncü satýr
        //        (button1.Text == button6.Text && button6.Text == button11.Text && button11.Text != "") || // Ýlk sütun
        //        (button2.Text == button7.Text && button7.Text == button12.Text && button12.Text != "") || // Ýkinci sütun
        //        (button3.Text == button8.Text && button8.Text == button13.Text && button13.Text != "") || // Üçüncü sütun
        //        (button4.Text == button9.Text && button9.Text == button14.Text && button14.Text != "") || // Dördüncü sütun
        //        (button5.Text == button10.Text && button10.Text == button15.Text && button15.Text != "") || // Beþinci sütun
        //        (button1.Text == button7.Text && button7.Text == button13.Text && button13.Text != "") || // Çapraz 1 (Sol üstten sað alta)
        //        (button5.Text == button9.Text && button9.Text == button11.Text && button11.Text != ""))   // Çapraz 2 (Sað üstten sol alta)
        //    {
        //        string kazanan = siradax ? "O" : "X"; // Sýra deðiþtiði için bir önceki oyuncu kazanýr
        //        MessageBox.Show($"{kazanan} kazandý!");
        //        OyunuSifirla();
        //    }
        //    else if (TümButonlarDoluMu())
        //    {
        //        MessageBox.Show("Berabere!");
        //        OyunuSifirla();
        //    }
        //}

        // Tüm butonlar dolu mu diye kontrol eden yardýmcý metod
        //private bool TümButonlarDoluMu()
        //{
        //    foreach (Control control in this.Controls)
        //    {
        //        if (control is Button button && button.Text == "")
        //            return false;
        //    }
        //    return true;
        //}

        //// Oyun bitince butonlarý sýfýrlayan metod
        //private void OyunuSifirla()
        //{
        //    foreach (Control control in this.Controls)
        //    {




        //    }
        //}



    }
}
