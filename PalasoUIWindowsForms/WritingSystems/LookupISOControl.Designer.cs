﻿namespace Palaso.UI.WindowsForms.WritingSystems
{
	partial class LookupISOControl
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._listView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._searchText = new System.Windows.Forms.TextBox();
			this._aboutISO639_1 = new System.Windows.Forms.LinkLabel();
			this._aboutISO639_3Link = new System.Windows.Forms.LinkLabel();
			this._searchTimer = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			//
			// _listView
			//
			this._listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)));
			this._listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2});
			this._listView.FullRowSelect = true;
			this._listView.HideSelection = false;
			this._listView.Location = new System.Drawing.Point(3, 29);
			this._listView.Name = "_listView";
			this._listView.Size = new System.Drawing.Size(280, 230);
			this._listView.TabIndex = 1;
			this._listView.UseCompatibleStateImageBehavior = false;
			this._listView.View = System.Windows.Forms.View.Details;
			this._listView.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
			this._listView.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			//
			// columnHeader1
			//
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 163;
			//
			// columnHeader2
			//
			this.columnHeader2.Text = "Code";
			//
			// _searchText
			//
			this._searchText.Location = new System.Drawing.Point(6, 3);
			this._searchText.Name = "_searchText";
			this._searchText.Size = new System.Drawing.Size(277, 20);
			this._searchText.TabIndex = 0;
			//
			// _aboutISO639_1
			//
			this._aboutISO639_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._aboutISO639_1.Location = new System.Drawing.Point(0, 273);
			this._aboutISO639_1.Name = "_aboutISO639_1";
			this._aboutISO639_1.Size = new System.Drawing.Size(196, 14);
			this._aboutISO639_1.TabIndex = 2;
			this._aboutISO639_1.TabStop = true;
			this._aboutISO639_1.Text = "About Language 639-1 Codes";
			this._aboutISO639_1.Click += new System.EventHandler(this.OnAboutLink639_1_Click);
			//
			// _aboutISO639_3Link
			//
			this._aboutISO639_3Link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._aboutISO639_3Link.Location = new System.Drawing.Point(0, 301);
			this._aboutISO639_3Link.Name = "_aboutISO639_3Link";
			this._aboutISO639_3Link.Size = new System.Drawing.Size(196, 14);
			this._aboutISO639_3Link.TabIndex = 3;
			this._aboutISO639_3Link.TabStop = true;
			this._aboutISO639_3Link.Text = "About Language 639-3 Codes";
			this._aboutISO639_3Link.Click += new System.EventHandler(this.OnAbout639_3_Clicked);
			//
			// _searchTimer
			//
			this._searchTimer.Tick += new System.EventHandler(this._searchTimer_Tick);
			//
			// pictureBox1
			//
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = global::Palaso.UI.WindowsForms.Properties.Resources.search18x18;
			this.pictureBox1.Location = new System.Drawing.Point(263, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(18, 18);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			//
			// LookupISOControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this._listView);
			this.Controls.Add(this._searchText);
			this.Controls.Add(this._aboutISO639_1);
			this.Controls.Add(this._aboutISO639_3Link);
			this.Name = "LookupISOControl";
			this.Size = new System.Drawing.Size(298, 319);
			this.Load += new System.EventHandler(this.OnLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView _listView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.TextBox _searchText;
		private System.Windows.Forms.LinkLabel _aboutISO639_1;
		private System.Windows.Forms.LinkLabel _aboutISO639_3Link;
		private System.Windows.Forms.Timer _searchTimer;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
