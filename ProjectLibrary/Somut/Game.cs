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

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLibrary.Arayüz;
using ProjectLibrary.Enum;
using System.Windows.Forms;
using System.IO;

namespace ProjectLibrary.Somut
{
    public class Game : ArayüzGame 
    {


        #region Areas
        private readonly Timer _period = new Timer { Interval = 1000 };
        private readonly Timer _movement = new Timer { Interval = 100 };
        private readonly Timer _ironTimer = new Timer { Interval = 2000 };
        private TimeSpan _theSpan;
        private readonly Panel _savunmaPanel;
        private readonly Panel _meydanPanel;
        private CaptainAmerica _captain;
        private readonly List<Shield> _shields = new List<Shield>();
        private readonly List<IronMan> _ironmans = new List<IronMan>();
        #endregion

        #region Events
        public event EventHandler changedTheTime;
        #endregion

        #region Properties
        public bool IsitContinue { get; private set; }

        public TimeSpan TheTime 
        {
            get => _theSpan; 
            private set
            {
                _theSpan = value;

                changedTheTime?.Invoke(this, EventArgs.Empty);
            }
        }
        #endregion

        #region Methods

        public Game(Panel savunmaPanel, Panel meydanPanel)
        {
            _savunmaPanel = savunmaPanel;
            _meydanPanel = meydanPanel;
            _period.Tick += Period_Tick;
            _movement.Tick += Movement_Tick;
            _ironTimer.Tick += IronTimer_Tick;
            
        }

        
        private void Period_Tick(object sender, EventArgs e)
        {
            TheTime += TimeSpan.FromSeconds(1);
        }

        //Her 100 milisaniyede yapılacaklar
        private void Movement_Tick(object sender, EventArgs e)
        {
            MovementShields();
            MovementIronMans();
            DeleteCrash();
        }
        public int zorlukDerecesi = 0;//new
        public int skor = 0;//new
        private void DeleteCrash()
        {
            
            for (var i = _ironmans.Count - 1; i >= 0; i--)
            {
                var iron = _ironmans[i];

                var shieldcrashed = iron.Crashed(_shields);
                //Eğer iron man vurulmadıysa bir sonrakine geçer. 
                if (shieldcrashed is null) continue;
                //Vurulduysa yok eder.
                _ironmans.Remove(iron);
                _shields.Remove(shieldcrashed);
                _meydanPanel.Controls.Remove(iron);
                _meydanPanel.Controls.Remove(shieldcrashed);

                skor ++;
                //iron man sıklığını arttırır
                if (skor % 5 == 0 && _ironTimer.Interval > 400)
                {
                    _ironTimer.Interval -= 100;
                }
                //iron man hızını arttırır
                if (skor % 10 == 0 && _movement.Interval > 50)
                {
                    _movement.Interval -= 10;
                }

                //Her imhadan sonra zorluk seviyesi değerini 10 arttırır.
                //Bunun amacı paneldeki zorluk seviyesini göstermek.

                zorlukDerecesi += 10;


            }
        }

        private void MovementIronMans()
        {
            
            foreach (var iron in _ironmans)
            {
                var isItCrash = iron.Leaving(Direction.down);

                if (!isItCrash)
                {
                    continue;
                }

                End();
                break;
            }
            
        }

        private void IronTimer_Tick(object sender, EventArgs e)
        {
            CreateIronMan(); // Zamana bağlı iron man üretir
        }
        private void MovementShields()
        {
            //Döngüyü bu şekilde yapmamızın sebebi panelin sonuna ulaşan kalkanların hemen silinmesi.
            for (int i = _shields.Count-1; i >= 0; i--)
            {
                var shield = _shields[i];
                var isItCrash = shield.Leaving(Direction.up);
                //Panelin sonuna çarpan kalkanları siliyoruz.
                if (isItCrash)
                {
                    _shields.Remove(shield);
                    _meydanPanel.Controls.Remove(shield);
                }
            }
        }

        public void Move(Direction direct)
        {
            if (!IsitContinue) return;
            _captain.Leaving(direct);
        }

        public void Start()
        {
            if (IsitContinue)
                return;
            
            IsitContinue = true;
            StartTimers();       

            CreateCaptain();
            CreateIronMan();
        }

        private void CreateIronMan()
        {
            var ironMan = new IronMan(_meydanPanel.Size);
            _ironmans.Add(ironMan);
            _meydanPanel.Controls.Add(ironMan);
        }

        private void StartTimers()
        {
            _period.Start();
            _movement.Start();
            _ironTimer.Start();
        }
        //--Oyunu duraklatma ve devam ettirme --

        public void Form1_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.P))
            {
                if (IsitContinue == true)
                {
                    Pause();
                }
            }
            if (e.KeyChar == Convert.ToChar(Keys.R))
            {
                if (IsitContinue == false)
                {
                    Resume();
                }
            }
        }

        public void Resume()
        {
            StartTimers();
        }
        public void Pause()
        {
            StopTimers();
        }
        //-----------------------------------------
        private void CreateCaptain()
        {
            _captain = new CaptainAmerica(_savunmaPanel.Width, _savunmaPanel.Size);
            
            _savunmaPanel.Controls.Add(_captain);
        }

        private void End()
        {
            if (!IsitContinue)
                return;
            
            IsitContinue = false;
            StopTimers();

            List<string> enİyi5SkorTablosu = File.ReadAllLines("BestFiveScores").ToList();
            for (int i = 0; i < 5; i++)
            {
                if ((skor) > Convert.ToInt32(enİyi5SkorTablosu[i]))
                {
                    enİyi5SkorTablosu.Insert(i, (skor*10).ToString());

                    enİyi5SkorTablosu.RemoveAt(5);

                    File.WriteAllLines("BestFiveScores", enİyi5SkorTablosu);
                    break;
                }
            }



            MessageBox.Show("!!!! GAME OVER !!!!");
            MessageBox.Show("Skorunuz :" + (skor * 10).ToString());

            
            
        }

        private void StopTimers()
        {
            _period.Stop();
            _movement.Stop();
            _ironTimer.Stop();
        }

        
        public void ThrowShield()
        {
            if (!IsitContinue) return;

            var shield = new Shield(_meydanPanel.Size, _captain.Center);
            _shields.Add(shield);
            _meydanPanel.Controls.Add(shield);
            //shield.Leaving(Direction.up);
        }

       


        #endregion

    }
}
