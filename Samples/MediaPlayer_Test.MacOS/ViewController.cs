using System;

using AppKit;
using Foundation;

namespace MediaPlayer_Test.MacOS
{
   public partial class ViewController : NSViewController
   {
      public ViewController(IntPtr handle) : base(handle)
      {
      }

      public override void ViewDidLoad()
      {
         base.ViewDidLoad();

         // Do any additional setup after loading the view.
      }

      public override NSObject RepresentedObject
      {
         get
         {
            return base.RepresentedObject;
         }
         set
         {
            base.RepresentedObject = value;
            // Update the view, if already loaded.
         }
      }

      partial void btnPlay(Foundation.NSObject sender)
      {
         ZPF.Media.MediaPlayer.Current.Play("http://www.zpf.fr/podcast/01.mp3");
      }
   }
}
