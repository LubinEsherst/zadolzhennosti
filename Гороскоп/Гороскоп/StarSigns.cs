using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гороскоп
{
    public partial class StarSigns : Form
    {
        public StarSigns(string ss)//Принимаю перемённую через конструктор и в лейбл передаю текст
        {
            InitializeComponent();
            txtText.Text = ss;
        }
    }
}
