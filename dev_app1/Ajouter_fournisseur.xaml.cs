using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace dev_app1
{
    /// <summary>
    /// Interaction logic for Ajouter_fournisseur.xaml
    /// </summary>
    public partial class Ajouter_fournisseur : Window
    {
        public string state = "ADD";

        Fournisseur _Fournisseur=new Fournisseur();
        BLL_Fournisseur _Bll_fournisseur;
        public Ajouter_fournisseur(Fournisseur _fr)
        {

            InitializeComponent();
            _Fournisseur = _fr;
            _Bll_fournisseur = new BLL_Fournisseur();
            DataContext = _Fournisseur;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if(state=="ADD")
                {
                    View_Fournisseur view = new View_Fournisseur();
                     _Bll_fournisseur.Insert(_Fournisseur);
                    //MessageBox.Show("Fournisseur a été ajouté avec succès");
                    view.Show();
                }
                if (state=="Update")
                {
                    _Bll_fournisseur.Update(_Fournisseur);
                    View_Fournisseur view = new View_Fournisseur();
                    view.Show();
                    Close();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
