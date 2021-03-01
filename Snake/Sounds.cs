using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace Snake
{
    public class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void PlayBackground()
        {
            player.URL = pathToMedia + "Background.mp3";
            player.settings.volume = 10;
            player.controls.play();
            player.settings.setMode("loop", true);
        }

        public void Play(string songName)
        {
            player.URL = pathToMedia + ".mp3";
            player.controls.play();
        }

        public void PlayEnd()
        {
            player.URL = pathToMedia + "End.mp3";
            player.settings.volume = 10;
            player.controls.play();
        }

        public void PlayEat()
        {
            player.URL = pathToMedia + "Feed.mp3";
            player.settings.volume = 10;
            player.controls.play();
        }
    }
}
