using System;
using System.Diagnostics;

namespace El_Hamla
{
    class CLStelegram
    {
        private Process _consoleProcess;

        public void RunConsoleApp()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"E:\برنامج الحملة\البرنامج\التلجرام\TelegramBotTester-master\TelegramBotTester-master\bin\Debug\net7.0\TelegramBotTester.exe"; // Path to your console app

            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true; // Optional: if you want to capture the output
            startInfo.CreateNoWindow = true; // Optional: if you don't want to create a new window

            _consoleProcess = Process.Start(startInfo);
        }

        public void StopConsoleApp()
        {
            if (_consoleProcess != null && !_consoleProcess.HasExited)
            {
                _consoleProcess.Kill();
                _consoleProcess.Dispose();
            }
        }
    }
}
