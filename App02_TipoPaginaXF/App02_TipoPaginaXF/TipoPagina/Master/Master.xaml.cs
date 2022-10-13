using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        // MudarPagina1
        public void MudarPagina1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Navigation.Pagina1());
            // Para esconder o Menu
            IsPresented = false;
        }


        // MudarPagina2
        public void MudarPagina2(object sender, EventArgs args)
        {
            Detail = new Navigation.Pagina2();
            // Para esconder o Menu
            IsPresented = false;
        }

        // MudarPagina3
        public void MudarPagina3(object sender, EventArgs args)
        {
            Detail = new Conteudo();
            // Para esconder o Menu
            IsPresented = false;
        }


    }
}