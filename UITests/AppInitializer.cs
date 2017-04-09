﻿using Xamarin.UITest;

namespace ArcTouch.TestApp.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
                return ConfigureApp.Android.StartApp();

            return ConfigureApp.iOS.StartApp();
        }
    }
}