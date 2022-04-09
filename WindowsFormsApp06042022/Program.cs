using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp06042022
{
    static class Program
    {
        static DialogResult ShowMessageBoxes()
        {
            //1
            string message = "Окно, отображающее текстовое сообщение";
            MessageBox.Show(message);
            //2
            message = "Окно с текстом и двумя кнопками OK и CANCEL";
            string _caption = "Окно с двумя кнопками";
            DialogResult result =result= MessageBox.Show(message,_caption, MessageBoxButtons.OKCancel);
            string _button = result.ToString();// передает название кнопки
            //3
            result = result = MessageBox.Show("Вы нажали кнопку"+_button+ "Повторить?", _button, MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
            return result;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DialogResult result;
            do
            {
                result = ShowMessageBoxes();
            } while (result == DialogResult.Retry);


            //DialogResult result = new DialogResult();
            //do
            //{
            //    result = MessageBox.Show("При доступе к диску произошла ошибка", "Ошибка", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            //    if (result == DialogResult.Abort)
            //    {
            //        MessageBox.Show("Вы нажали кнопку ПРЕРВАТЬ");
            //    }
            //    else if (result == DialogResult.Retry)
            //    {
            //        MessageBox.Show("Вы нажали кнопку ПОВТОРИТЬ");
            //    }
            //    if (result == DialogResult.Ignore)
            //    {
            //        MessageBox.Show("Вы нажали кнопку ПРОПУСТИТЬ");
            //    }
            //} while (result ==DialogResult.Retry);
            
        }
    }
}
