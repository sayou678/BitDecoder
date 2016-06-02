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
    public partial class LoadTable : Form
    {
        public string tableName
        {
            get { return comboBox1.SelectedItem.ToString(); }
        }
        public LoadTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void LoadTable_Load(object sender, EventArgs e)
        {
            TableEntryConfig tableConfig = new TableEntryConfig();
            string[] tableNames = tableConfig.getTableNames();

            comboBox1.Items.AddRange(tableNames);   
            comboBox1.SelectedIndex = 0;
        }
    }
}
