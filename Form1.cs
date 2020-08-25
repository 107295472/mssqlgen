using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实体生成器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBService DB_one = new DBService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void BindDataBase(ComboBox c, List<string> list)
        {
            c.Items.Clear();
            foreach (var item in list)
            {
                c.Items.Add(item);
            }
        }
        private void button_one_conn_Click(object sender, EventArgs e)
        {
            DB_one.Connonection = string.Format("Data Source={0};Initial Catalog={1};User ID={2};PassWord={3};persist security info=True;Max Pool Size=60000;", textBox_ont_ip.Text, textBox_dataBaseName.Text, textBox_one_user.Text, textBox_one_pwd.Text);
            BindDataBase(comboBox_one_dataBase, DB_one.GetAllDataBase());
        }

        private void comboBox_one_dataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_one_dataBase.SelectedIndex >= 0)
            {
                var str = GetStringMid(DB_one.Connonection, "Catalog=", ";");
                DB_one.Connonection = DB_one.Connonection.Replace(str, comboBox_one_dataBase.Text);
                IList <string> list = DB_one.GetTableNames(comboBox_one_dataBase.Text);
                listView_one_tables.Items.Clear();
                int index = 1;
                foreach (var item in list)
                {
                    listView_one_tables.Items.Add(new ListViewItem(new string[] {
                        index++.ToString(),
                        item
                    }));
                }
            }
        }

        private void listView_one_tables_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void listView_one_tables_Click(object sender, EventArgs e)
        {
            if (listView_one_tables.SelectedItems.Count == 1)
            {
                List<Field> list = DB_one.GetFileds(listView_one_tables.SelectedItems[0].SubItems[1].Text);
                listView_one_tableStruct.Items.Clear();
                int index = 1;
                foreach (Field item in list)
                {
                    listView_one_tableStruct.Items.Add(new ListViewItem(new string[] {
                        index++.ToString(),
                        item.Name,
                        item.Type
                    }));
                }
            }
        }

        private void button_toClass_Click(object sender, EventArgs e)
        {
            GoEntity();
        }
        private void WpfEntity()
        {
            string tableName = listView_one_tables.SelectedItems[0].SubItems[1].Text;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" public class " + tableName);
            sb.AppendLine("{");
            foreach (ListViewItem item in listView_one_tableStruct.Items)
            {
                string typename = ChangeToCSharpType(item.SubItems[2].Text);
                string name = item.SubItems[1].Text;
                name = name.Substring(0, 1) + name.Substring(1);
                sb.AppendLine("private " + typename + " _" + name + ";");
                sb.AppendLine("         public " + typename + " " + name);
                sb.AppendLine("{");
                sb.AppendLine("get=>_" + name + ";");
                sb.AppendLine("set=>Set(ref _" + name + ", value);");
                sb.AppendLine("}");
            }
            sb.AppendLine("}");
            textBox_result.Text = sb.ToString();
        }
        private void GoEntity()
        {
            string tableName = listView_one_tables.SelectedItems[0].SubItems[1].Text;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("type " + tableName + " struct {");
            StringBuilder cols = new StringBuilder();
            foreach (ListViewItem item in listView_one_tableStruct.Items)
            {
                string typename = GoChangeToCSharpType(item.SubItems[2].Text);
                string name = item.SubItems[1].Text;

                name = name.Substring(0, 1).ToUpper() + name.Substring(1);
                sb.AppendLine(name + " " + typename+" `json:\""+name+"\"`");
                cols.Append("&tableStruct."+name+",");
            }
            sb.AppendLine("}");

            sb.AppendLine("rows.Scan(" + cols .ToString().TrimEnd(',')+ ")");
            textBox_result.Text = sb.ToString();
        }
        private string GoChangeToCSharpType(string type)
        {
            string reval = string.Empty;
            switch (type.ToLower())
            {
                case "int":
                    reval = "int32";
                    break;
                case "text":
                    reval = "string";
                    break;
                case "bigint":
                    reval = "int64";
                    break;
                case "binary":
                    reval = "Byte[]";
                    break;
                case "bit":
                    reval = "bool";
                    break;
                case "char":
                    reval = "string";
                    break;
                case "datetime":
                    reval = "time.Time";
                    break;
                case "decimal":
                    reval = "float64";
                    break;
                case "float":
                    reval = "float32";
                    break;
                case "money":
                    reval = "float64";
                    break;
                case "nchar":
                    reval = "string";
                    break;
                case "ntext":
                    reval = "string";
                    break;
                case "numeric":
                    reval = "float64";
                    break;
                case "nvarchar":
                    reval = "string";
                    break;
                case "smalldatetime":
                    reval = "time.Time";
                    break;
                case "smallint":
                    reval = "int16";
                    break;
                case "timestamp":
                    reval = "time.Time";
                    break;
                case "tinyint":
                    reval = "byte";
                    break;
                case "varchar":
                    reval = "string";
                    break;
                default:
                    reval = "string";
                    break;
            }
            return reval;
        }
        /// <summary>
        /// 数据库中与C#中的数据类型对照
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private string ChangeToCSharpType(string type)
        {
            string reval = string.Empty;
            switch (type.ToLower())
            {
                case "int":
                    reval = "int";
                    break;
                case "text":
                    reval = "string";
                    break;
                case "bigint":
                    reval = "long";
                    break;
                case "binary":
                    reval = "Byte[]";
                    break;
                case "bit":
                    reval = "bool";
                    break;
                case "char":
                    reval = "string";
                    break;
                case "datetime":
                    reval = "DateTime";
                    break;
                case "decimal":
                    reval = "Decimal";
                    break;
                case "float":
                    reval = "double";
                    break;
                case "image":
                    reval = "Byte[]";
                    break;
                case "money":
                    reval = "decimal";
                    break;
                case "nchar":
                    reval = "string";
                    break;
                case "ntext":
                    reval = "string";
                    break;
                case "numeric":
                    reval = "decimal";
                    break;
                case "nvarchar":
                    reval = "string";
                    break;
                case "real":
                    reval = "Single";
                    break;
                case "smalldatetime":
                    reval = "DateTime";
                    break;
                case "smallint":
                    reval = "Int16";
                    break;
                case "smallmoney":
                    reval = "decimal";
                    break;
                case "timestamp":
                    reval = "DateTime";
                    break;
                case "tinyint":
                    reval = "Byte";
                    break;
                case "uniqueidentifier":
                    reval = "Guid";
                    break;
                case "varbinary":
                    reval = "Byte[]";
                    break;
                case "varchar":
                    reval = "string";
                    break;
                case "Variant":
                    reval = "Object";
                    break;
                default:
                    reval = "string";
                    break;
            }
            return reval;
        }

        private void textBox_result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x1')
            {
                ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }

        /// <summary>
        /// 取中间值
        /// </summary>
        /// <param name="allStr"></param>
        /// <param name="firstStr"></param>
        /// <param name="lastStr"></param>
        /// <returns></returns>
        public static string GetStringMid(string allStr, string firstStr, string lastStr)
        {
            int index1 = allStr.IndexOf(firstStr);
            int index2 = allStr.IndexOf(lastStr, index1 + firstStr.Length);

            if (index1 < 0 || index2 < 0)
            {
                return "";
            }

            index1 = index1 + firstStr.Length;
            index2 = index2 - index1;

            if (index1 < 0 || index2 < 0)
            {
                return "";
            }
            return allStr.Substring(index1, index2);
        }
    }
}
