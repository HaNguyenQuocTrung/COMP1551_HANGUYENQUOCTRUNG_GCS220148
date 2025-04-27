using COMP1551_HANGUYENQUOCTRUNG_FINAL;
using System;
using System.Windows.Forms;

namespace COMP1551_HANGUYENQUOCTRUNG_FINAL
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

