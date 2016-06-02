using System;

namespace BitDecode
{
    public class TableEntry
    {
        private string m_tableName;
        private string [] m_fieldName;
        private int[] m_fieldBitLen;

        public TableEntry()
        {
        }

        public string tableName
        {
            get {return m_tableName;}
            set { m_tableName = value; }
        }

        public string [] fieldName
        {
            get {return m_fieldName;}
            set { m_fieldName = value; }
        }

        public int [] fieldBitLen
        {
            get {return m_fieldBitLen;}
            set { m_fieldBitLen = value; }
        }
    }
}