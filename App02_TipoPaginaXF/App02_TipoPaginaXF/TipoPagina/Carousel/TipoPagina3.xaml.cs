using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

        
        // Método do Evento click do Botão
        private void MudarPagina(object sender, EventArgs args)
        {
            // Mudança de Página
            // Método .Current
            // navigation
            // NavigationPage
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) { BarBackgroundColor = Color.Blue };

            App.Current.MainPage = new Tabbed.Abas();


        }
        


    }
}