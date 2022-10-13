using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}


        // Método do click do Botão
        private void MudarParaPagina2(object sender, EventArgs args)
        {
            //  ir para a página 2, mas manter o Histórico
            Navigation.PushAsync(new Pagina2());
        }



        // ChamarModal
        // Método do Click do Botão
        private void ChamarModal(object sender, EventArgs args)
        {
            //  ir para a página 2, mas manter o Histórico
            Navigation.PushModalAsync(new Modal());
        }


        //ChamarMaster
        private void ChamarMaster(object sender, EventArgs args)
        {
            //  ir para a página 
            // Como é uma Página MasterDetail deve ser chamada com .Current
            App.Current.MainPage = new Master.Master();
        }

    }
}