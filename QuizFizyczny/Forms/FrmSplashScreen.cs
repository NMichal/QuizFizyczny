using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizFizyczny.Forms
{
    /// <summary>
    /// Formatka z okienkiem ładowania.
    /// </summary>
    public partial class FrmSplashScreen : Form
    {
        private Bitmap[] imageList = new Bitmap[]
        {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4,
            Properties.Resources._5,
            Properties.Resources._6,
            Properties.Resources._7,
            Properties.Resources._8,

        };

        Timer timer;
        int counter = 0;

        public FrmSplashScreen()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 120;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(counter > imageList.Length - 1)            
            {
                counter = 0;
            }

            PBloading.Image = imageList[counter++];
        }
    }
}
