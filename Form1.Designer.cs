namespace 实体生成器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_dataBaseName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_one_dataBase = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView_one_tableStruct = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_one_tables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_one_conn = new System.Windows.Forms.Button();
            this.textBox_one_pwd = new System.Windows.Forms.TextBox();
            this.textBox_one_user = new System.Windows.Forms.TextBox();
            this.textBox_ont_ip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_toClass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_dataBaseName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_one_dataBase);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button_one_conn);
            this.groupBox1.Controls.Add(this.textBox_one_pwd);
            this.groupBox1.Controls.Add(this.textBox_one_user);
            this.groupBox1.Controls.Add(this.textBox_ont_ip);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 638);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库一";
            // 
            // textBox_dataBaseName
            // 
            this.textBox_dataBaseName.Location = new System.Drawing.Point(157, 46);
            this.textBox_dataBaseName.Name = "textBox_dataBaseName";
            this.textBox_dataBaseName.Size = new System.Drawing.Size(184, 21);
            this.textBox_dataBaseName.TabIndex = 13;
            this.textBox_dataBaseName.Text = "master";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "数据库名:";
            // 
            // comboBox_one_dataBase
            // 
            this.comboBox_one_dataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_one_dataBase.FormattingEnabled = true;
            this.comboBox_one_dataBase.Location = new System.Drawing.Point(66, 97);
            this.comboBox_one_dataBase.Name = "comboBox_one_dataBase";
            this.comboBox_one_dataBase.Size = new System.Drawing.Size(184, 20);
            this.comboBox_one_dataBase.TabIndex = 11;
            this.comboBox_one_dataBase.SelectedIndexChanged += new System.EventHandler(this.comboBox_one_dataBase_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "数据库:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView_one_tableStruct);
            this.groupBox3.Location = new System.Drawing.Point(307, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 509);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "表结构";
            // 
            // listView_one_tableStruct
            // 
            this.listView_one_tableStruct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_one_tableStruct.FullRowSelect = true;
            this.listView_one_tableStruct.GridLines = true;
            this.listView_one_tableStruct.Location = new System.Drawing.Point(6, 20);
            this.listView_one_tableStruct.Name = "listView_one_tableStruct";
            this.listView_one_tableStruct.Size = new System.Drawing.Size(333, 489);
            this.listView_one_tableStruct.TabIndex = 0;
            this.listView_one_tableStruct.UseCompatibleStateImageBehavior = false;
            this.listView_one_tableStruct.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "序号";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "字段名";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "字段类型";
            this.columnHeader5.Width = 100;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(262, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "=>";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_one_tables);
            this.groupBox2.Location = new System.Drawing.Point(10, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 509);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "表集合";
            // 
            // listView_one_tables
            // 
            this.listView_one_tables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_one_tables.FullRowSelect = true;
            this.listView_one_tables.GridLines = true;
            this.listView_one_tables.HideSelection = false;
            this.listView_one_tables.Location = new System.Drawing.Point(6, 20);
            this.listView_one_tables.MultiSelect = false;
            this.listView_one_tables.Name = "listView_one_tables";
            this.listView_one_tables.Size = new System.Drawing.Size(234, 489);
            this.listView_one_tables.TabIndex = 0;
            this.listView_one_tables.UseCompatibleStateImageBehavior = false;
            this.listView_one_tables.View = System.Windows.Forms.View.Details;
            this.listView_one_tables.Click += new System.EventHandler(this.listView_one_tables_Click);
            this.listView_one_tables.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.listView_one_tables_ChangeUICues);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "表名称";
            this.columnHeader2.Width = 150;
            // 
            // button_one_conn
            // 
            this.button_one_conn.Location = new System.Drawing.Point(447, 83);
            this.button_one_conn.Name = "button_one_conn";
            this.button_one_conn.Size = new System.Drawing.Size(99, 29);
            this.button_one_conn.TabIndex = 6;
            this.button_one_conn.Text = "连接";
            this.button_one_conn.UseVisualStyleBackColor = true;
            this.button_one_conn.Click += new System.EventHandler(this.button_one_conn_Click);
            // 
            // textBox_one_pwd
            // 
            this.textBox_one_pwd.Location = new System.Drawing.Point(415, 46);
            this.textBox_one_pwd.Name = "textBox_one_pwd";
            this.textBox_one_pwd.PasswordChar = '●';
            this.textBox_one_pwd.Size = new System.Drawing.Size(184, 21);
            this.textBox_one_pwd.TabIndex = 5;
            this.textBox_one_pwd.Text = "sql2014";
            // 
            // textBox_one_user
            // 
            this.textBox_one_user.Location = new System.Drawing.Point(415, 14);
            this.textBox_one_user.Name = "textBox_one_user";
            this.textBox_one_user.Size = new System.Drawing.Size(184, 21);
            this.textBox_one_user.TabIndex = 4;
            this.textBox_one_user.Text = "sa";
            // 
            // textBox_ont_ip
            // 
            this.textBox_ont_ip.Location = new System.Drawing.Point(157, 14);
            this.textBox_ont_ip.Name = "textBox_ont_ip";
            this.textBox_ont_ip.Size = new System.Drawing.Size(184, 21);
            this.textBox_ont_ip.TabIndex = 3;
            this.textBox_ont_ip.Text = "localhost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "数据库连接地址:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "密码:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "用户名:";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(735, 9);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(444, 630);
            this.textBox_result.TabIndex = 23;
            this.textBox_result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_toClass
            // 
            this.button_toClass.Location = new System.Drawing.Point(661, 217);
            this.button_toClass.Name = "button_toClass";
            this.button_toClass.Size = new System.Drawing.Size(74, 31);
            this.button_toClass.TabIndex = 24;
            this.button_toClass.Text = "生成=>";
            this.button_toClass.UseVisualStyleBackColor = true;
            this.button_toClass.Click += new System.EventHandler(this.button_toClass_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 31);
            this.button1.TabIndex = 25;
            this.button1.Text = "生成=>bson";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 31);
            this.button2.TabIndex = 26;
            this.button2.Text = "生成=>db";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 640);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_toClass);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_dataBaseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_one_dataBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView_one_tableStruct;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_one_tables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_one_conn;
        private System.Windows.Forms.TextBox textBox_one_pwd;
        private System.Windows.Forms.TextBox textBox_one_user;
        private System.Windows.Forms.TextBox textBox_ont_ip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_toClass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

