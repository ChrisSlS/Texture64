﻿namespace Texture64
{
    partial class ImageForm
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.statusStripFile = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.statusStripLength = new System.Windows.Forms.ToolStripStatusLabel();
         this.vScrollBarOffset = new System.Windows.Forms.VScrollBar();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
         this.toolStripInsert = new System.Windows.Forms.ToolStripButton();
         this.toolStripSave = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
         this.toolStripCodec = new System.Windows.Forms.ToolStripComboBox();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.bgColorButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.toolStripAbout = new System.Windows.Forms.ToolStripButton();
         this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
         this.label2 = new System.Windows.Forms.Label();
         this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
         this.colorDialogBg = new System.Windows.Forms.ColorDialog();
         this.groupBoxPalette = new System.Windows.Forms.GroupBox();
         this.label15 = new System.Windows.Forms.Label();
         this.numericSplitOffset = new System.Windows.Forms.NumericUpDown();
         this.numericSplitLength = new System.Windows.Forms.NumericUpDown();
         this.numericPalette = new System.Windows.Forms.NumericUpDown();
         this.paletteFileLabel = new System.Windows.Forms.Label();
         this.loadPaletteButton = new System.Windows.Forms.Button();
         this.splitMinusButton = new System.Windows.Forms.Button();
         this.splitPlusButton = new System.Windows.Forms.Button();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.splitPaletteCheck = new System.Windows.Forms.CheckBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.label14 = new System.Windows.Forms.Label();
         this.numericOffset = new System.Windows.Forms.NumericUpDown();
         this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
         this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         this.graphicsViewer8x16 = new Texture64.GraphicsViewer();
         this.graphicsViewer16x32 = new Texture64.GraphicsViewer();
         this.graphicsViewer64x32 = new Texture64.GraphicsViewer();
         this.graphicsViewer32x64 = new Texture64.GraphicsViewer();
         this.gviewPalette = new Texture64.GraphicsViewer();
         this.graphicsViewerCustom = new Texture64.GraphicsViewer();
         this.graphicsViewerMap = new Texture64.GraphicsViewer();
         this.graphicsViewer8x8 = new Texture64.GraphicsViewer();
         this.graphicsViewer16x16 = new Texture64.GraphicsViewer();
         this.graphicsViewer32x32 = new Texture64.GraphicsViewer();
         this.graphicsViewer64x64 = new Texture64.GraphicsViewer();
         this.statusStrip1.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
         this.groupBoxPalette.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericSplitOffset)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericSplitLength)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericPalette)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericOffset)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
         this.SuspendLayout();
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripFile,
            this.toolStripStatusLabel1,
            this.statusStripLength});
         this.statusStrip1.Location = new System.Drawing.Point(0, 545);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(572, 22);
         this.statusStrip1.TabIndex = 0;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // statusStripFile
         // 
         this.statusStripFile.Name = "statusStripFile";
         this.statusStripFile.Size = new System.Drawing.Size(25, 17);
         this.statusStripFile.Text = "File";
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(488, 17);
         this.toolStripStatusLabel1.Spring = true;
         // 
         // statusStripLength
         // 
         this.statusStripLength.Name = "statusStripLength";
         this.statusStripLength.Size = new System.Drawing.Size(44, 17);
         this.statusStripLength.Text = "Length";
         // 
         // vScrollBarOffset
         // 
         this.vScrollBarOffset.Dock = System.Windows.Forms.DockStyle.Left;
         this.vScrollBarOffset.Enabled = false;
         this.vScrollBarOffset.LargeChange = 256;
         this.vScrollBarOffset.Location = new System.Drawing.Point(0, 25);
         this.vScrollBarOffset.Maximum = 1024;
         this.vScrollBarOffset.Name = "vScrollBarOffset";
         this.vScrollBarOffset.Size = new System.Drawing.Size(17, 520);
         this.vScrollBarOffset.SmallChange = 4;
         this.vScrollBarOffset.TabIndex = 2;
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOpen,
            this.toolStripInsert,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripCodec,
            this.toolStripSeparator2,
            this.bgColorButton,
            this.toolStripSeparator3,
            this.toolStripAbout});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(572, 25);
         this.toolStrip1.TabIndex = 1;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // toolStripOpen
         // 
         this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
         this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripOpen.Name = "toolStripOpen";
         this.toolStripOpen.Size = new System.Drawing.Size(56, 22);
         this.toolStripOpen.Text = "Open";
         this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
         // 
         // toolStripInsert
         // 
         this.toolStripInsert.Enabled = false;
         this.toolStripInsert.Image = global::Texture64.Properties.Resources.image_import;
         this.toolStripInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripInsert.Name = "toolStripInsert";
         this.toolStripInsert.Size = new System.Drawing.Size(65, 22);
         this.toolStripInsert.Text = "Insert...";
         this.toolStripInsert.Click += new System.EventHandler(this.toolStripInsert_Click);
         // 
         // toolStripSave
         // 
         this.toolStripSave.Enabled = false;
         this.toolStripSave.Image = global::Texture64.Properties.Resources.disk_black;
         this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripSave.Name = "toolStripSave";
         this.toolStripSave.Size = new System.Drawing.Size(51, 22);
         this.toolStripSave.Text = "Save";
         this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // toolStripLabel2
         // 
         this.toolStripLabel2.Name = "toolStripLabel2";
         this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
         this.toolStripLabel2.Text = "Codec:";
         // 
         // toolStripCodec
         // 
         this.toolStripCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.toolStripCodec.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.toolStripCodec.Items.AddRange(new object[] {
            "RGBA16",
            "RGBA32",
            "IA16",
            "IA8",
            "IA4",
            "I8",
            "I4",
            "CI8",
            "CI4",
            "1bpp"});
         this.toolStripCodec.Name = "toolStripCodec";
         this.toolStripCodec.Size = new System.Drawing.Size(80, 25);
         this.toolStripCodec.SelectedIndexChanged += new System.EventHandler(this.toolStripCodec_SelectedIndexChanged);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // bgColorButton
         // 
         this.bgColorButton.Image = global::Texture64.Properties.Resources.color;
         this.bgColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.bgColorButton.Name = "bgColorButton";
         this.bgColorButton.Size = new System.Drawing.Size(74, 22);
         this.bgColorButton.Text = "BG Color";
         this.bgColorButton.Click += new System.EventHandler(this.bgColorButton_Click);
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
         // 
         // toolStripAbout
         // 
         this.toolStripAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripAbout.Image = global::Texture64.Properties.Resources.question;
         this.toolStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripAbout.Name = "toolStripAbout";
         this.toolStripAbout.Size = new System.Drawing.Size(23, 22);
         this.toolStripAbout.Text = "About";
         this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
         // 
         // numericUpDownWidth
         // 
         this.numericUpDownWidth.Location = new System.Drawing.Point(196, 261);
         this.numericUpDownWidth.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
         this.numericUpDownWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.numericUpDownWidth.Name = "numericUpDownWidth";
         this.numericUpDownWidth.Size = new System.Drawing.Size(44, 20);
         this.numericUpDownWidth.TabIndex = 10;
         this.numericUpDownWidth.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
         this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(241, 264);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(12, 13);
         this.label2.TabIndex = 12;
         this.label2.Text = "x";
         // 
         // numericUpDownHeight
         // 
         this.numericUpDownHeight.Location = new System.Drawing.Point(253, 261);
         this.numericUpDownHeight.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
         this.numericUpDownHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.numericUpDownHeight.Name = "numericUpDownHeight";
         this.numericUpDownHeight.Size = new System.Drawing.Size(44, 20);
         this.numericUpDownHeight.TabIndex = 13;
         this.numericUpDownHeight.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
         this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDownHeight_ValueChanged);
         // 
         // groupBoxPalette
         // 
         this.groupBoxPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBoxPalette.Controls.Add(this.label15);
         this.groupBoxPalette.Controls.Add(this.numericSplitOffset);
         this.groupBoxPalette.Controls.Add(this.numericSplitLength);
         this.groupBoxPalette.Controls.Add(this.numericPalette);
         this.groupBoxPalette.Controls.Add(this.paletteFileLabel);
         this.groupBoxPalette.Controls.Add(this.loadPaletteButton);
         this.groupBoxPalette.Controls.Add(this.splitMinusButton);
         this.groupBoxPalette.Controls.Add(this.splitPlusButton);
         this.groupBoxPalette.Controls.Add(this.label6);
         this.groupBoxPalette.Controls.Add(this.label5);
         this.groupBoxPalette.Controls.Add(this.splitPaletteCheck);
         this.groupBoxPalette.Controls.Add(this.label4);
         this.groupBoxPalette.Controls.Add(this.gviewPalette);
         this.groupBoxPalette.Location = new System.Drawing.Point(425, 29);
         this.groupBoxPalette.Name = "groupBoxPalette";
         this.groupBoxPalette.Size = new System.Drawing.Size(143, 323);
         this.groupBoxPalette.TabIndex = 16;
         this.groupBoxPalette.TabStop = false;
         this.groupBoxPalette.Text = "CI Palette";
         // 
         // label15
         // 
         this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.label15.Location = new System.Drawing.Point(3, 270);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(138, 2);
         this.label15.TabIndex = 38;
         // 
         // numericSplitOffset
         // 
         this.numericSplitOffset.Enabled = false;
         this.numericSplitOffset.Hexadecimal = true;
         this.numericSplitOffset.Location = new System.Drawing.Point(61, 218);
         this.numericSplitOffset.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.numericSplitOffset.Name = "numericSplitOffset";
         this.numericSplitOffset.Size = new System.Drawing.Size(73, 20);
         this.numericSplitOffset.TabIndex = 37;
         this.numericSplitOffset.ValueChanged += new System.EventHandler(this.numericSplitOffset_ValueChanged);
         // 
         // numericSplitLength
         // 
         this.numericSplitLength.Enabled = false;
         this.numericSplitLength.Hexadecimal = true;
         this.numericSplitLength.Location = new System.Drawing.Point(60, 196);
         this.numericSplitLength.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
         this.numericSplitLength.Name = "numericSplitLength";
         this.numericSplitLength.Size = new System.Drawing.Size(73, 20);
         this.numericSplitLength.TabIndex = 36;
         this.numericSplitLength.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
         this.numericSplitLength.ValueChanged += new System.EventHandler(this.numericSplitLength_ValueChanged);
         // 
         // numericPalette
         // 
         this.numericPalette.Enabled = false;
         this.numericPalette.Hexadecimal = true;
         this.numericPalette.Location = new System.Drawing.Point(57, 18);
         this.numericPalette.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.numericPalette.Name = "numericPalette";
         this.numericPalette.Size = new System.Drawing.Size(77, 20);
         this.numericPalette.TabIndex = 35;
         this.numericPalette.ValueChanged += new System.EventHandler(this.numericTextPalette_ValueChanged);
         // 
         // paletteFileLabel
         // 
         this.paletteFileLabel.AutoSize = true;
         this.paletteFileLabel.Location = new System.Drawing.Point(7, 305);
         this.paletteFileLabel.Name = "paletteFileLabel";
         this.paletteFileLabel.Size = new System.Drawing.Size(59, 13);
         this.paletteFileLabel.TabIndex = 13;
         this.paletteFileLabel.Text = "Palette File";
         // 
         // loadPaletteButton
         // 
         this.loadPaletteButton.Image = ((System.Drawing.Image)(resources.GetObject("loadPaletteButton.Image")));
         this.loadPaletteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.loadPaletteButton.Location = new System.Drawing.Point(6, 275);
         this.loadPaletteButton.Name = "loadPaletteButton";
         this.loadPaletteButton.Size = new System.Drawing.Size(127, 23);
         this.loadPaletteButton.TabIndex = 12;
         this.loadPaletteButton.Text = "Load Palette...";
         this.loadPaletteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.loadPaletteButton.UseVisualStyleBackColor = true;
         this.loadPaletteButton.Click += new System.EventHandler(this.loadPaletteButton_Click);
         // 
         // splitMinusButton
         // 
         this.splitMinusButton.Enabled = false;
         this.splitMinusButton.Image = global::Texture64.Properties.Resources.minus;
         this.splitMinusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.splitMinusButton.Location = new System.Drawing.Point(6, 245);
         this.splitMinusButton.Name = "splitMinusButton";
         this.splitMinusButton.Size = new System.Drawing.Size(61, 23);
         this.splitMinusButton.TabIndex = 11;
         this.splitMinusButton.Text = "Length";
         this.splitMinusButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.splitMinusButton.UseVisualStyleBackColor = true;
         this.splitMinusButton.Click += new System.EventHandler(this.splitMinusButton_Click);
         // 
         // splitPlusButton
         // 
         this.splitPlusButton.Enabled = false;
         this.splitPlusButton.Image = global::Texture64.Properties.Resources.plus;
         this.splitPlusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.splitPlusButton.Location = new System.Drawing.Point(73, 244);
         this.splitPlusButton.Name = "splitPlusButton";
         this.splitPlusButton.Size = new System.Drawing.Size(60, 23);
         this.splitPlusButton.TabIndex = 9;
         this.splitPlusButton.Text = "Length";
         this.splitPlusButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.splitPlusButton.UseVisualStyleBackColor = true;
         this.splitPlusButton.Click += new System.EventHandler(this.splitPlusButton_Click);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(6, 198);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(57, 13);
         this.label6.TabIndex = 6;
         this.label6.Text = "Length: 0x";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(11, 220);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(52, 13);
         this.label5.TabIndex = 5;
         this.label5.Text = "Offset: 0x";
         // 
         // splitPaletteCheck
         // 
         this.splitPaletteCheck.AutoSize = true;
         this.splitPaletteCheck.Location = new System.Drawing.Point(6, 178);
         this.splitPaletteCheck.Name = "splitPaletteCheck";
         this.splitPaletteCheck.Size = new System.Drawing.Size(82, 17);
         this.splitPaletteCheck.TabIndex = 4;
         this.splitPaletteCheck.Text = "Split Palette";
         this.splitPaletteCheck.UseVisualStyleBackColor = true;
         this.splitPaletteCheck.CheckedChanged += new System.EventHandler(this.splitPaletteCheck_CheckedChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(7, 20);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(52, 13);
         this.label4.TabIndex = 1;
         this.label4.Text = "Offset: 0x";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(20, 32);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(18, 13);
         this.label3.TabIndex = 17;
         this.label3.Text = "0x";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(151, 29);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(36, 13);
         this.label7.TabIndex = 22;
         this.label7.Text = "64x64";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(285, 29);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(36, 13);
         this.label8.TabIndex = 23;
         this.label8.Text = "32x64";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(154, 264);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(45, 13);
         this.label1.TabIndex = 11;
         this.label1.Text = "Custom:";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(356, 29);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(36, 13);
         this.label9.TabIndex = 26;
         this.label9.Text = "16x32";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(356, 125);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(36, 13);
         this.label10.TabIndex = 28;
         this.label10.Text = "16x16";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(356, 226);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(24, 13);
         this.label11.TabIndex = 29;
         this.label11.Text = "8x8";
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(151, 176);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(36, 13);
         this.label12.TabIndex = 30;
         this.label12.Text = "64x32";
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(285, 176);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(36, 13);
         this.label13.TabIndex = 31;
         this.label13.Text = "32x32";
         // 
         // label14
         // 
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(356, 176);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(36, 13);
         this.label14.TabIndex = 33;
         this.label14.Text = "16x32";
         // 
         // numericOffset
         // 
         this.numericOffset.Enabled = false;
         this.numericOffset.Hexadecimal = true;
         this.numericOffset.Location = new System.Drawing.Point(36, 30);
         this.numericOffset.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.numericOffset.Name = "numericOffset";
         this.numericOffset.Size = new System.Drawing.Size(112, 20);
         this.numericOffset.TabIndex = 34;
         this.numericOffset.ValueChanged += new System.EventHandler(this.numericOffset_ValueChanged);
         // 
         // graphicsViewer8x16
         // 
         this.graphicsViewer8x16.Codec = Texture64.N64Codec.RGBA16;
         this.graphicsViewer8x16.Location = new System.Drawing.Point(359, 192);
         this.graphicsViewer8x16.Name = "graphicsViewer8x16";
         this.graphicsViewer8x16.PixHeight = 16;
         this.graphicsViewer8x16.PixScale = 2;
         this.graphicsViewer8x16.PixWidth = 8;
         this.graphicsViewer8x16.Size = new System.Drawing.Size(16, 32);
         this.graphicsViewer8x16.TabIndex = 32;
         this.graphicsViewer8x16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
         this.graphicsViewer8x16.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
         this.graphicsViewer8x16.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
         // 
         // graphicsViewer16x32
         // 
         this.graphicsViewer16x32.Codec = Texture64.N64Codec.RGBA16;
         this.graphicsViewer16x32.Location = new System.Drawing.Point(359, 45);
         this.graphicsViewer16x32.Name = "graphicsViewer16x32";
         this.graphicsViewer16x32.PixHeight = 32;
         this.graphicsViewer16x32.PixScale = 2;
         this.graphicsViewer16x32.PixWidth = 16;
         this.graphicsViewer16x32.Size = new System.Drawing.Size(32, 64);
         this.graphicsViewer16x32.TabIndex = 27;
         this.graphicsViewer16x32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
         this.graphicsViewer16x32.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
         this.graphicsViewer16x32.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
         // 
         // graphicsViewer64x32
         // 
         this.graphicsViewer64x32.Codec = Texture64.N64Codec.RGBA16;
         this.graphicsViewer64x32.Location = new System.Drawing.Point(154, 192);
         this.graphicsViewer64x32.Name = "graphicsViewer64x32";
         this.graphicsViewer64x32.PixHeight = 32;
         this.graphicsViewer64x32.PixScale = 2;
         this.graphicsViewer64x32.PixWidth = 64;
         this.graphicsViewer64x32.Size = new System.Drawing.Size(128, 64);
         this.graphicsViewer64x32.TabIndex = 25;
         this.graphicsViewer64x32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
         this.graphicsViewer64x32.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
         this.graphicsViewer64x32.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
         // 
         // graphicsViewer32x64
         // 
         this.graphicsViewer32x64.Codec = Texture64.N64Codec.RGBA16;
         this.graphicsViewer32x64.Location = new System.Drawing.Point(288, 45);
         this.graphicsViewer32x64.Name = "graphicsViewer32x64";
         this.graphicsViewer32x64.PixHeight = 64;
         this.graphicsViewer32x64.PixScale = 2;
         this.graphicsViewer32x64.PixWidth = 32;
         this.graphicsViewer32x64.Size = new System.Drawing.Size(64, 128);
         this.graphicsViewer32x64.TabIndex = 24;
         this.graphicsViewer32x64.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
         this.graphicsViewer32x64.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
         this.graphicsViewer32x64.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
         // 
         // gviewPalette
         // 
         this.gviewPalette.Codec = Texture64.N64Codec.RGBA16;
         this.gviewPalette.Location = new System.Drawing.Point(6, 43);
         this.gviewPalette.Name = "gviewPalette";
         this.gviewPalette.PixHeight = 16;
         this.gviewPalette.PixScale = 8;
         this.gviewPalette.PixWidth = 16;
         this.gviewPalette.Size = new System.Drawing.Size(128, 128);
         this.gviewPalette.TabIndex = 0;
         this.gviewPalette.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gviewPalette_MouseDown);
         // 
         // graphicsViewerCustom
         // 
         this.graphicsViewerCustom.Codec = Texture64.N64Codec.RGBA16;
         this.graphicsViewerCustom.Location = new System.Drawing.Point(154, 286);
         this.graphicsViewerCustom.Name = "graphicsViewerCustom";
         this.graphicsViewerCustom.PixHeight = 128;
         this.graphicsViewerCustom.PixScale = 2;
         this.graphicsViewerCustom.PixWidth = 128;
         this.graphicsViewerCustom.Size = new System.Drawing.Size(256, 256);
         this.graphicsViewerCustom.TabIndex = 9;
         this.graphicsViewerCustom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
         this.graphicsViewerCustom.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
         this.graphicsViewerCustom.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
         // 
         // graphicsViewerMap
         // 
         this.graphicsViewerMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.graphicsViewerMap.Codec = Texture64.N64Codec.RGBA16;
         this.graphicsViewerMap.Location = new System.Drawing.Point(20, 55);
         this.graphicsViewerMap.Name = "graphicsViewerMap";
         this.graphicsViewerMap.PixHeight = 243;
         this.graphicsViewerMap.PixScale = 2;
         this.graphicsViewerMap.PixWidth = 64;
         this.graphicsViewerMap.Size = new System.Drawing.Size(128, 487);
         this.graphicsViewerMap.TabIndex = 7;
         this.graphicsViewerMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
         this.graphicsViewerMap.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
         this.graphicsViewerMap.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
         // 
         // graphicsViewer8x8
         // 
         this.graphicsViewer8x8.Codec = Texture64.N64Codec.RGBA16;
         this.graphicsViewer8x8.Location = new System.Drawing.Point(359, 240);
         this.graphicsViewer8x8.Name = "graphicsViewer8x8";
         this.graphicsViewer8x8.PixHeight = 8;
         this.graphicsViewer8x8.PixScale = 2;
         this.graphicsViewer8x8.PixWidth = 8;
         this.graphicsViewer8x8.Size = new System.Drawing.Size(16, 16);
         this.graphicsViewer8x8.TabIndex = 6;
         this.graphicsViewer8x8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
         this.graphicsViewer8x8.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
         this.graphicsViewer8x8.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
         // 
         // graphicsViewer16x16
         // 
         this.graphicsViewer16x16.Codec = Texture64.N64Codec.RGBA16;
         this.graphicsViewer16x16.Location = new System.Drawing.Point(359, 141);
         this.graphicsViewer16x16.Name = "graphicsViewer16x16";
         this.graphicsViewer16x16.PixHeight = 16;
         this.graphicsViewer16x16.PixScale = 2;
         this.graphicsViewer16x16.PixWidth = 16;
         this.graphicsViewer16x16.Size = new System.Drawing.Size(32, 32);
         this.graphicsViewer16x16.TabIndex = 5;
         this.graphicsViewer16x16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
         this.graphicsViewer16x16.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
         this.graphicsViewer16x16.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
         // 
         // graphicsViewer32x32
         // 
         this.graphicsViewer32x32.Codec = Texture64.N64Codec.RGBA16;
         this.graphicsViewer32x32.Location = new System.Drawing.Point(288, 192);
         this.graphicsViewer32x32.Name = "graphicsViewer32x32";
         this.graphicsViewer32x32.PixHeight = 32;
         this.graphicsViewer32x32.PixScale = 2;
         this.graphicsViewer32x32.PixWidth = 32;
         this.graphicsViewer32x32.Size = new System.Drawing.Size(64, 64);
         this.graphicsViewer32x32.TabIndex = 4;
         this.graphicsViewer32x32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
         this.graphicsViewer32x32.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
         this.graphicsViewer32x32.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
         // 
         // graphicsViewer64x64
         // 
         this.graphicsViewer64x64.Codec = Texture64.N64Codec.RGBA16;
         this.graphicsViewer64x64.Location = new System.Drawing.Point(154, 45);
         this.graphicsViewer64x64.Name = "graphicsViewer64x64";
         this.graphicsViewer64x64.PixHeight = 64;
         this.graphicsViewer64x64.PixScale = 2;
         this.graphicsViewer64x64.PixWidth = 64;
         this.graphicsViewer64x64.Size = new System.Drawing.Size(128, 128);
         this.graphicsViewer64x64.TabIndex = 3;
         this.graphicsViewer64x64.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
         this.graphicsViewer64x64.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
         this.graphicsViewer64x64.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
         // 
         // ImageForm
         // 
         this.AllowDrop = true;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(572, 567);
         this.Controls.Add(this.numericOffset);
         this.Controls.Add(this.label14);
         this.Controls.Add(this.graphicsViewer8x16);
         this.Controls.Add(this.label13);
         this.Controls.Add(this.label12);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.graphicsViewer16x32);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.numericUpDownWidth);
         this.Controls.Add(this.graphicsViewer64x32);
         this.Controls.Add(this.graphicsViewer32x64);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.groupBoxPalette);
         this.Controls.Add(this.numericUpDownHeight);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.graphicsViewerCustom);
         this.Controls.Add(this.graphicsViewerMap);
         this.Controls.Add(this.graphicsViewer8x8);
         this.Controls.Add(this.graphicsViewer16x16);
         this.Controls.Add(this.graphicsViewer32x32);
         this.Controls.Add(this.graphicsViewer64x64);
         this.Controls.Add(this.vScrollBarOffset);
         this.Controls.Add(this.toolStrip1);
         this.Controls.Add(this.statusStrip1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "ImageForm";
         this.Text = "Texture64";
         this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImageForm_DragDrop);
         this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImageForm_DragEnter);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
         this.groupBoxPalette.ResumeLayout(false);
         this.groupBoxPalette.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericSplitOffset)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericSplitLength)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericPalette)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericOffset)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripFile;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.VScrollBar vScrollBarOffset;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private GraphicsViewer graphicsViewer64x64;
        private GraphicsViewer graphicsViewer32x32;
        private GraphicsViewer graphicsViewer16x16;
        private GraphicsViewer graphicsViewer8x8;
        private GraphicsViewer graphicsViewerMap;
        private GraphicsViewer graphicsViewerCustom;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.ToolStripComboBox toolStripCodec;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ColorDialog colorDialogBg;
        private System.Windows.Forms.GroupBox groupBoxPalette;
        private GraphicsViewer gviewPalette;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox splitPaletteCheck;
        private System.Windows.Forms.Button splitPlusButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton bgColorButton;
        private System.Windows.Forms.Button splitMinusButton;
        private System.Windows.Forms.Button loadPaletteButton;
        private System.Windows.Forms.Label paletteFileLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private GraphicsViewer graphicsViewer32x64;
        private GraphicsViewer graphicsViewer64x32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private GraphicsViewer graphicsViewer16x32;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private GraphicsViewer graphicsViewer8x16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripButton toolStripInsert;
        private System.Windows.Forms.ToolStripButton toolStripAbout;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.NumericUpDown numericOffset;
        private System.Windows.Forms.NumericUpDown numericPalette;
        private System.Windows.Forms.NumericUpDown numericSplitLength;
        private System.Windows.Forms.NumericUpDown numericSplitOffset;
        private System.Windows.Forms.Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

