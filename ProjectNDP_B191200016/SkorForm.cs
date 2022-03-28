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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNDP_B191200016
{
    public partial class SkorForm : Form
    {
        public SkorForm()
        {
            InitializeComponent();
        }

        private void SkorForm_Load(object sender, EventArgs e)
        {
            string fileName = "BestFiveScores";


            if (!File.Exists(fileName))
            {

                File.WriteAllLines(fileName, new List<string>() { "0", "0", "0", "0", "0" });
            }

            List<string> lines = File.ReadAllLines(fileName).ToList();

            List<Label> bestfivescores = new List<Label>();

            foreach (Label item in skorPanel.Controls)
            {
                bestfivescores.Add(item);
            }
            for (int i = 0; i < 5; i++)
            {
                bestfivescores[(4 - i)].Text = lines[i];
            }

        }
    }

    }
