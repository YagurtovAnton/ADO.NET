﻿namespace Academy
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
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			this.tabPageDirections = new System.Windows.Forms.TabPage();
			this.tabPageDisciplines = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.dgvDirections = new System.Windows.Forms.DataGridView();
			this.dgvDisciplines = new System.Windows.Forms.DataGridView();
			this.statusStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
			this.tabPageDirections.SuspendLayout();
			this.tabPageDisciplines.SuspendLayout();
			this.tabPageTeachers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCount});
			this.statusStrip.Location = new System.Drawing.Point(0, 535);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(844, 26);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip1";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Controls.Add(this.tabPageDirections);
			this.tabControl.Controls.Add(this.tabPageDisciplines);
			this.tabControl.Controls.Add(this.tabPageTeachers);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(844, 535);
			this.tabControl.TabIndex = 1;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.dgvStudents);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 25);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(836, 506);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// dgvStudents
			// 
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(0, 35);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.RowHeadersWidth = 51;
			this.dgvStudents.RowTemplate.Height = 24;
			this.dgvStudents.Size = new System.Drawing.Size(840, 472);
			this.dgvStudents.TabIndex = 0;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.dgvGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 25);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(836, 506);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// dgvGroups
			// 
			this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.Location = new System.Drawing.Point(0, 41);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.RowHeadersWidth = 51;
			this.dgvGroups.RowTemplate.Height = 24;
			this.dgvGroups.Size = new System.Drawing.Size(836, 465);
			this.dgvGroups.TabIndex = 0;
			// 
			// tabPageDirections
			// 
			this.tabPageDirections.Controls.Add(this.dgvDirections);
			this.tabPageDirections.Location = new System.Drawing.Point(4, 25);
			this.tabPageDirections.Name = "tabPageDirections";
			this.tabPageDirections.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDirections.Size = new System.Drawing.Size(836, 506);
			this.tabPageDirections.TabIndex = 2;
			this.tabPageDirections.Text = "Directions";
			this.tabPageDirections.UseVisualStyleBackColor = true;
			// 
			// tabPageDisciplines
			// 
			this.tabPageDisciplines.Controls.Add(this.dgvDisciplines);
			this.tabPageDisciplines.Location = new System.Drawing.Point(4, 25);
			this.tabPageDisciplines.Name = "tabPageDisciplines";
			this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisciplines.Size = new System.Drawing.Size(836, 506);
			this.tabPageDisciplines.TabIndex = 3;
			this.tabPageDisciplines.Text = "Disciplines";
			this.tabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Controls.Add(this.dgvTeachers);
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 25);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(836, 506);
			this.tabPageTeachers.TabIndex = 4;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(0, 37);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.RowHeadersWidth = 51;
			this.dgvTeachers.RowTemplate.Height = 24;
			this.dgvTeachers.Size = new System.Drawing.Size(840, 470);
			this.dgvTeachers.TabIndex = 2;
			// 
			// toolStripStatusLabelCount
			// 
			this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
			this.toolStripStatusLabelCount.Size = new System.Drawing.Size(182, 20);
			this.toolStripStatusLabelCount.Text = "toolStripStatusLabelCount";
			// 
			// dgvDirections
			// 
			this.dgvDirections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDirections.Location = new System.Drawing.Point(-4, 38);
			this.dgvDirections.Name = "dgvDirections";
			this.dgvDirections.RowHeadersWidth = 51;
			this.dgvDirections.RowTemplate.Height = 24;
			this.dgvDirections.Size = new System.Drawing.Size(844, 472);
			this.dgvDirections.TabIndex = 0;
			// 
			// dgvDisciplines
			// 
			this.dgvDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisciplines.Location = new System.Drawing.Point(0, 40);
			this.dgvDisciplines.Name = "dgvDisciplines";
			this.dgvDisciplines.RowHeadersWidth = 51;
			this.dgvDisciplines.RowTemplate.Height = 24;
			this.dgvDisciplines.Size = new System.Drawing.Size(840, 467);
			this.dgvDisciplines.TabIndex = 0;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 561);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Academy";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
			this.tabPageDirections.ResumeLayout(false);
			this.tabPageDisciplines.ResumeLayout(false);
			this.tabPageTeachers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageDirections;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.DataGridView dgvTeachers;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.DataGridView dgvGroups;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
		private System.Windows.Forms.DataGridView dgvDirections;
		private System.Windows.Forms.DataGridView dgvDisciplines;
	}
}

