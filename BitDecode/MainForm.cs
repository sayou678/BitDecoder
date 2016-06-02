using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using BitDecode.Properties;

namespace BitDecode
{
      
    public partial class MainForm : Form
    {
        private string mStrBinary = "";
        private string mStrHex = "";
        private int currentColumns = 0;
        private string mCurrentTableName = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayOption form = new DisplayOption();
            form.Visible = false;
            form.ShowDialog(this);
            reflashTextBox2();
            //test();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("字段含义");
            dataGridView1.Rows.Add("字段长度（bit位宽）");       
            dataGridView1.Rows[1].ReadOnly = false;
            dataGridView1.Rows.Add("十进制结果");
            dataGridView1.Rows.Add("十六进制结果");
            dataGridView1.Rows.Add("二进制结果");

            Settings set = new Settings();
            this.currentColumns = Convert.ToInt32(set.colums);            
            for (int i = 1; i <= this.currentColumns; i++)
            {
                dataGridView1.Columns.Add("c" + i, "第" + i + "字段");
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[i].Resizable = DataGridViewTriState.True;
                dataGridView1.Columns[i].Width = 60;
            }

            reflashTextBox2();

            TableEntryConfig tableConfig = new TableEntryConfig();
            tableConfig.initTableEntry();        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 1)
            {
                return;
            }

            reflashData();            
        }

        private void reflashData()
        {
            try
            {
                int offset = 0;

                for (int i = 1; i <= currentColumns; i++)
                {
                    dataGridView1.Rows[2].Cells[i].Value = "";
                    dataGridView1.Rows[3].Cells[i].Value = "";
                    dataGridView1.Rows[4].Cells[i].Value = "";
                }


                for (int i = 1; i <= currentColumns; i++)
                {
                    String subString;
                    Int32 bitLen = Convert.ToInt32(dataGridView1.Rows[1].Cells[i].Value);
                    if (bitLen > 0)
                    {
                        String sOverLoad = "";
                        if (bitLen > mStrBinary.Length - offset)
                        {
                            bitLen = (mStrBinary.Length - offset);
                            sOverLoad += "(" + bitLen + "bit被显示,源数据不足)";
                            //dataGridView1.Rows[1].Cells[i].Value = bitLen.ToString();
                        }
                       
                        subString = mStrBinary.Substring(offset, bitLen);
                        offset += bitLen;
                        // 转换成二进制回显
                        dataGridView1.Rows[4].Cells[i].Value = subString;

                        // 转换成十进制回显
                        try
                        {
                            UInt64 decimalOfSubString = Convert.ToUInt64(subString, 2);
                            dataGridView1.Rows[2].Cells[i].Value = decimalOfSubString;
                        }
                        catch (System.Exception ex)
                        {
                            dataGridView1.Rows[2].Cells[i].Value = "超出范围";
                        }

                        // 转成十六进制回显                       
                        for (int j = 0; j < subString.Length; )
                        {
                            UInt32 tmpDecimal;
                            if ((subString.Length - j) % 32 != 0)
                            {
                                tmpDecimal = Convert.ToUInt32(subString.Substring(0, subString.Length % 32), 2);
                                dataGridView1.Rows[3].Cells[i].Value += Convert.ToString(tmpDecimal, 16).ToUpper();
                                j += subString.Length % 32;
                            } 
                            else
                            {
                                tmpDecimal = Convert.ToUInt32(subString.Substring(j, 32), 2);
                                dataGridView1.Rows[3].Cells[i].Value += Convert.ToString(tmpDecimal, 16).ToUpper();
                                j += 32;
                            }                            
                        }
                        dataGridView1.Rows[3].Cells[i].Value += sOverLoad;
                    }
                    else
                    {
                        break;
                    }

                }
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mStrHex = "";
            try
            {
                // 将原始文本格式化为标准十六进制文本，去掉多余字符
                mStrHex = textBox1.Text.ToUpper().Replace(" ", "").Replace("0X", "").Replace(",", "").Replace(";", "").Replace(":", "")
                    .Replace("\r", "").Replace("\n", "");

                reflashTextBox2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void reflashTextBox2()
        {
            Int64 mTmp10;
            textBox2.Text = "";
            mStrBinary = "";

            try
            {
                Settings set = new Settings();
                int loopIndex = 0;
                Int32 binBitLen = Convert.ToInt32(set.binBitLen) / 4;

                // 遍历输入字符串，转换成二进制字符串
                foreach (char c in mStrHex)
                {
                    mTmp10 = Int64.Parse(c.ToString(), NumberStyles.AllowHexSpecifier);
                    mStrBinary += Convert.ToString(mTmp10, 2).PadLeft(4, '0');
                    if (radioButton1.Checked)
                    {
                        loopIndex++;
                        textBox2.Text += Convert.ToString(mTmp10, 2).PadLeft(4, '0');
                        if (loopIndex == binBitLen)
                        {
                            loopIndex = 0;
                            textBox2.Text += set.binSeperator.TrimStart("____".ToCharArray());
                        }
                    }
                }

                if (radioButton2.Checked)
                {
                    Int32 hexBitLen = Convert.ToInt32(set.hexBitLen);
                    for (int i = 0; ; i += hexBitLen)
                    {
                        if (mStrHex.Length - i > hexBitLen)
                        {
                            textBox2.Text += mStrHex.Substring(i, hexBitLen) + set.hexSeperator.TrimStart("____".ToCharArray());
                        } 
                        else
                        {
                            textBox2.Text += mStrHex.Substring(i, mStrHex.Length - i);
                            break;
                        }                        
                    }
                    
                }

                textBox2.Text += "\r\n\r\n共" + (mStrHex.Length * 4) + "bit";

                reflashData();
            }
            catch (Exception ee)
            {
                textBox2.Text = ee.Message.ToString();
            }
        }        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            reflashTextBox2();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            reflashTextBox2();
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 form = new AboutBox1();
            form.Visible = false;
            form.ShowDialog(this);
        }

        private void 选项OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Option form = new Option();
            form.Visible = false;
            form.ShowDialog(this);
            reflashTextBox2();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveTable();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTable();      
        }

        private void saveTable()
        {
            TableName form = new TableName(mCurrentTableName);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                form.Close();
                insertTable(form.tableName);
            }   
        }

        private void loadTable()
        {
            LoadTable form = new LoadTable();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                string tableName = form.tableName;               
                form.Close();

                TableEntryConfig tableConfig = new TableEntryConfig();
                TableEntry table = tableConfig.getTable(tableName);
                loadTableWithConfig(table);
                mCurrentTableName = tableName;
            }   
        }

        private void loadTableWithConfig(TableEntry table)
        {
            // 关闭事件响应，否则影响加载速度
            this.dataGridView1.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
           
            for (int i = 0; i < currentColumns; i++)
            {
                if (i < table.fieldBitLen.Length)
                {
                    dataGridView1.Rows[0].Cells[i + 1].Value = table.fieldName[i];
                    dataGridView1.Rows[1].Cells[i + 1].Value = table.fieldBitLen[i].ToString();  
                }
                else
                {
                    dataGridView1.Rows[0].Cells[i + 1].Value = "";
                    dataGridView1.Rows[1].Cells[i + 1].Value = "";  
                }                
            }

            // 打开事件响应
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            reflashTextBox2();
        }

        private void insertTable(string tableName)
        {
            TableEntry table = new TableEntry();
            table.tableName = tableName;
            table.fieldName = new string[currentColumns];
            table.fieldBitLen = new int[currentColumns];

            for (int i = 0; i < currentColumns; i++)
            {               
                try
                {
                    table.fieldName[i] = dataGridView1.Rows[0].Cells[i + 1].Value.ToString();
                }
                catch (System.Exception ex)
                {
                    table.fieldName[i] = "";
                }

                try
                {
                    table.fieldBitLen[i] = Convert.ToInt32(dataGridView1.Rows[1].Cells[i + 1].Value);
                }
                catch (System.Exception ex)
                {
                    break;                 
                }
            }

            TableEntryConfig tableConfig = new TableEntryConfig();
            tableConfig.insertTable(table);

        }

        private void 载入表项LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void 刷新AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reflashTextBox2();
        }

        private void 删除表项DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTable form = new DeleteTable();
            form.Show();           
        }

        private void 内容CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    cell.Value = "";
                }                
            }
            else
            {
                return;
            }            
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 关闭事件响应，否则影响加载速度
            this.dataGridView1.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);

            // 退出编辑模式
            dataGridView1.CurrentCell = null;

            for (int j = 0; j <= 2; j++)
            {
                for (int i = 1; i <= currentColumns; i++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = "";
                }
            }

            // 打开事件响应
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            reflashTextBox2();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip(); 
            p.ShowAlways = true; 
            p.SetToolTip(this.button2, "将上面数据源4字节一组逆序重新排列");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mStrHex.Length <= 8)
            {
                return;
            }
            else if (mStrHex.Length % 8 != 0)
            {
                // 不是4字节的整数倍
                MessageBox.Show("数据源不是4字节的整数倍");
                return;
            }
            else
            {
                string reversStrHex = "";                
                for (int i = mStrHex.Length - 8; i >= 0; i -= 8)
                {
                    reversStrHex += mStrHex.Substring(i, 8) + " ";
                }
                textBox1.Text = reversStrHex;
            }
        }
    }
}
