using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Fournisseur : ICrud<Fournisseur>
    {
        private Fournisseur_DAL _Fournisseur_DAL = new Fournisseur_DAL();
        public int Insert(Fournisseur _entity)
        {
           return _Fournisseur_DAL.Insert(_entity);
        }

        public int Update(Fournisseur _entity)
        {
            return _Fournisseur_DAL.Update(_entity);
        }

        public int Delete(Fournisseur _entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteByID(int ID)
        {
            return _Fournisseur_DAL.DeleteByID(ID);
        }

        public Fournisseur GetEntityByID(int ID,string Nom,string Adress)
        {
            return _Fournisseur_DAL.GetEntityByID(ID, Nom, Adress);
        }

        public List<Fournisseur> GetAllRecord()
        {
            return _Fournisseur_DAL.GetAllRecord();
        }

        public Fournisseur GetEntityByID(Fournisseur _Fournisseur)
        {
            throw new NotImplementedException();
        }
    }
}
