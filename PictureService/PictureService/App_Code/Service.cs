using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.IO;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    SqlConnection Conn;

    // Sercice initialization
    public Service()
    {
        Conn = new SqlConnection();
        Conn.ConnectionString = "Data Source=(local);Initial Catalog=PictureService;Integrated Security=True";
        Conn.Open();   
    }

    /*---------------------------------------------------------------------------*/
    /*                               Work with files                             */

    [WebMethod] // Add file to database
    public Guid PictureAdd(byte[] Picture)
    {
        Guid ID = Guid.NewGuid();
        SqlCommand Command = new SqlCommand();

        Command.Connection = Conn;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.Parameters.AddWithValue("@Picture", Picture);
        Command.Parameters.AddWithValue("@Comment", "");
        Command.CommandText = "INSERT INTO Pictures VALUES (@ID, @Picture, @Comment)";
        Command.ExecuteNonQuery();

        return ID;
    }

    [WebMethod] // Delete file from database
    public void PictureDelete(String ID)
    {
        SqlCommand Command = new SqlCommand();
        Command.Connection = Conn;
        Command.Parameters.AddWithValue("@ID", new Guid(ID));
        Command.CommandText = "DELETE FROM Pictures WHERE ID=@ID";
        Command.ExecuteNonQuery();
    }

    [WebMethod] // Gets image from base
    public byte[] PictureLoad(String ID)
    {
        SqlCommand Command = new SqlCommand();
        Command.Connection = Conn;
        Command.Parameters.AddWithValue("@ID", new Guid(ID));
        Command.CommandText = "SELECT Picture FROM Pictures WHERE ID = @ID";

        SqlDataReader Reader = Command.ExecuteReader();
        Reader.Read();
        byte[] Picture = Reader.GetSqlBinary(0).Value;
        Reader.Close();

        return Picture;
    }

    [WebMethod] // Display all files in base
    public List<Guid> PictureList()
    {
        List<Guid> PictureList = new List<Guid>();

        SqlCommand Command = new SqlCommand();
        Command.Connection = Conn;
        Command.CommandText = "SELECT ID FROM Pictures";

        SqlDataReader Reader = Command.ExecuteReader();

        while (Reader.Read())
        {
            PictureList.Add(Reader.GetGuid(0));
        }
        Reader.Close();

        return PictureList;
    }

    /*---------------------------------------------------------------------------*/
    /*                             Work with comments                            */

    [WebMethod] // Saves comment in base
    public void CommentSave(String ID, String Comment)
    {
        SqlCommand Command = new SqlCommand();
        Command.Connection = Conn;
        Command.Parameters.AddWithValue("@ID", new Guid(ID));
        Command.Parameters.AddWithValue("@Comment", Comment);
        Command.CommandText = "UPDATE Pictures SET Comment=@Comment WHERE ID=@ID";
        Command.ExecuteNonQuery();
    }

    [WebMethod] // Gets comment from base
    public String CommentLoad(String ID)
    {
        SqlCommand Command = new SqlCommand();
        Command.Connection = Conn;
        Command.Parameters.AddWithValue("@ID", new Guid(ID));
        Command.CommandText = "SELECT Comment FROM Pictures WHERE ID = @ID";

        SqlDataReader Reader = Command.ExecuteReader();
        Reader.Read();
        String Comment = Reader.GetString(0);
        Reader.Close();

        return Comment;    
    }
}
