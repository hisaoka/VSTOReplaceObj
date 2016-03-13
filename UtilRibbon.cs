using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Core  = Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ReplaceText
{
    public partial class UtilRibbon
    {
        private void UtilRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void buttonAsReplaceObj_Click(object sender, RibbonControlEventArgs e)
        {
            //オーナーのWindowを取得
            NativeWindow mainWindow = new NativeWindow();
            mainWindow.AssignHandle(Process.GetCurrentProcess().MainWindowHandle);

            //フォームをExcelの子供として起動
            var form = new ReplaceObjectForm();
            form.Show(mainWindow);

            mainWindow.ReleaseHandle();
        }


    }
}
