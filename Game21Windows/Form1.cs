using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game21Windows
{
    public partial class FormMain : Form
    {
        Random rnd = new Random();
        int number = 13;
        int sumPoints = 0;
        int countStep = 0;

        public FormMain()
        {
            InitializeComponent();
            number = rnd.Next(1, 14);
            labelCard.Text = number.ToString();
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
           
            sumPoints = sumPoints + number;
            labelSum.Text = sumPoints.ToString();
            countStep += 1;
            labelCountStep.Text = countStep.ToString();
            if (countStep > 10)
            {
                MessageBox.Show("Ты проиграл!");
                sumPoints = 0;
                labelSum.Text = sumPoints.ToString();
                countStep = 0;
                labelCountStep.Text = countStep.ToString();
            }
            if (sumPoints == 21)
            {
                MessageBox.Show("Ура! Ты победил!");
                sumPoints = 0;
                labelSum.Text = sumPoints.ToString();
                countStep = 0;
                labelCountStep.Text = countStep.ToString();
            }
            if (sumPoints > 21)
            {
                MessageBox.Show("Ты проиграл!");
                sumPoints = 0;
                labelSum.Text = sumPoints.ToString();
                countStep = 0;
                labelCountStep.Text = countStep.ToString();
            }
            number = rnd.Next(1, 14);
            labelCard.Text = number.ToString();
        }

        private void buttonNotTake_Click(object sender, EventArgs e)
        {
            number = rnd.Next(1, 14);
            labelCard.Text = number.ToString();
            countStep += 1;
            labelCountStep.Text = countStep.ToString();
            if (countStep > 10)
            {
                MessageBox.Show("Ты проиграл!");
                sumPoints = 0;
                labelSum.Text = sumPoints.ToString();
                countStep = 0;
                labelCountStep.Text = countStep.ToString();
            }
        }
    }
}
