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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void runTimer(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value == 100)
                timer.Stop();
        }
    }
}