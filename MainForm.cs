/*
 * Created by SharpDevelop.
 * User: dwang21
 * Date: 10/11/2017
 * Time: 09:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Rename
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<string> listFiles = new List<string>();
		doReName renameFormInput = new doReName();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//		
			textBoxCustom.Clear();
			rule.Text = File.ReadAllText(".\\Config\\Help.txt");
			LoadSugList(".\\Config\\SuggestList.txt");
			LoadPattList(".\\Config\\PattList.txt");
		}
		
		// Load suggestion list
		void LoadSugList(string path){
			string[] sugList = File.ReadAllLines(path);
			var source = new AutoCompleteStringCollection();
			foreach(string sug in sugList){
				source.Add(sug);
			}
			textBoxCustom.AutoCompleteCustomSource = source;
		}
		
		// Load pattern suggestion list
		void LoadPattList(string path){
			string[] sugList = File.ReadAllLines(path);
			var source = new AutoCompleteStringCollection();
			foreach(string sug in sugList){
				source.Add(sug);
			}
			textBoxPatt.AutoCompleteCustomSource = source;
		}		
		
		// [Open] Select files to be renamed
		void ButtonOpenClick(object sender, EventArgs e)
		{
		    DialogResult dr = this.openFileDialog1.ShowDialog();
		    if (dr == System.Windows.Forms.DialogResult.OK)
		    {
		    	textBoxPath.Clear();
		    	listFiles.Clear();
		    	foreach(String f in openFileDialog1.FileNames){
		    		listFiles.Add(Path.GetFileName(f));
		    	}
                renameFormInput._inName = listFiles;
                renameFormInput.fullPath = Path.GetDirectoryName(openFileDialog1.FileName);
                renameFormInput.nonRepFCnt = renameFormInput.getNonRepFileCnt(listFiles);


                string allF = "";
		    	// Gen. the text to be shown on GUI
		    	foreach(string eachf in listFiles){
		    		allF += eachf;
		    		allF += ", ";
		    	}
		    	textBoxPath.Text = allF;
		    	labelFileCnt.Text = string.Format("File Count: {0}, {1}",openFileDialog1.FileNames.Length, renameFormInput.nonRepFCnt);
			}
		}
		// Gen. output file name and save in _outName
		int GenOutFileName(){
            if (numericUpDownRep.Value > 1)
            {
                renameFormInput.nonRepFCnt = renameFormInput.getNonRepFileCnt(listFiles) / Decimal.ToInt32(numericUpDownRep.Value);
                labelFileCnt.Text = string.Format("File Count: {0}, {1}", openFileDialog1.FileNames.Length, renameFormInput.nonRepFCnt);
            }
            renameFormInput.repeat = Decimal.ToInt32(numericUpDownRep.Value);

            renameFormInput._patt = textBoxPatt.Text;
			//renameFormInput._inName = listFiles;
			int ret = renameFormInput.genNewNameList(renameFormInput.getCustomList(textBoxCustom.Text), Decimal.ToInt32(numericUpDownSN.Value));
			return ret;
		}
		
		// [Preview] Show preview
		void ButtonPreClick(object sender, EventArgs e)
		{
			int ret = GenOutFileName();
			if(ret == -1)
				return;
			string message = renameFormInput.getPreview();
			MessageBox.Show(message, "Preview");
			buttonRun.PerformClick();
		}
		
		// [Checkbox] Show textbox for editing only when checkbox is enabled
		void CheckBoxCustomCheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxCustom.Checked == false){
				textBoxCustom.Enabled = false;
				textBoxCustom.Clear();
				numericUpDownSN.Enabled = true;
			} else {
				textBoxCustom.Enabled = true;
				numericUpDownSN.Enabled = false;
				numericUpDownSN.Value = 0;
			}
		}
		void ButtonRunClick(object sender, EventArgs e)
		{
			int ret = GenOutFileName();
			if(ret == -1)
				return;
			string message = renameFormInput.getPreview();
			
			if (MessageBox.Show("Do rename?\n"+ message, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
				Process process = new System.Diagnostics.Process();
				ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
				startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
				startInfo.FileName = "cmd.exe";
			
				for(int i=0; i<renameFormInput._inName.Count; i++){
					string fromStr = Path.Combine(renameFormInput.fullPath, renameFormInput._inName[i]);
					string toStr = Path.Combine(renameFormInput.fullPath, renameFormInput._outName[i]);
					// Error handling for duplicated name
					if(File.Exists(toStr) == true){
						MessageBox.Show(string.Format("[Error] {0} exists",toStr),"Error");
						return;
					}
					startInfo.Arguments = string.Format( "/C move \"{0}\" \"{1}\"", fromStr, toStr);
					process.StartInfo = startInfo;
					process.Start();
				}
            }
		}
	}
}
