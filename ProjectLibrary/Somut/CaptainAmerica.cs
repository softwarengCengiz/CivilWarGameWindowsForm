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

using ProjectLibrary.Soyut;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectLibrary.Somut
{
    internal class CaptainAmerica : Matter
    {
        public CaptainAmerica(int widthOfPanel, Size leaveArea) : base(leaveArea)
        {

            Center = widthOfPanel / 2;
            LeavingDistance = Width;
            
        }
    }
}
