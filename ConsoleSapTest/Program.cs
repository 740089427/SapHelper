using System;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;
using SAP.Middleware.Connector;

namespace SapHelpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("helloWord");

            #region 整车经销商资金账户池

            //SapRequest request = new SapRequest();
            //request.RfcFunctionName = "ZSD_04_ZJCX";

            //request.tables = new Dictionary<string, DataTable>(){{ "GT_KUNNR",
            //    new List<VehicleDealerAccountPool>
            //        { new VehicleDealerAccountPool(){ KUNNR = "0000100201" } ,
            //            new VehicleDealerAccountPool() { KUNNR = "0000100202" } }
            //        .ToDataTable()
            //}};

            //SapFinanceInterfaceService testFin = new SapFinanceInterfaceService();
            //testFin.Excute(request);
            //var ttt1 = request.DealTableResult("GT_ZSCDYE");
            //var ttt2 = request.DealTableResult("GT_ZSDT753");

            //var ttt3 = request.DealTableResultToModel<List<BalanceReturn>>("GT_ZSCDYE");
            //var ttt4 = request.DealTableResultToModel<List<Cashbalance>>("GT_ZSDT753");

            #endregion


            //SapRequest request = new SapRequest();
            //request.RfcFunctionName = "ZSD_05_BJZJC";

            //request.tables = new Dictionary<string, DataTable>(){{ "GT_KUNNR",
            //    new List<PartsDealerCapitalAccount>
            //        { new PartsDealerCapitalAccount(){ KUNNR = "100113" } ,
            //            new PartsDealerCapitalAccount() { KUNNR = "100115" },
            //            new PartsDealerCapitalAccount() { KUNNR = "1111" }}
            //        .ToDataTable()
            //}};

            //SapFinanceInterfaceService testFin = new SapFinanceInterfaceService();
            //testFin.Excute(request);
            ////var ttt = request.DealTableResult("ZRETURN");
            //var ttt1 = request.DealTableResult("GT_OUT");

            //var ttt2 = request.DealTableResultToModel<List<PartsCashbalance>>("GT_OUT");
            //var objs = JsonConvert.DeserializeObject<List<PartsCashbalance>>(ttt1);

            //#region 测试元素数据
            //System.Console.WriteLine("输入rfcFunctionName:");
            //while (true)
            //{
            //    try
            //    {
            //        Run(System.Console.ReadLine());
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //        throw;
            //    }

            //}
            //// "ZSD_05_BJZJC"
            ////ZSD_04_ZJCX
            //#endregion

        }

        //public static void Run(string key)
        //{
        //    System.Console.WriteLine();
        //    System.Console.WriteLine("rfcFunctionName:" + key);
        //    SapHelper sapHelper = new SapHelper();
        //    try
        //    {
        //        sapHelper.CreateFunction(sapHelper.CreateRfcDestination("ZhangJiaKou"), key);
        //    }
        //    catch (Exception e)
        //    {
        //        System.Console.WriteLine(e);
        //        return;
        //    }
         
        //    //System.Console.WriteLine(sapHelper.rfcDestination.na)
        //    foreach (IRfcParameter rfcParameter in sapHelper.rfcFunction)
        //    {
        //        List<string> tableColumns = new List<string>();
        //        List<string> STRUCTUREColumns = new List<string>();
        //        List<string> FieldColumns = new List<string>();

        //        var metadata = rfcParameter.Metadata;
        //        if (metadata.DataType == RfcDataType.STRUCTURE)
        //        {
        //            var structureMetadata = metadata.ValueMetadataAsStructureMetadata;
        //            //var structureMetadataName = structureMetadata.Name;
        //            System.Console.WriteLine("STRUCTURE:" + rfcParameter.Metadata.Name);
        //            for (int i = 0; i < structureMetadata.FieldCount; i++)
        //            {
        //                System.Console.WriteLine(SetFieldString(structureMetadata[i]));
        //                STRUCTUREColumns .Add(structureMetadata[i].Name);
        //            }
        //        }
        //        else  if (metadata.DataType == RfcDataType.TABLE)
        //        {
        //            var tableMetadata = metadata.ValueMetadataAsTableMetadata;
        //            //var tableMetadataName = tableMetadata.Name;
        //            System.Console.WriteLine("TABLE:" + rfcParameter.Metadata.Name);
        //            for (int i = 0; i < tableMetadata.LineType.FieldCount; i++)
        //            {
        //                System.Console.WriteLine(SetFieldString(tableMetadata.LineType[i]));
        //                tableColumns.Add(tableMetadata[i].Name);
        //            }
        //        }
        //        else
        //        {

        //           //var test=;
        //            Console.WriteLine(SetFieldString(metadata));
        //            FieldColumns.Add(metadata.Name);
        //            //SetFieldString(metadata);
        //        }
        //        System.Console.WriteLine();
        //        if (tableColumns.Count>0)
        //        {
        //            Console.WriteLine("tableColumns:" + string.Join(",", tableColumns));
        //        }
        //        if (STRUCTUREColumns.Count > 0)
        //        {
        //            Console.WriteLine("STRUCTUREColumns:" + string.Join(",", STRUCTUREColumns));
        //        }
        //        if (FieldColumns.Count > 0)
        //        {
        //            Console.WriteLine("FieldColumns:" + string.Join(",", FieldColumns));
        //        }
        //    }
        //   System.Console.WriteLine();
        //}

        //public static string SetFieldString(RfcElementMetadata rfcField)
        //{
        //    return $"public {GetDotNetType(rfcField.DataType, rfcField.NucLength)} {rfcField.Name} {{ get; set; }}//({rfcField.DataType}|{rfcField.NucLength})";
        //    //return $"{rfcField.Name},";
        //}
        //public static string GetDotNetType(RfcDataType rfcDataType, int nucLength)
        //{
        //    switch (rfcDataType)
        //    {
        //        case RfcDataType.CHAR:
        //            switch (nucLength)
        //            {
        //                case 1: return "bool";
        //                default: return "string";
        //            }
        //        case RfcDataType.NUM: return "int";
        //        case RfcDataType.BCD: return "decimal";
        //        case RfcDataType.INT1: return "byte";
        //        case RfcDataType.INT2: return "short";
        //        case RfcDataType.INT4: return "int";
        //        case RfcDataType.INT8: return "long";
        //        case RfcDataType.DATE: return "DateTime";
        //        default:
        //            return "string";
        //    }
        //}
    }
    public class PartsDealerCapitalAccount
    {
        /// <summary>
        /// 经销商
        /// </summary>
        public string KUNNR { get; set; }
    }

    public class PartsCashbalance
    {
        /// <summary>
        /// 经销商
        /// </summary>
        public string KUNNR { get; set; }

        /// <summary>
        /// 经销商描述
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 利润中心
        /// </summary>
        public string PRCTR { get; set; }

        /// <summary>
        /// 利润中心描述
        /// </summary>
        public string NAME1 { get; set; }

        /// <summary>
        /// 账面余额
        /// </summary>
        public decimal ZMNET { get; set; }

        /// <summary>
        /// 保证金
        /// </summary>
        public decimal ZBZJ { get; set; }

    }
    public class VehicleDealerAccountPool
    {
        /// <summary>
        /// 经销商
        /// </summary>
        public string KUNNR { get; set; }
        // 0000100201
        //0000100202
    }

    /// <summary>
    /// 承兑余额业务返回
    /// </summary>
    public class BalanceReturn
    {
        //  (KUNNR:CHAR10:0000993306)  (KVGR5:CHAR3:300)  (WRBTR2:BCD[7:2]:20000.00)
        public string KUNNR { get; set; }
        public int KVGR5 { get; set; }
        public decimal WRBTR2 { get; set; }
    }

    /// <summary>
    /// 经销商现金余额表
    /// </summary>
    public class Cashbalance
    {
        //{TABLE  [STRUCTURE ZSDT753 { FIELD MANDT=300 FIELD BUKRS=3306 FIELD KUNNR=0000100022 FIELD HZUON=0033060102 FIELD ZZYCD=0.00 FIELD ZBSCD=0.00 FIELD ZLRJE=0.00 FIELD ZDJJE=0.00 FIELD ZZCJE=0.00 
        //FIELD ZZRJE=0.00 FIELD ZZZJE=0.00 FIELD ZXJZR=0.00 FIELD ZSHJE=0.00 FIELD ZJSJE=0.00 FIELD WRBTR=0.00 FIELD ZJRJE=0.00 FIELD ZDBJE=0.00 FIELD ZDBJS=0.00 }] [STRUCTURE ZSDT753 { FIELD MANDT=300 FIELD BUKRS=3306 FIELD KUNNR=0000100203 FIELD HZUON=0033060101 FIELD ZZYCD=0.00 FIELD ZBSCD=0.00 FIELD ZLRJE=2000000.00 FIELD ZDJJE=0.00 FIELD ZZCJE=0.00 FIELD ZZRJE=0.00 FIELD ZZZJE=0.00 FIELD ZXJZR=0.00 FIELD ZSHJE=0.00 FIELD ZJSJE=0.00 FIELD WRBTR=2000000.00 FIELD ZJRJE=0.00 FIELD ZDBJE=0.00 FIELD ZDBJS=0.00 }] [STRUCTURE ZSDT753 { FIELD MANDT=300 FIELD BUKRS=3306 FIELD KUNNR=0000100102 FIELD HZUON=0033060101 FIELD ZZYCD=0.00 FIELD ZBSCD=0.00 FIELD ZLRJE=0.00 FIELD ZDJJE=0.00 FIELD ZZCJE=0.00 FIELD ZZRJE=0.00 FIELD ZZZJE=0.00 FIELD ZXJZR=0.00 FIELD ZSHJE=0.00 FIELD ZJSJE=0.00 FIELD WRBTR=0.00 FIELD ZJRJE=0.00 FIELD ZDBJE=0.00 FIELD ZDBJS=0.00 }] [STRUCTURE ZSDT753 { FIELD MANDT=300 FIELD BUKRS=3306 FIELD KUNNR=0000100028 FIELD HZUON=0033060101 FIELD ZZYCD=0.00 FIELD ZBSCD=0.00 FIELD ZLRJE=0.00 FIELD ZDJJE=0.00 FIELD ZZCJE=0.00 FIELD ZZRJE=0.00 FIELD ZZZJE=0.00 FIELD ZXJZR=0.00 FIELD ZSHJE=0.00 FIELD ZJSJE=0.00 FIELD WRBTR=0.00 FIELD ZJRJE=0.00 FIELD ZDBJE=0.00 FIELD ZDBJS=0.00 }] [STRUCTURE ZSDT753 { FIELD MANDT=300 FIELD BUKRS=3306 FIELD KUNNR=0000100201 FIELD HZUON=0033060102 FIELD ZZYCD=0.00 FIELD ZBSCD=0.00 FIELD ZLRJE=0.00 FIELD ZDJJE=0.00 FIELD ZZCJE=0.00 FIELD ZZRJE=2200.00 FIELD ZZZJE=0.00 FIELD ZXJZR=0.00 FIELD ZSHJE=0.00 FIELD ZJSJE=0.00 FIELD WRBTR=2200.00 FIELD ZJRJE=0.00 FIELD ZDBJE=0.00 FIELD ZDBJS=0.00 }] [STRUCTURE ZSDT753 { FIELD MANDT=300 FIELD BUKRS=3306 FIELD KUNNR=0000100022 FIELD HZUON=0033060101 FIELD ZZYCD=0.00 FIELD ZBSCD=0.00 FIELD ZLRJE=5000.00 FIELD ZDJJE=10000.00 FIELD ZZCJE=0.00 FIELD ZZRJE=0.00 FIELD ZZZJE=0.00 FIELD ZXJZR=0.00 FIELD ZSHJE=0.00 FIELD ZJSJE=0.00 FIELD WRBTR=-5000.00 FIELD ZJRJE=0.00 FIELD ZDBJE=0.00 FIELD ZDBJS=0.00 }] [STRUCTURE ZSDT753 { FIELD MANDT=300 FIELD BUKRS=3306 FIELD KUNNR=0000100201 FIELD HZUON=0033060101 FIELD ZZYCD=0.00 FIELD ZBSCD=0.00 FIELD ZLRJE=3003000.00 FIELD ZDJJE=0.00 FIELD ZZCJE=5200.00 FIELD ZZRJE=0.00 FIELD ZZZJE=0.00 FIELD ZXJZR=0.00 FIELD ZSHJE=0.00 FIELD ZJSJE=0.00 FIELD WRBTR=2997800.00 FIELD ZJRJE=0.00 FIELD ZDBJE=0.00 FIELD ZDBJS=0.00 }] [STRUCTURE ZSDT753 { FIELD MANDT=300 FIELD BUKRS=3306 FIELD KUNNR=0000100201 FIELD HZUON=A0100101 FIELD ZZYCD=0.00 FIELD ZBSCD=0.00 FIELD ZLRJE=0.00 FIELD ZDJJE=0.00 FIELD ZZCJE=0.00 FIELD ZZRJE=3000.00 FIELD ZZZJE=0.00 FIELD ZXJZR=0.00 FIELD ZSHJE=0.00 FIELD ZJSJE=0.00 FIELD WRBTR=3000.00 FIELD ZJRJE=0.00 FIELD ZDBJE=0.00 FIELD ZDBJS=0.00 }]}
        /// <summary>
        /// 集团
        /// </summary>
        public int MANDT { get; set; }

        /// <summary>
        /// 公司代码
        /// </summary>
        public string BUKRS { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        public string KUNNR { get; set; }

        /// <summary>
        /// 利润中心组
        /// </summary>
        public string HZUON { get; set; }

        /// <summary>
        /// 自由承兑
        /// </summary>
        public decimal ZZYCD { get; set; }
        /// <summary>
        /// 背书承兑
        /// </summary>
        public decimal ZBSCD { get; set; }
        /// <summary>
        /// 录入金额
        /// </summary>
        public decimal ZLRJE { get; set; }
        /// <summary>
        /// 冻结金额
        /// </summary>
        public decimal ZDJJE { get; set; }
        /// <summary>
        /// 转出金额
        /// </summary>
        public decimal ZZCJE { get; set; }
        /// <summary>
        /// 转入金额 
        /// </summary>
        public decimal ZZRJE { get; set; }


        /// <summary>
        /// 做账金额（F-02）
        /// </summary>
        public decimal ZZZJE { get; set; }
        /// <summary>
        /// 承兑转现金金额
        /// </summary>
        public decimal ZXJZR { get; set; }
        /// <summary>
        ///  审核金额  
        /// </summary>
        public decimal ZSHJE { get; set; }


        /// <summary>
        /// 结算金额（财务部）
        /// </summary>
        public decimal ZJSJE { get; set; }
        /// <summary>
        /// 金额（订单管理部）
        /// </summary>
        public decimal WRBTR { get; set; }


        /// <summary>
        /// 金融公司可用余额
        /// </summary>
        public decimal ZJRJE { get; set; }
        /// <summary>
        /// 担保审核金额
        /// </summary>
        public decimal ZDBJE { get; set; }
        /// <summary>
        /// 担保结算金额
        /// </summary>
        public decimal ZDBJS { get; set; }

    }
}
