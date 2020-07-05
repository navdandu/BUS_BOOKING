using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Businessobjects;
namespace Dataacesslayer
{
    public class Dataaccesslayer
    {
        #region AutogenerateServiceno
        public string AutogenerateServiceno()
        {
            //create the connection
            SqlConnection con = new
                   SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            //open the connection
            con.Open();
            //pass the procedure
            SqlCommand cmd = new SqlCommand("proc_autogeneratesvno", con);
            //mention that we are working with storedprocedure
            cmd.CommandType = CommandType.StoredProcedure;
            string s = cmd.ExecuteScalar().ToString();
            return s;


        }
        #endregion
        #region Addbus
        public int Addbus(Businessobjects.BusinessObjectsclass objbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_addbus", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@svno", objbo.Serviceno);
            cmd.Parameters.AddWithValue("@fromplace", objbo.Fromplace);
            cmd.Parameters.AddWithValue("@toplace", objbo.Toplace);
            cmd.Parameters.AddWithValue("@capacity", objbo.Capacity);
            cmd.Parameters.AddWithValue("@arrivaltime", objbo.Arrivaltime);
            cmd.Parameters.AddWithValue("@depaturetime", objbo.Depaturetime);
            cmd.Parameters.AddWithValue("@tname", objbo.Travelagencyname);
            cmd.Parameters.AddWithValue("@bustype", objbo.bustype);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        #endregion
        #region Viewbus
        public DataSet Viewbus()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_viewbus", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "bus");
            return ds;
        }
        #endregion
        #region Deletebus

        public int DeleteBus(Businessobjects.BusinessObjectsclass objbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_deletebus", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@serviceno", objbo.Serviceno);
            int i = cmd.ExecuteNonQuery();
            return i;

        }
        #endregion
        #region EditBus
        public int EditBus(Businessobjects.BusinessObjectsclass objbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_editbus", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@svno", objbo.Serviceno);
            cmd.Parameters.AddWithValue("@fromplace", objbo.Fromplace);
            cmd.Parameters.AddWithValue("@toplace", objbo.Toplace);
            cmd.Parameters.AddWithValue("@capacity", objbo.Capacity);
            cmd.Parameters.AddWithValue("@arrivaltime", objbo.Arrivaltime);
            cmd.Parameters.AddWithValue("@depaturetime", objbo.Depaturetime);
            cmd.Parameters.AddWithValue("@tagencyname", objbo.Travelagencyname);
            cmd.Parameters.AddWithValue("@bustype", objbo.bustype);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        #endregion
        #region AutogeneratePickpoint

        public string AutogeneratePickpoint()

        {
            //create connection
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            //open the connection
            con.Open();
            //pass the procedure
            SqlCommand cmd = new SqlCommand("proc_autogeneratepickuppointid", con);
            //mention that we  are working with stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            string s = cmd.ExecuteScalar().ToString();
            return s;

        }

        #endregion
        #region Addpickuppoint
        public int Addpickuppoint(Businessobjects.BusinessObjectsclass objbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_addpickuppoint", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", objbo.pid);
            cmd.Parameters.AddWithValue("@pname", objbo.pname);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        #endregion
        #region Viewpickuppoints
        public DataSet Viewpickuppoints()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_viewpickuppoint", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "pickuppoints");
            return ds;
        }

        #endregion
        #region Deletepickuppoint
        public int Deletepickuppoint(Businessobjects.BusinessObjectsclass objbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_deletepickuppoint", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", objbo.pid);
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        #endregion
        #region Bindserviceno
        public SqlDataReader Bindserviceno()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_bindserviceno", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }
        #endregion
        #region Addbuspickuppoints
        public int Addbuspickuppoints(Businessobjects.BusinessObjectsclass objbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_addbuspickuppoint", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@svno", objbo.Serviceno);
            cmd.Parameters.AddWithValue("@pid", objbo.pid);
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        #endregion
        #region AutogenerateDid

        public string AutogenerateDid()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_autogeneratedid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            string s = cmd.ExecuteScalar().ToString();
            return s;


        }
        #endregion
        #region AddDestinationpoint
        public int AddDestinationpoint(Businessobjects.BusinessObjectsclass objbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_adddestinationpoint", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@did", objbo.Did);
            cmd.Parameters.AddWithValue("@dname", objbo.Dname);
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        #endregion
        #region ViewDestinationpoints
        public DataSet viewDpoints()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_displaydpoints", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "destination");
            return ds;

        }

        #endregion
        #region DeleteDestinationpoint
        public int DeleteDestinationpoint(Businessobjects.BusinessObjectsclass objbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_deletedestinationpoint", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@did", objbo.Did);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        #endregion
        #region UpdateDestination
        public int UpdateDestination(Businessobjects.BusinessObjectsclass objbo)
        {


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_updatedestination", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@did", objbo.Did);
            cmd.Parameters.AddWithValue("@dname", objbo.Dname);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        #endregion
        #region Addbusdestinationpoint
        public int AddbusDestinationpoints(Businessobjects.BusinessObjectsclass objbo)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_addbusdestinationpoint", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@svno", objbo.Serviceno);
            cmd.Parameters.AddWithValue("@did", objbo.Did);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        #endregion
        #region Bindpointsbasedonserviceno
        public DataSet Bindpointsbasedonserviceno(Businessobjects.BusinessObjectsclass objbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_bindpointsbasedonsvno", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@svno", objbo.Serviceno);
            da.Fill(ds, "destination");
            return ds;
        }
        #endregion
        #region Addfaredestion
        public int Addfaredestination(Businessobjects.BusinessObjectsclass objbo)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_addfaredestination", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@svno", objbo.Serviceno);
            cmd.Parameters.AddWithValue("@fdid", objbo.Fdid);
            cmd.Parameters.AddWithValue("@fdeptime", objbo.Fdeptime);
            cmd.Parameters.AddWithValue("@tdid", objbo.Tdid);
            cmd.Parameters.AddWithValue("@tdeptime", objbo.Tdeptime);
            cmd.Parameters.AddWithValue("@fare", objbo.Fare);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        #endregion
        #region Binddname
        public DataSet Binddenames()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_binddenames", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "destination");
            return ds;
        }

        #endregion
    }
}



