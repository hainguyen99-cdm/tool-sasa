using KAutoHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Controller
{
    internal class TaskController
    {
        public static bool FlagStop = false;
        public static void TaskLoginGame()
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\iconGame.PNG");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X+5, resBitmap.Value.Y+10);
            }
            Thread.Sleep(5000);
            laiplay:
            screen = CaptureHelper.CaptureScreen();
            subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\play.PNG");
            resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
                Thread.Sleep(1000);
                while(true)
                {
                    if (Item.ItemProFile())
                    {
                        break;

                    }
                    Thread.Sleep(1000);
                }

            }
            else
            {
                goto laiplay;
            }
        }
        public static void TaskAddDefender()
        {
   
                Item.Bag();
            Thread.Sleep(1000);
            Item.ItemBag();
            Thread.Sleep(1000);
            Item.ItemKhien();
            Thread.Sleep(1000);
            Item.Use();
            Thread.Sleep(1000);
            for (int i = 0; i < 10; i++)
            {
                Item.DefWater();
            }
            Thread.Sleep(1000);
            Item.Bag();
            Thread.Sleep(1000);
            Item.ItemBag();
            Thread.Sleep(1000);
            Item.ItemKhien();
            Thread.Sleep(1000);
            Item.Use();
            Thread.Sleep(1000);
            for (int i = 0; i < 10; i++)
            {
                Item.DefPot();
            }
            Thread.Sleep(1000);
            Item.Bag();
            Thread.Sleep(1000);
            Item.ItemBag();
            Thread.Sleep(1000);
            Item.ItemKhien();
            Thread.Sleep(1000);
            Item.Use();
            Thread.Sleep(1000);
            for (int i = 0; i < 10; i++)
            {
                Item.DefGem();
            }
           
        
    }
        public static void TaskWaterTheTree()
        {
         //while(true) {

               for (int i = 0; i < 100; i++)
                {
                   Item.Water();
                }
          

            //}
        }
        public static void Task300WaterTheTree()
        {
            //while(true) {

            for (int i = 0; i < 300; i++)
            {
                Item.Water();
            }


            //}
        }
        public static void Task500WaterTheTree()
        {
            //while(true) {

            for (int i = 0; i < 500; i++)
            {
                Item.Water();
            }


            //}
        }
        public static void Task1000WaterTheTree()
        {
            //while(true) {

            for (int i = 0; i < 1000; i++)
            {
                Item.Water();
            }


            //}
        }
        public static void Task20WaterTheTree(int time,int loop)
        {
         for(int j=0;j<loop; j++) { 

                for (int i = 0; i < 20; i++)
            {
                Item.Water();
            }
                Thread.Sleep(1000*time);

            }
        }
        public static void TaskGachak()
        {
            int index = 0;
            if (Item.AmountGachak())
            {
                return;
            }
            Item.gaCka();
            Thread.Sleep(1000);
        chochom:
            Item.autoGacka();
   
            while (true)
            {
                if (index == 30)
                {
                    break;
                    
                }
                if (Item.AmountGachak())
                {
                    break;
                }
                Thread.Sleep(1000);
                Debug.WriteLine(Item.GachakChom());
                if (Item.GachakChom())
                {
                    Thread.Sleep(3000);
                    Item.GachakChomWater();
                    Thread.Sleep(6000);
                    goto chochom;
                }
                Thread.Sleep(1000);
                index ++;
            }
            Thread.Sleep(1000);
            Item.X();
        }

        public static void TaskBuyTree5Gem()
        {
            Item.Shop();
            Thread.Sleep(1000);
            Item.SeedsShop();
            Thread.Sleep(1000);
            Item.BuyTree5Gem();
            Thread.Sleep(1000);
            Item.CFBuyTree5Gem();
            Thread.Sleep(1000);
            Item.X();
        }
        public static void Tree5()
        {

            Item.Bag();
            Thread.Sleep(1000);
            Item.SeedsBag();
            Thread.Sleep(1000);
            Item.Tree5();
            Thread.Sleep(1000);
            Item.Use();

        }
        public static void Buy100Water()
        {

            Item.Shop();
            Thread.Sleep(1000);
            Item.ItemShop();
            Thread.Sleep(1000);
            Item.BuyWater();
            Thread.Sleep(1000);
            for(int i = 0; i < 4; i++)
            {
                Item.CongShop();
                Thread.Sleep(1000);
            }
            Item.Buy100Water();

        }
        public static void Buy300Water()
        {

            Item.Shop();
            Thread.Sleep(1000);
            Item.ItemShop();
            Thread.Sleep(1000);
            Item.BuyWater();
            Thread.Sleep(1000);
            for (int i = 0; i < 15; i++)
            {
                Item.CongShop();
                Thread.Sleep(1000);
            }
            Item.Buy100Water();

        }
        public static void Buy500Water()
        {

            Item.Shop();
            Thread.Sleep(1000);
            Item.ItemShop();
            Thread.Sleep(1000);
            Item.BuyWater();
            Thread.Sleep(1000);
            for (int i = 0; i < 25; i++)
            {
                Item.CongShop();
                Thread.Sleep(1000);
            }
            Item.Buy100Water();

        }
        public static void Buy1000Water()
        {

            Item.Shop();
            Thread.Sleep(1000);
            Item.ItemShop();
            Thread.Sleep(1000);
            Item.BuyWater();
            Thread.Sleep(1000);
            for (int i = 0; i < 50; i++)
            {
                Item.CongShop();
                Thread.Sleep(1000);
            }
            Item.Buy100Water();

        }

        //gift
        public static void GiftoFriend()
        {
            Item.Friend();
            Thread.Sleep(1000);

            string folderPath = Environment.CurrentDirectory + "\\data\\friend";
            if (Directory.Exists(folderPath))
            {
                string[] filePath = Directory.GetFiles(folderPath);
                
                foreach (string filePath2 in filePath)
                {
                    Item.Friender(filePath2);
                    Thread.Sleep(1000);
                    Item.GiftToFriend();
                    Thread.Sleep(1000);
                    Item.sendGift();
                    Thread.Sleep(3000);
                    Item.Friender(filePath2);
                    Thread.Sleep(1000);

                }
            }


          
          
        }

        public static void ClaimGift()
        {
            Item.Gift();
            Thread.Sleep(1000);
            Item.ClaimGift();
        }
        public static void C3()
        {
            while (true)
            {
                for (int i = 0; i < 20; i++)
                {
                    Item.Water();
                    Debug.WriteLine(i);
                }
                Thread.Sleep(2000);
                ClaimGift();
                Thread.Sleep(2000);
                Item.Bag();
                Thread.Sleep(1000);
                Item.ItemBag();
                Thread.Sleep(1000);
                Item.ItemKhien();
                Thread.Sleep(1000);
                Item.Use();
                Thread.Sleep(1000);
                for (int i = 0; i < 10; i++)
                {
                    Item.DefWater();
                }
                Thread.Sleep(1000);
                Item.Bag();
                Thread.Sleep(1000);
                Item.ItemBag();
                Thread.Sleep(1000);
                Item.ItemKhien();
                Thread.Sleep(1000);
                Item.Use();
                Thread.Sleep(1000);
                for (int i = 0; i < 10; i++)
                {
                    Item.DefPot();
                }
                Thread.Sleep(1000);
                Item.Bag();
                Thread.Sleep(1000);
                Item.ItemBag();
                Thread.Sleep(1000);
                Item.ItemKhien();
                Thread.Sleep(1000);
                Item.Use();
                Thread.Sleep(1000);
                for (int i = 0; i < 10; i++)
                {
                    Item.DefGem();
                }
                TaskGachak();
                Thread.Sleep(2000);


            }

        }
    }
}
