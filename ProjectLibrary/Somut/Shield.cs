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
using System;
using System.Drawing;

namespace ProjectLibrary.Somut
{
    internal class Shield : Matter
    {
        public Shield (Size leavingArea,int middleOfCaptain) : base(leavingArea)
        {
            Initally(middleOfCaptain);
            LeavingDistance = (int)(Height * 1.5);
        }

        private void Initally(int middleOfCaptain)
        {
            Bottom = LeavingAreas.Height;
            Center = middleOfCaptain;
        }
    }
}
