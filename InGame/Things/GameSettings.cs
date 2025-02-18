using System.Linq;

namespace ProjectZ.InGame.Things
{
    class GameSettings
    {
        public static int UiScale = 0;
        public static int GameScale = 11; // autoscale

        public static bool ItemsOnRight = false;
        public static bool SwapButtons = false;
        public static Resources.SpriteFontName FontName = Resources.SpriteFontName.smallFont;

        public static bool EnableShadows = true;
        public static float ShadowOpacity = 0.55f;
        public static bool LockFps = true;
        public static bool Autosave = true;
        public static bool SmoothCamera = true;
        
        public static bool BorderlessWindowed = false;
        public static bool IsFullscreen = false;

        public static int DamageMultiplier = 1;
        public static bool NoHeartDrops = false;
        public static bool NoPickupDialogs = false;
        public static float WalkSpeed = 1f;

        private static int _musicVolume = 100;
        private static int _effectVolume = 100;

        public static int MusicVolume
        {
            get => _musicVolume;
            set { _musicVolume = value; Game1.GbsPlayer.SetVolume(value / 100.0f); }
        }

        public static int EffectVolume
        {
            get => _effectVolume;
            set { _effectVolume = value; }
        }
    }
}
