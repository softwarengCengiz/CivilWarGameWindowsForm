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

using ProjectLibrary.Enum;
using System.Drawing;

namespace ProjectLibrary.Arayüz
{
    internal interface ALeave
    {

       Size LeavingAreas { get; }
        int LeavingDistance { get; }

        /// <summary>
        /// Cismi hareket ettirme
        /// </summary>
        /// <param name="direct">Hangi yönde hareket ettireceği</param>
        /// <returns>Cisim çarparsa return true</returns>
        bool Leaving(Direction direct);
    }
}
