using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MugenMvvmToolkit;
using MugenMvvmToolkit.WinForms.Infrastructure;
using RSL.ViewModels;

namespace RSL
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var bootstrapper = new Bootstrapper<MainViewModel>(new MugenContainer());
            bootstrapper.Start();
        }
    }
}
