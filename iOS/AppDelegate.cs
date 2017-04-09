using FFImageLoading.Forms.Touch;
using Foundation;
using Lottie.Forms.iOS.Renderers;
using Syncfusion.SfRating.XForms.iOS;
using UIKit;
using UXDivers.Artina.Shared;

namespace ArcTouch.TestApp.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new SfRatingRenderer ();

            global::Xamarin.Forms.Forms.Init();
            CachedImageRenderer.Init(); // Initializing FFImageLoading
            AnimationViewRenderer.Init(); // Initializing Lottie

            // Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
#endif
            // Initializing UXDivers.Effects
            FormsHelper.ForceLoadingAssemblyContainingType(typeof(UXDivers.Effects.Effects));
            FormsHelper.ForceLoadingAssemblyContainingType<UXDivers.Effects.iOS.CircleEffect>();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
