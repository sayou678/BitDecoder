using System;
using System.IO;
using System.Runtime.InteropServices; // For COMException
using System.Xml;
using System.Collections;

namespace BitDecode
{
    public class TableEntryConfig
    {
        private string mFilePath = "";

        public TableEntryConfig()
        {
            mFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\bitDecodeConfig.xml";
        }

        /// <summary>
        /// 插入新表，API函数
        /// </summary>
        /// <param name="table"></param>
        public void insertTable(TableEntry table)
        {
            if (!configFileIsExist())
            {
                createXml();
            }

            // 查询是否存在此表，如果存在则为修改，否则为插入
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(this.mFilePath);
            XmlNode root = xmlDoc.SelectSingleNode("Tables");
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("Tables").ChildNodes;//获取Tables节点的所有子节点 
            foreach (XmlNode xn in nodeList)//遍历所有子节点 
            {
                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型 
                if (xe.GetAttribute("name") == table.tableName)
                {
                    root.RemoveChild(xn);
                }
            }

            xmlDoc.Save(this.mFilePath);

            insertNewTable(table);
        }

        /// <summary>
        /// 删除表项
        /// </summary>
        /// <param name="tableNames">需要删除的表，数组</param>
        public void deleteTable(string [] tableNames)
        {
            foreach (string name in tableNames)
            {
                deleteOneTable(name);
            }
        }

        /// <summary>
        /// 删除一张表
        /// </summary>
        /// <param name="tableName"></param>
        private void deleteOneTable(string tableName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(this.mFilePath);
            XmlNode root = xmlDoc.SelectSingleNode("Tables");
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("Tables").ChildNodes;//获取Tables节点的所有子节点 
            foreach (XmlNode xn in nodeList)//遍历所有子节点 
            {
                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型 
                if (xe.GetAttribute("name") == tableName)
                {
                    root.RemoveChild(xn);
                }
            }

            xmlDoc.Save(this.mFilePath);
        }

        /// <summary>
        /// 插入新的表项
        /// </summary>
        /// <param name="table">表</param>
        private void insertNewTable(TableEntry table)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(this.mFilePath);
            XmlNode root = xmlDoc.SelectSingleNode("Tables");//查找<Tables> 
            XmlElement xe1 = xmlDoc.CreateElement("Table");//创建一个<Table>节点 
            xe1.SetAttribute("name", table.tableName);//设置该节点name属性 

            for (int i = 1; i <= table.fieldBitLen.Length; i++)
            {
                int fieldBitlen = table.fieldBitLen[i - 1];
                if (fieldBitlen == 0)
                {
                    break;
                }

                XmlElement xesub1 = xmlDoc.CreateElement("f" + i);
                xesub1.SetAttribute("field_name", table.fieldName[i - 1]);
                xesub1.SetAttribute("field_bitlen", fieldBitlen.ToString());
                xe1.AppendChild(xesub1);//添加到<Table>节点中 
            }

            root.AppendChild(xe1);//添加到<Tables>节点中 
            xmlDoc.Save(this.mFilePath);
        }

        /// <summary>
        /// 得到表项
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public TableEntry getTable(string tableName)
        {
            TableEntry table = new TableEntry();
            table.tableName = tableName;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(this.mFilePath);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("Tables").ChildNodes;//获取Tables节点的所有子节点 
            foreach (XmlNode xn in nodeList)//遍历所有子节点 
            {
                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型 
                if (xe.GetAttribute("name") == tableName)
                {
                    XmlNodeList fieldList = xe.ChildNodes;
                    ArrayList arrayFieldName = new ArrayList();
                    ArrayList arrayfieldBitLen = new ArrayList();
                    foreach (XmlNode fn in fieldList)
                    {
                        XmlElement fn_e = (XmlElement)fn;
                        arrayFieldName.Add(fn_e.GetAttribute("field_name"));
                        arrayfieldBitLen.Add(fn_e.GetAttribute("field_bitlen"));
                    }
                    table.fieldName = (string[])arrayFieldName.ToArray(typeof(string));
                    string[] strBitLen = (string[])arrayfieldBitLen.ToArray(typeof(string));
                    table.fieldBitLen = new int[strBitLen.Length];

                    for (int i = 0; i < strBitLen.Length; i++)
                    {
                        table.fieldBitLen[i] = Convert.ToInt32(strBitLen[i]);
                    }

                    return table;
                }
            }

            throw new Exception("读取表项出错");
        }

        /// <summary>
        /// 得到所有的表名
        /// </summary>
        /// <returns></returns>
        public string [] getTableNames()
        {
            ArrayList array = new ArrayList();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(this.mFilePath);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("Tables").ChildNodes;//获取Tables节点的所有子节点 
            foreach (XmlNode xn in nodeList)//遍历所有子节点 
            {
                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型 
                array.Add(xe.GetAttribute("name"));
            }

            return (string[])array.ToArray(typeof(string));
        }

        /// <summary>
        /// 配置文件是否存在
        /// </summary>
        /// <returns></returns>
        private bool configFileIsExist()
        {
            return File.Exists(this.mFilePath);
        }

        /// <summary>
        /// 创建新xml文件
        /// </summary>
        private void createXml()
        {
            XmlDocument xmldoc = new XmlDocument();
            //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
            XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
            xmldoc.AppendChild(xmldecl);

            //加入一个根元素
            XmlElement xmlelem = xmldoc.CreateElement("", "Tables", "");
            xmldoc.AppendChild(xmlelem);
            
            //保存创建好的XML文档
            xmldoc.Save(this.mFilePath);

            TableEntry[] tables = new TableEntry[] { new TableEntry(), new TableEntry(), new TableEntry(), 
                new TableEntry(), new TableEntry(), new TableEntry() };
            tables[0].tableName = "IPV4";
            tables[0].fieldName = new string[] {"版本", "报文长度",  "服务类型", "总长度", "标识符", "标记", "分片偏移", "生存时间", "协议", "头部校验", "源地址", "目的地址"};
            tables[0].fieldBitLen = new int[] {4,      4,          8,         16,       16,        3,      13,         8,          8,      16,        32,       32};

            tables[1].tableName = "IPV6";
            tables[1].fieldName = new string[] { "版本", "流量类别", "流标签", "有效荷载长度", "下一报头", "跳数限制", "源地址", "目的地址"};
            tables[1].fieldBitLen = new int[] {4,        8,          20,       16,             8,          8,          128,      128 };

            tables[2].tableName = "ARP";
            tables[2].fieldName = new string[] { "硬件类型", "协议类型", "硬件地址长度", "协议地址长度", "操作", "发送者硬件地址", "发送者IP地址", "目的硬件地址", "目的IP地址"};
            tables[2].fieldBitLen = new int[] { 16,          16,         8,              8,              16,     48,               32,             48,              32 };

            tables[3].tableName = "ICMP";
            tables[3].fieldName = new string[] { "类型", "代码", "校验和"};
            tables[3].fieldBitLen = new int[] { 8,       8     , 16 };

            tables[4].tableName = "TCP";
            tables[4].fieldName = new string[] { "源端口", "目的端口", "序列号", "确认号", "报文长度", "保留", "标记", "窗口大小", "校验和", "紧急指针"};
            tables[4].fieldBitLen = new int[] { 16,        16,        32,        32,       4,          4,      8,      16,         16,        16 };

            tables[5].tableName = "UDP";
            tables[5].fieldName = new string[] { "源端口", "目的端口", "UDP长度", "校验和"};
            tables[5].fieldBitLen = new int[] { 16,        16,         16,        16 };

            foreach (TableEntry table in tables)
            {
                insertNewTable(table);
            }
        }  
     
        public void initTableEntry()
        {
            if (!configFileIsExist())
            {
                createXml();
            }
        }        
    }
}