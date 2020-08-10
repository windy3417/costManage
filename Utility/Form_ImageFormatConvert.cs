using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace utility

{
    public partial class Form_imageFormatConvert : Form
    {
        public Form_imageFormatConvert()
        {
            InitializeComponent();
        }

        private void toolStripButton_openFile_Click(object sender, EventArgs e)
        {
            string stringFileName = this.opengImageFiles();
          
            if (stringFileName != string.Empty)
            {
                try
                {
                   this.pictureBox1.Load(stringFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        /// <summary>
        /// 打开文件，返回文件的绝对路径
        /// </summary>
        /// <returns></returns>
        private string opengImageFiles()
        {
            OpenFileDialog openFileDialogImage = new OpenFileDialog();
            openFileDialogImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            openFileDialogImage.ShowDialog();
            return openFileDialogImage.FileName;//返回文件的绝对路径
        }

        private void toolStripButton_convertFormat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
