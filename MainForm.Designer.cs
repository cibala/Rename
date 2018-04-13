/*
 * Created by SharpDevelop.
 * User: dwang21
 * Date: 10/11/2017
 * Time: 09:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rename
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonRun;
		private System.Windows.Forms.Button buttonPre;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label labelPatt;
		private System.Windows.Forms.TextBox textBoxPatt;
		private System.Windows.Forms.Label rule;
		private System.Windows.Forms.CheckBox checkBoxCustom;
		private System.Windows.Forms.TextBox textBoxCustom;
		private System.Windows.Forms.Label labelFileCnt;
		private System.Windows.Forms.GroupBox groupBoxRule;
		private System.Windows.Forms.GroupBox groupBoxHelp;
		private System.Windows.Forms.NumericUpDown numericUpDownSN;
		
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonPre = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelPatt = new System.Windows.Forms.Label();
            this.textBoxPatt = new System.Windows.Forms.TextBox();
            this.rule = new System.Windows.Forms.Label();
            this.checkBoxCustom = new System.Windows.Forms.CheckBox();
            this.textBoxCustom = new System.Windows.Forms.TextBox();
            this.labelFileCnt = new System.Windows.Forms.Label();
            this.groupBoxRule = new System.Windows.Forms.GroupBox();
            this.numericUpDownSN = new System.Windows.Forms.NumericUpDown();
            this.groupBoxHelp = new System.Windows.Forms.GroupBox();
            this.numericUpDownRep = new System.Windows.Forms.NumericUpDown();
            this.labelRep = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.groupBoxRule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSN)).BeginInit();
            this.groupBoxHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRep)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(301, 95);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run...";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRunClick);
            // 
            // buttonPre
            // 
            this.buttonPre.Enabled = false;
            this.buttonPre.Location = new System.Drawing.Point(301, 64);
            this.buttonPre.Name = "buttonPre";
            this.buttonPre.Size = new System.Drawing.Size(75, 23);
            this.buttonPre.TabIndex = 1;
            this.buttonPre.Text = "Preview...";
            this.buttonPre.UseVisualStyleBackColor = true;
            this.buttonPre.Click += new System.EventHandler(this.ButtonPreClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(301, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpenClick);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(12, 15);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(283, 20);
            this.textBoxPath.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // labelPatt
            // 
            this.labelPatt.Location = new System.Drawing.Point(6, 19);
            this.labelPatt.Name = "labelPatt";
            this.labelPatt.Size = new System.Drawing.Size(38, 20);
            this.labelPatt.TabIndex = 4;
            this.labelPatt.Text = "Pattern";
            // 
            // textBoxPatt
            // 
            this.textBoxPatt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPatt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPatt.Location = new System.Drawing.Point(50, 19);
            this.textBoxPatt.Name = "textBoxPatt";
            this.textBoxPatt.Size = new System.Drawing.Size(181, 20);
            this.textBoxPatt.TabIndex = 5;
            // 
            // rule
            // 
            this.rule.AutoSize = true;
            this.rule.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rule.Location = new System.Drawing.Point(6, 26);
            this.rule.Name = "rule";
            this.rule.Size = new System.Drawing.Size(144, 13);
            this.rule.TabIndex = 6;
            this.rule.Text = "Replace # with serial number";
            // 
            // checkBoxCustom
            // 
            this.checkBoxCustom.Location = new System.Drawing.Point(6, 82);
            this.checkBoxCustom.Name = "checkBoxCustom";
            this.checkBoxCustom.Size = new System.Drawing.Size(240, 24);
            this.checkBoxCustom.TabIndex = 7;
            this.checkBoxCustom.Text = "Custom sequence, seperate with \",\"";
            this.checkBoxCustom.UseVisualStyleBackColor = true;
            this.checkBoxCustom.CheckedChanged += new System.EventHandler(this.CheckBoxCustomCheckedChanged);
            // 
            // textBoxCustom
            // 
            this.textBoxCustom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCustom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCustom.Enabled = false;
            this.textBoxCustom.Location = new System.Drawing.Point(6, 112);
            this.textBoxCustom.Name = "textBoxCustom";
            this.textBoxCustom.Size = new System.Drawing.Size(271, 20);
            this.textBoxCustom.TabIndex = 8;
            // 
            // labelFileCnt
            // 
            this.labelFileCnt.Location = new System.Drawing.Point(3, 135);
            this.labelFileCnt.Name = "labelFileCnt";
            this.labelFileCnt.Size = new System.Drawing.Size(100, 23);
            this.labelFileCnt.TabIndex = 9;
            this.labelFileCnt.Text = "File Count: 0";
            // 
            // groupBoxRule
            // 
            this.groupBoxRule.Controls.Add(this.labelStart);
            this.groupBoxRule.Controls.Add(this.labelRep);
            this.groupBoxRule.Controls.Add(this.numericUpDownRep);
            this.groupBoxRule.Controls.Add(this.numericUpDownSN);
            this.groupBoxRule.Controls.Add(this.labelPatt);
            this.groupBoxRule.Controls.Add(this.labelFileCnt);
            this.groupBoxRule.Controls.Add(this.textBoxPatt);
            this.groupBoxRule.Controls.Add(this.textBoxCustom);
            this.groupBoxRule.Controls.Add(this.checkBoxCustom);
            this.groupBoxRule.Location = new System.Drawing.Point(12, 50);
            this.groupBoxRule.Name = "groupBoxRule";
            this.groupBoxRule.Size = new System.Drawing.Size(283, 161);
            this.groupBoxRule.TabIndex = 10;
            this.groupBoxRule.TabStop = false;
            this.groupBoxRule.Text = "Rename Rule";
            // 
            // numericUpDownSN
            // 
            this.numericUpDownSN.Location = new System.Drawing.Point(146, 48);
            this.numericUpDownSN.Name = "numericUpDownSN";
            this.numericUpDownSN.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownSN.TabIndex = 10;
            // 
            // groupBoxHelp
            // 
            this.groupBoxHelp.AutoSize = true;
            this.groupBoxHelp.Controls.Add(this.rule);
            this.groupBoxHelp.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxHelp.Location = new System.Drawing.Point(12, 217);
            this.groupBoxHelp.Name = "groupBoxHelp";
            this.groupBoxHelp.Size = new System.Drawing.Size(200, 100);
            this.groupBoxHelp.TabIndex = 11;
            this.groupBoxHelp.TabStop = false;
            this.groupBoxHelp.Text = "Help";
            // 
            // numericUpDownRep
            // 
            this.numericUpDownRep.Location = new System.Drawing.Point(50, 48);
            this.numericUpDownRep.Name = "numericUpDownRep";
            this.numericUpDownRep.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownRep.TabIndex = 12;
            this.numericUpDownRep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRep
            // 
            this.labelRep.AutoSize = true;
            this.labelRep.Location = new System.Drawing.Point(6, 48);
            this.labelRep.Name = "labelRep";
            this.labelRep.Size = new System.Drawing.Size(42, 13);
            this.labelRep.TabIndex = 13;
            this.labelRep.Text = "Repeat";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(91, 48);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(52, 13);
            this.labelStart.TabIndex = 14;
            this.labelStart.Text = "Start from";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 434);
            this.Controls.Add(this.groupBoxHelp);
            this.Controls.Add(this.groupBoxRule);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonPre);
            this.Controls.Add(this.buttonRun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Rename";
            this.groupBoxRule.ResumeLayout(false);
            this.groupBoxRule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSN)).EndInit();
            this.groupBoxHelp.ResumeLayout(false);
            this.groupBoxHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelRep;
        private System.Windows.Forms.NumericUpDown numericUpDownRep;
    }
}
