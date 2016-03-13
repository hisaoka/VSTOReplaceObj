using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Core = Microsoft.Office.Core;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;


namespace ReplaceText
{
    public partial class ReplaceObjectForm : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        private static extern int GetWindowRect(IntPtr hwnd, ref RECT lpRect);

        public ReplaceObjectForm()
        {
            InitializeComponent();
        }

        // 直接Excelのオブジェクトをスレッドで処理できない。ＵＩスレッドで行う。
        // https://msdn.microsoft.com/ja-jp/library/8sesy69e.aspx

        //private async void buttonAsReplaceAll_Click(object sender, EventArgs e)
        //{
        //    await Task.Run(() =>
        //    {
        //        ReplaceObj(this.textBoxAsFrom.Text, this.textBoxAsTo.Text);
        //    });
        //}


        //private void buttonAsReplaceAll_Click(object sender, EventArgs e)
        //{
        //    Task.Factory.StartNew(() =>
        //        ReplaceObj(this.textBoxAsFrom.Text, this.textBoxAsTo.Text));
        //}

        private void buttonAsReplaceAll_Click(object sender, EventArgs e)
        {
            ReplaceObj(this.textBoxAsFrom.Text, this.textBoxAsTo.Text);
        }

        //ワークシート上のshapeをすべて置き換える
        //  ⇒数が多量の場合は、何か考える。
        private void ReplaceObj(string strFrom, string strTo) 
        {
            //Excelのアクティブワークシートを取得
            Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Globals.ThisAddIn.Application.ActiveSheet);
            foreach (Excel.Shape shape in activeWorksheet.Shapes)
            {
                //文字列が含まれている場合だけ処理する
                if (shape.TextFrame2.HasText == Core.MsoTriState.msoTrue)
                {
                    //シェイプのテキストを置き換える
                    string strTmp = shape.TextFrame2.TextRange.Text.Replace(strFrom, strTo);
                    shape.TextFrame2.TextRange.Text = strTmp;
                }
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;

            //空の変換はやらない。
            if (this.textBoxAsFrom.Text.Length == 0) 
            {
                this.buttonAsReplaceAll.Enabled = false;
            }

            //位置をメインWindowの下にくっつける
            IntPtr hwnd = Process.GetCurrentProcess().MainWindowHandle;
            RECT rect = new RECT();
            GetWindowRect(hwnd, ref rect);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(rect.left + 100, rect.bottom - 200);
        }

        private void textBoxAsFrom_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxAsFrom.Text.Length == 0) 
            {
                this.buttonAsReplaceAll.Enabled = false;
            }
            else {
                this.buttonAsReplaceAll.Enabled = true; 
            }
        }


    }
}
