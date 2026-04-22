using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Attributes;

namespace DoggyDaycare.Data.Mappers
{
    internal static class DataSetMapper
    {
        internal static List<T> MapToList<T>(DataSet ds) where T : new()
        {
            List<T> list = new List<T>();

            if (ds is null || ds.Tables.Count == 0)
                return list;

            DataTable table = ds.Tables[0];

            var properties = typeof(T).GetProperties().Where(p => p.CanWrite).ToArray();

            foreach (DataRow row in table.Rows)
            {
                var obj = new T();

                foreach (var prop in properties)
                {
                    var columnName = prop.GetCustomAttribute<ColumnNameAttribute>()?.Name ?? prop.Name;

                    if (!table.Columns.Contains(columnName))
                        continue;

                    var value = row[columnName];

                    if (value == DBNull.Value || value is null)
                        continue;

                    var targetType = Nullable.GetUnderlyingType(prop.PropertyType)
                                 ?? prop.PropertyType;

                    prop.SetValue(obj, Convert.ChangeType(value, targetType));
                }

                list.Add(obj);
            }

            return list;
        }
    }
}
