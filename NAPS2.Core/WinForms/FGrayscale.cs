using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NAPS2.Scan.Images;
using NAPS2.Scan.Images.Transforms;
using NAPS2.Util;

namespace NAPS2.WinForms
{
    partial class FGrayscale : ImageForm
    {
        public FGrayscale(ChangeTracker changeTracker, ScannedImageRenderer scannedImageRenderer)
            : base(changeTracker, scannedImageRenderer)
        {
            InitializeComponent();
            ActiveControl = txtRed;
            ResetTransform();
        }

        public GrayscaleTransform GrayscaleTransform { get; private set; }

        protected override IEnumerable<Transform> Transforms => new[] { GrayscaleTransform };

        protected override PictureBox PictureBox => pictureBox;

        protected override void ResetTransform()
        {
            GrayscaleTransform = new GrayscaleTransform();

            var red = GrayscaleTransform.RedWeighting;
            var green = GrayscaleTransform.GreenWeighting;
            var blue = GrayscaleTransform.BlueWeighting;

            tbRed.Value = red;
            txtRed.Text = tbRed.Value.ToString();

            tbGreen.Value = green;
            txtGreen.Text = tbGreen.Value.ToString();

            tbBlue.Value = blue;
            txtBlue.Text = tbBlue.Value.ToString();
        }

        private void UpdateTransform()
        {
            GrayscaleTransform.RedWeighting = tbRed.Value;
            GrayscaleTransform.GreenWeighting = tbGreen.Value;
            GrayscaleTransform.BlueWeighting = tbBlue.Value;
            UpdatePreviewBox();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            txtRed.Text = tbRed.Value.ToString("G");
            UpdateTransform();
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            txtGreen.Text = tbGreen.Value.ToString("G");
            UpdateTransform();
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            txtBlue.Text = tbBlue.Value.ToString("G");
            UpdateTransform();
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
