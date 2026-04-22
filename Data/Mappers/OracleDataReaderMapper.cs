using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Attributes;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare.Data.Mappers
{
    internal static class OracleDataReaderMapper
    {
        internal static List<T> MapToList<T>(OracleDataReader reader) where T : new()
        {
            var list = new List<T>();
            var properties = typeof(T).GetProperties()
                                      .Where(p => p.CanWrite)
                                      .ToArray();

            var columns = Enumerable.Range(0, reader.FieldCount)
                                    .Select(i => reader.GetName(i))
                                    .ToHashSet();

            while (reader.Read())
            {
                var obj = new T();

                foreach (var prop in properties)
                {
                    var columnName = prop.GetCustomAttribute<ColumnNameAttribute>()?.Name
                                  ?? prop.Name;

                    if (!columns.Contains(columnName))
                        continue;

                    var value = reader[columnName];

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

        internal static T MapToObject<T>(OracleDataReader reader) where T : new()
        {
            var properties = typeof(T).GetProperties()
                                      .Where(p => p.CanWrite)
                                      .ToArray();

            var columns = Enumerable.Range(0, reader.FieldCount)
                                    .Select(i => reader.GetName(i))
                                    .ToHashSet();
            if (reader.Read())
            {
                var obj = new T();
                foreach (var prop in properties)
                {
                    var columnName = prop.GetCustomAttribute<ColumnNameAttribute>()?.Name
                                  ?? prop.Name;
                    if (!columns.Contains(columnName))
                        continue;
                    var value = reader[columnName];
                    if (value == DBNull.Value || value is null)
                        continue;
                    var targetType = Nullable.GetUnderlyingType(prop.PropertyType)
                                  ?? prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(value, targetType));
                }
                return obj;
            }
            return default!;
        }
    }
}
