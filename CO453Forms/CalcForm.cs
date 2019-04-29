using System;
using System.Drawing;
using System.Windows.Forms;

namespace CO453Forms
{
    public partial class CalcForm : Form
    {
        private double number1;
        private double number2;
        private double result;

        public CalcForm()
        {
            InitializeComponent();
        }

        private void AddNumbers(object sender, EventArgs e)
        {
            GetNumbers();

            ClearPicture();

            result = number1 + number2;
            ShowResult();

            addPictureBox.Visible = true;
            RandomColor();
        }

        private void GetNumbers()
        {
            number1 = Convert.ToDouble(firstNumberTextBox.Text);
            number2 = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void QuitForm(object sender, EventArgs e)
        {
            //Close();
            QuitForm quit = new QuitForm();
            quit.Show();
        }

        private void SubtractNumbers(object sender, EventArgs e)
        {
            GetNumbers();

            ClearPicture();

            result = number1 - number2;
            ShowResult();

            subtractPictureBox.Visible = true;
            RandomColor();
        }

        private void ShowResult()
        {
            resultTextBox.Text = result.ToString("0.##");
        }

        private void MultiplyNumbers(object sender, EventArgs e)
        {
            GetNumbers();

            ClearPicture();

            result = number1 * number2;
            ShowResult();

            multiplyPictureBox.Visible = true;
            RandomColor();
        }

        private void DivisionNumbers(object sender, EventArgs e)
        {
            GetNumbers();

            ClearPicture();

            if (number2 == 0)
            {
                messageLabel.Text = "You can't devide by zero.";
            }
            else
            {
                result = number1 / number2;
                messageLabel.Text = "";
                ShowResult();

                dividePictureBox.Visible = true;
                RandomColor();
            }
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            SplashForm splash = new SplashForm();
            splash.ShowDialog();
            //System.Threading.Thread.Sleep(2000);
            //splash.Close();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            GetNumbers();

            result = Math.Pow(number1, number2);
            resultTextBox.Text = result.ToString();
        }

        /// <summary>
        /// Sets back each PictureBox.Visible to false clearing the screen
        /// </summary>
        private void ClearPicture()
        {
            addPictureBox.Visible = false;
            subtractPictureBox.Visible = false;
            multiplyPictureBox.Visible = false;
            dividePictureBox.Visible = false;
        }

        /// <summary>
        /// Generates random color and set it as background
        /// </summary>
        private void RandomColor()
        {
            Random rnd = new Random();

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            BackColor = randomColor;
        }
    }
}