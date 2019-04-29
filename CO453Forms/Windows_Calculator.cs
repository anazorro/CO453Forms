using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453Forms
{
    public partial class Windows_Calculator : Form
    {
        public Double result = 0;

        public String operation = "";

        public bool operationButtonIsClicked = false;

        public Windows_Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will print the 'text' of each button that is 
        /// clicked (in this case numbers) in the displayTextBox.
        /// It will also clear the displayTextBox at the start and
        /// everytime an operationButtonIsClicked. 
        /// </summary>
        private void NumberButtons(object sender, EventArgs e)
        {
            if((displayTextBox.Text == "0") || (operationButtonIsClicked))
            {
                displayTextBox.Clear();
            }

            operationButtonIsClicked = false;
            Button button = (Button)sender;
            displayTextBox.Text = displayTextBox.Text + button.Text;
        }

        /// <summary>
        /// This method will perform any operation
        /// </summary>
        private void OperatorButtons(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(displayTextBox.Text);

            operationLabel.Text = result + " " + operation;
            operationButtonIsClicked = true;
        }

        /// <summary>
        /// This method will clear the displayTextBox
        /// </summary>
        private void ClearButton(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            result = 0;
        }

        /// <summary>
        /// This method will calculate and show the result 
        /// in the displayTextBox
        /// </summary>
        private void EqualTo(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "/":
                    displayTextBox.Text = (result / Double.Parse(displayTextBox.Text)).ToString();
                    break;
                case "*":
                    displayTextBox.Text = (result * Double.Parse(displayTextBox.Text)).ToString();
                    break;
                case "-":
                    displayTextBox.Text = (result - Double.Parse(displayTextBox.Text)).ToString();
                    break;
                case "+":
                    displayTextBox.Text = (result + Double.Parse(displayTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}