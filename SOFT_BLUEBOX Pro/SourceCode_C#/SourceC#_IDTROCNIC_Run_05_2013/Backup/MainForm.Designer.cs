namespace BLUEBOX_Polling
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.MainFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TagDataGridView = new System.Windows.Forms.DataGridView();
            this.DeviceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntennaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceDataGridView = new System.Windows.Forms.DataGridView();
            this.IpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FwRelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.MainFormMenuStrip.SuspendLayout();
            this.MainFormTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(692, 24);
            this.MainFormMenuStrip.TabIndex = 0;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainFormToolStrip
            // 
            this.MainFormToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainFormToolStrip.Name = "MainFormToolStrip";
            this.MainFormToolStrip.Size = new System.Drawing.Size(692, 25);
            this.MainFormToolStrip.TabIndex = 1;
            this.MainFormToolStrip.Text = "toolStrip1";
            // 
            // MainFormStatusStrip
            // 
            this.MainFormStatusStrip.Location = new System.Drawing.Point(0, 424);
            this.MainFormStatusStrip.Name = "MainFormStatusStrip";
            this.MainFormStatusStrip.Size = new System.Drawing.Size(692, 22);
            this.MainFormStatusStrip.TabIndex = 2;
            this.MainFormStatusStrip.Text = "statusStrip1";
            // 
            // MainFormTableLayoutPanel
            // 
            this.MainFormTableLayoutPanel.ColumnCount = 5;
            this.MainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainFormTableLayoutPanel.Controls.Add(this.TagDataGridView, 0, 2);
            this.MainFormTableLayoutPanel.Controls.Add(this.DeviceDataGridView, 0, 0);
            this.MainFormTableLayoutPanel.Controls.Add(this.StartButton, 1, 1);
            this.MainFormTableLayoutPanel.Controls.Add(this.StopButton, 3, 1);
            this.MainFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormTableLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.MainFormTableLayoutPanel.Name = "MainFormTableLayoutPanel";
            this.MainFormTableLayoutPanel.RowCount = 3;
            this.MainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainFormTableLayoutPanel.Size = new System.Drawing.Size(692, 375);
            this.MainFormTableLayoutPanel.TabIndex = 3;
            // 
            // TagDataGridView
            // 
            this.TagDataGridView.AllowUserToAddRows = false;
            this.TagDataGridView.AllowUserToDeleteRows = false;
            this.TagDataGridView.AllowUserToResizeColumns = false;
            this.TagDataGridView.AllowUserToResizeRows = false;
            this.TagDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TagDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TagDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceColumn,
            this.AntennaColumn,
            this.InputColumn,
            this.TagTypeColumn,
            this.IdColumn,
            this.CountColumn});
            this.MainFormTableLayoutPanel.SetColumnSpan(this.TagDataGridView, 5);
            this.TagDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TagDataGridView.Location = new System.Drawing.Point(3, 215);
            this.TagDataGridView.Name = "TagDataGridView";
            this.TagDataGridView.ReadOnly = true;
            this.TagDataGridView.RowHeadersVisible = false;
            this.TagDataGridView.Size = new System.Drawing.Size(686, 157);
            this.TagDataGridView.TabIndex = 4;
            // 
            // DeviceColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DeviceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeviceColumn.HeaderText = "Device";
            this.DeviceColumn.MinimumWidth = 80;
            this.DeviceColumn.Name = "DeviceColumn";
            this.DeviceColumn.ReadOnly = true;
            this.DeviceColumn.Width = 80;
            // 
            // AntennaColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AntennaColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.AntennaColumn.HeaderText = "Antenna";
            this.AntennaColumn.MinimumWidth = 80;
            this.AntennaColumn.Name = "AntennaColumn";
            this.AntennaColumn.ReadOnly = true;
            this.AntennaColumn.Width = 80;
            // 
            // InputColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InputColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.InputColumn.HeaderText = "Input";
            this.InputColumn.MinimumWidth = 80;
            this.InputColumn.Name = "InputColumn";
            this.InputColumn.ReadOnly = true;
            this.InputColumn.Width = 80;
            // 
            // TagTypeColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TagTypeColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.TagTypeColumn.HeaderText = "Tag Type";
            this.TagTypeColumn.MinimumWidth = 80;
            this.TagTypeColumn.Name = "TagTypeColumn";
            this.TagTypeColumn.ReadOnly = true;
            this.TagTypeColumn.Width = 80;
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // CountColumn
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CountColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.CountColumn.HeaderText = "Count";
            this.CountColumn.MinimumWidth = 80;
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.ReadOnly = true;
            this.CountColumn.Width = 80;
            // 
            // DeviceDataGridView
            // 
            this.DeviceDataGridView.AllowUserToResizeColumns = false;
            this.DeviceDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DeviceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DeviceDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DeviceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DeviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IpColumn,
            this.PortColumn,
            this.AddressColumn,
            this.FwRelColumn});
            this.MainFormTableLayoutPanel.SetColumnSpan(this.DeviceDataGridView, 5);
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeviceDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.DeviceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DeviceDataGridView.MultiSelect = false;
            this.DeviceDataGridView.Name = "DeviceDataGridView";
            this.DeviceDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DeviceDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DeviceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeviceDataGridView.Size = new System.Drawing.Size(686, 156);
            this.DeviceDataGridView.TabIndex = 0;
            // 
            // IpColumn
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IpColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.IpColumn.Frozen = true;
            this.IpColumn.HeaderText = "IP";
            this.IpColumn.MinimumWidth = 150;
            this.IpColumn.Name = "IpColumn";
            this.IpColumn.Width = 150;
            // 
            // PortColumn
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PortColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.PortColumn.Frozen = true;
            this.PortColumn.HeaderText = "Port";
            this.PortColumn.MinimumWidth = 100;
            this.PortColumn.Name = "PortColumn";
            // 
            // AddressColumn
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AddressColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.MinimumWidth = 100;
            this.AddressColumn.Name = "AddressColumn";
            // 
            // FwRelColumn
            // 
            this.FwRelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FwRelColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.FwRelColumn.HeaderText = "Firmware Release";
            this.FwRelColumn.Name = "FwRelColumn";
            this.FwRelColumn.ReadOnly = true;
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(139, 165);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(194, 44);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start acquisition";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(359, 165);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(194, 44);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop acquisition";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(692, 446);
            this.Controls.Add(this.MainFormTableLayoutPanel);
            this.Controls.Add(this.MainFormStatusStrip);
            this.Controls.Add(this.MainFormToolStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLUEBOX Polling";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.MainFormTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TagDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip MainFormToolStrip;
        private System.Windows.Forms.StatusStrip MainFormStatusStrip;
        private System.Windows.Forms.TableLayoutPanel MainFormTableLayoutPanel;
        private System.Windows.Forms.DataGridView DeviceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FwRelColumn;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.DataGridView TagDataGridView;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntennaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
    }
}

