﻿using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System;

namespace MediaPlayer_Test.Android
{
   [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
   public class MainActivity : AppCompatActivity
   {

      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);
         SetContentView(Resource.Layout.activity_main);

         //Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
         //SetSupportActionBar(toolbar);

         FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
         fab.Click += FabOnClick;

         var b = FindViewById<Button>(Resource.Id.button1);

         b.Click += (object sender, EventArgs e) =>
         {
            ZPF.Media.MediaPlayer.Current.Play("http://www.zpf.fr/podcast/01.mp3");
         };
      }


      public override bool OnCreateOptionsMenu(IMenu menu)
      {
         MenuInflater.Inflate(Resource.Menu.menu_main, menu);
         return true;
      }

      public override bool OnOptionsItemSelected(IMenuItem item)
      {
         int id = item.ItemId;
         if (id == Resource.Id.action_settings)
         {
            return true;
         }

         return base.OnOptionsItemSelected(item);
      }

      private void FabOnClick(object sender, EventArgs eventArgs)
      {
         View view = (View)sender;
         //Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
         //    .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();

         ZPF.Media.MediaPlayer.Current.Play("http://www.zpf.fr/podcast/WTF.mp3");
      }
   }
}

