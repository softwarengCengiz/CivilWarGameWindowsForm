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

using ProjectLibrary.Arayüz;
using ProjectLibrary.Enum;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace ProjectLibrary.Soyut
{
    internal abstract class Matter : PictureBox, ALeave
    {

        public Size LeavingAreas { get; }

        public int LeavingDistance { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2; 
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }
        protected Matter(Size leaveAreas)
        {
            Image = Image.FromFile($@"pictures\{GetType().Name}.png");
            LeavingAreas = leaveAreas;
            SizeMode = PictureBoxSizeMode.AutoSize; 
        }

        

        public bool Leaving(Direction direct)
        {
            switch (direct)
            {
                case Direction.up:
                    return MoveUp();
                    

                case Direction.down:
                    return MoveDown();
                    

                case Direction.right:
                    return MoveRight();
                    

                case Direction.left:
                    return MoveLeft();

                default:
                    throw new ArgumentOutOfRangeException(nameof(direct), direct, null);
                
                    
            }
        }

       

        private bool MoveLeft()
        {
            if (Left == 0)
                return true;
            var newLeft = Left - LeavingDistance;
            var overflow = newLeft < 0;
            Left = overflow ? 0 : newLeft;

            return Left == 0;
        }

        private bool MoveRight()
        {
            if (Right == LeavingAreas.Width) return true;
                
            var newRight = Right + LeavingDistance;
            var overflow = newRight > LeavingAreas.Width;

            Right = overflow ? LeavingAreas.Width : newRight;


            return Right == LeavingAreas.Width;
            
        }

        private bool MoveDown()
        {
            if (Bottom == LeavingAreas.Height) return true;

            var newBottom = Bottom + LeavingDistance;
            var overflow = newBottom > LeavingAreas.Height;

            Bottom = overflow ? LeavingAreas.Height : newBottom;


            return Bottom == LeavingAreas.Height;
        }

        private bool MoveUp()
        {
            if (Top == 0)
                return true;
            var newTop = Top - LeavingDistance;
            var overflow = newTop < 0;
            Top = overflow ? 0 : newTop;

            return Top == 0;
        }

    }
}
