using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public interface ICrud<F>
    {
        int Insert(F _entity);
        int Update(F _entity);
        int Delete(F _entity);
        int DeleteByID(int ID);

        F GetEntityByID(int ID,string Nom,string Adress);
        List<F> GetAllRecord();

    }
}
