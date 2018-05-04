using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ResourcesStylesExemplos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            //App.Current.Resources["backgroundColor"] = Color.White;
            //App.Current.Resources["textColor"] = Color.Pink;

            InitializeComponent();

        }

        void btnTemaClicked(object sender, EventArgs e)
        {
            App.Current.Resources["corFundo"] = Color.FromHex(txtCorFundo.Text);
            App.Current.Resources["corTexto"] = Color.FromHex(txtCorTexto.Text);
        }
    }
}
