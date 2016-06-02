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
    public partial class DeleteTable : Form
    {
        public DeleteTable()
        {
            InitializeComponent();
        }

        private void DeleteTable_Load(object sender, EventArgs e)
        {
            TableEntryConfig tableConfig = new TableEntryConfig();
            string[] tableNames = tableConfig.getTableNames();

            listBox1.Items.AddRange(tableNames);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tableNames = new string[listBox1.SelectedItems.Count];
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                tableNames[i] = listBox1.SelectedItems[i].ToString();
            }

            TableEntryConfig tableConfig = new TableEntryConfig();
            tableConfig.deleteTable(tableNames);

            object[] selected_objs = new object[listBox1.SelectedItems.Count];
            listBox1.SelectedItems.CopyTo(selected_objs, 0); 
            foreach (object oval in selected_objs)
            { 
                listBox1.Items.Remove(oval); 
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
