using Foundation;
using System;
using UIKit;

namespace MediaPlayer_Test.iOS
{
   public partial class ViewController : UIViewController
   {
      public ViewController(IntPtr handle) : base(handle)
      {
      }

      public override void ViewDidLoad()
      {
         base.ViewDidLoad();
         // Perform any additional setup after loading the view, typically from a nib.
      }

      public override void DidReceiveMemoryWarning()
      {
         base.DidReceiveMemoryWarning();
         // Release any cached data, images, etc that aren't in use.
      }

      partial void btnPlayDown(UIButton sender)
      {
         ZPF.Media.MediaPlayer.Current.Play("http://www.zpf.fr/podcast/01.mp3");
      }
   }
}