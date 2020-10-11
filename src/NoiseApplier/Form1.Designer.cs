namespace NoiseApplier
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Original = new System.Windows.Forms.PictureBox();
            this.NewImage = new System.Windows.Forms.PictureBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File = new System.Windows.Forms.MenuStrip();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PicSize = new System.Windows.Forms.TextBox();
            this.Range = new System.Windows.Forms.NumericUpDown();
            this.Apply = new System.Windows.Forms.Button();
            this.ImageColors = new System.Windows.Forms.ListBox();
            this.IgnoredColors = new System.Windows.Forms.ListBox();
            this.AddIgnored = new System.Windows.Forms.Button();
            this.RemoveIgnored = new System.Windows.Forms.Button();
            this.ColorPreview = new System.Windows.Forms.PictureBox();
            this.Intensity = new System.Windows.Forms.NumericUpDown();
            this.CustomColor = new System.Windows.Forms.Button();
            this.Debug = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewImage)).BeginInit();
            this.File.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intensity)).BeginInit();
            this.SuspendLayout();
            // 
            // Original
            // 
            this.Original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Original.ErrorImage = null;
            this.Original.InitialImage = null;
            this.Original.Location = new System.Drawing.Point(12, 27);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(360, 360);
            this.Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Original.TabIndex = 1;
            this.Original.TabStop = false;
            // 
            // NewImage
            // 
            this.NewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewImage.ErrorImage = null;
            this.NewImage.InitialImage = null;
            this.NewImage.Location = new System.Drawing.Point(412, 27);
            this.NewImage.Name = "NewImage";
            this.NewImage.Size = new System.Drawing.Size(360, 360);
            this.NewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NewImage.TabIndex = 1;
            this.NewImage.TabStop = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.SelectFile);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // File
            // 
            this.File.AllowMerge = false;
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.folderToolStripMenuItem});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(784, 24);
            this.File.TabIndex = 0;
            this.File.Text = "File";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyNoiseToolStripMenuItem});
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // applyNoiseToolStripMenuItem
            // 
            this.applyNoiseToolStripMenuItem.Name = "applyNoiseToolStripMenuItem";
            this.applyNoiseToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.applyNoiseToolStripMenuItem.Text = "Apply Noise";
            this.applyNoiseToolStripMenuItem.Click += new System.EventHandler(this.ConvertFolder);
            // 
            // PicSize
            // 
            this.PicSize.BackColor = System.Drawing.SystemColors.Menu;
            this.PicSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicSize.Enabled = false;
            this.PicSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PicSize.Location = new System.Drawing.Point(12, 393);
            this.PicSize.Name = "PicSize";
            this.PicSize.ReadOnly = true;
            this.PicSize.ShortcutsEnabled = false;
            this.PicSize.Size = new System.Drawing.Size(84, 22);
            this.PicSize.TabIndex = 2;
            this.PicSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Range
            // 
            this.Range.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Range.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Range.Location = new System.Drawing.Point(102, 393);
            this.Range.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Range.Name = "Range";
            this.Range.ReadOnly = true;
            this.Range.Size = new System.Drawing.Size(42, 22);
            this.Range.TabIndex = 3;
            this.Range.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Apply
            // 
            this.Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply.Location = new System.Drawing.Point(12, 425);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(84, 22);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ApplyNoise);
            // 
            // ImageColors
            // 
            this.ImageColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageColors.FormattingEnabled = true;
            this.ImageColors.Location = new System.Drawing.Point(412, 393);
            this.ImageColors.Name = "ImageColors";
            this.ImageColors.Size = new System.Drawing.Size(222, 93);
            this.ImageColors.TabIndex = 5;
            this.ImageColors.SelectedIndexChanged += new System.EventHandler(this.DisplayColor);
            // 
            // IgnoredColors
            // 
            this.IgnoredColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IgnoredColors.FormattingEnabled = true;
            this.IgnoredColors.Location = new System.Drawing.Point(150, 393);
            this.IgnoredColors.Name = "IgnoredColors";
            this.IgnoredColors.Size = new System.Drawing.Size(222, 93);
            this.IgnoredColors.TabIndex = 5;
            this.IgnoredColors.SelectedIndexChanged += new System.EventHandler(this.DisplayColor);
            // 
            // AddIgnored
            // 
            this.AddIgnored.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIgnored.Location = new System.Drawing.Point(378, 393);
            this.AddIgnored.Name = "AddIgnored";
            this.AddIgnored.Size = new System.Drawing.Size(28, 28);
            this.AddIgnored.TabIndex = 4;
            this.AddIgnored.Text = "<";
            this.AddIgnored.UseVisualStyleBackColor = true;
            this.AddIgnored.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddedIgnored);
            // 
            // RemoveIgnored
            // 
            this.RemoveIgnored.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveIgnored.Location = new System.Drawing.Point(378, 458);
            this.RemoveIgnored.Name = "RemoveIgnored";
            this.RemoveIgnored.Size = new System.Drawing.Size(28, 28);
            this.RemoveIgnored.TabIndex = 4;
            this.RemoveIgnored.Text = "X";
            this.RemoveIgnored.UseVisualStyleBackColor = true;
            this.RemoveIgnored.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemovedIgnored);
            // 
            // ColorPreview
            // 
            this.ColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPreview.ErrorImage = null;
            this.ColorPreview.InitialImage = null;
            this.ColorPreview.Location = new System.Drawing.Point(640, 393);
            this.ColorPreview.Name = "ColorPreview";
            this.ColorPreview.Size = new System.Drawing.Size(132, 93);
            this.ColorPreview.TabIndex = 1;
            this.ColorPreview.TabStop = false;
            // 
            // Intensity
            // 
            this.Intensity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Intensity.DecimalPlaces = 1;
            this.Intensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Intensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Intensity.Location = new System.Drawing.Point(102, 425);
            this.Intensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Intensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Intensity.Name = "Intensity";
            this.Intensity.ReadOnly = true;
            this.Intensity.Size = new System.Drawing.Size(42, 22);
            this.Intensity.TabIndex = 3;
            this.Intensity.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // CustomColor
            // 
            this.CustomColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomColor.Location = new System.Drawing.Point(378, 427);
            this.CustomColor.Name = "CustomColor";
            this.CustomColor.Size = new System.Drawing.Size(28, 25);
            this.CustomColor.TabIndex = 4;
            this.CustomColor.Text = "C";
            this.CustomColor.UseVisualStyleBackColor = true;
            this.CustomColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PickCustomColor);
            // 
            // Debug
            // 
            this.Debug.BackColor = System.Drawing.SystemColors.Menu;
            this.Debug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Debug.Enabled = false;
            this.Debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debug.Location = new System.Drawing.Point(12, 462);
            this.Debug.Name = "Debug";
            this.Debug.ReadOnly = true;
            this.Debug.ShortcutsEnabled = false;
            this.Debug.Size = new System.Drawing.Size(132, 22);
            this.Debug.TabIndex = 2;
            this.Debug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.IgnoredColors);
            this.Controls.Add(this.ImageColors);
            this.Controls.Add(this.RemoveIgnored);
            this.Controls.Add(this.CustomColor);
            this.Controls.Add(this.AddIgnored);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Intensity);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.PicSize);
            this.Controls.Add(this.ColorPreview);
            this.Controls.Add(this.NewImage);
            this.Controls.Add(this.Original);
            this.Controls.Add(this.File);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.File;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Noise Applier";
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewImage)).EndInit();
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Original;
        private System.Windows.Forms.PictureBox NewImage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip File;
        private System.Windows.Forms.TextBox PicSize;
        private System.Windows.Forms.NumericUpDown Range;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.ListBox ImageColors;
        private System.Windows.Forms.ListBox IgnoredColors;
        private System.Windows.Forms.Button AddIgnored;
        private System.Windows.Forms.Button RemoveIgnored;
        private System.Windows.Forms.PictureBox ColorPreview;
        private System.Windows.Forms.NumericUpDown Intensity;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyNoiseToolStripMenuItem;
        private System.Windows.Forms.Button CustomColor;
        private System.Windows.Forms.TextBox Debug;
    }
}

