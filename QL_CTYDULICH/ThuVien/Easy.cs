//#region Using
//using System;
//using System.Collections;
////using System.Collections.Specialized;
//using System.Text.RegularExpressions;
//using System.Globalization;
////using System.Text;
//using System.Windows.Forms;
//using System.Data;
//using System.Linq;
////using System.Xml;
//using System.IO;
//using System.Net;
//using System.Data.SqlClient;
////using System.Reflection;
////using System.Drawing;
////using TienIch.Model;
////using TienIch.Exceptions;
//using TienIch.Utils;
////using TienIch.Facade;
////using TienIch.Business;
////using DevExpress.XtraPrinting;
//using Excel = Microsoft.Office.Interop.Excel;
//using Word = Microsoft.Office.Interop.Word;
////using DevExpress.XtraEditors.Repository;
//using System.Collections.Generic;
//using System.Data.OleDb;
//using Outlook = Microsoft.Office.Interop.Outlook;
////using System.Net.Mail;
////using Microsoft.VisualBasic;
//using System.Diagnostics;
//using DevExpress.XtraGrid.Views.Grid;
//using DevExpress.XtraGrid.Columns;
//using DevExpress.XtraGrid.Localization;
//using TienIch.Model;
//using TienIch.Business;
//using DevExpress.XtraEditors;
//using DevExpress.XtraEditors.Controls;
//using DevExpress.XtraPrinting.Localization;
//using DevExpress.XtraTreeList.Localization;
//using DevExpress.XtraLayout.Localization;
//using Microsoft.Win32;
//using System.Threading;
//#endregion
//namespace TienIch
//{
//    public class Easy
//    {
//        #region Variables
//        static private SqlConnection mySqlConnection;
//        #region FORMAT
//        public const string CurrencyFormat = "###,###,###.00";
//        public const string CurrencyFormatVND = "###,###,###,###";
//        public const string FomatShortDate = "dd/MM/yyyy";
//        public const string FormatLongDate = "dd/MM/yyyy HH:mm";
//        #endregion
//        #region MESSAGE
//        public static string Caption = "Thông báo";
//        #endregion
//        #region DATETIME
//        public static DateTime MIN_DATE = new DateTime(1950, 1, 1);
//        #endregion
//        private static string[] Number_Patterns = new string[] { "{0:#,##0}", "{0:#,##0.0}", "{0:#,##0.00}", "{0:#,##0}.000", "{0:#,##0.0000}",
//            "{0:#,##0.00000;#,##0.00000; }" };
//        private static string[] Currency_Patterns = new string[] { "{0:$#,##0;($#,##0); }", "{0:$#,##0.0;($#,##0.0); }", "{0:$#,##0.00;($#,##0.00); }",
//            "{0:$#,##0.000;($#,##0.000); }", "{0:$#,##0.0000;($#,##0.0000); }", "{0:$#,##0.00000;($#,##0.00000); }" };
//        #endregion Variables

//        #region Contructors
//        public Easy()
//        {
//        }
//        #endregion Contructors

//        #region Methods

//        public static bool IsPhoneNumber(string str)
//        {
//            Regex Phone = new Regex(@"^[2-9]\d{2}-\d{3}-\d{4}$");
//            if (Phone.IsMatch(str) == false)
//            {
//                return false;
//            }
//            return true;
//        }

//        /// <summary>
//        /// random ID
//        /// </summary>
//        /// <returns></returns>
//        public static string RandomID()
//        {
//            Guid sID = Guid.NewGuid();
//            return sID.ToString();
//        }

//        /// <summary>
//        /// Set tim kiem tieng viet tren gridview devexpress
//        /// </summary>
//        /// <param name="view"></param>
//        public static void SetContainsFilter(GridView view)
//        {
//            foreach (GridColumn col in view.Columns)
//            {
//                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
//            }
//        }

//        static public bool Log(string U, string P, ref DataTable mU)
//        {
//            try
//            {
//                Expression exp = new Expression("LoginName", U, "=");
//                exp = exp.And(new Expression("PassWordHash", MD5.EncryptPassword(P), "="));

//                DataTable arrU = Easy.Select("SELECT * FROM Users WHERE (LoginName = N'" + U + "') AND (PasswordHash = N'" + MD5.EncryptPassword(P) + "')");// UsersBO.Instance.FindByExpression(exp);
//                if ((arrU != null) && (arrU.Rows.Count > 0))
//                {
//                    mU = arrU;

//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//                return false;
//            }
//        }

//        public static void loadFormPRO()
//        {
//            Global.DefaultFileName = "default.ini";
//            Global.ComputerName = Easy.GetHostName();
//            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
//            if (!rkey.GetValue("sShortDate", "MM/dd/yy").ToString().Contains("M/yyyy"))
//            {
//                if (XtraMessageBox.Show("Định dạng ngày tháng trên máy của bạn không phải là định dạng của Việt Nam (ngày/tháng/năm - dd/MM/yyyy)\nĐiều này có thể ảnh hưởng tới hoạt động chương trình.\n Bạn có muốn đổi lại định dạng ngày tháng không ?", Easy.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//                {
//                    rkey.SetValue("sShortDate", "dd/MM/yyyy");
//                }
//            }
//            rkey.Close();
//        }

//        /// <summary>
//        /// Viet hoa devexpress
//        /// </summary>
//        public static void VietHoa()
//        {
//            DevExpress.UserSkins.BonusSkins.Register();
//            DevExpress.Skins.SkinManager.EnableFormSkins();
//            if (Directory.Exists(Application.StartupPath + "\\vi"))
//            {
//                // The following line provides localization for the application's user interface. 
//                System.Threading.Thread.CurrentThread.CurrentUICulture =
//                    new System.Globalization.CultureInfo("vi-VN");

//                // The following line provides localization for data formats. 
//                System.Threading.Thread.CurrentThread.CurrentCulture =
//                    new System.Globalization.CultureInfo("vi-VN");
//            }
//            else
//            {
//                GridLocalizer.Active = new NVGridLocalizer();
//                Localizer.Active = new NVEditorsLocalizer();
//                PreviewLocalizer.Active = new NVPrintingLocalizer();
//                TreeListLocalizer.Active = new NVTreeListLocalizer();
//                LayoutLocalizer.Active = new NVLayoutLocalizer();
//            }
//        }
//        #region Chuyển kiểu, ép kiểu
//        /// <summary>
//        /// Chuyển giá trị sang kiểu integer
//        /// </summary>
//        /// <param name="x">giá trị cần chuyển</param>
//        /// <returns></returns>
//        public static int ToInt(object x)
//        {
//            try
//            {
//                return Convert.ToInt32(x);
//            }
//            catch
//            {
//                return 0;
//            }
//        }
//        /// <summary>
//        /// Chuyển giá trị sang kiểu long
//        /// </summary>
//        /// <param name="x">giá trị cần chuyển</param>
//        /// <returns></returns>
//        public static Int64 ToInt64(object x)
//        {
//            try
//            {
//                return Convert.ToInt64(x);
//            }
//            catch
//            {
//                return 0;
//            }
//        }
//        /// <summary>
//        /// Chuyển giá trị sang kiểu decimal
//        /// </summary>
//        /// <param name="x">giá trị cần chuyển</param>
//        /// <returns></returns>
//        public static Decimal ToDecimal(object x)
//        {
//            try
//            {
//                return Convert.ToDecimal(x);
//            }
//            catch
//            {
//                return 0;
//            }
//        }
//        /// <summary>
//        /// Chuyển giá trị sang kiểu double
//        /// </summary>
//        /// <param name="x">giá trị cần chuyển</param>
//        /// <returns></returns>
//        public static Double ToDouble(object x)
//        {
//            try
//            {
//                return Convert.ToDouble(x);
//            }
//            catch
//            {
//                return 0;
//            }
//        }
//        /// <summary>
//        /// Chuyển giá trị sang kiểu bool
//        /// </summary>
//        /// <param name="x">giá trị cần chuyển</param>
//        /// <returns></returns>
//        public static bool ToBoolean(object x)
//        {
//            try
//            {
//                return Convert.ToBoolean(x);
//            }
//            catch
//            {
//                return false;
//            }
//        }
//        /// <summary>
//        /// Chuyển giá trị chuỗi sang kiểu datetime
//        /// </summary>
//        /// <param name="date">chuỗi cần chuyển</param>
//        /// <returns></returns>
//        public static DateTime ToDate(string date)
//        {
//            try
//            {
//                try
//                {
//                    return DateTime.Parse(date, new CultureInfo("en-US", true));
//                }
//                catch
//                {
//                    return DateTime.Parse(date, new CultureInfo("fr-FR", true));
//                }
//            }
//            catch
//            {
//                return Easy.MIN_DATE;
//            }
//        }
//        /// <summary>
//        /// Chuyển giá trị datetime sang kiểu chuỗi ngày tháng định dạng Việt Nam
//        /// </summary>
//        /// <param name="date">Ngày cần chuyển</param>
//        /// <returns></returns>
//        public static string DateToStringVN(DateTime date)
//        {
//            return date.ToString("dd/MM/yyyy");
//        }
//        /// <summary>
//        /// Chuyển dạng số thành dạng %
//        /// </summary>
//        /// <param name="x"></param>
//        /// <returns></returns>
//        public static string FormatPercentNumber(Decimal x)
//        {
//            return String.Format("{0:#0.00}%", x);
//        }
//        #endregion Các hàm chuyển kiểu
//        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//        #region Lấy dữ liệu từ cơ sở dữ liệu
//        /// <summary>
//        /// Hàm kết nối với CSDL SqlServer
//        /// </summary>
//        /// <returns>Trả về giá trị dạng bool</returns>
//        static private bool connect()
//        {
//            string str = DBUtils.GetDBConnectionString();
//            try
//            {
//                mySqlConnection = new SqlConnection(str);
//                mySqlConnection.Open();
//                return true;
//            }
//            catch (SqlException ex)
//            {
//                XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return false;
//            }
//        }
//        /// <summary>
//        /// Hàm đóng kết nối với CSDL SqlServer
//        /// </summary>
//        /// <returns></returns>
//        static private bool disconnect()
//        {
//            try
//            {
//                mySqlConnection.Close();
//                return true;
//            }
//            catch (SqlException ex)
//            {
//                XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return false;
//            }
//        }
//        /// <summary>
//        /// Lấy giá trị trả về của procedure với dạng bảng
//        /// </summary>
//        /// <param name="procedureName">Tên procedure</param>
//        /// <param name="mySqlParameter">parametter</param>
//        /// <param name="nameSetToTable">Tên bảng trả về</param>
//        /// <returns></returns>
//        static public DataTable GetTable(string procedureName, SqlParameter mySqlParameter, string nameSetToTable)
//        {
//            DataTable table = new DataTable();
//            try
//            {
//                if (connect())
//                {
//                    SqlCommand mySqlCommand = new SqlCommand(procedureName, mySqlConnection);
//                    mySqlCommand.CommandType = CommandType.StoredProcedure;
//                    SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);
//                    DataSet myDataSet = new DataSet();
//                    if (mySqlParameter != null)
//                        mySqlCommand.Parameters.Add(mySqlParameter);
//                    //mySqlCommand.ExecuteNonQuery();
//                    mySqlDataAdapter.Fill(myDataSet, nameSetToTable);
//                    table = myDataSet.Tables[nameSetToTable];
//                }
//            }
//            catch (SqlException ex)
//            {
//                throw new Exception(ex.Message);
//            }
//            finally
//            {
//                disconnect();
//            }
//            return table;
//        }
//        /// <summary>
//        /// Lấy giá trị trả về của procedure với dạng bảng
//        /// </summary>
//        /// <param name="procedureName">tên procedure</param>
//        /// <param name="nameSetToTable">Tên bảng trả về</param>
//        /// <param name="mySqlParameter">danh sách parameter</param>
//        /// <returns></returns>
//        static public DataTable GetTable(string procedureName, string nameSetToTable, params SqlParameter[] mySqlParameter)
//        {
//            DataTable table = new DataTable();
//            try
//            {
//                if (connect())
//                {
//                    SqlCommand mySqlCommand = new SqlCommand(procedureName, mySqlConnection);
//                    mySqlCommand.CommandType = CommandType.StoredProcedure;
//                    SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);
//                    DataSet myDataSet = new DataSet();
//                    for (int i = 0; i < mySqlParameter.Length; i++)
//                        mySqlCommand.Parameters.Add(mySqlParameter[i]);
//                    //mySqlCommand.ExecuteNonQuery();
//                    mySqlDataAdapter.Fill(myDataSet, nameSetToTable);
//                    table = myDataSet.Tables[nameSetToTable];
//                }
//            }
//            catch (SqlException ex)
//            {
//                throw new Exception(ex.Message);
//            }
//            finally
//            {
//                disconnect();
//            }
//            return table;
//        }
//        /// <summary>
//        /// Lấy giá trị trả về của 1 command với dạng bảng
//        /// </summary>
//        /// <param name="strComm">Chuỗi command</param>
//        /// <returns></returns>
//        static public DataTable Select(string strComm)
//        {
//            SqlConnection cnn = new SqlConnection(DBUtils.GetDBConnectionString());
//            try
//            {
//                SqlCommand cmd = new SqlCommand();
//                SqlDataAdapter da = new SqlDataAdapter();
//                cnn.Open();
//                cmd = new SqlCommand("spSearchAllForTrans", cnn);
//                cmd.CommandTimeout = 6000;
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.Add(new SqlParameter("@sqlCommand", strComm));
//                //cmd.ExecuteNonQuery();
//                da = new SqlDataAdapter(cmd);
//                DataSet ds = new DataSet();
//                da.Fill(ds);
//                return ds.Tables[0];
//            }
//            catch (SqlException se)
//            {
//                return null;
//                //throw new Exception("Sellect error :" + se.Message);
//            }
//            finally
//            {
//                cnn.Close();
//            }
//        }
//        /// <summary>
//        /// Lấy dữ liệu của 1 bảng trong sql
//        /// </summary>
//        /// <param name="tableName">Tên bảng</param>
//        /// <param name="exp">Điều kiện</param>
//        /// <returns>Trả về một Datatable</returns>
//        public static DataTable Select(string tableName, Expression exp)
//        {
//            return Easy.Select(DBUtils.SQLSelect(tableName, exp));
//        }
//        /// <summary>
//        /// Thực thi một câu lệnh Command
//        /// </summary>
//        /// <param name="strSQL">Chuỗi command</param>
//        public static void ExcuteSQL(string strSQL)
//        {
//            SqlConnection cn = new SqlConnection(DBUtils.GetDBConnectionString());
//            SqlCommand cmd = new SqlCommand(strSQL, cn);
//            cmd.CommandType = CommandType.Text;
//            cmd.CommandTimeout = 0;
//            cn.Open();
//            cmd.CommandText = strSQL;
//            cmd.ExecuteNonQuery();
//            cn.Close();
//        }
//        /// <summary>
//        /// Thực thi một câu lệnh update
//        /// </summary>
//        /// <param name="command">Chuỗi câu lệnh update</param>
//        /// <returns></returns>
//        public static Boolean UpdateByCommand(string command)
//        {
//            SqlConnection cnn = new SqlConnection(DBUtils.GetDBConnectionString());
//            Boolean update = false;
//            try
//            {
//                SqlCommand cmd = new SqlCommand();
//                cnn.Open();
//                cmd = new SqlCommand("spSearchAllForTrans", cnn);
//                cmd.CommandTimeout = 6000;
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.Add(new SqlParameter("@sqlCommand", command));
//                cmd.ExecuteNonQuery();
//                update = true;
//            }
//            catch (SqlException se)
//            {
//                throw new Exception("UPDATE_ERROR :" + se.Message);
//            }
//            finally
//            {
//                cnn.Close();
//            }
//            return update;
//        }

//        #endregion Các hàm lấy dữ liệu từ cơ sở dữ liệu
//        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//        #region Xử lý Chuỗi
//        /// <summary>
//        /// Viết hoa chữ cái đầu của một chuỗi
//        /// </summary>
//        /// <param name="str"></param>
//        /// <returns></returns>
//        public static string ToUpperFC(string str)
//        {
//            return str.Substring(0, 1).ToUpper() + str.Substring(1);
//        }
//        /// <summary>
//        /// Cảnh Hưng
//        /// Đổi từ số sang chữ tiếng việt
//        /// </summary>
//        /// <param name="Num">Giá trị số cần chuyển</param>
//        /// <returns></returns>
//        public static string NumericToString(decimal Num)
//        {
//            string[] Dvi = { "", "ngàn", "triệu", "tỷ", "ngàn" };
//            string Result = "";
//            long IntNum = (long)Num;
//            for (int i = 0; i < 5; i++)
//            {
//                long Doc = (long)IntNum % 1000;
//                if (Doc > 0) Result = NumericToString(Doc, IntNum < 1000) + " " + Dvi[i] + "" + Result;
//                IntNum = (long)IntNum / 1000;
//            }
//            Result += " đồng" + ((((long)Num) % 1000 == 0) ? " chẵn" : "");
//            if (Result.ToString().Trim().Substring(0, 1) == "m" && Result.ToString().Trim().Substring(3, 1) == "i")
//                Result = "Mười " + Result.Remove(0, 5);
//            return Result.Length == 4 ? "..." : Result;
//        }
//        /// <summary>
//        /// Đổi từ số sang chữ Tiếng Anh
//        /// </summary>
//        /// <param name="number">Giá trị số cần chuyển</param>
//        /// <returns></returns>
//        public static string NumberToWordsENG(int number)
//        {
//            if (number == 0)
//                return "zero";
//            if (number < 0)
//                return "minus " + NumberToWordsENG(Math.Abs(number));
//            string words = "";
//            if ((number / 1000000) > 0)
//            {
//                words += NumberToWordsENG(number / 1000000) + " million ";
//                number %= 1000000;
//            }
//            if ((number / 1000) > 0)
//            {
//                words += NumberToWordsENG(number / 1000) + " thousand ";
//                number %= 1000;
//            }
//            if ((number / 100) > 0)
//            {
//                words += NumberToWordsENG(number / 100) + " hundred ";
//                number %= 100;
//            }
//            if (number > 0)
//            {
//                if (words != "")
//                    words += "and ";
//                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
//                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
//                if (number < 20)
//                    words += unitsMap[number];
//                else
//                {
//                    words += tensMap[number / 10];
//                    if ((number % 10) > 0)
//                        words += "-" + unitsMap[number % 10];
//                }
//            }
//            return words;
//        }
//        /// <summary>
//        /// Cảnh Hưng
//        /// Dùng để đổi dấu phân biệt hàng nghìn, hàng đơn vị trong các câu lệnh UPDATE
//        /// </summary>
//        /// <param name="strNumber">Giá trị số cần chuyển theo dạng chuỗi</param>
//        /// <returns></returns>
//        public static string DoiDau(string strNumber)
//        {
//            int length = 0; int pos = 0; string st = ""; string DoiDau1 = "";
//            st = strNumber;
//            pos = st.IndexOf(".", 0);
//            while (pos > 0)
//            {
//                st = st.Substring(0, pos) + st.Remove(0, pos);
//                pos = st.IndexOf(".", 0);
//            }
//            length = st.Length;
//            pos = st.IndexOf(",", 0);
//            if (pos > 0)
//                DoiDau1 = st.Substring(0, pos) + "." + st.Remove(0, pos + 1);
//            else
//                DoiDau1 = st;
//            return DoiDau1;
//        }
//        #endregion
//        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//        #region Xử lý thời gian
//        /// <summary>
//        /// Lay ve ngay thang cua he thong.
//        /// </summary>
//        /// <returns></returns>
//        public static DateTime GetSystemDate()
//        {
//            try
//            {
//                return Convert.ToDateTime(Easy.GetTable("spGetDateSystem", null, "Table").Rows[0][0]);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }
//        /// <summary>
//        /// Lấy giá trị chênh lệch giữa 2 mốc thời gian
//        /// </summary>
//        /// <param name="Interval">dạng giá trị cần lấy h: Số giờ, day: số ngày, month: số tháng, year: số năm</param>
//        /// <param name="Date1">Ngày bắt đầu</param>
//        /// <param name="Date2">Ngày kết thúc</param>
//        /// <returns></returns>
//        public static int DateDiff(string Interval, DateTime Date1, DateTime Date2)
//        {
//            int intDateDiff = 0;
//            TimeSpan time = Date1 - Date2;
//            int timeHours = Math.Abs(time.Hours);
//            int timeDays = Math.Abs(time.Days);
//            switch (Interval.ToLower())
//            {
//                case "h": // hours
//                    intDateDiff = timeHours;
//                    break;
//                case "d": // days
//                    time = Date1.Date - Date2.Date;
//                    intDateDiff = Math.Abs(time.Days);
//                    //intDateDiff = timeDays;
//                    break;
//                case "w": // weeks
//                    intDateDiff = timeDays / 7;
//                    break;
//                case "bw": // bi-weekly
//                    intDateDiff = (timeDays / 7) / 2;
//                    break;
//                case "m": // monthly
//                    timeDays = timeDays - ((timeDays / 365) * 5);
//                    intDateDiff = timeDays / 30;
//                    break;
//                case "bm": // bi-monthly
//                    timeDays = timeDays - ((timeDays / 365) * 5);
//                    intDateDiff = (timeDays / 30) / 2;
//                    break;
//                case "q": // quarterly
//                    timeDays = timeDays - ((timeDays / 365) * 5);
//                    intDateDiff = (timeDays / 90);
//                    break;
//                case "y": // yearly
//                    intDateDiff = (timeDays / 365);
//                    break;
//            }
//            return intDateDiff;
//        }
//        /// <summary>
//        /// Cảnh Hưng
//        /// Lấy số tuần của 1 năm
//        /// </summary>
//        /// <param name="Year">Năm cần lấy</param>
//        /// <returns></returns>
//        public static List<string> LoadAllWeekOfYear(int Year)
//        {
//            List<DateTime[]> weeks = new List<DateTime[]>();
//            List<string> str = new List<string>();
//            DateTime beginDate = new DateTime(Year, 01, 01);
//            DateTime endDate = new DateTime(Year, 12, 31);
//            DateTime monday = DateTime.Today;
//            DateTime satday = DateTime.Today;
//            while (beginDate < endDate)
//            {
//                beginDate = beginDate.AddDays(1);
//                if (beginDate.DayOfWeek == DayOfWeek.Monday)
//                {
//                    monday = beginDate;
//                }
//                else if (beginDate.DayOfWeek == DayOfWeek.Saturday)
//                {
//                    satday = beginDate;
//                }
//                else if (beginDate.DayOfWeek == DayOfWeek.Sunday)
//                {
//                    weeks.Add(new DateTime[] { monday, satday });
//                }
//            }
//            int count = 0;
//            for (int x = 1; x < weeks.Count; x++)
//            {
//                if (x == 1)
//                {
//                    int startDay = weeks[x][0].Date.Day;
//                    if (startDay >= 4)
//                    {
//                        str.Add("Tuần 1: " + "02/01/" + Year + " - 0" + (startDay - 2) + "/01/" + Year);
//                        count = 1;
//                    }
//                }
//                str.Add("Tuần " + (x + count) + ": " + (weeks[x][0]).ToString("dd/MM/yyyy") + " - " + (weeks[x][1]).ToString("dd/MM/yyyy"));
//                if (x == weeks.Count - 1)
//                {
//                    int endDay = weeks[x][1].Date.Day;
//                    if (endDay <= 29)
//                    {
//                        str.Add("Tuần " + (weeks.Count + count) + ": " + (endDay + 2) + "/01/" + Year + " - 31/01/" + Year);
//                    }
//                }
//            }
//            return str;
//        }
//        #endregion Cac ham xu li thoi gian
//        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
//        #region Xứ lý với File, Folder
//        /// <summary>
//        /// Lưu trũ một file dựa trên giao diện lưu trữ của window
//        /// </summary>
//        /// <param name="title"></param>
//        /// <param name="filter">Kiểu file (.doc,xls,...)</param>
//        /// <param name="FileName">Tên file</param>
//        /// <returns></returns>
//        public static string ShowSaveFileDialog(string title, string filter, string FileName)
//        {
//            SaveFileDialog dlg = new SaveFileDialog();
//            dlg.Title = title;
//            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//            dlg.FileName = FileName;//name;
//            dlg.Filter = filter;
//            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
//            return "";
//        }
//        /// <summary>
//        /// Mở một file
//        /// </summary>
//        /// <param name="fileName">đường dẫn file</param>
//        public static void OpenFile(string fileName)
//        {
//            if (XtraMessageBox.Show("Do you want to open file?", Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//            {
//                try
//                {
//                    System.Diagnostics.Process process = new System.Diagnostics.Process();
//                    process.StartInfo.FileName = fileName;
//                    process.StartInfo.Verb = "Open";
//                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
//                    process.Start();
//                }
//                catch
//                {
//                    XtraMessageBox.Show("File not found.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }
//        /// <summary>
//        /// Kiểm tra xem đường dẫn có phải là 1 file không
//        /// </summary>
//        /// <param name="filePath">Đường dẫn</param>
//        /// <returns></returns>
//        public static bool IsFile(string filePath)
//        {
//            if (File.Exists(filePath))
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        /// <summary>
//        /// Kiểm tra xem đường dẫn có phải là 1 thư mục không
//        /// </summary>
//        /// <param name="filePath">Đường dẫn</param>
//        /// <returns></returns>
//        public static bool IsFolder(string filePath)
//        {
//            if (Directory.Exists(filePath))
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        /// <summary>
//        /// Copy file nhưng không ghi đề file trùng tên mà tạo ra một phiên bản mới. VD: a(1).txt
//        /// </summary>
//        /// <param name="sourceFile">Đường dẫn file nguồn</param>
//        /// <param name="fileName">Tên file</param>
//        /// <param name="destinationPath">Thư mục chứa file</param>
//        /// <returns></returns>
//        public static bool FileCopyWithoutOverwriting(string sourceFile, string fileName, string destinationPath)
//        {
//            // if destinationPath doesn't add with a slash, add one
//            if ((destinationPath.EndsWith("\\") || destinationPath.EndsWith("/")) == false)
//                destinationPath += "\\";
//            try
//            {
//                // if file already exists in destination
//                if (File.Exists(destinationPath + fileName))
//                {
//                    // counter
//                    int count = 1;
//                    // extract extension
//                    FileInfo info = new FileInfo(sourceFile);
//                    string ext = info.Extension;
//                    string prefix;
//                    // if it has an extension, append it to a .
//                    if (ext.Length > 0)
//                    {
//                        // get filename without extension
//                        prefix = fileName.Substring(0, fileName.Length - ext.Length);
//                        //ext = "." + ext;
//                    }
//                    else
//                        prefix = fileName;
//                    // while not found an valid destination file name, increase counter
//                    while (File.Exists(destinationPath + fileName))
//                    {
//                        fileName = prefix + "(" + count.ToString() + ")" + ext;
//                        count++;
//                    }
//                    // copy file
//                    File.Copy(sourceFile, destinationPath + fileName);
//                }
//                else
//                {
//                    File.Copy(sourceFile, destinationPath + fileName);
//                }
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }
//        /// <summary>
//        /// Lấy đường dẫn thư mục trên Server
//        /// </summary>
//        /// <param name="pathServerNotDrive"></param>
//        /// <returns></returns>
//        /// <summary>
//        /// CreateFolder(Server.MapPath("Album/Folder1″)); sẽ tạo thư mục Folder1 trong thư mục Album của webroot
//        /// </summary>
//        /// <param name="strPath">Đường dẫn</param>
//        public static void CreateFolder(string strPath)
//        {
//            try
//            {
//                if (Directory.Exists(strPath) == false)
//                {
//                    Directory.CreateDirectory(strPath);
//                }
//            }
//            catch { }
//        }
//        /// <summary>
//        /// RenameFolder(Server.MapPath("Album/Folder1″), Server.MapPath("Album/Folder2″)); 
//        /// Sẻ đổi tên thư mục có tên Folder1 thành Folder2 trong thư mục Album của webroot
//        /// </summary>
//        /// <param name="strOldFolderName"></param>
//        /// <param name="strNewFolderName"></param>
//        public static void RenameFolder(string strOldFolderName, string strNewFolderName)
//        {
//            try
//            {
//                Directory.Move(strOldFolderName, strNewFolderName);
//            }
//            catch { }
//        }
//        /// <summary>
//        /// Hàm xóa hết các thư mục và file bên trong một thư mục: 
//        /// </summary>
//        /// <param name="directoryInfo"></param>
//        public static void EmptyFolder(DirectoryInfo directoryInfo)
//        {
//            try
//            {
//                foreach (FileInfo file in directoryInfo.GetFiles())
//                {
//                    file.Delete();
//                }
//                foreach (DirectoryInfo subfolder in directoryInfo.GetDirectories())
//                {
//                    //EmptyFolder(subfolder);
//                    subfolder.Delete(true);
//                }
//            }
//            catch { }
//        }
//        /// <summary>
//        /// Hàm Copy thư mục này đến thư mục khác
//        /// </summary>
//        /// <param name="ThuMucNguon"></param>
//        /// <param name="ThucMucDich"></param>
//        public static void CopyDirectory(DirectoryInfo ThuMucNguon, DirectoryInfo ThucMucDich)
//        {
//            try
//            {
//                if (!ThucMucDich.Exists)
//                {
//                    ThucMucDich.Create();
//                }
//                FileInfo[] files = ThuMucNguon.GetFiles(); foreach (FileInfo file in files)
//                {
//                    if ((File.Exists(System.IO.Path.Combine(ThucMucDich.FullName, file.Name))) == false)
//                    {
//                        file.CopyTo(Path.Combine(ThucMucDich.FullName, file.Name));
//                    }
//                }
//                //Xử lý thư mục con
//                DirectoryInfo[] dirs = ThuMucNguon.GetDirectories();
//                foreach (DirectoryInfo dir in dirs)
//                {
//                    string ThucMucDichDir = Path.Combine(ThucMucDich.FullName, dir.Name); CopyDirectory(dir, new DirectoryInfo(ThucMucDichDir));
//                }
//            }
//            catch { }
//        }
//        /// <summary>
//        /// Hàm này sẽ xóa thư mục mục và nội dung bên trong của thư mục được chọn
//        /// </summary>
//        /// <param name="strFolderName"></param>
//        public static void DeleteFolder(string strFolderName)
//        {
//            DirectoryInfo ThuMucNguonDir = new DirectoryInfo(strFolderName);
//            if (Directory.Exists(strFolderName))
//            {
//                try
//                {
//                    //EmptyFolder(ThuMucNguonDir);
//                    EmptyFolder(ThuMucNguonDir);
//                    Directory.Delete(strFolderName);
//                }
//                catch { }
//            }
//        }

//        /// <summary>
//        /// Đổi tên file
//        /// </summary>
//        /// <param name="filePath"></param>
//        /// <param name="newName"></param>
//        public static void RenameFile(string filePath, string newName)
//        {
//            // (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.RenameFile(filePath, newName);
//        }
//        public static void DeleteFile(string filePath)
//        {
//            //(new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DeleteFile(filePath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
//        }
//        #endregion Xứ lý với File
//        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//        #region Control
//        #region GridControl Devexpress
//        /// <summary>
//        /// Bật chế hiển thị của GridControl để export
//        /// </summary>
//        /// <param name="grid"></param>
//        public static void GridPreview(DevExpress.XtraGrid.GridControl grid)
//        {
//            if (grid.DataSource == null)
//                return;
//            // Check whether or not the XtraGrid control can be previewed. 
//            if (!grid.IsPrintingAvailable)
//            {
//                XtraMessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
//                return;
//            }
//            // Opens the Preview window. 
//            grid.ShowRibbonPrintPreview();
//        }
//        /// <summary>
//        /// In dữ liệu trong gridcontrol
//        /// </summary>
//        /// <param name="grid"></param>
//        public static void GridPrint(DevExpress.XtraGrid.GridControl grid)
//        {
//            if (grid.DataSource == null)
//                return;
//            // Check whether or not the XtraGrid control can be previewed. 
//            if (!grid.IsPrintingAvailable)
//            {
//                XtraMessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
//                return;
//            }
//            // Opens the Preview window. 
//            grid.Print();
//        }
//        /// <summary>
//        /// Export dữ liệu trong BandedGridView thành file excel
//        /// </summary>
//        /// <param name="grvData"></param>
//        public static void ExportExcel(DevExpress.XtraGrid.Views.BandedGrid.BandedGridView grvData)
//        {
//            //grvData.OptionsPrint.AutoWidth = false;
//            //grvData.OptionsPrint.ExpandAllDetails = false;
//            //grvData.OptionsPrint.PrintDetails = true;
//            //grvData.OptionsPrint.UsePrintStyles = true;
//            ////string filepath = System.IO.Path.GetTempFileName();
//            //string filepath = System.IO.Path.GetTempFileName();
//            //filepath = filepath.Remove(filepath.LastIndexOf('.') + 1);
//            //filepath = String.Concat(filepath, "xls");
//            //if (filepath != "")
//            //{
//            //    try
//            //    { grvData.ExportToXls(filepath, new XlsExportOptions(TextExportMode.Value)); }
//            //    catch
//            //    { grvData.ExportToExcelOld(filepath); }
//            //    Excel.Application xlApp = new Excel.Application();
//            //    Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filepath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, 1, 0);
//            //    Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
//            //    xlApp.Visible = true;
//            //    System.IO.File.Delete(filepath);
//            //    //System.Diagnostics.Process.Start(filepath);
//            //}
//        }
//        /// <summary>
//        /// Export dữ liệu trong BandedGridView thành file pdf
//        /// </summary>
//        /// <param name="grvData"></param>
//        public static void ExportPdf(DevExpress.XtraGrid.Views.BandedGrid.BandedGridView grvData)
//        {
//            string filepath = System.IO.Path.GetTempFileName();
//            filepath = filepath.Remove(filepath.LastIndexOf('.') + 1);
//            filepath = String.Concat(filepath, "pdf");
//            grvData.OptionsPrint.AutoWidth = false;
//            grvData.OptionsPrint.ExpandAllDetails = false;
//            grvData.OptionsPrint.PrintDetails = true;
//            grvData.OptionsPrint.UsePrintStyles = true;
//            try
//            { grvData.ExportToPdf(filepath); }
//            catch
//            { grvData.ExportToPdf(filepath); }
//            System.Diagnostics.Process.Start(filepath);
//        }
//        /// <summary>
//        /// Export dữ liệu trong GridView thành file excel
//        /// </summary>
//        /// <param name="grvData"></param>
//        public static void ExportExcel(DevExpress.XtraGrid.Views.Grid.GridView grvData)
//        {
//            //string filepath = System.IO.Path.GetTempFileName();
//            //filepath = filepath.Remove(filepath.LastIndexOf('.') + 1);
//            //filepath = String.Concat(filepath, "xls");
//            grvData.OptionsPrint.AutoWidth = false;
//            grvData.OptionsPrint.ExpandAllDetails = false;
//            grvData.OptionsPrint.PrintDetails = true;
//            grvData.OptionsPrint.UsePrintStyles = true;
//            string filepath = System.IO.Path.GetTempFileName();
//            if (filepath != "")
//            {
//                try
//                { grvData.ExportToXls(filepath); }
//                catch
//                { grvData.ExportToExcelOld(filepath); }
//                try
//                {
//                    Excel.Application xlApp = new Excel.Application();
//                    Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filepath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, 1, 0);
//                    Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
//                    xlApp.Visible = true;
//                    System.IO.File.Delete(filepath);
//                }
//                catch
//                {
//                    filepath = filepath.Replace(".tmp", ".xls");
//                    grvData.ExportToXls(filepath);
//                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("Excel.exe", String.Format("/r \"{0}\"", filepath));
//                    System.Diagnostics.Process.Start(startInfo);
//                }
//            }
//            //try
//            //{ grvData.ExportToXls(filepath); }
//            //catch
//            //{ grvData.ExportToExcelOld(filepath); }
//            //System.Diagnostics.ProcessStartInfo startInfo =
//            //     new System.Diagnostics.ProcessStartInfo("Excel.exe", String.Format("/r \"{0}\"", filepath));
//            //System.Diagnostics.Process.Start(startInfo);
//        }
//        #endregion GridControl Devexpress
//        #region Gridview
//        public static void FormatCurrencyColumnGrid(ref DataGridView grvData, string ColoumnName)
//        {
//            grvData.Columns[ColoumnName].DefaultCellStyle.Format = CurrencyFormat;
//            grvData.Columns[ColoumnName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
//        }
//        public static void FormatCurrencyColumnGrid(ref TienIch.DatagridView grvData, string ColoumnName)
//        {
//            grvData.Columns[ColoumnName].DefaultCellStyle.Format = CurrencyFormat;
//            grvData.Columns[ColoumnName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
//        }
//        public static void FormatDateColumnGrid(ref DataGridView grvData, string ColoumnName)
//        {
//            grvData.Columns[ColoumnName].DefaultCellStyle.Format = FomatShortDate;
//        }
//        public static void FormatDateColumnGrid(ref TienIch.DatagridView grvData, string ColoumnName)
//        {
//            grvData.Columns[ColoumnName].DefaultCellStyle.Format = FomatShortDate;
//        }
//        #endregion Gridview
//        #region TextBox
//        /// <summary>
//        /// Cảnh Hưng
//        /// Kiểm tra dữ liệu kiểu số khi nhập vào các ô textbox
//        /// </summary>
//        /// <param name="e"></param>
//        /// <returns></returns>
//        public static bool CheckNumber(KeyPressEventArgs e)
//        {
//            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && (e.KeyChar != '-'))
//                return true;
//            else
//                return false;
//        }
//        /// <summary>
//        /// Cảnh Hưng
//        /// Kiểm tra dữ liệu kiểu số khi nhập vào các ô textbox
//        /// </summary>
//        /// <param name="e"></param>
//        /// <returns></returns>
//        public static bool CheckInterger(KeyPressEventArgs e)
//        {
//            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar) && !Char.IsDigit(e.KeyChar))
//                return true;
//            else
//                return false;
//        }
//        #endregion TextBox
//        #region Combobox
//        /// <summary>
//        /// Nhập dữ liệu dạng ArrayList vào Combobox
//        /// </summary>
//        /// <param name="item">tên combobox</param>
//        /// <param name="list">dữ liệu</param>
//        /// <param name="display">Trường hiển thị</param>
//        /// <param name="value">Trường giá trị</param>
//        public static void PopulateCombo(System.Windows.Forms.ComboBox item, ArrayList list, string display, string value)
//        {
//            if (list.Count > 0)
//            {
//                item.DataSource = list;
//                item.DisplayMember = display;
//                item.ValueMember = value;
//            }
//            else
//            {
//                item.DataSource = null;
//                item.Items.Clear();
//            }
//            item.Focus();
//        }
//        /// <summary>
//        /// Nhập dữ liệu dạng DataTable vào Combobox
//        /// </summary>
//        /// <param name="comboBox">tên combobox</param>
//        /// <param name="data">dữ liệu</param>
//        /// <param name="DisplayField">trường hiển thị</param>
//        /// <param name="ValueField">Trường giá trị</param>
//        /// <param name="NotSetItem">Giá trị khởi tạo</param>
//        public static void PopulateCombo(System.Windows.Forms.ComboBox comboBox, DataTable data, string DisplayField, string ValueField, string NotSetItem)
//        {
//            if (NotSetItem != "")
//            {
//                DataRow dr = data.NewRow();
//                dr[DisplayField] = NotSetItem;
//                dr[ValueField] = 0;
//                data.Rows.InsertAt(dr, 0);
//            }
//            comboBox.DataSource = data;
//            comboBox.DisplayMember = DisplayField;
//            comboBox.ValueMember = ValueField;
//            comboBox.SelectedIndex = 0;
//        }

//        /// <summary>
//        /// Đưa dữ liệu vào LookUpEdit trong Devexpress
//        /// </summary>
//        /// <param name="comboBox">LookUpEdit</param>
//        /// <param name="data">dữ liệu muốn hiển thị trên lookupedit</param>
//        /// <param name="DisplayField">Trường cần hiển thị</param>
//        /// <param name="ValueField">Trường giá trị</param>
//        /// <param name="NotSetItem">Giá trị khởi tạo</param>
//        public static void PopulateCombo(DevExpress.XtraEditors.LookUpEdit comboBox, DataTable data, string DisplayField, string ValueField, string NotSetItem)
//        {
//            if (NotSetItem != null && NotSetItem != "")
//            {
//                DataRow dr = data.NewRow();
//                dr[DisplayField] = NotSetItem;
//                dr[ValueField] = 0;
//                data.Rows.InsertAt(dr, 0);
//            }
//            comboBox.Properties.Columns.Clear();
//            comboBox.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
//            {
//                new DevExpress.XtraEditors.Controls.LookUpColumnInfo(ValueField),
//                new DevExpress.XtraEditors.Controls.LookUpColumnInfo(DisplayField),
//            });
//            comboBox.Properties.Columns[ValueField].Visible = false;
//            comboBox.Properties.DataSource = data;
//            comboBox.Properties.DisplayMember = DisplayField;
//            comboBox.Properties.ValueMember = ValueField;
//            if (data.Rows.Count > 0)
//                comboBox.EditValue = ((DataTable)comboBox.Properties.DataSource).Rows[0][ValueField];
//        }


//        public static void PopulateCombo(DevExpress.XtraEditors.LookUpEdit comboBox, ArrayList data, string DisplayField, string ValueField, string NotSetItem)
//        {
//            comboBox.Properties.Columns.Clear();
//            comboBox.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
//            {
//                new DevExpress.XtraEditors.Controls.LookUpColumnInfo(ValueField),
//                new DevExpress.XtraEditors.Controls.LookUpColumnInfo(DisplayField),
//            });
//            comboBox.Properties.Columns[ValueField].Visible = false;
//            comboBox.Properties.DataSource = data;
//            comboBox.Properties.DisplayMember = DisplayField;
//            comboBox.Properties.ValueMember = ValueField;
//        }


//        public static void PopulateCombo(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit comboBox, DataTable data, string DisplayField, string ValueField, string NotSetItem)
//        {
//            if (NotSetItem != null && NotSetItem != "")
//            {
//                DataRow dr = data.NewRow();
//                dr[DisplayField] = NotSetItem;
//                dr[ValueField] = 0;
//                data.Rows.InsertAt(dr, 0);
//            }
//            comboBox.Columns.Clear();
//            comboBox.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
//            {
//                new DevExpress.XtraEditors.Controls.LookUpColumnInfo(ValueField),
//                new DevExpress.XtraEditors.Controls.LookUpColumnInfo(DisplayField),
//            });
//            comboBox.Columns[ValueField].Visible = false;
//            comboBox.DataSource = data;
//            comboBox.DisplayMember = DisplayField;
//            comboBox.ValueMember = ValueField;
//            comboBox.NullText = NotSetItem;
//            //if (data.Rows.Count > 0)
//            //    comboBox.EditValue = ((DataTable)comboBox.Properties.DataSource).Rows[0][ValueField];
//        }

//        #endregion Combobox
//        /// <summary>
//        /// Mở form có check sự tồn tại của nó
//        /// </summary>
//        /// <param name="frm">tên form</param>
//        public static void OpenForm(FormBase frm)
//        {
//            FormBase _frmShow = (FormBase)Application.OpenForms[frm.Name];
//            if (_frmShow == null)
//            {
//                _frmShow = frm;
//            }
//            else
//                frm.Dispose();
//            _frmShow.Show();
//            if (_frmShow.WindowState == FormWindowState.Minimized)
//                _frmShow.WindowState = _frmShow.VisibleFormState;
//            _frmShow.Activate();
//        }
//        /// <summary>
//        /// Reset tất cả các textbox trong form
//        /// </summary>
//        /// <param name="frm"></param>
//        public static void ClearTexbox(Form frm)
//        {
//            foreach (Control ctrl in frm.Controls)
//            {
//                if (ctrl.GetType() == typeof(TextBox))
//                {
//                    ((TextBox)ctrl).Clear();
//                }
//            }
//        }
//        /// <summary>
//        /// Reset tất cả các textbox trong các container
//        /// </summary>
//        /// <param name="ctrCollection"></param>
//        static public void ClearTextBox(System.Windows.Forms.Control.ControlCollection ctrCollection)
//        {
//            foreach (object myObject in ctrCollection)
//            {
//                if (myObject is TextBox)
//                {
//                    ((TextBox)myObject).Clear();
//                }
//            }
//        }
//        /// <summary>
//        /// Reset tất cả các textbox trong các container, chọn textbox sẽ được focus 
//        /// </summary>
//        /// <param name="ctrCollection">list container control</param>
//        /// <param name="txtFocus">textbox sẽ được focus </param>
//        static public void ClearTextBox(System.Windows.Forms.Control.ControlCollection ctrCollection, TextBox txtFocus)
//        {
//            ClearTextBox(ctrCollection);
//            txtFocus.Focus();
//        }
//        #endregion Control
//        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//        #region Process Excel
//        /// <summary>
//        /// Lấy danh sách các tên sheet trong file excel
//        /// </summary>
//        /// <param name="filePath">Đường dẫn file Excel</param>
//        /// <returns></returns>
//        public static List<string> ListSheetInExcel(string filePath)
//        {
//            OleDbConnectionStringBuilder sbConnection = new OleDbConnectionStringBuilder();
//            String strExtendedProperties = String.Empty;
//            sbConnection.DataSource = filePath;
//            if (Path.GetExtension(filePath).Equals(".xls"))//for 97-03 Excel file
//            {
//                sbConnection.Provider = "Microsoft.Jet.OLEDB.4.0";
//                strExtendedProperties = "Excel 8.0;HDR=Yes;IMEX=1";//HDR=ColumnHeader,IMEX=InterMixed
//            }
//            else if (Path.GetExtension(filePath).Equals(".xlsx") || Path.GetExtension(filePath).Equals(".xlsm"))  //for 2007 Excel file
//            {
//                sbConnection.Provider = "Microsoft.ACE.OLEDB.12.0";
//                strExtendedProperties = "Excel 12.0;HDR=Yes;IMEX=1";
//            }
//            sbConnection.Add("Extended Properties", strExtendedProperties);
//            List<string> listSheet = new List<string>();
//            OleDbConnection conn = new OleDbConnection(sbConnection.ToString());
//            try
//            {
//                conn.Open();
//                DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
//                foreach (DataRow drSheet in dtSheet.Rows)
//                {
//                    if (drSheet["TABLE_NAME"].ToString().EndsWith("$") || drSheet["TABLE_NAME"].ToString().EndsWith("$'"))
//                    {
//                        listSheet.Add(drSheet["TABLE_NAME"].ToString().Replace("$", "").Replace("#", ".").Replace("'", ""));
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                ShowError(ex);
//            }
//            finally
//            {
//                conn.Close();
//            }
//            return listSheet;
//        }
//        /// <summary>
//        /// Lấy dữ liệu file excel dưới dạng Datatable
//        /// </summary>
//        /// <param name="filename">Đường dẫn file Excel</param>
//        /// <param name="sheetName">Tên sheet cần lấy dữ liệu</param>
//        /// <returns></returns>
//        public static DataTable ExcelToDatatable(string filename)
//        {
//            OleDbConnectionStringBuilder sbConnection = new OleDbConnectionStringBuilder();
//            String strExtendedProperties = String.Empty;
//            sbConnection.DataSource = filename;
//            if (Path.GetExtension(filename).Equals(".xls"))//for 97-03 Excel file
//            {
//                sbConnection.Provider = "Microsoft.Jet.OLEDB.4.0";
//                strExtendedProperties = "Excel 8.0;HDR=Yes;IMEX=1";//HDR=ColumnHeader,IMEX=InterMixed
//            }
//            else if (Path.GetExtension(filename).Equals(".xlsx") || Path.GetExtension(filename).Equals(".xlsm"))  //for 2007 Excel file
//            {
//                sbConnection.Provider = "Microsoft.ACE.OLEDB.12.0";
//                strExtendedProperties = "Excel 12.0;HDR=Yes;IMEX=1";
//            }
//            sbConnection.Add("Extended Properties", strExtendedProperties);
//            OleDbConnection conn = new OleDbConnection(sbConnection.ToString());
//            DataTable dt = new DataTable();
//            try
//            {
//                conn.Open();
//                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [" + ListSheetInExcel(filename)[0] + "$]", conn);
//                DataSet ds = new DataSet();
//                da.Fill(ds);
//                dt = ds.Tables[0];
//            }
//            catch (Exception ex)
//            {
//                ShowError(ex);
//            }
//            finally
//            {
//                conn.Close();
//            }
//            return dt;
//        }
//        public static DataTable ExcelToDatatable(string filename, string sheetName)
//        {
//            OleDbConnectionStringBuilder sbConnection = new OleDbConnectionStringBuilder();
//            String strExtendedProperties = String.Empty;
//            sbConnection.DataSource = filename;
//            if (Path.GetExtension(filename).Equals(".xls"))//for 97-03 Excel file
//            {
//                sbConnection.Provider = "Microsoft.Jet.OLEDB.4.0";
//                strExtendedProperties = "Excel 8.0;HDR=Yes;IMEX=1";//HDR=ColumnHeader,IMEX=InterMixed
//            }
//            else //if (Path.GetExtension(filename).Equals(".xlsx"))  //for 2007 Excel file
//            {
//                sbConnection.Provider = "Microsoft.ACE.OLEDB.12.0";
//                strExtendedProperties = "Excel 12.0;HDR=Yes;IMEX=1";
//            }
//            sbConnection.Add("Extended Properties", strExtendedProperties);
//            OleDbConnection conn = new OleDbConnection(sbConnection.ToString());
//            DataTable dt = new DataTable();
//            try
//            {
//                conn.Open();
//                //OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [" + ListSheetInExcel(filename)[0] + "$]", conn);
//                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [" + sheetName.Replace("'", "") + "$]", conn);
//                DataSet ds = new DataSet();
//                da.Fill(ds);
//                dt = ds.Tables[0];
//            }
//            catch (Exception ex)
//            {
//                ShowError(ex);
//            }
//            finally
//            {
//                conn.Close();
//            }
//            return dt;
//        }
//        public void ThayTheExcel(string fileName, string k)
//        {
//            Process[] pro = Process.GetProcessesByName("EXCEL");
//            if (pro.Length > 0)
//            {
//                if (XtraMessageBox.Show("Chương trinhg Excel đang chạy trên máy của bạn.\nXin vui lòng lưu trữ nó trước khi thực hiện công việc này\nẤn Yes để chương trình tự động tắt Excel mà không lưu trữ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
//                {
//                    foreach (Process p in pro)
//                    {
//                        p.Kill();
//                    }
//                    {
//                        Excel.Application objXLApp = default(Excel.Application);
//                        Excel.Workbook objXLWb = default(Excel.Workbook);
//                        Excel.Worksheet objXLWs = default(Excel.Worksheet);

//                        try
//                        {
//                            //------------ Chỉnh sửa nội dung ------------
//                            objXLApp = new Excel.Application();
//                            objXLApp.Workbooks.Open(fileName);
//                            objXLWb = objXLApp.Workbooks[1];
//                            objXLWs = (Excel.Worksheet)objXLWb.Worksheets[1];

//                            objXLWs.Cells[k] = "productName";
//                            objXLApp.Cells[3, 10] = "Mã: ";

//                            objXLApp.ActiveWorkbook.Save();
//                            objXLApp.Workbooks.Close();
//                            objXLApp.Quit();

//                            Process.Start(fileName);
//                        }
//                        catch (Exception ex)
//                        {
//                            XtraMessageBox.Show(ex.Message);
//                        }
//                        finally
//                        {
//                            ReleaseComObject(objXLApp);
//                            ReleaseComObject(objXLWb);
//                            ReleaseComObject(objXLWs);
//                        }
//                    }
//                }
//            }
//        }
//        #endregion Process Excel
//        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//        #region Mails
//        public static bool SetEmailSend(string sSubject, string sBody, string sTo, string sCC, string sFilename, string sDisplayname)
//        {
//            bool isSuccess;
//            try
//            {
//                // Create the Outlook application by using inline initialization.
//                Outlook.Application oApp = new Outlook.Application();
//                //Create the new message by using the simplest approach.
//                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
//                //Add a recipient.
//                // TODO: Change the following recipient where appropriate.
//                Outlook.Recipient oRecip = (Outlook.Recipient)oMsg.Recipients.Add("e-mail address");
//                oRecip.Resolve();
//                //Set the basic properties.
//                oMsg.Subject = sSubject;
//                oMsg.Body = sBody;
//                //Add an attachment.
//                // TODO: change file path where appropriate
//                String sSource = sFilename;
//                int iPosition = (int)oMsg.Body.Length + 1;
//                int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
//                Outlook.Attachment oAttach = oMsg.Attachments.Add(sFilename, iAttachType, iPosition, sDisplayname);
//                //Send the message.
//                oMsg.Save();
//                oMsg.Send();
//                isSuccess = true;
//                //Explicitly release objects.
//                oRecip = null;
//                oAttach = null;
//                oMsg = null;
//                oApp = null;
//            }
//            catch (Exception)
//            {
//                isSuccess = false;
//            }
//            return isSuccess;
//        }
//        public static bool SetEmailSend(string sSubject, string sBody, string sTo)
//        {
//            bool isSuccess;
//            try
//            {
//                //Create the Outlook application by using inline initialization.
//                Outlook.Application oApp = new Outlook.Application();
//                //Create the new message by using the simplest approach.
//                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
//                Outlook.Inspector oInspector = oMsg.GetInspector;
//                //Set the basic properties.
//                oMsg.Subject = sSubject;
//                oMsg.Body = sBody;
//                oMsg.To = sTo;
//                oMsg.Send();
//                isSuccess = true;
//                oMsg = null;
//                oApp = null;
//            }
//            catch (Exception)
//            {
//                isSuccess = false;
//            }
//            return isSuccess;
//        }
//        #endregion Mails
//        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//        #region Process Word

//        public static void ThayTheWord(string[] canthay, string[] thaythebang, string fileName)
//        {
//            Process[] pro = Process.GetProcessesByName("WINWORD");
//            if (pro.Length > 0)
//            {
//                if (
//                    XtraMessageBox.Show(
//                        "Chương trinhg Word đang chạy trên máy của bạn.\nXin vui lòng lưu trữ nó trước khi thực hiện công việc này\nẤn Yes để chương trình tự động tắt Word mà không lưu trữ",
//                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
//                {
//                    foreach (Process p in pro)
//                    {
//                        p.Kill();
//                    }
//                }
//            }
//            {
//                Word.Application word = new Word.Application();
//                word.Visible = true;
//                Word.Document doc = new Word.Document();



//                string dd = "";
//                try
//                {
//                    dd = fileName;

//                    doc = word.Documents.Open((dd));

//                    doc.Activate();
//                    for (int i = 0; i < canthay.Count(); i++)
//                    {
//                        FindReplaceAnywhere(word, canthay[i], thaythebang[i]);
//                    }

//                    doc.Save();
//                    doc.Close();
//                    word.Quit();

//                    Process.Start(dd);
//                }
//                catch (Exception ex)
//                {
//                    XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//                finally
//                {
//                    ReleaseComObject(doc);
//                    ReleaseComObject(word);
//                }
//            }
//        }

//        //using (WaitDialogForm fWait = new WaitDialogForm("Vui lòng chờ trong giây lát...", "Đang tạo biểu mẫu bản vẽ mạch in"))



//        private static void SearchAndReplaceInStory(Word.Range rngStory, string strSearch, string strReplace)
//        {
//            rngStory.Find.ClearFormatting();
//            rngStory.Find.Replacement.ClearFormatting();
//            rngStory.Find.Text = strSearch;
//            rngStory.Find.Replacement.Text = strReplace;
//            rngStory.Find.Wrap = Word.WdFindWrap.wdFindContinue;
//            object arg1 = Type.Missing; // Find Pattern
//            object arg2 = Type.Missing; //MatchCase
//            object arg3 = Type.Missing; //MatchWholeWord
//            object arg4 = Type.Missing; //MatchWildcards
//            object arg5 = Type.Missing; //MatchSoundsLike
//            object arg6 = Type.Missing; //MatchAllWordForms
//            object arg7 = Type.Missing; //Forward
//            object arg8 = Type.Missing; //Wrap
//            object arg9 = Type.Missing; //Format
//            object arg10 = Type.Missing; //ReplaceWith
//            object arg11 = Word.WdReplace.wdReplaceAll; //Replace
//            object arg12 = Type.Missing; //MatchKashida
//            object arg13 = Type.Missing; //MatchDiacritics
//            object arg14 = Type.Missing; //MatchAlefHamza
//            object arg15 = Type.Missing; //MatchControl
//            rngStory.Find.Execute(ref arg1, ref arg2, ref arg3, ref arg4, ref arg5, ref arg6, ref arg7, ref arg8, ref arg9, ref arg10, ref arg11, ref arg12, ref arg13, ref arg14, ref arg15);
//        }
//        public static void FindReplaceAnywhere(Word.Application app, string findText, string replaceText)
//        {
//            var doc = app.ActiveDocument;
//            //Word.WdStoryType lngJunk = doc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.StoryType;
//            foreach (Word.Range rngStory in doc.StoryRanges)
//            {
//                var internalRangeStory = rngStory;
//                do
//                {
//                    SearchAndReplaceInStory(internalRangeStory, findText, replaceText);
//                    try
//                    {
//                        switch (internalRangeStory.StoryType)
//                        {
//                            case Word.WdStoryType.wdEvenPagesHeaderStory: // 6
//                            case Word.WdStoryType.wdPrimaryHeaderStory:   // 7
//                            case Word.WdStoryType.wdEvenPagesFooterStory: // 8
//                            case Word.WdStoryType.wdPrimaryFooterStory:   // 9
//                            case Word.WdStoryType.wdFirstPageHeaderStory: // 10
//                            case Word.WdStoryType.wdFirstPageFooterStory: // 11
//                                if (internalRangeStory.ShapeRange.Count != 0)
//                                {
//                                    foreach (Word.Shape oShp in internalRangeStory.ShapeRange)
//                                    {
//                                        if (oShp.TextFrame.HasText != 0)
//                                        {
//                                            SearchAndReplaceInStory(oShp.TextFrame.TextRange, findText, replaceText);
//                                        }
//                                    }
//                                }
//                                break;
//                            default:
//                                break;
//                        }
//                    }
//                    catch
//                    {
//                    }
//                    internalRangeStory = internalRangeStory.NextStoryRange;
//                } while (internalRangeStory != null);
//            }
//        }
//        public static void RepalaceText(Word.Document doc, string oldtext, string newText)
//        {
//            doc.Content.Find.Execute(oldtext, false, true, false, false, false, true, 1, false, newText, 2,
//            false, false, false, false);
//        }
//        #endregion
//        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//        #region Phân trang
//        /// <summary>
//        /// Phân trang 
//        /// </summary>
//        /// <param name="PageNumber">Trang hiển thị</param>
//        /// <param name="PageSize">Số dòng trên 1 trang</param>
//        /// <param name="TableOrView">Bảng hoặc view</param>
//        /// <param name="OrderBy">OrderBy theo cột nào</param>
//        public static DataTable PhanTrang(int PageNumber, int PageSize, string TableOrView, string OrderBy)
//        {
//            try
//            {
//                string ff = "WITH Results AS (SELECT ROW_NUMBER() OVER(ORDER BY MR." + OrderBy + " DESC) As STT,* FROM " + TableOrView + " MR WITH (NOLOCK)) SELECT * FROM Results R WHERE STT > (" + PageNumber + " * " + PageSize + ") - " + PageSize + " AND STT < (" + PageNumber + " * " + PageSize + ") + 1 ";
//                DataTable dt = Easy.Select(ff);
//                return dt;
//            }
//            catch (Exception ex)
//            {
//                XtraMessageBox.Show(ex.Message);
//                return null;
//            }
//        }
//        public static DataTable PhanTrang(int PageNumber, int PageSize, string TableOrView, string OrderBy, string AscOrDesc, string DieuKienStartWithAND)
//        {
//            try
//            {
//                string ff = "WITH Results AS (SELECT ROW_NUMBER() OVER(ORDER BY MR." + OrderBy + " " + AscOrDesc + ") As STT,* FROM " + TableOrView + " MR WITH (NOLOCK)) SELECT * FROM Results R WHERE STT > (" + PageNumber + " * " + PageSize + ") - " + PageSize + " AND STT < (" + PageNumber + " * " + PageSize + ") + 1 " + DieuKienStartWithAND;
//                DataTable dt = Easy.Select(ff);
//                return dt;
//            }
//            catch (Exception ex)
//            {
//                XtraMessageBox.Show(ex.Message);
//                return null;
//            }
//        }
//        /// <summary>
//        /// Phân trang 
//        /// </summary>
//        /// <param name="PageNumber">Trang hiển thị</param>
//        /// <param name="PageSize">Số dòng trên 1 trang</param>
//        /// <param name="TableOrView">Bảng hoặc view</param>
//        /// <param name="OrderBy">OrderBy theo cột nào</param>
//        /// <param name="AscOrDesc">Tăng dần hay giảm dần</param>
//        /// <returns></returns>
//        public static DataTable PhanTrang(int PageNumber, int PageSize, string TableOrView, string OrderBy, string AscOrDesc)
//        {
//            try
//            {
//                string ff = "WITH Results AS (SELECT ROW_NUMBER() OVER(ORDER BY MR." + OrderBy + " " + AscOrDesc + ") As STT,* FROM " + TableOrView + " MR WITH (NOLOCK)) SELECT * FROM Results R WHERE STT > (" + PageNumber + " * " + PageSize + ") - " + PageSize + " AND STT < (" + PageNumber + " * " + PageSize + ") + 1 ";
//                DataTable dt = Easy.Select(ff);
//                return dt;
//            }
//            catch (Exception ex)
//            {
//                XtraMessageBox.Show(ex.Message);
//                return null;
//            }
//        }

//        /// <summary>
//        /// Trả về số trang dựa vào rows và pageSize
//        /// </summary>
//        /// <param name="rows">Số dòng được chọn</param>
//        /// <param name="pageSize">Số dòng trên 1 trang</param>
//        /// <returns></returns>
//        public static int SoTrang(int rows, int pageSize)
//        {
//            int pageNumber = rows % pageSize != 0 ? rows / pageSize + 1 : rows / pageSize;
//            return pageNumber;
//        }
//        #endregion
//        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//        #region Cac ham xu li khac
//        /// <summary>
//        /// Lấy giá trị trong bảng ConfigSystem
//        /// </summary>
//        /// <param name="keyName">trường đại diện của giá trị</param>
//        /// <returns></returns>
//        /// <summary>
//        /// Khởi tạo thông số để kết nối với đầu đọc thẻ
//        /// </summary>
//        /// <param name="com">Đối tượng xử lý các sự kiện liên quan đến cổng COM</param>
//        /// <param name="displayWindow">Control dùng để hiển thị dữ liệu đọc vào từ đầu đọc</param>
//        public static void InitializeCardReader(ref CommunicationManager com, Control displayWindow)
//        {
//            com = new CommunicationManager();
//            com.BaudRate = "9600";
//            com.DataBits = "8";
//            com.Parity = "None";
//            com.StopBits = "1";
//            com.DisplayWindow = displayWindow;
//            com.CurrentTransmissionType = CommunicationManager.TransmissionType.Text;
//            try
//            {
//                string[] settings = File.ReadAllLines("settings.ini");
//                for (int i = 0; i < settings.Length; i++)
//                {
//                    if (settings[i].StartsWith("COMPort"))
//                        com.PortName = settings[i].Split('=')[1].Trim().ToUpper();
//                }
//            }
//            catch
//            {
//                com.PortName = "COM7";
//                XtraMessageBox.Show("Cổng COM của đầu đọc thẻ chưa được thiết lập!\nCổng mặc định (COM7) sẽ được sử dụng.", Easy.Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            }
//        }
//        /// <summary>
//        /// Hàm trả địa chỉ IP hoặc tên máy hiện tại
//        /// </summary>
//        /// <param name="IP"></param>
//        /// <returns>IP=true: Trả lại địa chỉ IP. IP=false: Trả lại tên máy</returns>
//        public static string GetHostName()
//        {
//            return Dns.GetHostName();
//        }
//        /// <summary>
//        /// Kiểm tra một chuối có phải là định dạng của email không
//        /// </summary>
//        /// <param name="str"></param>
//        /// <returns></returns>
//        public static bool IsEmail(string str)
//        {
//            bool State = true;
//            if (!Regex.IsMatch(str, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
//            {
//                State = false;
//            }
//            return State;
//        }
//        private static string NumberToString(long Num)
//        {
//            string[] Number = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
//            return Number[Num];
//        }
//        public static string NumberToStringH(long Num)
//        {
//            string[] Number = { "không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
//            return Number[Num];
//        }
//        /// <summary>
//        /// Chuyển kiểu số sang kiểu chữ tiếna việt
//        /// </summary>
//        /// <param name="Num"></param>
//        /// <param name="Dau"></param>
//        /// <returns></returns>
//        private static string NumericToString(long Num, bool Dau)
//        {
//            long Tram = (long)Num / 100;
//            long Chuc = (long)(Num % 100) / 10;
//            long Dvi = Num % 10;
//            string Doc = (((Tram == 0) && (Dau)) ? "" : (" " + NumberToString(Tram) + " trăm")) + ((Chuc == 0) ? (((Tram == 0) && Dau) ? "" : ((Dvi == 0) ? "" : " lẻ")) : ((Chuc == 1) ? " mười" : (" " + NumberToString(Chuc) + " mươi"))) + (((Dvi == 5) && (Chuc > 0)) ? " năm" : ((Dvi == 0) ? "" : " " + NumberToString(Dvi)));
//            return Doc;
//        }
//        /// <summary>
//        /// Định dạng số dưới dạng tiền Việt Nam
//        /// </summary>
//        /// <param name="amount"></param>
//        /// <returns></returns>
//        public static string FormatVND(decimal amount)
//        {
//            if (amount == 0) { return "0"; }
//            else
//            {
//                return amount.ToString(Easy.CurrencyFormatVND);
//            }
//        }
//        /// <summary>
//        /// Hiển thị Thông báo lỗi
//        /// </summary>
//        /// <param name="ex"></param>
//        public static void ShowError(Exception ex)
//        {
//            XtraMessageBox.Show(ex.Message, Easy.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//        public static void ShowError(string content)
//        {
//            XtraMessageBox.Show(content, Easy.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//        public static void ReleaseComObject(object obj)
//        {
//            try
//            {
//                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
//                obj = null;
//            }
//            catch (Exception)
//            {
//                obj = null;
//            }
//        }
//        public static void EndProcess(string processName)
//        {
//            Process[] ps = Process.GetProcesses().Where(o => o.ProcessName.Contains(processName)).ToArray();
//            foreach (Process p in ps)
//            {
//                p.Kill();
//            }
//        }

//        #endregion
//        public static void Chay1Lan()
//        {
//            // chương trình chỉ chạy 1 instance
//            Mutex _mut = null;
//            try
//            {
//                _mut = Mutex.OpenExisting(AppDomain.CurrentDomain.FriendlyName);
//            }
//            catch { }
//            if (_mut == null)
//                _mut = new Mutex(false, AppDomain.CurrentDomain.FriendlyName);
//            else
//            {
//                _mut.Close();
//                XtraMessageBox.Show("Chương trình đã được chạy");
//                return;
//            }
//        }

//        /// <summary>
//        /// Chữ chạy
//        /// </summary>
//        /// <param name="str"></param>
//        /// <returns></returns>
//        public static string ChuChay(string str)
//        {
//            return str.Substring(str.Length - (str.Length - 1)) + str.Substring(0, str.Length - (str.Length - 1));
//        }

//        #region Đọc số Tiếng Việt
//        private static string[] mangso = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
//        public static string dochangchuc(double so, bool daydu)
//        {
//            string chuoi = "";
//            int chuc = (int)Math.Floor(so / 10);
//            int donvi = (int)so % 10;
//            if (chuc > 1)
//            {
//                chuoi = " " + mangso[chuc] + " mươi";
//                if (donvi == 1)
//                {
//                    chuoi += " mốt";
//                }
//            }
//            else if (chuc == 1)
//            {
//                chuoi = " mười";
//                if (donvi == 1)
//                {
//                    chuoi += " một";
//                }
//            }
//            else if (daydu && donvi > 0)
//            {
//                chuoi = " lẻ";
//            }
//            if (donvi == 5 && chuc >= 1)
//            {
//                chuoi += " lăm";
//            }
//            else if (donvi > 1 || (donvi == 1 && chuc == 0))
//            {
//                chuoi += " " + mangso[donvi];
//            }
//            return chuoi;
//        }
//        //Đọc block 3 số
//        public static string docblock(double so, bool daydu)
//        {
//            string chuoi = "";
//            int tram = (int)Math.Floor(so / 100);
//            so = so % 100;
//            if (daydu || tram > 0)
//            {
//                chuoi = " " + mangso[tram] + " trăm";
//                chuoi += dochangchuc(so, true);
//            }
//            else
//            {
//                chuoi = dochangchuc(so, false);
//            }
//            return chuoi;
//        }
//        //Đọc số hàng triệu
//        public static string dochangtrieu(double so, bool daydu)
//        {
//            string chuoi = "";
//            int trieu = (int)Math.Floor(so / 1000000);
//            so = so % 1000000;
//            if (trieu > 0)
//            {
//                chuoi = docblock(trieu, daydu) + " triệu ";
//                daydu = true;
//            }
//            double nghin = Math.Floor(so / 1000);
//            so = so % 1000;
//            if (nghin > 0)
//            {
//                chuoi += docblock(nghin, daydu) + " nghìn ";
//                daydu = true;
//            }
//            if (so > 0)
//            {
//                chuoi += docblock(so, daydu);
//            }
//            return chuoi;
//        }

//        //Đọc số
//        /// <summary>
//        /// Đọc số Tiếng Việt
//        /// </summary>
//        /// <param name="so">Kiểu double</param>
//        /// <returns></returns>
//        public static string docso(double so)
//        {
//            if (so == 0) return mangso[0];
//            string chuoi = "", hauto = "";
//            do
//            {
//                double ty = so % 1000000000;
//                so = Math.Floor(so / 1000000000);
//                if (so > 0)
//                {
//                    chuoi = dochangtrieu(ty, true) + hauto + chuoi;
//                }
//                else
//                {
//                    chuoi = dochangtrieu(ty, false) + hauto + chuoi;
//                }
//                hauto = " tỷ ";
//            } while (so > 0);
//            try
//            {
//                if (chuoi.Trim().Substring(chuoi.Trim().Length - 1, 1) == ",")
//                { chuoi = chuoi.Trim().Substring(0, chuoi.Trim().Length - 1); }
//            }
//            catch { }


//            string hungPro = chuoi.Trim();
//            char[] letters = hungPro.ToCharArray();
//            string tmpStr = "", ToProper = "";
//            ToProper = letters[0].ToString().ToUpper();
//            for (int ij = 1; ij < letters.Length; ij++)
//                tmpStr += letters[ij].ToString().ToLower();
//            hungPro = ToProper + tmpStr + " đồng";

//            return hungPro;
//        }
//        #endregion
//        #endregion Methods

//        private void autolist(TextBox txtss1, DataTable dtSource)
//        {
//            try
//            {
//                AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
//                foreach (DataRow dr in dtSource.Rows)
//                {
//                    auto2.Add(dr["Id"].ToString());
//                }
//                txtss1.AutoCompleteMode = AutoCompleteMode.Suggest;
//                txtss1.AutoCompleteSource = AutoCompleteSource.CustomSource;
//                txtss1.AutoCompleteCustomSource = auto2;
//            }
//            catch (Exception ex)
//            {
//                XtraMessageBox.Show(ex.Message, "Lỗi, vui lòng chụp màn hình gửi cho bộ phận IT giải quyết");
//            }
//        }
//    }
//}