using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProcessesApp
{
    public partial class Form1 : Form
    {
        public SynchronizationContext uiContext;
        public Form1()
        {
            InitializeComponent();
            // Получим контекст синхронизации для текущего потока 
            uiContext = SynchronizationContext.Current;
            uiContext.Send(d => activeProcessList.Items.Clear(), null);
            Process[] lp = Process.GetProcesses();
            foreach (Process p in lp) // список всех процессов, запущенных в системе
            {
                // uiContext.Send отправляет синхронное сообщение в контекст синхронизации
                // SendOrPostCallback - делегат указывает метод, вызываемый при отправке сообщения в контекст синхронизации. 
                uiContext.Send(d => activeProcessList.Items.Add(p.ProcessName) /* Вызываемый делегат SendOrPostCallback */,
                    null /* Объект, переданный делегату */);// получим имя очередного процесса
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    uiContext.Send(d => activeProcessList.Items.Clear(), null);
                    Process[] lp = Process.GetProcesses();
                    foreach (Process p in lp) // список всех процессов, запущенных в системе
                    {
                        // uiContext.Send отправляет синхронное сообщение в контекст синхронизации
                        // SendOrPostCallback - делегат указывает метод, вызываемый при отправке сообщения в контекст синхронизации. 
                        uiContext.Send(d => activeProcessList.Items.Add(p.ProcessName) /* Вызываемый делегат SendOrPostCallback */,
                            null /* Объект, переданный делегату */);// получим имя очередного процесса
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (activeProcessList.SelectedIndex == -1)  //Если процесс не выбран
            {
                MessageBox.Show("You didn't chosen any process to delete.");

                return;
            }

            // To kill all processes by name
            Process[] ps = Process.GetProcessesByName(activeProcessList.Text);
            foreach (Process p in ps) p.Kill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // создаем новый процесс
                Process proc = new Process();
                // Запускаем процесс
                proc.StartInfo.FileName = textBox1.Text;
                //proc.StartInfo.Arguments = Application.ExecutablePath;
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}