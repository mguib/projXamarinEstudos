using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace estudosInterface2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var image = new Image { Source = "vai.png" };


        }
        void Impressao(object sender, EventArgs e)
        {
            (sender as Button).Text = "Iniciar impressão de Texto";
        }
        

    }
}
