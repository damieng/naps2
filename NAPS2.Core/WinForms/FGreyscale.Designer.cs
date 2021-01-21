using System;
using System.Collections.Generic;
using System.Linq;

namespace NAPS2.WinForms
{
    partial class FGreyscale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGreyscale));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // pbRed
            // 
            resources.ApplyResources(this.pbRed, "pbRed");
            this.pbRed.Image = global::NAPS2.Icons.flag_red;
            this.pbRed.Name = "pbRed";
            this.pbRed.TabStop = false;
            // 
            // txtRed
            // 
            resources.ApplyResources(this.txtRed, "txtRed");
            this.txtRed.Name = "txtRed";
            this.txtRed.TextChanged += new System.EventHandler(this.txtRed_TextChanged);
            // 
            // tbRed
            // 
            resources.ApplyResources(this.tbRed, "tbRed");
            this.tbRed.Maximum = 1000;
            this.tbRed.Minimum = -1000;
            this.tbRed.Name = "tbRed";
            this.tbRed.TickFrequency = 200;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // txtGreen
            // 
            resources.ApplyResources(this.txtGreen, "txtGreen");
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.TextChanged += new System.EventHandler(this.txtGreen_TextChanged);
            // 
            // tbGreen
            // 
            resources.ApplyResources(this.tbGreen, "tbGreen");
            this.tbGreen.Maximum = 1000;
            this.tbGreen.Minimum = -1000;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.TickFrequency = 200;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // pbBlue
            // 
            resources.ApplyResources(this.pbBlue, "pbBlue");
            this.pbBlue.Image = global::NAPS2.Icons.flag_blue;
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.TabStop = false;
            // 
            // txtBlue
            // 
            resources.ApplyResources(this.txtBlue, "txtBlue");
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.TextChanged += new System.EventHandler(this.txtBlue_TextChanged);
            // 
            // tbBlue
            // 
            resources.ApplyResources(this.tbBlue, "tbBlue");
            this.tbBlue.Maximum = 1000;
            this.tbBlue.Minimum = -1000;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.TickFrequency = 200;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // pbGreen
            // 
            resources.ApplyResources(this.pbGreen, "pbGreen");
            this.pbGreen.Image = global::NAPS2.Icons.flag_green;
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.TabStop = false;
            // 
            // FGreyscale
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.pbBlue);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.pbRed);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.pictureBox);
            this.Name = "FGreyscale";
            this.Controls.SetChildIndex(this.pictureBox, 0);
            this.Controls.SetChildIndex(this.tbRed, 0);
            this.Controls.SetChildIndex(this.txtRed, 0);
            this.Controls.SetChildIndex(this.pbRed, 0);
            this.Controls.SetChildIndex(this.tbGreen, 0);
            this.Controls.SetChildIndex(this.txtGreen, 0);
            this.Controls.SetChildIndex(this.tbBlue, 0);
            this.Controls.SetChildIndex(this.txtBlue, 0);
            this.Controls.SetChildIndex(this.pbBlue, 0);
            this.Controls.SetChildIndex(this.pbGreen, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.PictureBox pbGreen;
    }
}
