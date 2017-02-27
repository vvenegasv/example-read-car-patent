using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using VehicleRegistrationPlate.Core.Implementations;
using VehicleRegistrationPlate.Core.Interfaces;

namespace VehicleRegistrationPlate
{
    public partial class frmVehiclePlateReader : Form
    {
        private string _workingArea;
        private string _currentImagePath;
        private ICarRegistrationPlateReader _carRegistrationPlateReader;

        public frmVehiclePlateReader()
        {
            InitializeComponent();
        }

        private void btnWorkingArea_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtWorkingArea.Text = fbd.SelectedPath;
                    _workingArea = fbd.SelectedPath;
                    grpSelector.Enabled = true;
                }
            }

        }

        private void pictureToScan_Click(object sender, EventArgs e)
        {
            PickImage();
        }

        private void lblEmptyMessage_Click(object sender, EventArgs e)
        {
            PickImage();
        }

        private void PickImage()
        {
            var dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                _currentImagePath = dialog.FileName;
                pictureToScan.ImageLocation = dialog.FileName;
                pictureToScan.SizeMode = PictureBoxSizeMode.StretchImage;
                lblEmptyMessage.Visible = false;
                lblEmptyMessage.Enabled = false;
                GetCarPlate();
            }
        }

        private void GetCarPlate()
        {
            try
            {
                _carRegistrationPlateReader = new RegistrationPlateAPLRReader(_workingArea);
                var carPlate = _carRegistrationPlateReader.GetPlate(_currentImagePath);
                lblPatente.Text = string.Format("Patente: {0}", carPlate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
