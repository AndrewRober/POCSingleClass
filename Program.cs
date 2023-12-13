using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var header = new HeaderClass();
            foreach (var diag in header.GetDiagnosticsList())
            {
                Console.WriteLine(diag);
            }

            var submitterInfo = new SubmitterInfo(header);
        }
    }

    public class SubmitterInfo
    {
        public string SubmitterName { get; set; }
        public string SubmitterID { get; set; }
        public string SubmitterContact { get; set; }
        public string SubmitterTel { get; set; }
        public string SubmitterTelExt { get; set; }
        public string SubmitterFax { get; set; }
        public string SubmitterEmail { get; set; }

        public SubmitterInfo(HeaderClass header)
        {
            SubmitterName = header.SubmitterName;
            SubmitterID = header.SubmitterID;
            SubmitterContact = header.SubmitterContact;
            SubmitterTel = header.SubmitterTel;
            SubmitterTelExt = header.SubmitterTelExt;
            SubmitterFax = header.SubmitterFax;
            SubmitterEmail = header.SubmitterEmail;
        }
    }

    public static class HeaderHelpers
    {
        public static List<string> GetHeaderList(this HeaderClass header)
        {
            var headerList = new List<string>();
            var headerProperties = typeof(HeaderClass).GetProperties();
            foreach (var property in headerProperties)
            {
                var value = property.GetValue(header);
                if (value != null)
                {
                    headerList.Add(value.ToString());
                }
                else
                {
                    headerList.Add("");
                }
            }

            return headerList;
        }

        public static IEnumerable<string> GetDiagnosticsList(this HeaderClass header)
        {
            foreach (var diagnosis in new List<string>
                                                         {
                                                             header.PrincipalDiagnosis,
                                                             header.Diag2,
                                                             header.Diag3,
                                                             header.Diag4,
                                                             header.Diag5,
                                                             header.Diag6,
                                                             header.Diag7,
                                                             header.Diag8,
                                                             header.Diag9,
                                                             header.Diag10
                                                         })
            {
                if (!string.IsNullOrEmpty(diagnosis))
                {
                    yield return diagnosis;
                }
            }
        }
    }

    public class HeaderClass
    {
        public long ID { get; set; }
        public string Filename { get; set; }
        public string Version { get; set; }
        public string ImageFilePath { get; set; }
        public string ImageFilename { get; set; }
        public string TradingPartnerIDType { get; set; }
        public string TradingPartnerID { get; set; }
        public DateTime? TransactionDate { get; set; }
        public TimeSpan? TransactionTime { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string SubmitterName { get; set; }
        public string SubmitterID { get; set; }
        public string SubmitterContact { get; set; }
        public string SubmitterTel { get; set; }
        public string SubmitterTelExt { get; set; }
        public string SubmitterFax { get; set; }
        public string SubmitterEmail { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverID { get; set; }
        public string TransactionType { get; set; }
        public string OrigAppTransactionID { get; set; }
        public string FedTaxIDQual { get; set; }
        public string FedTaxID { get; set; }
        public string BillProvIDType { get; set; }
        public string BillProvID { get; set; }
        public string BillProvNPI { get; set; }
        public string BillProvLast { get; set; }
        public string BillProvFirst { get; set; }
        public string BillProvMiddle { get; set; }
        public string BillProvSuffix { get; set; }
        public string BillProvSpecialty { get; set; }
        public string BillProvAddress { get; set; }
        public string BillProvAddress2 { get; set; }
        public string BillProvCity { get; set; }
        public string BillProvState { get; set; }
        public string BillProvZip { get; set; }
        public string BillProvCountry { get; set; }
        public string BillProvSubdivision { get; set; }
        public string BillProvContact { get; set; }
        public string BillProvTel { get; set; }
        public string BillProvTelExt { get; set; }
        public string BillProvFax { get; set; }
        public string BillProvEmail { get; set; }
        public string BillProvOtherIDQual1 { get; set; }
        public string BillProvOtherID1 { get; set; }
        public string BillProvOtherIDQual2 { get; set; }
        public string BillProvOtherID2 { get; set; }
        public string BillProvOtherIDQual3 { get; set; }
        public string BillProvOtherID3 { get; set; }
        public string BillProvOtherIDQual4 { get; set; }
        public string BillProvOtherID4 { get; set; }
        public string BillProvOtherIDQual5 { get; set; }
        public string BillProvOtherID5 { get; set; }
        public string PrincipalDiagnosis { get; set; }
        public string Diag2 { get; set; }
        public string Diag3 { get; set; }
        public string Diag4 { get; set; }
        public string Diag5 { get; set; }
        public string Diag6 { get; set; }
        public string Diag7 { get; set; }
        public string Diag8 { get; set; }
        public string Diag9 { get; set; }
        public string Diag10 { get; set; }
    }
}