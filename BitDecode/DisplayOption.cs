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
    public partial class DisplayOption : Form
    {
        public DisplayOption()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.binBitLen = comboBox1.Text;

            if (radio_douhao_2.Checked)
            {
                set.binSeperator = ",";
            } 
            else if (radio_fenhao_2.Checked)
            {
                set.binSeperator = ";";
            }
            else if (radio_maohao_2.Checked)
            {
                set.binSeperator = ":";
            }
            else if (radio_douhao_space_2.Checked)
            {
                set.binSeperator = ", ";
            }
            else if (radio_custom_2.Checked)
            {
                // 直接用空格不行，为什么？
                set.binSeperator = "____" + textBox1.Text;
            }
            else if (radio_space_2.Checked)
            {
                set.binSeperator = "____ ";
            }


            set.hexBitLen = comboBox2.Text;

            if (radio_douhao_16.Checked)
            {
                set.hexSeperator = ",";
            }
            else if (radio_fenhao_16.Checked)
            {
                set.hexSeperator = ";";
            }
            else if (radio_maohao_16.Checked)
            {
                set.hexSeperator = ":";
            }
            else if (radio_douhao_space_16.Checked)
            {
                set.hexSeperator = ", ";
            }
            else if (radio_custom_16.Checked)
            {
                // 直接用空格不行，为什么？
                set.hexSeperator = "____" + textBox2.Text;
            }
            else if (radio_space_16.Checked)
            {
                set.hexSeperator = "____ ";
            }


            set.Save();          
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Settings set = new Settings();
            comboBox1.Text = set.binBitLen;

            if (set.binSeperator == ",")
            {
                radio_douhao_2.Checked = true;
            }
            else if (set.binSeperator == ";")
            {
                radio_fenhao_2.Checked = true;
            }
            else if (set.binSeperator == ":")
            {
                radio_maohao_2.Checked = true;
            }
            else if (set.binSeperator == ", ")
            {
                radio_douhao_space_2.Checked = true;
            }            
            else if (set.binSeperator == "____ ")
            {
                radio_space_2.Checked = true;
            }
            else
            {
                radio_custom_2.Checked = true;
                textBox1.Text = set.binSeperator.ToString().TrimStart("____".ToCharArray());
            }

            comboBox2.Text = set.hexBitLen;

            if (set.hexSeperator == ",")
            {
                radio_douhao_16.Checked = true;
            }
            else if (set.hexSeperator == ";")
            {
                radio_fenhao_16.Checked = true;
            }
            else if (set.hexSeperator == ":")
            {
                radio_maohao_16.Checked = true;
            }
            else if (set.hexSeperator == ", ")
            {
                radio_douhao_space_16.Checked = true;
            }
            else if (set.hexSeperator == "____ ")
            {
                radio_space_16.Checked = true;
            }
            else
            {
                radio_custom_16.Checked = true;
                textBox2.Text = set.hexSeperator.ToString().TrimStart("____".ToCharArray());
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            radio_custom_2.Checked = true;
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            radio_custom_16.Checked = true;
        }
    }
}
