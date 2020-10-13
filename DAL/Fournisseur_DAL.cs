using BEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Fournisseur_DAL : Connection, ICrud<Fournisseur>
    {
        public int Insert(Fournisseur _entity)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "Insert Into fournisseur (Nom,Tel,Ville,Adress,IFF,Email,Pays,ICE) values(@Nom,@Tel,@Ville,@Adress,@IFF,@Email,@Pays,@ICE)";
                    cmd.Parameters.AddWithValue("@Nom", _entity.Nom);
                    cmd.Parameters.AddWithValue("@Tel", _entity.Tel);
                    cmd.Parameters.AddWithValue("@Ville", _entity.Ville);
                    cmd.Parameters.AddWithValue("@Adress", _entity.Adress);
                    cmd.Parameters.AddWithValue("@IFF", _entity.IFF);
                    cmd.Parameters.AddWithValue("@Email", _entity.Email);
                    cmd.Parameters.AddWithValue("@Pays", _entity.Pays);
                    cmd.Parameters.AddWithValue("@ICE", _entity.Ice);
                    OpenCon();
                    return cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseCon();
            }
        }

        public int Update(Fournisseur _entity)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "Update fournisseur SET Nom=@Nom, Tel=@Tel, Ville=@Ville, Adress=@Adress,IFF=@IFF,Email=@Email,Pays=@Pays,ICE=@ICE Where Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", _entity.Id);
                    cmd.Parameters.AddWithValue("@Nom", _entity.Nom);
                    cmd.Parameters.AddWithValue("@Tel", _entity.Tel);
                    cmd.Parameters.AddWithValue("@Ville", _entity.Ville);
                    cmd.Parameters.AddWithValue("@Adress", _entity.Adress);
                    cmd.Parameters.AddWithValue("@IFF", _entity.IFF);
                    cmd.Parameters.AddWithValue("@Email", _entity.Email);
                    cmd.Parameters.AddWithValue("@Pays", _entity.Pays);
                    cmd.Parameters.AddWithValue("@ICE", _entity.Ice);
                    OpenCon();
                    return cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseCon();
            }
        }

        public int Delete(Fournisseur _entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteByID(int ID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "Delete from fournisseur where Id=@ID";
                    cmd.Parameters.AddWithValue("@ID", ID);
                    OpenCon();
                    return cmd.ExecuteNonQuery();
                }
            }

            finally
            {
                CloseCon();
            }
        }

        public Fournisseur GetEntityByID(int ID,string Nom,string Adress)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "Select * From fournisseur Where Id ='%'+@Id+'%' OR Nom='%'+@Name+'%' OR Adress='%'+@Adress+'%'";
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.Parameters.AddWithValue("@Name", Nom);
                    cmd.Parameters.AddWithValue("@Adress", Adress);
                    OpenCon();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Fournisseur _Fournisseur = null;
                    while (dr.Read())
                    {
                        _Fournisseur = new Fournisseur
                        {
                            Id = (int)dr["Id"],
                            Nom = dr["Nom"].ToString(),
                            Tel = dr["Tel"].ToString(),
                            Ville = dr["Ville"].ToString(),
                            Adress = dr["Adress"].ToString(),
                            IFF = dr["IFF"].ToString(),
                            Email = dr["Email"].ToString(),
                            Pays = dr["Pays"].ToString(),
                            Ice = dr["ICE"].ToString()
                        };
                    }
                    dr.Close();
                    return _Fournisseur;
                }
            }
            finally
            {
                CloseCon();
            }
        }
        public List<Fournisseur> GetAllRecord()
        {
            try
            {
                using(SqlCommand cmd=new SqlCommand("",con))
                {
                    cmd.CommandText = "select *from fournisseur";
                    OpenCon();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Fournisseur> lstfornisseur = new List<Fournisseur>();
                    while(dr.Read())
                    {
                        lstfornisseur.Add
                            (
                                new Fournisseur()
                                {
                                    Id = (int)dr["Id"],
                                    Nom=dr["Nom"].ToString(),
                                    Tel=dr["Tel"].ToString(),
                                    Ville=dr["Ville"].ToString(),
                                    Adress=dr["Adress"].ToString(),
                                    IFF=dr["IFF"].ToString(),
                                    Email=dr["Email"].ToString(),
                                    Pays=dr["Pays"].ToString(),
                                    Ice=dr["ICE"].ToString()
                                }
                            );
                       
                    }
                    dr.Close();
                    return lstfornisseur;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }


    }
}
