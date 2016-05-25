using System;
using System.Windows.Forms;

namespace Enigma {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            string[] args = Environment.GetCommandLineArgs();
            if(args.Length > 1) {
                if(args[1].ToLower() == "/h") {
                    Console.WriteLine(@"
using:
enigma.exe [ text [ /r rotors [ /p pos ]]]
            /r rotors - количество роторов машины (3 или 4)
            /p pos    - начальная конфигурация роторов, например, ABC для 3 роторов
");
                }
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }
    }
}
