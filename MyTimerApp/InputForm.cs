using System;
using System.Windows.Forms;

namespace MyTimerApp
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string errorMessage;
            if (TrytoParseNumber(userInputTextBox.Text, out errorMessage))
            {
                Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
                userInputTextBox.Clear();
            }
        }

        private bool TrytoParseNumber(string userInput, out string errorMessage)
        {

            try
            {
                int number = int.Parse(userInput);
                errorMessage = "";
                return true;
            }
            catch (FormatException)
            {
                errorMessage = "Ошибка! Введите число!";
                return false;
            }
            catch (OverflowException)
            {
                errorMessage = "Ошибка! Слишком большое число!";
                return false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
