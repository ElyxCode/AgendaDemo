using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AgendaDemo
{
    public class PaginaListaContacto : MasterDetailPage
    {
        public PaginaListaContacto()
        {
            var lista = new ListView();
            lista.ItemsSource =
                GeneradorDeContactos.
                CrearContactos().
                OrderBy(x => x.Nombre);

            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Detail = new PaginaContacto(e.SelectedItem as Contacto);
                    IsPresented = false;
                }
            };

            Master = new ContentPage
            {
                Title = "Contacto",
                Content = lista
            };

            Detail = new PaginaContacto(GeneradorDeContactos.CrearContactos().First());
        }
    }
}
