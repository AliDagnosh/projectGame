using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace progect.code
{
    
    class DATA_ACCESS_LAYER

    {
       // كود الاتصال بقاعدة البيانات
      
     public SqlConnection SCon = new SqlConnection(@"SERVER=.; DATABASE=HS_DB; INTEGRATED SECURITY=TRUE");
        //public DATA_ACCESS_LAYER ()
        //  {
            
        //   }
        //كود فتح الاتصال
        public void OPEN()
    {
    if (SCon.State != ConnectionState .Open )
           {
                SCon.Open() ;
           }   
    }
        // كود غلق الاتصال
        public void CLOSE()

    {
     if (SCon.State != ConnectionState .Closed )
           {
                SCon.Close() ;
           }   
    }
        // كود القراءة من قاعدة البيانات
        public DataTable SELECTDATA(string STORED_PROC, SqlParameter [] PARAM)

        {
            SqlCommand CMD = new SqlCommand();
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = STORED_PROC;
            CMD.Connection = SCon;

            if (PARAM != null)
            {
                CMD.Parameters.AddRange(PARAM);
            }

            SqlDataAdapter DA = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable("STORED_PROC");
            DA.Fill(DT);
            CLOSE();
            return DT;
        }
        // كود الكتابة علي قاعدة البيانات
        public void EXCUTDATA(string STORED_PROC, SqlParameter[] PARAM)
        {
            SqlCommand CMD = new SqlCommand();
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = STORED_PROC;
            CMD.Connection = SCon;
            OPEN();
            if (PARAM != null)
            {
                CMD.Parameters.AddRange(PARAM);
            }
            
            CMD.ExecuteNonQuery();
            CLOSE();
        }

}
}
