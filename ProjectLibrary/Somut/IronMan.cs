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
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectLibrary.Somut
{
    internal class IronMan : Matter
    {
        private static readonly Random Random = new Random();
        public IronMan(Size leaveAreas) : base(leaveAreas)
        {
            LeavingDistance = (int)(Height*.1);
            Left = Random.Next(leaveAreas.Width - Width + 1);
        }

        public Shield Crashed(List<Shield> shields)
        {
            foreach (var shield in shields)
            {
                var crashed = shield.Top < Bottom && shield.Right > Left && shield.Left < Right;
                if (crashed) return shield;
            }
            return null;
        }
    }
}
