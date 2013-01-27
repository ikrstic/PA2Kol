using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoKlubWin
{
    class ClanProvider
    {
    
        public List<Clan> IscitajListuClanova()
        {
            SqlConnection kon  = new SqlConnection(Konekcija.cnnVideoKlub);
            List<Clan> Clanovi = new List<Clan>();
            SqlCommand sqlCom  = new SqlCommand("select * from Clan",kon);
            kon.Open();
            SqlDataReader dr   = sqlCom.ExecuteReader();
        while (dr.Read())
        {
            Clan cl            = new Clan();
            cl.ClanID          = Int32.Parse(dr["ClanID"].ToString());
            cl.Ime             = dr["Ime"].ToString();
            cl.Prezime         = dr["Prezime"].ToString();
            cl.Jmbg            = dr["Jmbg"].ToString();
            cl.Adresa          = dr["Adresa"].ToString();
            cl.Telefon         = dr["Telefon"].ToString();
            Clanovi.Add(cl);
        }
            kon.Close();
            return Clanovi;
        }

    public int UbaciClana(Clan cl)
    {
        SqlConnection kon = new SqlConnection(Konekcija.cnnVideoKlub);
        SqlCommand sqlCom = new SqlCommand("UbaciClana", kon);
        sqlCom.CommandType = CommandType.StoredProcedure;
        sqlCom.Parameters.Add("@ime", SqlDbType.NVarChar);
        sqlCom.Parameters["@ime"].Value = cl.Ime;
        sqlCom.Parameters.Add("@prezime", SqlDbType.NVarChar);
        sqlCom.Parameters["@prezime"].Value = cl.Prezime;
        sqlCom.Parameters.Add("@jmbg", SqlDbType.NVarChar);
        sqlCom.Parameters["@jmbg"].Value = cl.Jmbg;
        sqlCom.Parameters.Add("@adresa", SqlDbType.NVarChar);
        sqlCom.Parameters["@adresa"].Value = cl.Adresa;
        sqlCom.Parameters.Add("@telefon", SqlDbType.NVarChar);
        sqlCom.Parameters["@telefon"].Value = cl.Telefon;
        try
    {
        kon.Open();
        sqlCom.ExecuteNonQuery();
        return 0;
    }
    catch
    {
        return -1;
    }
    finally
    {
        kon.Close();
    }
    }
    public int IzbrisiClana(Clan cl)
    {
        SqlConnection kon = new SqlConnection(Konekcija.cnnVideoKlub);
        SqlCommand sqlCom = new SqlCommand("IzbrisiClana", kon);
        sqlCom.CommandType = CommandType.StoredProcedure;
        sqlCom.Parameters.Add("@clanID", SqlDbType.NVarChar);
        sqlCom.Parameters["@clanID"].Value = cl.ClanID;
        try
        {
            kon.Open();
            sqlCom.ExecuteNonQuery();
            return 0;
        }
        catch
        {
            return -1;
        }
        finally
        {
            kon.Close();
        }
    }

    public int IzmeniClana(Clan cl)
    {
        SqlConnection kon = new SqlConnection(Konekcija.cnnVideoKlub);
        SqlCommand sqlCom = new SqlCommand("IzmeniClana", kon);
        sqlCom.CommandType = CommandType.StoredProcedure;
        sqlCom.Parameters.Add("@clanID", SqlDbType.Int);
        sqlCom.Parameters["@clanID"].Value = cl.ClanID;
        sqlCom.Parameters.Add("@ime", SqlDbType.NVarChar);
        sqlCom.Parameters["@ime"].Value = cl.Ime;
        sqlCom.Parameters.Add("@prezime", SqlDbType.NVarChar);
        sqlCom.Parameters["@prezime"].Value = cl.Prezime;
        sqlCom.Parameters.Add("@jmbg", SqlDbType.NVarChar);
        sqlCom.Parameters["@jmbg"].Value = cl.Jmbg;
        sqlCom.Parameters.Add("@adresa", SqlDbType.NVarChar);
        sqlCom.Parameters["@adresa"].Value = cl.Adresa;
        sqlCom.Parameters.Add("@telefon", SqlDbType.NVarChar);
        sqlCom.Parameters["@telefon"].Value = cl.Telefon;
        try
        {
            kon.Open();
            sqlCom.ExecuteNonQuery();
            return 0;
        }
        catch
        {
            return -1;
        }
        finally
        {
            kon.Close();
        }
    }

    }
}
