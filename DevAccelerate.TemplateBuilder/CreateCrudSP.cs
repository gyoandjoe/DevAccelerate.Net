using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DevAccelerate.TemplateBuilder
{
    public class CreateCrudSP
    {
        private readonly string StoreProcedureName;
        private readonly string parameterId;
        private readonly string IdTable;
        private readonly string tableName;
        private readonly string selectFields;
        private readonly string insertFields;
        private readonly string schema;
        private readonly string updatevalues;
        private readonly string paramsUpdateFields, InsertValues, insertParamFields;
        private readonly Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public CreateCrudSP(string StoreProcedureName,
         string IdTable,
         string tableName,
         string selectFields,
         string insertFields,
         string insertParamFields,
         string InsertValues,
         string schema, string updateValues, string paramsUpdateFields)
        {
            this.StoreProcedureName= StoreProcedureName;            
            this.IdTable= IdTable;
            this.parameterId = "P_"+IdTable;
            this.tableName= tableName;
            this.selectFields= selectFields;
            this.schema = schema;
            this.insertFields = insertFields;
            this.InsertValues = InsertValues;
            this.updatevalues = updateValues;
            this.insertParamFields = insertParamFields;
            this.paramsUpdateFields = paramsUpdateFields;
            dictionary.Add("%StoreProcedureName%", this.StoreProcedureName);
            dictionary.Add("%parameterId%", this.parameterId);
            dictionary.Add("%IdTable%", this.IdTable);
            dictionary.Add("%tableName%", this.tableName);
            dictionary.Add("%selectFields%", this.selectFields);
            dictionary.Add("%insertFields%", this.insertFields);
            dictionary.Add("%UpdateValues%", this.updatevalues);
            dictionary.Add("%paramsUpdateFields%", this.paramsUpdateFields);
            dictionary.Add("%InsertValues%", this.InsertValues);
            dictionary.Add("%insertParamFields%", this.insertParamFields);
        }


        public  void Replace(string pathTemplate, string outputPath)
        {
            DirectoryInfo di = new DirectoryInfo(pathTemplate);
            foreach (FileInfo templateFile in di.GetFiles())
            {
                var sb = new StringBuilder(File.ReadAllText(templateFile.FullName));
                foreach(var v in dictionary)
                {
                    if (v.Key == "%StoreProcedureName%")
                    {
                        sb.Replace(v.Key, this.StoreProcedureName + "_"+templateFile.Name.Remove(templateFile.Name.Length-4,4));
                    }
                    else
                    {
                        sb.Replace(v.Key, v.Value);
                    }
                    
                }
                string newPath = Path.Combine(outputPath,schema+"."+this.StoreProcedureName+"_"+ templateFile.Name) ;
                if (File.Exists(newPath))
                    File.Delete(newPath);
                File.WriteAllText(newPath, sb.ToString());
            }
        }
    }
}
