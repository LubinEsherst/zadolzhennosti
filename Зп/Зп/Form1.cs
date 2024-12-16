using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            int tax = Convert.ToInt32(txtTax.Text);
            if (tax < 0 || tax > 100)
            {
                lbTax.Visible = true;
            }
            else
            {
                lbTax.Visible = false;
            }
            if (cmbExperience.SelectedIndex != -1 && cmbDischarge.SelectedIndex != -1 && cmbHours.SelectedIndex != -1 && cmbQuantity.SelectedIndex != -1 && txtPayment.Text != "" && lbTax.Visible == false&&lbTax.Text!="")
            {
                butZ.Enabled = true;
            }
        }

        private void butZ_Click(object sender, EventArgs e)
        {
            int Accrued = 0;
            //В зависимости от стажа работы сотрудника начисляем надбавку
            if (cmbExperience.SelectedIndex == 1)
            {
                Accrued += 2000;
            }
            else if (cmbExperience.SelectedIndex == 2)
            {
                Accrued += 4000;
            }
            //В зависимости от разряда работника сотрудника начисляем надбавку
            if (cmbDischarge.SelectedIndex == 1)
            {
                Accrued += 2000;
            }
            else if (cmbDischarge.SelectedIndex == 2)
            {
                Accrued += 4000;
            }
            int payment = Convert.ToInt32(txtPayment.Text);//Оплата одного часа
            int quantity = Convert.ToInt32(cmbQuantity.SelectedIndex + 1);//Кол-во рабочих дней
            if (cmbHours.SelectedIndex == 0)//В зависимости от рабочих часов считаем зп
            {
                Accrued += payment * 6 * quantity;
            }
            else if (cmbHours.SelectedIndex == 1)
            {
                Accrued += payment * 8 * quantity;
            }
            int tax = Convert.ToInt32(txtTax.Text);//Налог
            txtAccrued.Text = $"{Accrued}";
            txtWithheld.Text = $" {Accrued * tax / 100f}";
            txtIssued.Text = $" {Accrued - Accrued * tax / 100f}";
        }

        private void cmbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExperience.SelectedIndex != -1 && cmbDischarge.SelectedIndex != -1 && cmbHours.SelectedIndex != -1 && cmbQuantity.SelectedIndex != -1 && txtPayment.Text != "" && lbTax.Visible == false && lbTax.Text != "")
            {
                butZ.Enabled = true;
            }
        }

        private void cmbHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExperience.SelectedIndex != -1 && cmbDischarge.SelectedIndex != -1 && cmbHours.SelectedIndex != -1 && cmbQuantity.SelectedIndex != -1 && txtPayment.Text != "" && lbTax.Visible == false && lbTax.Text != "")
            {
                butZ.Enabled = true;
            }
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            if (cmbExperience.SelectedIndex != -1 && cmbDischarge.SelectedIndex != -1 && cmbHours.SelectedIndex != -1 && cmbQuantity.SelectedIndex != -1 && txtPayment.Text != "" && lbTax.Visible == false && lbTax.Text != "")
            {
                butZ.Enabled = true;
            }
        }

        private void cmbDischarge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExperience.SelectedIndex != -1 && cmbDischarge.SelectedIndex != -1 && cmbHours.SelectedIndex != -1 && cmbQuantity.SelectedIndex != -1 && txtPayment.Text != "" && lbTax.Visible == false && lbTax.Text != "")
            {
                butZ.Enabled = true;
            }
        }

        private void cmbExperience_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExperience.SelectedIndex != -1 && cmbDischarge.SelectedIndex != -1 && cmbHours.SelectedIndex != -1 && cmbQuantity.SelectedIndex != -1 && txtPayment.Text != "" && lbTax.Visible == false && lbTax.Text != "")
            {
                butZ.Enabled = true;
            }
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void txtTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
