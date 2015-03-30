using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestGrid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.SizeChanged += MainPage_SizeChanged;
        }

        void MainPage_SizeChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("GRID SIZE : HEIGHT " + this.Height + " WIDTH : " + this.Width);
        }
    }
}
