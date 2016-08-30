/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 30/08/2016
 * Time: 10:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlagiarismChecker
{
	/// <summary>
	/// Description of AbtForm.
	/// </summary>
	public partial class AbtForm : Form
	{
		public AbtForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
