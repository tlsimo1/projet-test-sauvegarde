using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for View_Fournisseur.xaml
    /// </summary>
    public partial class View_Fournisseur : Window,INotifyPropertyChanged
    {
        BLL_Fournisseur _BLL_Fournisseur;
        Fournisseur _Fournisseur;
        //List<Fournisseur> list = new List<Fournisseur>();
        #region
        private List<Fournisseur> _Lists;
        public List<Fournisseur> Lists
        {
            get { return _Lists; }
            set
            {
                _Lists = value;
                OnProperyChanged("Lists");
            }
        }
        private Fournisseur _chosenItem = new Fournisseur();
        public Fournisseur ChosenItem
        {
            get
            {
                return _chosenItem;
            }
            set
            {
                _chosenItem = value;
                OnProperyChanged("ChosenItem");
            }
        }
        #endregion

        public View_Fournisseur()
        {

            InitializeComponent();
            _BLL_Fournisseur = new BLL_Fournisseur();
            _Fournisseur = new Fournisseur();
            DataContext = this;
            ActualiseGrid();
            
        }

        void ActualiseGrid()
        {
            Lists = _BLL_Fournisseur.GetAllRecord();
            grid_Fournisseur.ItemsSource = Lists;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void txt_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            _Fournisseur = (_BLL_Fournisseur.GetEntityByID(_Fournisseur.Id,_Fournisseur.Nom,_Fournisseur.Adress));
            DataContext = _Fournisseur;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            View_Fournisseur v1 = new View_Fournisseur();
            Ajouter_fournisseur FRA = new Ajouter_fournisseur(ChosenItem);
            FRA.state = "Update";
            v1.Close();
            Close();
            FRA.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                _Fournisseur.Id = ((Fournisseur)grid_Fournisseur.SelectedItem).Id;
                _BLL_Fournisseur.DeleteByID(_Fournisseur.Id);
                ActualiseGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnProperyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}