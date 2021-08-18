using System;
using System.Windows.Forms;

namespace MyTimerApp
{
    public partial class InputForm : Form
    {
        public string[] date;
        public InputForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            date = userInputTextBox.Text.Split(':');
            if (!CheckingInput(date, out string errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                date = userInputTextBox.Text.Split(':');
                Close();
            }
        }

        private bool CheckingInput(string [] date, out string errorMessage)
        {
            for (int i = 0; i < date.Length; i++)
            {
                if (!TrytoParseNumber(date[i]))
                {
                    errorMessage = "Ошибка! Неверный формат данных";
                    return false;
                }
            }
            errorMessage = "";
            return true;
        }
        public static bool TrytoParseNumber(string userInput)
        {
            int number;
            try
            {
                number = int.Parse(userInput);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
