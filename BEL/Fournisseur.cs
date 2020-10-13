using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class Fournisseur:BindableBase
    {
        private int _id;
        private string _nom;
        private string _ville;
        private string _adress;
        private string _email;
        private string _Ice;
        private string _tel;
        private string _iFF;
        private string _pays;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnProperyChanged("Id");
            }
        }
        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
                OnProperyChanged("Nom");
            }
        }
        public string Ville
        {
            get
            {
                return _ville;
            }

            set
            {
                _ville = value;
                OnProperyChanged("Ville");

            }
        }
        public string Adress
        {
            get
            {
                return _adress;
            }

            set
            {
                _adress = value;
                OnProperyChanged("Adress");

            }
        }
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
                OnProperyChanged("Email");

            }
        }
        public string Ice
        {
            get
            {
                return _Ice;
            }

            set
            {
                _Ice = value;
                OnProperyChanged("Ice");

            }
        }
        public string Tel
        {
            get
            {
                return _tel;
            }

            set
            {
                _tel = value;
                OnProperyChanged("Tel");

            }
        }
        public string IFF
        {
            get
            {
                return _iFF;
            }

            set
            {
                _iFF = value;
                OnProperyChanged("IFF");

            }
        }

        public string Pays
        {
            get
            {
                return _pays;
            }

            set
            {
                _pays = value;
                OnProperyChanged("Pays");

            }
        }
        public Fournisseur() { }
    }
}
