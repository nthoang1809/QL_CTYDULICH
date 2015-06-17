//using DevExpress.XtraEditors;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using DevExpress.XtraSplashScreen;

//namespace TienIch
//{
//    public class EasyDialog
//    {
//        #region Dialog
//        /// <summary>
//        /// Hiện msg box (yes/no)
//        /// </summary>
//        /// <param name="caption">Nội dung cần thông báo</param>
//        /// <returns>DialogResult</returns>
//        public static DialogResult ShowYesNoDialog(string caption)
//        {
//            return XtraMessageBox.Show(caption, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//        }
//        /// <summary>
//        /// Hiện msg box thông báo thao tác thành công
//        /// </summary>
//        /// <param name="action">Lưu/Xóa/Sửa/...</param>
//        /// <returns>DialogResult</returns>
//        public static DialogResult ShowSuccessfulDialog(string action)
//        {
//            return XtraMessageBox.Show(action, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }
//        /// <summary>
//        /// Hiện msg box thông báo thao tác không thành công
//        /// </summary>
//        /// <param name="action">Lưu/Xóa/Sửa/...</param>
//        /// <returns>DialogResult</returns>
//        public static DialogResult ShowUnsuccessfulDialog(string action)
//        {
//            return XtraMessageBox.Show(action, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//        }
//        /// <summary>
//        ///  Hiện msg box thông báo lỗi
//        /// </summary>
//        /// <param name="caption"></param>
//        /// <returns></returns>
//        public static DialogResult ShowErrorDialog(string caption)
//        {
//            return XtraMessageBox.Show(caption, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//        /// <summary>
//        /// Hiện msg box cảnh báo
//        /// </summary>
//        /// <param name="caption"></param>
//        /// <returns></returns>
//        public static DialogResult ShowWarningDialog(string caption)
//        {
//            return XtraMessageBox.Show(caption, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//        }
//        public static DialogResult ShowInfoDialog(string caption)
//        {
//            return XtraMessageBox.Show(caption, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }
//        public static DialogResult ShowYesNoCancelDialog(string caption)
//        {
//            return XtraMessageBox.Show(caption, "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
//        } 
//        #endregion

//        #region WaitForm
//        public static void ShowWaitForm()
//        {
//            if (SplashScreenManager.Default != null) return;
//            SplashScreenManager.ShowForm(typeof(FrmWait));
//        }

//        public static void ShowWaitForm(string description)
//        {
//            if (SplashScreenManager.Default != null)
//                if (SplashScreenManager.Default.IsSplashFormVisible)
//                {
//                    SplashScreenManager.Default.SetWaitFormDescription(description);
//                    return;
//                }
//            SplashScreenManager.ShowForm(typeof(FrmWait));
//            if (SplashScreenManager.Default != null) SplashScreenManager.Default.SetWaitFormDescription(description);
//        }

//        //public static void ShowWaitForm(string description, Form parentForm)
//        //{
//        //    if (SplashScreenManager.Default != null)
//        //        if (SplashScreenManager.Default.IsSplashFormVisible)
//        //        {
//        //            SplashScreenManager.Default.SetWaitFormDescription(description);
//        //            return;
//        //        }

//        //    SplashScreenManager.ShowForm(parentForm, typeof(FrmWait));
//        //    if (SplashScreenManager.Default != null) SplashScreenManager.Default.SetWaitFormDescription(description);
//        //}

//        public static void SetWaitFormDescription(string description)
//        {
//            if (SplashScreenManager.Default != null)
//                if (SplashScreenManager.Default.IsSplashFormVisible)
//                    SplashScreenManager.Default.SetWaitFormDescription(description);
//        }

//        public static void CloseWaitForm()
//        {
//            if (SplashScreenManager.Default != null)
//                if (SplashScreenManager.Default.IsSplashFormVisible)
//                {
//                    SplashScreenManager.CloseForm();
//                }
//        }
//        #endregion

//        #region SplashForm
//        public static void ShowSplashForm()
//        {
//            if (SplashScreenManager.Default != null) return;
//            SplashScreenManager.ShowForm(typeof(FrmSplashScreen));
//        }
//        public static void ShowSplashForm(string description)
//        {
//            if (SplashScreenManager.Default != null)
//            {
//                var type = SplashScreenManager.Default.GetType();
//                SplashScreenManager.Default.SendCommand(null, description);
//                return;
//            }
//            SplashScreenManager.ShowForm(typeof(FrmSplashScreen));
//        }

//        public static void CloseSplashForm()
//        {
//            if (SplashScreenManager.Default != null)
//                SplashScreenManager.CloseForm();
//        }

//        #endregion
//    }
//}
