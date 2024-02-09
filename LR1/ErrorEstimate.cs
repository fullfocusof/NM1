using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class ErrorEstimate : Form
    {
        float value, absError, relatError;

        public ErrorEstimate()
        {
            InitializeComponent();
        }

        private void textBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            labelValue.ForeColor = Color.Black;
            labelAbsError.ForeColor = Color.Black;
            labelRelatError.ForeColor = Color.Black;

            if (textBoxValue.Text == string.Empty)
            {
                labelValue.ForeColor = Color.Red;
                labelError.Text = "***Введите значение***";
                labelError.Visible = true;

                return;
            }

            if (textBoxAbsError.Text == string.Empty && textBoxRelatError.Text == string.Empty)
            {
                labelAbsError.ForeColor = Color.Red;
                labelRelatError.ForeColor = Color.Red;
                labelError.Text = "***Введите значение***";
                labelError.Visible = true;

                return;
            }

            if (!(textBoxAbsError.Text == string.Empty) && textBoxRelatError.Text == string.Empty)
            {
                value = float.Parse(textBoxValue.Text);
                absError = float.Parse(textBoxAbsError.Text);

                relatError = absError / Math.Abs(value) * 100;

                textBoxRelatError.Text = relatError.ToString();
            }
            else if (textBoxAbsError.Text == string.Empty && !(textBoxRelatError.Text == string.Empty))
            {
                value = float.Parse(textBoxValue.Text);
                relatError = float.Parse(textBoxRelatError.Text);

                if (relatError > 100)
                {
                    labelRelatError.ForeColor = Color.Red;
                    labelError.Text = "***Неверные данные***";
                    labelError.Visible = true;

                    return;
                }

                absError = relatError * Math.Abs(value) / 100;

                textBoxAbsError.Text = absError.ToString();
            }
            else if (!(textBoxAbsError.Text == string.Empty) && !(textBoxRelatError.Text == string.Empty))
            {
                labelAbsError.ForeColor = Color.Red;
                labelRelatError.ForeColor = Color.Red;
                labelError.Text = "***Введите одно из значений***";
                labelError.Visible = true;

                return;
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = string.Empty;
            textBoxAbsError.Text = string.Empty;
            textBoxRelatError.Text = string.Empty;
        }
    }
}
