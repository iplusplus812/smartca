using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCA.Infrastructure
{
    public static class DataHelper
    {
        public static bool ReaderContainsColumnName(DataTable schemaTable, string columnName)
        {
            return schemaTable.Rows.Cast<DataRow>().Any(row => row["ColumnName"].ToString() == columnName);
        }
    }
}
