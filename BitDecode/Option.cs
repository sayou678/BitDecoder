using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BitDecode.Properties;

namespace BitDecode
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            Settings set = new Settings();
            textBox1.Text = set.colums;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();

            try
            {
                Int32 columNum = Convert.ToInt32(textBox1.Text.Trim());
                if (columNum < 5 || columNum > 999)
                {
                    MessageBox.Show("请输入5~999之间的正整数");
                    return;
                }

                set.colums = textBox1.Text.Trim();
                set.Save();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("请输入5~999之间的正整数");
                return;
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayOption form = new DisplayOption();
            form.Visible = false;
            form.ShowDialog(this);            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定要重置所有选项吗？", "警告！！！", MessageBoxButtons.OKCancel))
            {
                Settings set = new Settings();
                set.Reset();
                set.Save();
                textBox1.Text = set.colums;
            }
        }
    }
}
