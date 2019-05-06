using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tesseract;


namespace OCRProject
{
    public partial class frmOCR_Project : Form
    {
        public frmOCR_Project()
        {
            InitializeComponent();
        }

        private void frmOCR_Project_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFileSelect_Click(object sender, EventArgs e) //method to search for a file to read
        {
            OpenFileDialog fileSearch = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Select an image file",

                CheckFileExists = true,
                CheckPathExists = true,

                /*DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,*/

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (fileSearch.ShowDialog() == DialogResult.OK)
            {
                if (fileSearch.FileName.EndsWith(".bmp") 
                    || fileSearch.FileName.EndsWith(".jpg") 
                    || fileSearch.FileName.EndsWith(".jpeg") 
                    || fileSearch.FileName.EndsWith(".png"))
                {
                    txtFilePath.Text = fileSearch.FileName;
                }
                else
                {
                    txtFilePath.Text = "You have selected an invalid file, please select an image";
                }

                
            }
        }

        private void Read_Click(object sender, EventArgs e) //method to read the file itself
        {
            /* I will leave notes of the *specific* error I am encountering and information here
             https://github.com/charlesw/tesseract
             https://github.com/charlesw/tesseract/wiki/Error-1
             */

            var image = new Bitmap(txtFilePath.Text); //image location
            var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.Default); //we may need to change the file path

            var page = ocr.Process(image); //image processing
            txtTextOutPut.Text = page.GetText(); //adding the text to the form
        }
    }
}
