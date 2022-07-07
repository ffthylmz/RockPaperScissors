using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.CALISMA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int skor = 0, botSkor = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            ButonlariBeyazaCevir();
        }

        private void btnTas_Click(object sender, EventArgs e)
        {
            ButonlariBeyazaCevir();
            btnTas.BackColor = Color.Yellow;
            Random rnd = new Random();
            byte deger = (byte)rnd.Next(1, 4); // 1=BotTaş, 2=BotKağıt, 3=BotMakas

            switch (deger)
            {
                case 1:
                    lblBotSkor.Text = botSkor.ToString();
                    lblSkor.Text = skor.ToString();
                    lblMesaj.Text = "Berabere";
                    btnBotTas.BackColor = Color.Gray;

                    break;

                case 2:
                    botSkor++;
                    lblBotSkor.Text = botSkor.ToString();
                    lblSkor.Text = skor.ToString();
                    lblMesaj.Text = "Kaybettin";
                    btnBotKagit.BackColor = Color.Red;

                    break;

                case 3:
                    skor++;
                    lblBotSkor.Text = botSkor.ToString();
                    lblSkor.Text = skor.ToString();
                    lblMesaj.Text = "Kazandın";
                    btnBotMakas.BackColor = Color.Green;

                    break;

                default:
                    break;
            }

            SkorKontrolEt();
        }


        private void btnKagit_Click(object sender, EventArgs e)
        {
            ButonlariBeyazaCevir();
            btnKagit.BackColor = Color.Yellow;
            Random rnd = new Random();
            byte deger = (byte)rnd.Next(1, 4);

            switch (deger)
            {
                case 1:
                    skor++;
                    lblBotSkor.Text = botSkor.ToString();
                    lblSkor.Text = skor.ToString();
                    lblMesaj.Text = "Kazandın";
                    btnBotTas.BackColor = Color.Green;

                    break;

                case 2:
                    lblBotSkor.Text = botSkor.ToString();
                    lblSkor.Text = skor.ToString();
                    lblMesaj.Text = "Berabere";
                    btnBotKagit.BackColor = Color.Gray;

                    break;

                case 3:
                    botSkor++;
                    lblBotSkor.Text = botSkor.ToString();
                    lblSkor.Text = skor.ToString();
                    lblMesaj.Text = "Kaybettin";
                    btnBotMakas.BackColor = Color.Red;

                    break;

                default:
                    break;
            }

            SkorKontrolEt();
        }

        private void btnMakas_Click(object sender, EventArgs e)
        {
            ButonlariBeyazaCevir();
            btnMakas.BackColor = Color.Yellow;
            Random rnd = new Random();
            byte deger = (byte)rnd.Next(1, 4);

            switch (deger)
            {
                case 1:
                    botSkor++;
                    lblBotSkor.Text = botSkor.ToString();
                    lblSkor.Text = skor.ToString();
                    lblMesaj.Text = "Kaybettin";
                    btnBotTas.BackColor = Color.Red;

                    break;

                case 2:
                    skor++;
                    lblBotSkor.Text = botSkor.ToString();
                    lblSkor.Text = skor.ToString();
                    lblMesaj.Text = "Kazandın";
                    btnBotKagit.BackColor = Color.Green;

                    break;

                case 3:
                    lblBotSkor.Text = botSkor.ToString();
                    lblSkor.Text = skor.ToString();
                    lblMesaj.Text = "Berabere";
                    btnBotMakas.BackColor = Color.Gray;

                    break;

                default:
                    break;
            }

            SkorKontrolEt();
        }

        private void ButonlariBeyazaCevir()
        {
            btnKagit.BackColor = Color.White;
            btnBotKagit.BackColor = Color.White;
            btnMakas.BackColor = Color.White;
            btnBotMakas.BackColor = Color.White;
            btnTas.BackColor = Color.White;
            btnBotTas.BackColor = Color.White;
        }
        private void SkorKontrolEt()
        {
            if (lblSkor.Text == 5.ToString() || lblBotSkor.Text == 5.ToString())
            {
                ButonlariDisableYap();
                if (lblSkor.Text == "5")
                {
                    lblMesaj.Text = "Sen Kazandın.";
                }
                else if (lblBotSkor.Text == "5")
                {
                    lblMesaj.Text = "Bot Kazandı.";
                }
            }
        }
        private void ButonlariDisableYap()
        {
            btnKagit.Enabled = false;
            btnBotKagit.Enabled = false;
            btnMakas.Enabled = false;
            btnBotMakas.Enabled = false;
            btnTas.Enabled = false;
            btnBotTas.Enabled = false;
        }
    }
}
