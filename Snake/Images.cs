using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Invisible.Png");
        //public readonly static ImageSource Body = LoadImage("Body.Png");
        //public readonly static ImageSource Body = LoadImage("MittyBody.Png");
        //public readonly static ImageSource Head = LoadImage("Head.Png");
        //public readonly static ImageSource Head = LoadImage("AliveHeadM.Png");
        //public readonly static ImageSource Food = LoadImage("OscarFood.Png");
        //public readonly static ImageSource Food = LoadImage("Food.Png");
        //public readonly static ImageSource DeadBody = LoadImage("DeadBody.Png");
        //public readonly static ImageSource DeadBody = LoadImage("MittyDeadBody.Png");
        //public readonly static ImageSource DeadHead = LoadImage("DeadHead.Png");
        //public readonly static ImageSource DeadHead = LoadImage("DeadHeadM.Png");

        public readonly static ImageSource Head = LoadImage("NewHead.Png");
        public readonly static ImageSource Body = LoadImage("NewBody.Png");
        public readonly static ImageSource DeadHead = LoadImage("NewDeadHead2.Png");
        public readonly static ImageSource DeadBody = LoadImage("NewDeadBody.Png");
        public readonly static ImageSource Food = LoadImage("NewFood.Png");

        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }
    }
}
