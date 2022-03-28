/****************************************************************************
**                                SAKARYA ÜNİVERSİTESİ
**                     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                       BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                          NESNEYE DAYALI PROGRAMLAMA DERSİ
**                              2020-2021 BAHAR DÖNEMİ
**
**                          ÖDEV NUMARASI..........: Proje Ödevi
**                          ÖĞRENCİ ADI............: Cengiz Emre ÜNLÜ
**                          ÖĞRENCİ NUMARASI.......: B191200016
**                          DERSİN ALINDIĞI GRUP...: A Grubu
*****************************************************************************/



using ProjectLibrary.Somut;
using ProjectLibrary.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNDP_B191200016
{
    public partial class Form1 : Form
    {
        
        private readonly Game _game;
       
        public Form1()
        {
            InitializeComponent();

            _game =new Game(savunmaPanel,meydanPanel);

            _game.changedTheTime += Game_changedTheTime;

            //this.IsMdiContainer = true; //Form içinde form açılabilir şekilde ayarlamak için.

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter://Oyunu başlatır.
                    _game.Start();
                    bilgiLabel.Visible = true;
                    skorYazıLabel.Visible = true;
                    skorLabel.Visible = true;                    
                    break;

                case Keys.Right://Sağa hareket
                    _game.Move(Direction.right);
                    break;

                case Keys.Left://Sola hareket
                    _game.Move(Direction.left);
                    break;

                case Keys.Space://Kalkan atma
                    _game.ThrowShield();
                    break;

                case Keys.P://Oyun durdurma
                    _game.Pause();                                    
                    break;

                case Keys.R://Oyun devam ettirme
                    _game.Resume();                   
                    break;

                case Keys.F:
                    TabloyuAc();
                    break;
            }
        }
        
        
        private void Game_changedTheTime(object sender, EventArgs e)
        {
            zamanLabel.Text = $"{_game.TheTime.Minutes}:{_game.TheTime.Seconds.ToString("D2")}";

            skorLabel.Text = (_game.skor * 10).ToString(); //Skoru yazdırır

            //Üst kısımda anlık olarak zorluk seviyesini gösterir.

            if (_game.zorlukDerecesi >= 0 && _game.zorlukDerecesi <= 100)
                zorlukDereceLabel.Text = "Basit";
            if (_game.zorlukDerecesi >100 && _game.zorlukDerecesi <= 300)
                zorlukDereceLabel.Text = "Orta";
            if (_game.zorlukDerecesi >300  && _game.zorlukDerecesi <= 500)
                zorlukDereceLabel.Text = "Zor";
            if (_game.zorlukDerecesi >500)
                zorlukDereceLabel.Text = "Uzman";
        }

       public void TabloyuAc()
        {
            SkorForm frm2 = new SkorForm();
            frm2.ShowDialog();
        }
    }
}
