using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Color = Aspose.Imaging.Color;
using Image = Aspose.Imaging.Image;

namespace EMF_to_SVG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openEmfBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "EMF files (*.emf)|*.emf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.selectedEMFBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void saveSVGBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "SVG files (*.svg)|*.svg";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.outputSVGFileBox.Text = saveFileDialog.FileName;

                    EMF_SVG(this.selectedEMFBox.Text, this.outputSVGFileBox.Text);
                }
            }
        }

        private void EMF_SVG(string inEMF, string outSVG)
        {

            //// Path to input EMF file
            //string sourcePath = dataDir + @"test.emf";

            //// Path for output SVG image
            //string destPath = dataDir + @"EMF_out.svg";

            // Load input EMF file
            using (Image image = Image.Load(inEMF))
            {
                // Initilaize EmfRasterizationOptions class object
                EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();

                emfRasterizationOptions.BackgroundColor = image.BackgroundColor;
                emfRasterizationOptions.PageWidth = image.Width;
                emfRasterizationOptions.PageHeight = image.Height;

                // Save output SVG image
                image.Save(outSVG, new SvgOptions() { VectorRasterizationOptions = emfRasterizationOptions });
            }
        }
    }
}
