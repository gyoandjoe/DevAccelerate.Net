using System;
using DevAccelerate.TemplateBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrudTestSP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cc = new CreateCrudSP(
                StoreProcedureName: "SI_PR_EMPRESASSANCION",
             IdTable: "EMPR_ID",
             tableName: "SI_C_EMPRESASSANCION",
             selectFields : @"[EMPR_ID]
          ,[EMPR_RAZONSOCIAL]
          ,[EMPR_FECHA_DOF]
          ,[EMPR_FECHA_INICIO]
          ,[EMPR_FECHA_TERMINO]
          ,[EMPR_FECHA_CANCELACION]
          ,[EMPR_FECHA_SUSPENCION]
          ,[ACTIVO]",
             insertParamFields: @"@p_EMPR_RAZONSOCIAL_in varchar(255),
@p_EMPR_FECHA_DOF_in varchar(255),
@p_EEMPR_FECHA_INICIO_in datetime2(0),
@p_EMPR_FECHA_TERMINO_in datetime2(0),
@p_EMPR_FECHA_CANCELACION_in datetime2(0),
@p_EMPR_FECHA_SUSPENCION_in datetime2(0),",
             insertFields: @"[EMPR_RAZONSOCIAL]
          ,[EMPR_FECHA_DOF]
          ,[EMPR_FECHA_INICIO]
          ,[EMPR_FECHA_TERMINO]
          ,[EMPR_FECHA_CANCELACION]
          ,[EMPR_FECHA_SUSPENCION]",
             InsertValues: @"@p_EMPR_RAZONSOCIAL_in,
@p_EMPR_FECHA_DOF_in,
@p_EEMPR_FECHA_INICIO_in,
@p_EMPR_FECHA_TERMINO_in,
@p_EMPR_FECHA_CANCELACION_in,
@p_EMPR_FECHA_SUSPENCION_in",

             schema:"dbo",
             
             updateValues: $@"[EMPR_RAZONSOCIAL]=@p_EMPR_RAZONSOCIAL_in
          ,[EMPR_FECHA_DOF]=@p_EMPR_FECHA_DOF_in
          ,[EMPR_FECHA_INICIO]=@p_EEMPR_FECHA_INICIO_in
          ,[EMPR_FECHA_TERMINO]=@p_EMPR_FECHA_TERMINO_in
          ,[EMPR_FECHA_CANCELACION]=@p_EMPR_FECHA_CANCELACION_in
          ,[EMPR_FECHA_SUSPENCION]=@p_EMPR_FECHA_SUSPENCION_in",
             paramsUpdateFields : @"@p_EMPR_RAZONSOCIAL_in varchar(255),
@p_EMPR_FECHA_DOF_in varchar(255),
@p_EEMPR_FECHA_INICIO_in datetime2(0),
@p_EMPR_FECHA_TERMINO_in datetime2(0),
@p_EMPR_FECHA_CANCELACION_in datetime2(0),
@p_EMPR_FECHA_SUSPENCION_in datetime2(0),
"
                    );

            cc.Replace(@"C:\Projects\TemplatesSP\templates", @"C:\Projects\Workspaces\PEP.ACTIVOSINFORMACION.SIMAN\SIMAN.Solution\MSSQL\StoreProcedures");

            }
        
    }
}
