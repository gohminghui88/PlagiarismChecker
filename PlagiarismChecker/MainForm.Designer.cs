/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 30/08/2016
 * Time: 9:41 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PlagiarismChecker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.TextBox wordsNumTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox outTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox optComboBox;
		private System.Windows.Forms.Button abtButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button checkButton;
		private System.Windows.Forms.CheckBox bingCheckBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox googleCheckBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.wordsNumTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.outTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.optComboBox = new System.Windows.Forms.ComboBox();
			this.abtButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.checkButton = new System.Windows.Forms.Button();
			this.bingCheckBox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.googleCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Size = new System.Drawing.Size(842, 601);
			this.splitContainer1.SplitterDistance = 127;
			this.splitContainer1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.browseButton);
			this.groupBox2.Controls.Add(this.wordsNumTextBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.outTextBox);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.optComboBox);
			this.groupBox2.Controls.Add(this.abtButton);
			this.groupBox2.Controls.Add(this.cancelButton);
			this.groupBox2.Controls.Add(this.checkButton);
			this.groupBox2.Controls.Add(this.bingCheckBox);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.googleCheckBox);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(842, 127);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Settings";
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(534, 19);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(31, 23);
			this.browseButton.TabIndex = 14;
			this.browseButton.Text = "...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// wordsNumTextBox
			// 
			this.wordsNumTextBox.Location = new System.Drawing.Point(338, 50);
			this.wordsNumTextBox.Name = "wordsNumTextBox";
			this.wordsNumTextBox.Size = new System.Drawing.Size(74, 20);
			this.wordsNumTextBox.TabIndex = 13;
			this.wordsNumTextBox.Text = "5";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(311, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "of ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(149, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "using";
			// 
			// outTextBox
			// 
			this.outTextBox.Location = new System.Drawing.Point(102, 21);
			this.outTextBox.Name = "outTextBox";
			this.outTextBox.Size = new System.Drawing.Size(426, 20);
			this.outTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Output Report: ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Check every: ";
			// 
			// optComboBox
			// 
			this.optComboBox.FormattingEnabled = true;
			this.optComboBox.Items.AddRange(new object[] {
			"Sentence",
			"Words"});
			this.optComboBox.Location = new System.Drawing.Point(102, 50);
			this.optComboBox.Name = "optComboBox";
			this.optComboBox.Size = new System.Drawing.Size(192, 21);
			this.optComboBox.TabIndex = 2;
			this.optComboBox.Text = "Sentence";
			this.optComboBox.SelectedIndexChanged += new System.EventHandler(this.OptComboBoxSelectedIndexChanged);
			// 
			// abtButton
			// 
			this.abtButton.Location = new System.Drawing.Point(755, 92);
			this.abtButton.Name = "abtButton";
			this.abtButton.Size = new System.Drawing.Size(75, 23);
			this.abtButton.TabIndex = 6;
			this.abtButton.Text = "About";
			this.abtButton.UseVisualStyleBackColor = true;
			this.abtButton.Click += new System.EventHandler(this.AbtButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(755, 48);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(755, 19);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(75, 23);
			this.checkButton.TabIndex = 4;
			this.checkButton.Text = "Check!";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.CheckButtonClick);
			// 
			// bingCheckBox
			// 
			this.bingCheckBox.Location = new System.Drawing.Point(190, 92);
			this.bingCheckBox.Name = "bingCheckBox";
			this.bingCheckBox.Size = new System.Drawing.Size(104, 24);
			this.bingCheckBox.TabIndex = 3;
			this.bingCheckBox.Text = "Bing";
			this.bingCheckBox.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Search Engines: ";
			// 
			// googleCheckBox
			// 
			this.googleCheckBox.Location = new System.Drawing.Point(119, 92);
			this.googleCheckBox.Name = "googleCheckBox";
			this.googleCheckBox.Size = new System.Drawing.Size(104, 24);
			this.googleCheckBox.TabIndex = 0;
			this.googleCheckBox.Text = "Google";
			this.googleCheckBox.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.richTextBox1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(842, 470);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Text";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(3, 16);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(836, 451);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 601);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PlagiarismChecker";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
