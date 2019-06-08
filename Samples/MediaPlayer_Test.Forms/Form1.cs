using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer_Test.Forms
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnPlay_Click(object sender, EventArgs e)
      {
         ZPF.Media.MediaPlayer.Current.Play("http://www.zpf.fr/podcast/01.mp3");
      }
   }
}
