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
    public partial class MADCIN : Form
    {
        DATA_ACCESS_LAYER DAL = new DATA_ACCESS_LAYER();
        public MADCIN()
        {
            InitializeComponent();
            DataTable DT = new DataTable();
            DT = DAL.SELECTDATA("fill_comboCLINCas", null);
            cmb_cliID.DataSource = DT;
            cmb_cliID.DisplayMember = "CLI_NAME";
            cmb_cliID.ValueMember = "CLI_ID";
            cmb_cliID.SelectedValue = -1;
        }
        void GetAllAliasCLINC_TBL()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DAL.SCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetMEDCINData"; // استبدل "YourStoredProcedureName" بالاسم الصحيح للإجراء المخزن
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            SqlParameter[] Param = new SqlParameter[6];
            //Param[0] = new SqlParameter("@MED_ID", SqlDbType.Int) { Value = MED_ID.Text };
            Param[0] = new SqlParameter("@MED_CODE", SqlDbType.NVarChar) { Value = MED_CODE.Text };
            Param[1] = new SqlParameter("@MED_NAME", SqlDbType.NVarChar) { Value = MED_NAME.Text };
            Param[2] = new SqlParameter("@MED_S_NAME", SqlDbType.NVarChar) { Value = MED_S_NAME.Text };
            Param[3] = new SqlParameter("@MED_SOURSE", SqlDbType.NVarChar) { Value = MED_SOURSE.Text };
            Param[4] = new SqlParameter("@MED_PRICE", SqlDbType.Decimal) { Value = MED_PRICE.Text };
            Param[5] = new SqlParameter("@CLI_ID", SqlDbType.Int) { Value = cmb_cliID.SelectedValue };
            //Cmd.Parameters.AddRange(Param);
            DAL.EXCUTDATA("AddMEDCIN", Param);
            MessageBox.Show("تم الإضافة بنجاح ", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();









        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MED_ID.Text = this.dataGridView1.CurrentRow.Cells["MED_ID"].Value.ToString(); this.MED_CODE.Text = this.dataGridView1.CurrentRow.Cells["MED_CODE"].Value.ToString();
            this.MED_NAME.Text = this.dataGridView1.CurrentRow.Cells["MED_NAME"].Value.ToString(); this.MED_S_NAME.Text = this.dataGridView1.CurrentRow.Cells["MED_S_NAME"].Value.ToString();
            this.MED_SOURSE.Text = this.dataGridView1.CurrentRow.Cells["MED_SOURSE"].Value.ToString(); this.MED_PRICE.Text = this.dataGridView1.CurrentRow.Cells["MED_PRICE"].Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@MED_IDE", SqlDbType.Int) { Value = MED_ID.Text };
            Param[1] = new SqlParameter("@MED_CODE", SqlDbType.NVarChar) { Value = MED_CODE.Text };
            Param[2] = new SqlParameter("@MED_NAME", SqlDbType.NVarChar) { Value = MED_NAME.Text };
            Param[3] = new SqlParameter("@MED_S_NAME", SqlDbType.NVarChar) { Value = MED_S_NAME.Text };
            Param[4] = new SqlParameter("@MED_SOURSE", SqlDbType.NVarChar) { Value = MED_SOURSE.Text };
            Param[5] = new SqlParameter("@MED_PRICE", SqlDbType.NVarChar) { Value = MED_PRICE.Text };

            //Cmd.Parameters.AddRange(Param);
                DAL.EXCUTDATA("sp_insertmedcin", Param);
            MessageBox.Show("تم الحفظ بنجاح ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlParameter[] Param = new SqlParameter[7];
            
            Param[0] = new SqlParameter("@MED_CODE", SqlDbType.NVarChar) { Value = MED_CODE.Text };
            Param[1] = new SqlParameter("@MED_NAME", SqlDbType.NVarChar) { Value = MED_NAME.Text };
            Param[2] = new SqlParameter("@MED_S_NAME", SqlDbType.NVarChar) { Value = MED_S_NAME.Text };
            Param[3] = new SqlParameter("@MED_SOURSE", SqlDbType.NVarChar) { Value = MED_SOURSE.Text };
            Param[4] = new SqlParameter("@MED_PRICE", SqlDbType.Decimal) { Value = 9.8 };
            Param[5] = new SqlParameter("@CLI_ID", SqlDbType.Int) { Value = cmb_cliID.SelectedValue };

            Param[6] = new SqlParameter("@MED_ID", SqlDbType.Int) { Value = MED_ID.Text };

            //Cmd.Parameters.AddRange(Param);
            DAL.EXCUTDATA("UpdateMEDCIN", Param);
            MessageBox.Show("تم التعديل بنجاح ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@MED_ID", SqlDbType.NVarChar) { Value = MED_ID.Text };
            DAL.EXCUTDATA("DeleteRecord", Param);
            MessageBox.Show("تم الحذف بنجاح ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();





        }

        private void MADCIN_Load(object sender, EventArgs e)
        {

        }
    }
  }

