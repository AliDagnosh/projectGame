namespace progect
{
    partial class Frmclin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CLI_NOTE = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.CLI_LOC = new System.Windows.Forms.TextBox();
            this.CLI_NAME = new System.Windows.Forms.TextBox();
            this.CLI_CODE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CLI_PHON = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ee = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CLI_ID = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "اسم العيادة";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CLI_NOTE);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.CLI_LOC);
            this.groupBox1.Controls.Add(this.CLI_NAME);
            this.groupBox1.Controls.Add(this.CLI_CODE);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CLI_PHON);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ee);
            this.groupBox1.Location = new System.Drawing.Point(355, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(414, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات الاساسية";
            // 
            // CLI_NOTE
            // 
            this.CLI_NOTE.Location = new System.Drawing.Point(19, 175);
            this.CLI_NOTE.Name = "CLI_NOTE";
            this.CLI_NOTE.Size = new System.Drawing.Size(100, 20);
            this.CLI_NOTE.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(202, 143);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // CLI_LOC
            // 
            this.CLI_LOC.Location = new System.Drawing.Point(202, 96);
            this.CLI_LOC.Name = "CLI_LOC";
            this.CLI_LOC.Size = new System.Drawing.Size(100, 20);
            this.CLI_LOC.TabIndex = 7;
            // 
            // CLI_NAME
            // 
            this.CLI_NAME.Location = new System.Drawing.Point(202, 54);
            this.CLI_NAME.Name = "CLI_NAME";
            this.CLI_NAME.Size = new System.Drawing.Size(100, 20);
            this.CLI_NAME.TabIndex = 6;
            // 
            // CLI_CODE
            // 
            this.CLI_CODE.Location = new System.Drawing.Point(202, 19);
            this.CLI_CODE.Name = "CLI_CODE";
            this.CLI_CODE.Size = new System.Drawing.Size(100, 20);
            this.CLI_CODE.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "الملاحظات";
            // 
            // CLI_PHON
            // 
            this.CLI_PHON.AutoSize = true;
            this.CLI_PHON.Location = new System.Drawing.Point(330, 134);
            this.CLI_PHON.Name = "CLI_PHON";
            this.CLI_PHON.Size = new System.Drawing.Size(55, 13);
            this.CLI_PHON.TabIndex = 3;
            this.CLI_PHON.Text = "رقم الهاتف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "عنوان العيادة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم العيادة";
            // 
            // ee
            // 
            this.ee.AutoSize = true;
            this.ee.Location = new System.Drawing.Point(330, 27);
            this.ee.Name = "ee";
            this.ee.Size = new System.Drawing.Size(59, 13);
            this.ee.TabIndex = 0;
            this.ee.Text = "كود العيادة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(355, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(414, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الاجراءات";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Image = global::progect.Properties.Resources.icons8_delete_document_48;
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 75);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Image = global::progect.Properties.Resources.icons8_amendment_48;
            this.button3.Location = new System.Drawing.Point(100, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 75);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Image = global::progect.Properties.Resources.حفظ;
            this.button2.Location = new System.Drawing.Point(202, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 75);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Image = global::progect.Properties.Resources.جديد;
            this.button1.Location = new System.Drawing.Point(308, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 75);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CLI_ID);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(337, 282);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عرض البيانات";
            // 
            // CLI_ID
            // 
            this.CLI_ID.Location = new System.Drawing.Point(239, 228);
            this.CLI_ID.Name = "CLI_ID";
            this.CLI_ID.Size = new System.Drawing.Size(59, 20);
            this.CLI_ID.TabIndex = 4;
            this.CLI_ID.Visible = false;
            this.CLI_ID.TextChanged += new System.EventHandler(this.CLI_ID_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(110, 24);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(155, 20);
            this.textBox7.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "بحث";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 38);
            this.button5.TabIndex = 1;
            this.button5.Text = "خروج";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(291, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Frmclin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Frmclin";
            this.Text = "Frmclin";
            this.Load += new System.EventHandler(this.Frmclin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CLI_NOTE;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox CLI_LOC;
        private System.Windows.Forms.TextBox CLI_NAME;
        private System.Windows.Forms.TextBox CLI_CODE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CLI_PHON;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox CLI_ID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}