using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nombremagique.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        const int NB_MAGIQUE_MIN = 1;
        const int NB_MAGIQUE_MAX = 10;
        int nombreMagique = 0;
        public GamePage()
        {
            InitializeComponent();
            nombreMagique = new Random().Next(NB_MAGIQUE_MIN, NB_MAGIQUE_MAX);
            minMaxLabel.Text = "entre " + NB_MAGIQUE_MIN + " et " + NB_MAGIQUE_MAX;
        }

        public void ButtonClick(object sender, System.EventArgs args)
        {
            if (String.IsNullOrWhiteSpace(numberEntry.Text))
            {
                DisplayAlert("Oops", "Vous devez entrer un nombre", "ok");
                return;
            }
            int nombreUtilisateur = 0;
            try
            {
                nombreUtilisateur = Int32.Parse(numberEntry.Text);
            }
            catch (Exception e)
            {
                DisplayAlert("Oops", "Vous devez entreruniquement des chiffres", "ok");
                return;
            }
            if ((nombreUtilisateur < NB_MAGIQUE_MIN) || (nombreUtilisateur > NB_MAGIQUE_MAX))
            {
                DisplayAlert("Oops", "Vous devez entrer un nombre entre " + NB_MAGIQUE_MIN + " et " + NB_MAGIQUE_MAX, "ok");
                return;
            }
            if (nombreUtilisateur < nombreMagique)
            {
                DisplayAlert("Oops", "Le nombre magique est supérieur à " + nombreUtilisateur, "ok");
                return;
            }
            if (nombreUtilisateur > nombreMagique)
            {
                DisplayAlert("Oops", "Le nombre magique est inférieur à " + nombreUtilisateur, "ok");
                return;
            }
            if (nombreUtilisateur == nombreMagique)
            {
                DisplayAlert("Gagné", "Vous avez trouvé le nombre magique", "ok");
            }
        }
    }
}