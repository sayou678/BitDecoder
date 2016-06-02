using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BitDecode
{
    public partial class TableName : Form
    {
        private string m_tableName = "";

        public string tableName 
        {
            get { return comboBox1.Text; }
        }
        public TableName()
        {
            InitializeComponent();
        }

        public TableName(string tableName)
        {
            this.m_tableName = tableName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim().Length < 1 || comboBox1.Text.Trim().Length > 50)
            {
                MessageBox.Show("输入的字符串除去空格后长度应在1~50之间");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void TableName_Load(object sender, EventArgs e)
        {
            TableEntryConfig tableConfig = new TableEntryConfig();
            string[] tableNames = tableConfig.getTableNames();

            comboBox1.Items.AddRange(tableNames);
            comboBox1.Text = m_tableName;
        }
    }
}
