using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;//для Mutex

namespace FibonacciNumbers
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool onlyInstance;

            Mutex mtx = new Mutex(true, "FibonacciNumbersProgram", out onlyInstance); // используйте имя вашего приложения

            // Манипуляции, чтобы программу нельзя было запустить повторно:
            // Если другие процессы не владеют мьютексом, то
            // приложение запущено в единственном экземпляре
            if (onlyInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FibonacciNumbers());
            }
            else
            {
                MessageBox.Show(
                   "Приложение уже запущено",
                   "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
