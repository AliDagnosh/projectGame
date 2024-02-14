using progect.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progect
{
    public partial class MEDLIST : Form
    {
        DATA_ACCESS_LAYER DAL = new DATA_ACCESS_LAYER();
        public MEDLIST()
        {
            InitializeComponent();
        }
        void GetAllAliasCLINC_TBL()
        {
            DataTable Dt = new DataTable();
            Dt.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DAL.SCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ("Select * from MEDLIST_TBL");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlParameter[] Param = new SqlParameter[4];
            Param[0] = new SqlParameter("@MEDLIST_IDE", SqlDbType.Int) { Value = MEDLIST_ID.Text };
            Param[1] = new SqlParameter("@MEDLIST_NAME", SqlDbType.NVarChar) { Value = MEDLIST_NAME.Text };
            Param[2] = new SqlParameter("@MEDLIST_DATE", SqlDbType.NVarChar) { Value = MEDLIST_DATE.Text };
            Param[3] = new SqlParameter("@MEDLIST_TIME", SqlDbType.NVarChar) { Value = MEDLIST_TIME.Text };
        
            //Cmd.Parameters.AddRange(Param);
            DAL.EXCUTDATA("sp_insertmedlist", Param);
            MessageBox.Show("تم الإضافة بنجاح ", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();
        }
       
        private void Button5_Click(object sender, EventArgs e)
        {
            SqlParameter[] Param = new SqlParameter[4];
            Param[0] = new SqlParameter("@MEDLIST_IDE", SqlDbType.Int) { Value = MEDLIST_ID.Text };
            Param[1] = new SqlParameter("@MEDLIST_NAME", SqlDbType.NVarChar) { Value = MEDLIST_NAME.Text };
            Param[2] = new SqlParameter("@MEDLIST_DATE", SqlDbType.NVarChar) { Value = MEDLIST_DATE.Text };
            Param[3] = new SqlParameter("@MEDLIST_TIME", SqlDbType.NVarChar) { Value = MEDLIST_TIME.Text };

            //Cmd.Parameters.AddRange(Param);
            DAL.EXCUTDATA("sp_insertmedlist", Param);
            MessageBox.Show("تم الحفظ بنجاح ", "االحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlParameter[] Param = new SqlParameter[4];
            Param[0] = new SqlParameter("@MEDLIST_IDE", SqlDbType.Int) { Value = MEDLIST_ID.Text };
            Param[1] = new SqlParameter("@MEDLIST_NAME", SqlDbType.NVarChar) { Value = MEDLIST_NAME.Text };
            Param[2] = new SqlParameter("@MEDLIST_DATE", SqlDbType.NVarChar) { Value = MEDLIST_DATE.Text };
            Param[3] = new SqlParameter("@MEDLIST_TIME", SqlDbType.NVarChar) { Value = MEDLIST_TIME.Text };

            //Cmd.Parameters.AddRange(Param);
            DAL.EXCUTDATA("sp_Updatemedlist", Param);
            MessageBox.Show("تم التعديل بنجاح ", "االتعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@MEDLIST_IDE", SqlDbType.Int) { Value = MEDLIST_ID.Text };
            DAL.EXCUTDATA("sp_DELETmedlist", Param);
            MessageBox.Show("تم الحذف بنجاح ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();
        }

        private void MEDLIST_Load(object sender, EventArgs e)
        {

        }
    }

       
  }
