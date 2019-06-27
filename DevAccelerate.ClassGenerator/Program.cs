using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevAccelerate.Net;

namespace DevAccelerate.ClassGenerator
{
    public class Program
    {
        

        public static void Main(string[] args)
        {

            ReplaceNameInFiles.Replace(@"C:\Projects\Workspaces\PEP.ACTIVOSINFORMACION.SIMAN\SIMAN.Solution\MSSQL\StoreProcedures", "SM", "SI");            
            string TableFullName = args.ElementAt(0); //"[GradoContable].[dbo].[CFDI_Comprobante]"; // 
            string OutClassFullPath = args.ElementAt(1);  //@"e:\";//
            string className = args.ElementAt(2);  //"Caballo";

            SqlConnection _sqlConnection = new SqlConnection("User ID=sa;Password=saluditos1;Data Source=DESKTOP-7A8G52V;Initial Catalog=GradoContable;Pooling=true;");
            _sqlConnection.Open();
            List<MetadataTable> fields =  _sqlConnection.Query<MetadataTable>(@"SELECT c.name Field, 
    t.name Type,
    c.Precision,     
    c.Is_nullable    
FROM sys.columns c 
INNER JOIN sys.types t ON t.system_type_id=c.system_type_id
WHERE object_id=object_id('"+TableFullName+@"') and t.name <> 'sysname' 
ORDER BY column_id").ToList();
            _sqlConnection.Close();

            StringBuilder sb = new StringBuilder(@"public class " + className);
            sb.AppendLine(string.Empty);
            sb.AppendLine("{");
            foreach (MetadataTable field in fields)
            {
                string fieldfulltext = string.Empty;
                string propName = field.Field;
                string typeName = "string";
                switch(field.Type)
                {
                    case "text":
                    case "nvarchar":
                        break;
                    case "datetime":
                        typeName = "DateTime";                        
                        break;
                    case "decimal":
                        typeName = "Double";
                        break;
                    case "int":
                        typeName = "int";
                        break;
                }

                fieldfulltext = @"public " + typeName + @" " + propName + @" { get; set; }";
                sb.AppendLine("");
                sb.AppendLine(fieldfulltext);                
            }
            sb.AppendLine(string.Empty);
            sb.AppendLine("}");

            var f = File.CreateText(Path.Combine(OutClassFullPath, className + ".cs"));
            f.Write(sb);
            f.Close();
        }
    }

    public class MetadataTable
    {
        public string Field { get; set; }

        public string Type { get; set; }

        public string Precision { get; set; }

        public string Is_nullable { get; set; }
    }
}

