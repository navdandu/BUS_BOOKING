﻿using System.Data;
using Businessobjects;
using Dataacesslayer;
using System.Data.SqlClient;
using System;

namespace Businesslogiclayer
{
    public  class Businesslogiclayerclass
    {
        #region Admin
        public int Adminlogin(Businessobjects.BusinessObjectsclass objbo)
        {
            if (objbo.Username=="Admin" && objbo.Password=="naveen")
            {
                return 1;
            }
            else
            {
                return 0;
            }
            #endregion
        }

        public DataSet ViewDpoints()
        {
            DataSet ds = objdal.viewDpoints();
            return ds;
        }

        Dataacesslayer.Dataaccesslayer objdal = new Dataacesslayer.Dataaccesslayer();
        #region Autogeneratesvno
            public string AutogenerateSvno()
        {
            string s2 = "sv_";
            string s = objdal.AutogenerateServiceno();
            string[] s1 = s.Split('_');
            int i = int.Parse(s1[1]);
            i++;
            s2 = s2 + i;
            return s2;
        }
        #endregion
        #region Addbus
        public int Addbus(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.Addbus(objbo);
            return i;
        }

            
        #endregion
        #region Viewbus
        public DataSet Viewbus()
        {
            DataSet ds = objdal.Viewbus();
            return ds;

        }
        #endregion
        #region DeleteBus
        public int DeleteBus(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.DeleteBus(objbo);
            return i;
        }
        #endregion
        #region EditBus

        public int Editbus(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.EditBus(objbo);
            return i;
        }

        #endregion
        #region AutogeneratePickPoint
        public string AutogeneratePickPoint()
        {
            string pid = "pid_";
            string s = objdal.AutogeneratePickpoint();
            string[] s1 = s.Split('_');
            int i = int.Parse(s1[1]);
            i++;
            pid = pid + i;
            return pid;
        }
        #endregion
        #region Addpickuppoint
        public int Addpickuppoint(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.Addpickuppoint(objbo);
            return i;
        }

        public DataSet ViewDpoints(BusinessObjectsclass objbo)
        {
            DataSet ds = objdal.viewDpoints();
            return ds;
        }
        #endregion
        #region Viewpickuppoints
        public DataSet Viewpickpoints()
        {
            DataSet ds = objdal.Viewpickuppoints();
            return ds;
        }
        #endregion
        #region Deletepickuppoints
        public int Deletepickuppoint(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.Deletepickuppoint(objbo);
            return i;
        }
        #endregion
        #region Bindserviceno
        public SqlDataReader Bindserviceno()
        {
            SqlDataReader dr = objdal.Bindserviceno();
            return dr;
        }




        #endregion
        #region Addbuspickuppoints
        public int Addbuspickuppoints(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.Addbuspickuppoints(objbo);
            return i;
        }
        #endregion
        #region AutogenerateDid()

        public string AutogenerateDid()
        {
            string did = "did_";
            string s = objdal.AutogenerateDid();
            string[] s1 = s.Split('_');
            int i = int.Parse(s1[1]);
            i++;
            did = did + i;
            return did;
        }
        #endregion
        #region Adddestinationpoint
        public int Adddestinationpoint(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.AddDestinationpoint(objbo);
            return i;
        }

        #endregion
        #region DeleteDestinationpoint
        public int DeleteDestinationpoint(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.DeleteDestinationpoint(objbo);
            return i;
        }
        #endregion
        #region  UpdateDestination 
        public int UpdateDestination(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.UpdateDestination(objbo);
            return i;
        }
        #endregion
        #region AddbusDestinationpoints
        public int AddbusDestinationpoints(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.AddbusDestinationpoints(objbo);
            return i;
        }
        #endregion
        #region  Bindpointsbasedonserviceno
        public DataSet Bindpointsbasedonserviceno(Businessobjects.BusinessObjectsclass objbo)
        {
            DataSet ds = objdal.Bindpointsbasedonserviceno(objbo);
            return ds;
        }
        #endregion
        #region Addfaredestination
        public int Addfaredestination(Businessobjects.BusinessObjectsclass objbo)
        {
            int i = objdal.Addfaredestination(objbo);
            return i;
        }
        #endregion
        #region Binddname
        public DataSet Binddenames()
        {
            return objdal.Binddenames();
        }
        #endregion


    }
}