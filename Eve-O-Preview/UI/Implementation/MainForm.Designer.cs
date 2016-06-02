using System.Windows.Forms;

namespace EveOPreview.UI
{
	partial class MainForm
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

		/// <summary>s
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label OpacityLabel;
			System.Windows.Forms.ToolStripMenuItem RestoreWindowMenuItem;
			System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
			System.Windows.Forms.FlowLayoutPanel ContentFlowLayoutPanel;
			System.Windows.Forms.Panel OpacityPanel;
			System.Windows.Forms.Label ZoomFactorLabel;
			System.Windows.Forms.Label ZoomAnchorLabel;
			System.Windows.Forms.Label PreviewsListLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MinimizeToTrayCheckBox = new System.Windows.Forms.CheckBox();
			this.ThumbnailsOpacityScrollBar = new System.Windows.Forms.HScrollBar();
			this.TrackClientLocationsCheckBox = new System.Windows.Forms.CheckBox();
			this.HideActiveClientThumbnailCheckBox = new System.Windows.Forms.CheckBox();
			this.ShowThumbnailsAlwaysOnTopCheckBox = new System.Windows.Forms.CheckBox();
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox = new System.Windows.Forms.CheckBox();
			this.EnableUniqueThumbnailsLayoutsCheckBox = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SyncThumbnailsSizeCheckBox = new System.Windows.Forms.CheckBox();
			this.ThumbnailsWidthNumericEdit = new System.Windows.Forms.NumericUpDown();
			this.ThumbnailsHeightNumericEdit = new System.Windows.Forms.NumericUpDown();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ZoomAnchorPanel = new System.Windows.Forms.Panel();
			this.ZoomAanchorNWRadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorNRadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorNERadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorWRadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorSERadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorCRadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorSRadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorERadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorSWRadioButton = new System.Windows.Forms.RadioButton();
			this.EnableZoomOnHoverCheckBox = new System.Windows.Forms.CheckBox();
			this.ZoomFactorNumericEdit = new System.Windows.Forms.NumericUpDown();
			this.ShowThumbnailOverlaysCheckBox = new System.Windows.Forms.CheckBox();
			this.ShowThumbnailFramesCheckBox = new System.Windows.Forms.CheckBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.ThumbnailsList = new System.Windows.Forms.CheckedListBox();
			this.ForumLinkLabel = new System.Windows.Forms.LinkLabel();
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			OpacityLabel = new System.Windows.Forms.Label();
			RestoreWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			ContentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			OpacityPanel = new System.Windows.Forms.Panel();
			ZoomFactorLabel = new System.Windows.Forms.Label();
			ZoomAnchorLabel = new System.Windows.Forms.Label();
			PreviewsListLabel = new System.Windows.Forms.Label();
			ContentFlowLayoutPanel.SuspendLayout();
			OpacityPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ThumbnailsWidthNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ThumbnailsHeightNumericEdit)).BeginInit();
			this.panel2.SuspendLayout();
			this.ZoomAnchorPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ZoomFactorNumericEdit)).BeginInit();
			this.panel5.SuspendLayout();
			this.TrayMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// OpacityLabel
			// 
			OpacityLabel.AutoSize = true;
			OpacityLabel.Location = new System.Drawing.Point(2, 5);
			OpacityLabel.Name = "OpacityLabel";
			OpacityLabel.Size = new System.Drawing.Size(43, 13);
			OpacityLabel.TabIndex = 0;
			OpacityLabel.Text = "Opacity";
			// 
			// RestoreWindowMenuItem
			// 
			RestoreWindowMenuItem.Name = "RestoreWindowMenuItem";
			RestoreWindowMenuItem.Size = new System.Drawing.Size(113, 22);
			RestoreWindowMenuItem.Text = "Restore";
			RestoreWindowMenuItem.Click += new System.EventHandler(this.RestoreMainForm_Handler);
			// 
			// ExitMenuItem
			// 
			ExitMenuItem.Name = "ExitMenuItem";
			ExitMenuItem.Size = new System.Drawing.Size(113, 22);
			ExitMenuItem.Text = "Exit";
			ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItemClick_Handler);
			// 
			// ContentFlowLayoutPanel
			// 
			ContentFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
			ContentFlowLayoutPanel.Controls.Add(this.MinimizeToTrayCheckBox);
			ContentFlowLayoutPanel.Controls.Add(OpacityPanel);
			ContentFlowLayoutPanel.Controls.Add(this.TrackClientLocationsCheckBox);
			ContentFlowLayoutPanel.Controls.Add(this.HideActiveClientThumbnailCheckBox);
			ContentFlowLayoutPanel.Controls.Add(this.ShowThumbnailsAlwaysOnTopCheckBox);
			ContentFlowLayoutPanel.Controls.Add(this.HideAllThumbnailsIfClientIsNotActiveCheckBox);
			ContentFlowLayoutPanel.Controls.Add(this.EnableUniqueThumbnailsLayoutsCheckBox);
			ContentFlowLayoutPanel.Controls.Add(this.panel1);
			ContentFlowLayoutPanel.Controls.Add(this.panel2);
			ContentFlowLayoutPanel.Controls.Add(this.ShowThumbnailOverlaysCheckBox);
			ContentFlowLayoutPanel.Controls.Add(this.ShowThumbnailFramesCheckBox);
			ContentFlowLayoutPanel.Controls.Add(this.panel5);
			ContentFlowLayoutPanel.Controls.Add(this.ForumLinkLabel);
			ContentFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			ContentFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			ContentFlowLayoutPanel.Name = "ContentFlowLayoutPanel";
			ContentFlowLayoutPanel.Size = new System.Drawing.Size(252, 467);
			ContentFlowLayoutPanel.TabIndex = 25;
			// 
			// MinimizeToTrayCheckBox
			// 
			this.MinimizeToTrayCheckBox.AutoSize = true;
			this.MinimizeToTrayCheckBox.Location = new System.Drawing.Point(3, 3);
			this.MinimizeToTrayCheckBox.Name = "MinimizeToTrayCheckBox";
			this.MinimizeToTrayCheckBox.Size = new System.Drawing.Size(139, 17);
			this.MinimizeToTrayCheckBox.TabIndex = 34;
			this.MinimizeToTrayCheckBox.Text = "Minimize to System Tray";
			this.MinimizeToTrayCheckBox.UseVisualStyleBackColor = true;
			this.MinimizeToTrayCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// OpacityPanel
			// 
			OpacityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			OpacityPanel.Controls.Add(this.ThumbnailsOpacityScrollBar);
			OpacityPanel.Controls.Add(OpacityLabel);
			OpacityPanel.Location = new System.Drawing.Point(3, 26);
			OpacityPanel.Name = "OpacityPanel";
			OpacityPanel.Size = new System.Drawing.Size(246, 26);
			OpacityPanel.TabIndex = 33;
			// 
			// ThumbnailsOpacityScrollBar
			// 
			this.ThumbnailsOpacityScrollBar.Location = new System.Drawing.Point(48, 1);
			this.ThumbnailsOpacityScrollBar.Maximum = 120;
			this.ThumbnailsOpacityScrollBar.Name = "ThumbnailsOpacityScrollBar";
			this.ThumbnailsOpacityScrollBar.Size = new System.Drawing.Size(195, 23);
			this.ThumbnailsOpacityScrollBar.TabIndex = 1;
			this.ThumbnailsOpacityScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptionChanged_Handler);
			// 
			// TrackClientLocationsCheckBox
			// 
			this.TrackClientLocationsCheckBox.AutoSize = true;
			this.TrackClientLocationsCheckBox.Location = new System.Drawing.Point(3, 58);
			this.TrackClientLocationsCheckBox.Name = "TrackClientLocationsCheckBox";
			this.TrackClientLocationsCheckBox.Size = new System.Drawing.Size(127, 17);
			this.TrackClientLocationsCheckBox.TabIndex = 32;
			this.TrackClientLocationsCheckBox.Text = "Track client locations";
			this.TrackClientLocationsCheckBox.UseVisualStyleBackColor = true;
			this.TrackClientLocationsCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// HideActiveClientThumbnailCheckBox
			// 
			this.HideActiveClientThumbnailCheckBox.AutoSize = true;
			this.HideActiveClientThumbnailCheckBox.Checked = true;
			this.HideActiveClientThumbnailCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.HideActiveClientThumbnailCheckBox.Location = new System.Drawing.Point(3, 81);
			this.HideActiveClientThumbnailCheckBox.Name = "HideActiveClientThumbnailCheckBox";
			this.HideActiveClientThumbnailCheckBox.Size = new System.Drawing.Size(184, 17);
			this.HideActiveClientThumbnailCheckBox.TabIndex = 1;
			this.HideActiveClientThumbnailCheckBox.Text = "Hide preview of active EVE client";
			this.HideActiveClientThumbnailCheckBox.UseVisualStyleBackColor = true;
			this.HideActiveClientThumbnailCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ShowThumbnailsAlwaysOnTopCheckBox
			// 
			this.ShowThumbnailsAlwaysOnTopCheckBox.AutoSize = true;
			this.ShowThumbnailsAlwaysOnTopCheckBox.Checked = true;
			this.ShowThumbnailsAlwaysOnTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ShowThumbnailsAlwaysOnTopCheckBox.Location = new System.Drawing.Point(3, 104);
			this.ShowThumbnailsAlwaysOnTopCheckBox.Name = "ShowThumbnailsAlwaysOnTopCheckBox";
			this.ShowThumbnailsAlwaysOnTopCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowThumbnailsAlwaysOnTopCheckBox.Size = new System.Drawing.Size(137, 17);
			this.ShowThumbnailsAlwaysOnTopCheckBox.TabIndex = 8;
			this.ShowThumbnailsAlwaysOnTopCheckBox.Text = "Previews always on top";
			this.ShowThumbnailsAlwaysOnTopCheckBox.UseVisualStyleBackColor = true;
			this.ShowThumbnailsAlwaysOnTopCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// HideAllThumbnailsIfClientIsNotActiveCheckBox
			// 
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox.AutoSize = true;
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox.Checked = true;
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox.Location = new System.Drawing.Point(3, 127);
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox.Name = "HideAllThumbnailsIfClientIsNotActiveCheckBox";
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox.Size = new System.Drawing.Size(242, 17);
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox.TabIndex = 2;
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox.Text = "Hide previews if active window not EVE client";
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox.UseVisualStyleBackColor = true;
			this.HideAllThumbnailsIfClientIsNotActiveCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// EnableUniqueThumbnailsLayoutsCheckBox
			// 
			this.EnableUniqueThumbnailsLayoutsCheckBox.AutoSize = true;
			this.EnableUniqueThumbnailsLayoutsCheckBox.Checked = true;
			this.EnableUniqueThumbnailsLayoutsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.EnableUniqueThumbnailsLayoutsCheckBox.Location = new System.Drawing.Point(3, 150);
			this.EnableUniqueThumbnailsLayoutsCheckBox.Name = "EnableUniqueThumbnailsLayoutsCheckBox";
			this.EnableUniqueThumbnailsLayoutsCheckBox.Size = new System.Drawing.Size(185, 17);
			this.EnableUniqueThumbnailsLayoutsCheckBox.TabIndex = 3;
			this.EnableUniqueThumbnailsLayoutsCheckBox.Text = "Unique layout for each EVE client";
			this.EnableUniqueThumbnailsLayoutsCheckBox.UseVisualStyleBackColor = true;
			this.EnableUniqueThumbnailsLayoutsCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.SyncThumbnailsSizeCheckBox);
			this.panel1.Controls.Add(this.ThumbnailsWidthNumericEdit);
			this.panel1.Controls.Add(this.ThumbnailsHeightNumericEdit);
			this.panel1.Location = new System.Drawing.Point(3, 173);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(246, 30);
			this.panel1.TabIndex = 26;
			// 
			// SyncThumbnailsSizeCheckBox
			// 
			this.SyncThumbnailsSizeCheckBox.AutoSize = true;
			this.SyncThumbnailsSizeCheckBox.Checked = true;
			this.SyncThumbnailsSizeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.SyncThumbnailsSizeCheckBox.Location = new System.Drawing.Point(1, 3);
			this.SyncThumbnailsSizeCheckBox.Name = "SyncThumbnailsSizeCheckBox";
			this.SyncThumbnailsSizeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.SyncThumbnailsSizeCheckBox.Size = new System.Drawing.Size(108, 17);
			this.SyncThumbnailsSizeCheckBox.TabIndex = 4;
			this.SyncThumbnailsSizeCheckBox.Text = "Syncronize resize";
			this.SyncThumbnailsSizeCheckBox.UseVisualStyleBackColor = true;
			this.SyncThumbnailsSizeCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ThumbnailsWidthNumericEdit
			// 
			this.ThumbnailsWidthNumericEdit.BackColor = System.Drawing.SystemColors.Window;
			this.ThumbnailsWidthNumericEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ThumbnailsWidthNumericEdit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.ThumbnailsWidthNumericEdit.Location = new System.Drawing.Point(137, 3);
			this.ThumbnailsWidthNumericEdit.Maximum = new decimal(new int[] {
            640,
            0,
            0,
            0});
			this.ThumbnailsWidthNumericEdit.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
			this.ThumbnailsWidthNumericEdit.Name = "ThumbnailsWidthNumericEdit";
			this.ThumbnailsWidthNumericEdit.Size = new System.Drawing.Size(48, 20);
			this.ThumbnailsWidthNumericEdit.TabIndex = 11;
			this.ThumbnailsWidthNumericEdit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.ThumbnailsWidthNumericEdit.TextChanged += new System.EventHandler(this.ThumbnailSizeChanged_Handler);
			this.ThumbnailsWidthNumericEdit.ValueChanged += new System.EventHandler(this.ThumbnailSizeChanged_Handler);
			// 
			// ThumbnailsHeightNumericEdit
			// 
			this.ThumbnailsHeightNumericEdit.BackColor = System.Drawing.SystemColors.Window;
			this.ThumbnailsHeightNumericEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ThumbnailsHeightNumericEdit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.ThumbnailsHeightNumericEdit.Location = new System.Drawing.Point(196, 3);
			this.ThumbnailsHeightNumericEdit.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
			this.ThumbnailsHeightNumericEdit.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.ThumbnailsHeightNumericEdit.Name = "ThumbnailsHeightNumericEdit";
			this.ThumbnailsHeightNumericEdit.Size = new System.Drawing.Size(42, 20);
			this.ThumbnailsHeightNumericEdit.TabIndex = 12;
			this.ThumbnailsHeightNumericEdit.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
			this.ThumbnailsHeightNumericEdit.TextChanged += new System.EventHandler(this.ThumbnailSizeChanged_Handler);
			this.ThumbnailsHeightNumericEdit.ValueChanged += new System.EventHandler(this.ThumbnailSizeChanged_Handler);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(ZoomFactorLabel);
			this.panel2.Controls.Add(this.ZoomAnchorPanel);
			this.panel2.Controls.Add(ZoomAnchorLabel);
			this.panel2.Controls.Add(this.EnableZoomOnHoverCheckBox);
			this.panel2.Controls.Add(this.ZoomFactorNumericEdit);
			this.panel2.Location = new System.Drawing.Point(3, 209);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(246, 62);
			this.panel2.TabIndex = 27;
			// 
			// ZoomFactorLabel
			// 
			ZoomFactorLabel.AutoSize = true;
			ZoomFactorLabel.Location = new System.Drawing.Point(49, 31);
			ZoomFactorLabel.Name = "ZoomFactorLabel";
			ZoomFactorLabel.Size = new System.Drawing.Size(37, 13);
			ZoomFactorLabel.TabIndex = 29;
			ZoomFactorLabel.Text = "Factor";
			// 
			// ZoomAnchorPanel
			// 
			this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorNWRadioButton);
			this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorNRadioButton);
			this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorNERadioButton);
			this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorWRadioButton);
			this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorSERadioButton);
			this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorCRadioButton);
			this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorSRadioButton);
			this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorERadioButton);
			this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorSWRadioButton);
			this.ZoomAnchorPanel.Location = new System.Drawing.Point(182, 3);
			this.ZoomAnchorPanel.Name = "ZoomAnchorPanel";
			this.ZoomAnchorPanel.Size = new System.Drawing.Size(60, 57);
			this.ZoomAnchorPanel.TabIndex = 28;
			// 
			// ZoomAanchorNWRadioButton
			// 
			this.ZoomAanchorNWRadioButton.AutoSize = true;
			this.ZoomAanchorNWRadioButton.Location = new System.Drawing.Point(3, 3);
			this.ZoomAanchorNWRadioButton.Name = "ZoomAanchorNWRadioButton";
			this.ZoomAanchorNWRadioButton.Size = new System.Drawing.Size(14, 13);
			this.ZoomAanchorNWRadioButton.TabIndex = 15;
			this.ZoomAanchorNWRadioButton.TabStop = true;
			this.ZoomAanchorNWRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorNWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorNRadioButton
			// 
			this.ZoomAanchorNRadioButton.AutoSize = true;
			this.ZoomAanchorNRadioButton.Location = new System.Drawing.Point(23, 3);
			this.ZoomAanchorNRadioButton.Name = "ZoomAanchorNRadioButton";
			this.ZoomAanchorNRadioButton.Size = new System.Drawing.Size(14, 13);
			this.ZoomAanchorNRadioButton.TabIndex = 16;
			this.ZoomAanchorNRadioButton.TabStop = true;
			this.ZoomAanchorNRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorNRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorNERadioButton
			// 
			this.ZoomAanchorNERadioButton.AutoSize = true;
			this.ZoomAanchorNERadioButton.Location = new System.Drawing.Point(43, 3);
			this.ZoomAanchorNERadioButton.Name = "ZoomAanchorNERadioButton";
			this.ZoomAanchorNERadioButton.Size = new System.Drawing.Size(14, 13);
			this.ZoomAanchorNERadioButton.TabIndex = 17;
			this.ZoomAanchorNERadioButton.TabStop = true;
			this.ZoomAanchorNERadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorNERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorWRadioButton
			// 
			this.ZoomAanchorWRadioButton.AutoSize = true;
			this.ZoomAanchorWRadioButton.Location = new System.Drawing.Point(3, 22);
			this.ZoomAanchorWRadioButton.Name = "ZoomAanchorWRadioButton";
			this.ZoomAanchorWRadioButton.Size = new System.Drawing.Size(14, 13);
			this.ZoomAanchorWRadioButton.TabIndex = 18;
			this.ZoomAanchorWRadioButton.TabStop = true;
			this.ZoomAanchorWRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorSERadioButton
			// 
			this.ZoomAanchorSERadioButton.AutoSize = true;
			this.ZoomAanchorSERadioButton.Location = new System.Drawing.Point(43, 41);
			this.ZoomAanchorSERadioButton.Name = "ZoomAanchorSERadioButton";
			this.ZoomAanchorSERadioButton.Size = new System.Drawing.Size(14, 13);
			this.ZoomAanchorSERadioButton.TabIndex = 23;
			this.ZoomAanchorSERadioButton.TabStop = true;
			this.ZoomAanchorSERadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorSERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorCRadioButton
			// 
			this.ZoomAanchorCRadioButton.AutoSize = true;
			this.ZoomAanchorCRadioButton.Location = new System.Drawing.Point(23, 22);
			this.ZoomAanchorCRadioButton.Name = "ZoomAanchorCRadioButton";
			this.ZoomAanchorCRadioButton.Size = new System.Drawing.Size(14, 13);
			this.ZoomAanchorCRadioButton.TabIndex = 19;
			this.ZoomAanchorCRadioButton.TabStop = true;
			this.ZoomAanchorCRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorCRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorSRadioButton
			// 
			this.ZoomAanchorSRadioButton.AutoSize = true;
			this.ZoomAanchorSRadioButton.Location = new System.Drawing.Point(23, 41);
			this.ZoomAanchorSRadioButton.Name = "ZoomAanchorSRadioButton";
			this.ZoomAanchorSRadioButton.Size = new System.Drawing.Size(14, 13);
			this.ZoomAanchorSRadioButton.TabIndex = 22;
			this.ZoomAanchorSRadioButton.TabStop = true;
			this.ZoomAanchorSRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorSRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorERadioButton
			// 
			this.ZoomAanchorERadioButton.AutoSize = true;
			this.ZoomAanchorERadioButton.Location = new System.Drawing.Point(43, 22);
			this.ZoomAanchorERadioButton.Name = "ZoomAanchorERadioButton";
			this.ZoomAanchorERadioButton.Size = new System.Drawing.Size(14, 13);
			this.ZoomAanchorERadioButton.TabIndex = 20;
			this.ZoomAanchorERadioButton.TabStop = true;
			this.ZoomAanchorERadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorSWRadioButton
			// 
			this.ZoomAanchorSWRadioButton.AutoSize = true;
			this.ZoomAanchorSWRadioButton.Location = new System.Drawing.Point(3, 41);
			this.ZoomAanchorSWRadioButton.Name = "ZoomAanchorSWRadioButton";
			this.ZoomAanchorSWRadioButton.Size = new System.Drawing.Size(14, 13);
			this.ZoomAanchorSWRadioButton.TabIndex = 21;
			this.ZoomAanchorSWRadioButton.TabStop = true;
			this.ZoomAanchorSWRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorSWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAnchorLabel
			// 
			ZoomAnchorLabel.AutoSize = true;
			ZoomAnchorLabel.Location = new System.Drawing.Point(138, 31);
			ZoomAnchorLabel.Name = "ZoomAnchorLabel";
			ZoomAnchorLabel.Size = new System.Drawing.Size(41, 13);
			ZoomAnchorLabel.TabIndex = 30;
			ZoomAnchorLabel.Text = "Anchor";
			// 
			// EnableZoomOnHoverCheckBox
			// 
			this.EnableZoomOnHoverCheckBox.AutoSize = true;
			this.EnableZoomOnHoverCheckBox.Checked = true;
			this.EnableZoomOnHoverCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.EnableZoomOnHoverCheckBox.Location = new System.Drawing.Point(1, 5);
			this.EnableZoomOnHoverCheckBox.Name = "EnableZoomOnHoverCheckBox";
			this.EnableZoomOnHoverCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.EnableZoomOnHoverCheckBox.Size = new System.Drawing.Size(98, 17);
			this.EnableZoomOnHoverCheckBox.TabIndex = 13;
			this.EnableZoomOnHoverCheckBox.Text = "Zoom on hover";
			this.EnableZoomOnHoverCheckBox.UseVisualStyleBackColor = true;
			this.EnableZoomOnHoverCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomFactorNumericEdit
			// 
			this.ZoomFactorNumericEdit.BackColor = System.Drawing.SystemColors.Window;
			this.ZoomFactorNumericEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ZoomFactorNumericEdit.Location = new System.Drawing.Point(9, 28);
			this.ZoomFactorNumericEdit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.ZoomFactorNumericEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ZoomFactorNumericEdit.Name = "ZoomFactorNumericEdit";
			this.ZoomFactorNumericEdit.Size = new System.Drawing.Size(34, 20);
			this.ZoomFactorNumericEdit.TabIndex = 24;
			this.ZoomFactorNumericEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ZoomFactorNumericEdit.ValueChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ShowThumbnailOverlaysCheckBox
			// 
			this.ShowThumbnailOverlaysCheckBox.AutoSize = true;
			this.ShowThumbnailOverlaysCheckBox.Checked = true;
			this.ShowThumbnailOverlaysCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ShowThumbnailOverlaysCheckBox.Location = new System.Drawing.Point(3, 277);
			this.ShowThumbnailOverlaysCheckBox.Name = "ShowThumbnailOverlaysCheckBox";
			this.ShowThumbnailOverlaysCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowThumbnailOverlaysCheckBox.Size = new System.Drawing.Size(90, 17);
			this.ShowThumbnailOverlaysCheckBox.TabIndex = 14;
			this.ShowThumbnailOverlaysCheckBox.Text = "Show overlay";
			this.ShowThumbnailOverlaysCheckBox.UseVisualStyleBackColor = true;
			this.ShowThumbnailOverlaysCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ShowThumbnailFramesCheckBox
			// 
			this.ShowThumbnailFramesCheckBox.AutoSize = true;
			this.ShowThumbnailFramesCheckBox.Checked = true;
			this.ShowThumbnailFramesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ShowThumbnailFramesCheckBox.Location = new System.Drawing.Point(99, 277);
			this.ShowThumbnailFramesCheckBox.Name = "ShowThumbnailFramesCheckBox";
			this.ShowThumbnailFramesCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowThumbnailFramesCheckBox.Size = new System.Drawing.Size(127, 17);
			this.ShowThumbnailFramesCheckBox.TabIndex = 9;
			this.ShowThumbnailFramesCheckBox.Text = "Show preview frames";
			this.ShowThumbnailFramesCheckBox.UseVisualStyleBackColor = true;
			this.ShowThumbnailFramesCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.ThumbnailsList);
			this.panel5.Controls.Add(PreviewsListLabel);
			this.panel5.Location = new System.Drawing.Point(3, 300);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(246, 125);
			this.panel5.TabIndex = 31;
			// 
			// ThumbnailsList
			// 
			this.ThumbnailsList.BackColor = System.Drawing.SystemColors.Window;
			this.ThumbnailsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ThumbnailsList.FormattingEnabled = true;
			this.ThumbnailsList.IntegralHeight = false;
			this.ThumbnailsList.Location = new System.Drawing.Point(3, 18);
			this.ThumbnailsList.Name = "ThumbnailsList";
			this.ThumbnailsList.Size = new System.Drawing.Size(240, 100);
			this.ThumbnailsList.TabIndex = 28;
			this.ThumbnailsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ThumbnailsList_ItemCheck_Handler);
			// 
			// PreviewsListLabel
			// 
			PreviewsListLabel.AutoSize = true;
			PreviewsListLabel.Location = new System.Drawing.Point(3, 0);
			PreviewsListLabel.Name = "PreviewsListLabel";
			PreviewsListLabel.Size = new System.Drawing.Size(151, 13);
			PreviewsListLabel.TabIndex = 29;
			PreviewsListLabel.Text = "Previews (check to force hide)";
			// 
			// ForumLinkLabel
			// 
			this.ForumLinkLabel.AutoSize = true;
			this.ForumLinkLabel.Location = new System.Drawing.Point(3, 428);
			this.ForumLinkLabel.Name = "ForumLinkLabel";
			this.ForumLinkLabel.Size = new System.Drawing.Size(241, 26);
			this.ForumLinkLabel.TabIndex = 10;
			this.ForumLinkLabel.TabStop = true;
			this.ForumLinkLabel.Text = "to be set from prresenter to be set from prresenter to be set from prresenter to " +
    "be set from prresenter";
			this.ForumLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForumLinkLabelClicked_Handler);
			// 
			// NotifyIcon
			// 
			this.NotifyIcon.ContextMenuStrip = this.TrayMenu;
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
			this.NotifyIcon.Text = "EVE-O Preview";
			this.NotifyIcon.Visible = true;
			this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RestoreMainForm_Handler);
			// 
			// TrayMenu
			// 
			this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            RestoreWindowMenuItem,
            ExitMenuItem});
			this.TrayMenu.Name = "contextMenuStrip1";
			this.TrayMenu.Size = new System.Drawing.Size(114, 48);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(252, 467);
			this.Controls.Add(ContentFlowLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "EVE Online previewer";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing_Handler);
			this.Resize += new System.EventHandler(this.MainFormResize_Handler);
			ContentFlowLayoutPanel.ResumeLayout(false);
			ContentFlowLayoutPanel.PerformLayout();
			OpacityPanel.ResumeLayout(false);
			OpacityPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ThumbnailsWidthNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ThumbnailsHeightNumericEdit)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ZoomAnchorPanel.ResumeLayout(false);
			this.ZoomAnchorPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ZoomFactorNumericEdit)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.TrayMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private CheckBox HideActiveClientThumbnailCheckBox;
		private CheckBox HideAllThumbnailsIfClientIsNotActiveCheckBox;
		private CheckBox EnableUniqueThumbnailsLayoutsCheckBox;
		private CheckBox SyncThumbnailsSizeCheckBox;
		private CheckBox ShowThumbnailsAlwaysOnTopCheckBox;
		private CheckBox ShowThumbnailFramesCheckBox;
		private LinkLabel ForumLinkLabel;
		private NumericUpDown ThumbnailsWidthNumericEdit;
		private NumericUpDown ThumbnailsHeightNumericEdit;
		private CheckBox EnableZoomOnHoverCheckBox;
		private CheckBox ShowThumbnailOverlaysCheckBox;
		private RadioButton ZoomAanchorNWRadioButton;
		private RadioButton ZoomAanchorNRadioButton;
		private RadioButton ZoomAanchorNERadioButton;
		private RadioButton ZoomAanchorWRadioButton;
		private RadioButton ZoomAanchorCRadioButton;
		private RadioButton ZoomAanchorERadioButton;
		private RadioButton ZoomAanchorSWRadioButton;
		private RadioButton ZoomAanchorSRadioButton;
		private RadioButton ZoomAanchorSERadioButton;
		private NumericUpDown ZoomFactorNumericEdit;
		private Panel panel1;
		private Panel panel2;
		private Panel ZoomAnchorPanel;
		private CheckedListBox ThumbnailsList;
		private Panel panel5;
		private CheckBox TrackClientLocationsCheckBox;
		private HScrollBar ThumbnailsOpacityScrollBar;
		private CheckBox MinimizeToTrayCheckBox;
		private NotifyIcon NotifyIcon;
		private ContextMenuStrip TrayMenu;
	}
}