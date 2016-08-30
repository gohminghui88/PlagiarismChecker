/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 30/08/2016
 * Time: 9:41 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PlagiarismChecker
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string curDir = System.IO.Directory.GetCurrentDirectory();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.wordsNumTextBox.Visible = false;
			this.label5.Visible = false;
			
			this.googleCheckBox.Checked = true;
			this.outTextBox.Text = curDir + "\\output.txt";
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void AbtButtonClick(object sender, EventArgs e)
		{
			AbtForm af = new AbtForm();
			af.ShowDialog();
		}
		
		void BrowseButtonClick(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Text Documents (*.txt)|*.txt";
			DialogResult res = sfd.ShowDialog();
			
			if(res == DialogResult.OK){
				outTextBox.Text = sfd.FileName;
			}
		}
		
		void OptComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			if(optComboBox.Text == "Sentence") {
				this.wordsNumTextBox.Visible = false;
				this.label5.Visible = false;
			}
			
			else if(optComboBox.Text == "Words") {
				this.wordsNumTextBox.Visible = true;
				this.label5.Visible = true;
			}
			
			else MessageBox.Show("Error!");
		}
		
		void CheckButtonClick(object sender, EventArgs e)
		{
			if(richTextBox1.Text != "" && outTextBox.Text != "")
			{
				if(richTextBox1.Text.Split(' ').Length < int.Parse(wordsNumTextBox.Text)) MessageBox.Show("Please input more text. ");
				
				else {
					
					DialogResult dr = MessageBox.Show("This can take quite some time. Do you want to continue? ", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					
					if(dr == DialogResult.Yes) {
						
						CheckPlagiarism cp = new CheckPlagiarism();
					
						string[] corpuses = new string[9999];
					
						if(optComboBox.Text == "Words")
							corpuses = cp.getWordGroups(richTextBox1.Text, int.Parse(wordsNumTextBox.Text));
						else if(optComboBox.Text == "Sentence")
							corpuses = cp.getSentences(richTextBox1.Text);
					
						
						//SHOW INPUT TEXT
						richTextBox1.Text = "\n\n\n---------------------------------\n" + "INPUT TEXT" + "\n---------------------------------\n\n" + richTextBox1.Text;
						
						//SHOW CORPUSES
						richTextBox1.Text += "\n\n\n---------------------------------\n";
						richTextBox1.Text += "DERIVED SENTENCES OR WORD GROUPS";
						richTextBox1.Text += "\n---------------------------------\n\n";
					
						int k = 1;
						foreach(string c in corpuses) {
							if(c != "") richTextBox1.Text += "\n[" + k.ToString() + "]: " + c;
							k++;
						}
					
						//SHOW PLAGIARIZED
						richTextBox1.Text += "\n\n\n---------------------------------\n";
						richTextBox1.Text += "PLAGIARIZED";
						richTextBox1.Text += "\n---------------------------------\n\n";
						
						string[] res = cp.checkPlagiarism(corpuses, googleCheckBox.Checked, bingCheckBox.Checked);
					
						k = 1;
						foreach(string r in res) {
							if(r != "") richTextBox1.Text += "\n[" + k.ToString() + "] Plagiarized. Found at: " + r;
							k++;
						}
						
						float percentPlagiarized = ( cp.plagiarized / (float) cp.numCorpuses ) * 100;
						richTextBox1.Text += "\n\n---------------------------------\n";
						richTextBox1.Text += "Number of Plagarism Found: " + cp.plagiarized.ToString() + ". \nTotal Number of Sentences/Word Groups Checked: " + cp.numCorpuses.ToString();
						richTextBox1.Text += "\n% Plagiarized: " + percentPlagiarized.ToString();
						
						cp.numCorpuses = 0;
						cp.plagiarized = 0;
						
						
						//SAVE OUTPUT FILE
						richTextBox1.SaveFile(outTextBox.Text, RichTextBoxStreamType.PlainText);
						
						if(File.Exists(outTextBox.Text)) MessageBox.Show("Results have been saved to: \"" + outTextBox.Text + "\"");
						
					}
				}
			}
			
			else MessageBox.Show("Please input some text to check first. Output File cannot be empty too. ");
			
		}
		
		
	}
}
