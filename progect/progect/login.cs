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
    public partial class login : Form
    {
        DATA_ACCESS_LAYER DAL = new DATA_ACCESS_LAYER();
        public login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            
                 SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@USER_NAME", SqlDbType.VarChar,50) { Value = USER_NAME.Text };
            Param[1] = new SqlParameter("@USER_PASSWORD", SqlDbType.VarChar,50) { Value = USER_PASSWORD.Text };
            DT = DAL.SELECTDATA("Sp_login", Param);
            if(DT.Rows.Count>0)
               {
                Form1 SS=new Form1();
                SS.ShowDialog();
            }
            else
            {
                MessageBox.Show("التاكد من كلمة المرور واسم المستخدم");
            }

        }

      
    }
}
