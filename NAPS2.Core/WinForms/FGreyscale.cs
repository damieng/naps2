using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NAPS2.Scan.Images;
using NAPS2.Scan.Images.Transforms;
using NAPS2.Util;

namespace NAPS2.WinForms
{
    partial class FGreyscale : ImageForm
    {
        public FGreyscale(ChangeTracker changeTracker, ScannedImageRenderer scannedImageRenderer)
            : base(changeTracker, scannedImageRenderer)
        {
            InitializeComponent();
            ActiveControl = txtRed;
            ResetTransform();
        }

        public GrayscaleTransform GreyscaleTransform { get; private set; }

        protected override IEnumerable<Transform> Transforms => new[] { GreyscaleTransform };

        protected override PictureBox PictureBox => pictureBox;

        protected override void ResetTransform()
        {
            GreyscaleTransform = new GrayscaleTransform();

            var red = GreyscaleTransform.RedWeighting;
            var green = GreyscaleTransform.GreenWeighting;
            var blue = GreyscaleTransform.BlueWeighting;

            tbRed.Value = (int)(red * 1000);
            txtRed.Text = tbRed.Value.ToString();

            tbGreen.Value = (int)(green * 1000);
            txtGreen.Text = tbGreen.Value.ToString();

            tbBlue.Value = (int)(blue * 1000);
            txtBlue.Text = tbBlue.Value.ToString();
        }

        private void UpdateTransform()
        {
            GreyscaleTransform.RedWeighting = tbRed.Value / 1000f;
            GreyscaleTransform.GreenWeighting = tbGreen.Value / 1000f;
            GreyscaleTransform.BlueWeighting = tbBlue.Value / 1000f;
            UpdatePreviewBox();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            txtRed.Text = tbRed.Value.ToString("G");
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            txtGreen.Text = tbGreen.Value.ToString("G");
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            txtBlue.Text = tbBlue.Value.ToString("G");
        }

        private void txtRed_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtRed.Text, out int value))
            {
                if (value >= tbRed.Minimum && value <= tbRed.Maximum)
                {
                    tbRed.Value = value;
                }
            }
            UpdateTransform();
        }

        private void txtGreen_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtGreen.Text, out int value))
            {
                if (value >= tbGreen.Minimum && value <= tbGreen.Maximum)
                {
                    tbGreen.Value = value;
                }
            }
            UpdateTransform();
        }

        private void txtBlue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBlue.Text, out int value))
            {
                if (value >= tbBlue.Minimum && value <= tbBlue.Maximum)
                {
                    tbBlue.Value = value;
                }
            }
            UpdateTransform();
        }
    }
}
