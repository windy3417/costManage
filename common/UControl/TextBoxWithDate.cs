using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace U8Common.UControl
{
    public partial class TextBoxWithDate : UserControl
    {
        public TextBoxWithDate()
        {
            InitializeComponent();
          

        }
        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_startDate.CustomFormat = "yyyy-mm-dd";
            dateTimePicker_startDate.Format = DateTimePickerFormat.Custom;
            textBox_startDate.Text = dateTimePicker_startDate.Value.ToString().Substring(0, 10);

        }
    }
}
