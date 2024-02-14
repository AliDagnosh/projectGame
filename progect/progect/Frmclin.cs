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
    public partial class Frmclin : Form
    {
        DATA_ACCESS_LAYER DAL = new DATA_ACCESS_LAYER();
        public Frmclin()
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
            cmd.CommandText = ("Select * from CLINC_TBL");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }
        private void Frmclin_Load(object sender, EventArgs e)
        {
            this.Hide(); // إخفاء نموذج العيادات الحالي
            Form1 loginForm = new Form1();
            loginForm.ShowDialog(); // عرض شاشة تسجيل الدخول
            this.Close(); // إغلاق نموذج العيادات بعد تسجيل الدخول
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            SqlParameter[] Param = new SqlParameter[5];
            Param[0] = new SqlParameter("@CLI_CODE", SqlDbType.Int) { Value = CLI_CODE.Text };
            Param[1] = new SqlParameter("@CLI_NAME", SqlDbType.NVarChar) { Value = CLI_NAME.Text };
            Param[2] = new SqlParameter("@CLI_LOC", SqlDbType.NVarChar) { Value = CLI_LOC.Text };
            Param[3] = new SqlParameter("@CLI_PHON", SqlDbType.NVarChar) { Value = CLI_PHON.Text };
            Param[4] = new SqlParameter("@CLI_NOTE", SqlDbType.NVarChar) { Value = CLI_NOTE.Text };
            //Cmd.Parameters.AddRange(Param);
            DAL.EXCUTDATA("sp_insertclin", Param);
            MessageBox.Show("تم الإضافة بنجاح ", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CLI_ID.Text = this.dataGridView1.CurrentRow.Cells["CLI_ID"].Value.ToString(); this.CLI_CODE.Text = this.dataGridView1.CurrentRow.Cells["CLI_CODE"].Value.ToString();
            this.CLI_NAME.Text = this.dataGridView1.CurrentRow.Cells["CLI_NAME"].Value.ToString(); this.CLI_NOTE.Text = this.dataGridView1.CurrentRow.Cells["CLI_NOTE"].Value.ToString();
            this.CLI_PHON.Text = this.dataGridView1.CurrentRow.Cells["CLI_PHON"].Value.ToString(); this.CLI_LOC.Text = this.dataGridView1.CurrentRow.Cells["CLI_LOC"].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            SqlParameter[] Param = new SqlParameter[5];
            Param[0] = new SqlParameter("@CLI_CODE", SqlDbType.Int) { Value = CLI_CODE.Text };
            Param[1] = new SqlParameter("@CLI_NAME", SqlDbType.NVarChar) { Value = CLI_NAME.Text };
            Param[2] = new SqlParameter("@CLI_LOC", SqlDbType.NVarChar) { Value = CLI_LOC.Text };
            Param[3] = new SqlParameter("@CLI_PHON", SqlDbType.NVarChar) { Value = CLI_PHON.Text };
            Param[4] = new SqlParameter("@CLI_NOTE", SqlDbType.NVarChar) { Value = CLI_NOTE.Text };
            //Cmd.Parameters.AddRange(Param);
            DAL.EXCUTDATA("sp_insertclin", Param);
            MessageBox.Show("تم الحفظ بنجاح ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@CLI_CODE", SqlDbType.Int) { Value = CLI_CODE.Text };
            Param[1] = new SqlParameter("@CLI_NAME", SqlDbType.NVarChar) { Value = CLI_NAME.Text };
            Param[2] = new SqlParameter("@CLI_LOC", SqlDbType.NVarChar) { Value = CLI_LOC.Text };
            Param[3] = new SqlParameter("@CLI_PHON", SqlDbType.NVarChar) { Value = CLI_PHON.Text };
            Param[4] = new SqlParameter("@CLI_NOTE", SqlDbType.NVarChar) { Value = CLI_NOTE.Text };
            //Cmd.Parameters.AddRange(Param);
            DAL.EXCUTDATA("sp_UpdateClin", Param);
            MessageBox.Show("تم التعديل بنجاح ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@CLI_CODE", SqlDbType.Int) { Value = CLI_CODE.Text };
            DAL.EXCUTDATA("sp_DELETClin", Param);
            MessageBox.Show("تم الحذف بنجاح ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllAliasCLINC_TBL();
    }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void clear()
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //reports.FrmReportView FRM = new reports.FrmReportView();
            //ReportDocument reportDocument = new ReportDocument();
            //// reportDocument.SetParameterValue("ParameterName", parameterValue);         
            //reports.CrystalReport1 REPORT = new reports.CrystalReport1();
            //this.Cursor = Cursors.WaitCursor; reportDocument.SetParameterValue("ParameterName", repname);
            //FRM.crystalReportViewer1.ReportSource = REPORT;
            //FRM.crystalReportViewer1.Refresh();
            //FRM.ShowDialog();
        }

        private void CLI_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
