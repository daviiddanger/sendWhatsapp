using System.Globalization;

namespace sendWhatsapp
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string Numero = ladaEntry.Text + numberEntry.Text;
            EnviarWhatsapp(Numero, messageEntry.Text);
          
        }

        public async static void EnviarWhatsapp(string numTelefonico, string Mensaje)
        {
            bool sepodra = await Launcher.Default.CanOpenAsync($"whatsapp://send?phone=+{numTelefonico}&text={Mensaje}");
           if ( sepodra )
            {
                await Launcher.Default.OpenAsync($"whatsapp://send?phone=+{numTelefonico}&text={Mensaje}");

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "No se puede abrir WhatsApp.", "OK");

            }
 
             





            
        }
    }
}