using System;
using System.Windows.Media;
namespace Snake
{
    public static class Audio
    {
        public readonly static MediaPlayer GameOver = LoadAudio("game-over-01.wav", .1);
        public readonly static MediaPlayer FoodScore = LoadAudio("Coins.wav");
        private static MediaPlayer LoadAudio(string filename, double volume = 1, bool repeat = false, bool autoReset = true)
        {
            MediaPlayer player = new();
            player.Open(new Uri($"Assets/{filename}", UriKind.Relative));
            if (autoReset) 
            {
                player.MediaEnded += Player_MediaEnded;
            }

            if (repeat) 
            {
                player.MediaEnded += PlayerRepeat_MediaEnded;
            }

            return player;
        }
        private static void Player_MediaEnded(object sneder, EventArgs e)
        {
            MediaPlayer m = sneder as MediaPlayer;
            m.Stop();
            m.Position = new TimeSpan(0);
        }

        private static void PlayerRepeat_MediaEnded(Object sneder, EventArgs e) 
        {
            MediaPlayer m = sneder as MediaPlayer;
            m.Position = new TimeSpan(0);
            m.Play();
        }
    }
}
