using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel;

namespace Microsoft.Azure.ApplicationInsights.Models
{
    /// <summary>
    /// The query response. This currently only supports the thinned query
    /// response format.
    /// </summary>
    public partial class QueryResults
    {
        public static readonly IDictionary<string, Type> Types = new Dictionary<string, Type>
        {
            { "float", typeof(float) },
            { "real", typeof(double) },
            { "string", typeof(string) },
            { "datetime" , typeof(DateTime) },
            { "int", typeof(int) },
            { "long", typeof(long) },
            { "bool", typeof(bool) }
        };

        /// <summary>
        /// Enumerates over all rows in all tables.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IEnumerable<IDictionary<string, string>> Results
        {
            get
            {
                foreach (var table in Tables)
                {
                    foreach (var row in table.Rows)
                    {
                        yield return table.Columns.Zip(row, (column, cell) => new { column.Name, cell })
                            .ToDictionary(entry => entry.Name, entry => entry.cell);
                    }
                }
            }
        }

        public IEnumerable<IDictionary<string, object>> TypedResults
        {
            get
            {
                foreach (var table in Tables)
                {
                    foreach (var row in table.Rows.Select((r, i) => new { values = r, index = i }))
                    {
                        var results = new Dictionary<string, object>() ;
                        foreach (var obj in row.values.Select((v, j) => new { val = v, index = j }))
                        {
                            switch (table.Columns[obj.index].Type)
                            {
                                case ("float"):
                                    float f;
                                    Single.TryParse(obj.val, out f);
                                    results.Add(table.Columns[obj.index].Name, f);
                                    break;
                                case ("real"):
                                    double d;
                                    Double.TryParse(obj.val, out d);
                                    results.Add(table.Columns[obj.index].Name, d);
                                    break;
                                case ("bool"):
                                    bool b;
                                    bool.TryParse(obj.val, out b);
                                    results.Add(table.Columns[obj.index].Name, b);
                                    break;
                                case ("int"):
                                    int i;
                                    Int32.TryParse(obj.val, out i);
                                    results.Add(table.Columns[obj.index].Name, i);
                                    break;
                                case ("long"):
                                    long l;
                                    Int64.TryParse(obj.val, out l);
                                    results.Add(table.Columns[obj.index].Name, l);
                                    break;
                                case ("timespan"):
                                    DateTime dateTime;
                                    DateTime.TryParse(obj.val, out dateTime);
                                    results.Add(table.Columns[obj.index].Name, dateTime);
                                    break;
                                case ("string"):
                                default:
                                    results.Add(table.Columns[obj.index].Name, obj.val);
                                    break;
                            };
                        }
                        yield return results;
                    }
                }
            }
        }

        public IDictionary<string, string> Render { get; set; }
        public IDictionary<string, object> Statistics { get; set; }
    }
}
