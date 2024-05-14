using KAutoHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Controller
{
    internal class Item
    {
        public static bool ItemProFile()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Profile.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                return true;
            }else { return false; }
        }
        public static void Bag()
        {
            var screen = CaptureHelper.CaptureScreen();
  
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Bag.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
        
            if (resBitmap != null)
            {
            
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
      
    
        public static void FruiBag()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\FruitsBag.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static void ItemBag()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\ItemBag.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
    
        public static void SeedsBag()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\SeedBag.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static void Tree5()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Tree5.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }


        //shop
        public static void Shop()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Shop.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static void ItemShop()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\ItemtShop.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static void SeedsShop()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\SeedsShop.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static void BuyTree5Gem() {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Tree5Gem.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static void BuyWater()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\BuyWater.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X+5, resBitmap.Value.Y+5);
            }
        }
        public static void CongShop()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\CongShop.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X+3, resBitmap.Value.Y+3);
            }
        }
        public static void Buy100Water()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Buy100Water.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X+5, resBitmap.Value.Y + 5);
            }
        }
        public static void CFBuyTree5Gem()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\CfBuy5Gem.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        //gacka
        public static void gaCka()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Spin.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static void autoGacka()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\AutoGacka.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static void StopGaChak()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\AutoGacka.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static bool GachakChom()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\AvatarChom.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool AmountGachak()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\AmountGachak.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void GachakChomGem()
        {
            lai:
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\CuopGem.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X+20, resBitmap.Value.Y+20);
            }
            else
            {
                goto lai;
            }
        }
        public static void GachakChomWater()
        {
        lai:
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\CuopWater.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X + 20, resBitmap.Value.Y + 20);
            }
            else
            {
                goto lai;
            }
        }
        //water
        public static void Water()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\water.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X+10, resBitmap.Value.Y+10);
            }
        }
        public static bool AmountWater()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\AmountWater.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void DefWater()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\WaterDef.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        //girf
        public static void Gift()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Gift.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static void ClaimGift()
        {
            claimagain:
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\ClaimGift.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
                Thread.Sleep(1000);
                goto claimagain;
            }
            
        }
        //chau cay
        public static void Pot()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\ClaimGift.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        public static void DefPot()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\DefenPot.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X+20, resBitmap.Value.Y+20);
            }
        }
        //itemchom
        public static void itemChom()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\itemChom.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        //itemchom
        public static void ItemKhien()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\itemkhien.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        //Use
        public static void Use()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Use.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X+5, resBitmap.Value.Y+5);
            }
        }
        //gem
        public static void DefGem()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\DefGem.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }
        //x
        public static void X()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\X.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
            }
        }

        public static void Friend()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Friend.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X+3, resBitmap.Value.Y+3);
            }
        }
        public static void GiftToFriend()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\GiftToFriend.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X + 3, resBitmap.Value.Y + 3);
            }
        }
        public static void sendGift()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\SendGiftEnergy.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X + 3, resBitmap.Value.Y + 3);
            }
        }
        public static void Friender(string filePath)
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(filePath);
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X + 3, resBitmap.Value.Y + 3);
            }
        }
    }
}
