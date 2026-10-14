using System;
using System.Windows.Forms;

namespace Quanlyphongtromini
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            while (true)
            {
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;
                }

                var main = new MainForm();
                Application.Run(main);
                if (!main.DangXuat) break;
            }
        }
    }
}