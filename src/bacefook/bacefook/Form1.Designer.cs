
namespace bacefook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clickMeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGraphInput = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.richTxtBoxFilename = new System.Windows.Forms.RichTextBox();
            this.richTxtBoxGraph = new System.Windows.Forms.RichTextBox();
            this.labelGraphVisual = new System.Windows.Forms.Label();
            this.labelChooseAccount = new System.Windows.Forms.Label();
            this.labelChooseAlgorithm = new System.Windows.Forms.Label();
            this.radioButton_DFS = new System.Windows.Forms.RadioButton();
            this.radioButton_BFS = new System.Windows.Forms.RadioButton();
            this.comboBox_chooseAccount = new System.Windows.Forms.ComboBox();
            this.labelExploreFriends = new System.Windows.Forms.Label();
            this.comboBox_exploreFriends = new System.Windows.Forms.ComboBox();
            this.richTextBoxHasil = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // clickMeButton
            // 
            resources.ApplyResources(this.clickMeButton, "clickMeButton");
            this.clickMeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            // 
            // labelGraphInput
            // 
            resources.ApplyResources(this.labelGraphInput, "labelGraphInput");
            this.labelGraphInput.Name = "labelGraphInput";
            // 
            // btnUploadFile
            // 
            resources.ApplyResources(this.btnUploadFile, "btnUploadFile");
            this.btnUploadFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // richTxtBoxFilename
            // 
            this.richTxtBoxFilename.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTxtBoxFilename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTxtBoxFilename, "richTxtBoxFilename");
            this.richTxtBoxFilename.Name = "richTxtBoxFilename";
            // 
            // richTxtBoxGraph
            // 
            resources.ApplyResources(this.richTxtBoxGraph, "richTxtBoxGraph");
            this.richTxtBoxGraph.Name = "richTxtBoxGraph";
            this.richTxtBoxGraph.TextChanged += new System.EventHandler(this.richTxtBoxGraph_TextChanged);
            // 
            // labelGraphVisual
            // 
            resources.ApplyResources(this.labelGraphVisual, "labelGraphVisual");
            this.labelGraphVisual.Name = "labelGraphVisual";
            // 
            // labelChooseAccount
            // 
            resources.ApplyResources(this.labelChooseAccount, "labelChooseAccount");
            this.labelChooseAccount.Name = "labelChooseAccount";
            // 
            // labelChooseAlgorithm
            // 
            resources.ApplyResources(this.labelChooseAlgorithm, "labelChooseAlgorithm");
            this.labelChooseAlgorithm.Name = "labelChooseAlgorithm";
            // 
            // radioButton_DFS
            // 
            resources.ApplyResources(this.radioButton_DFS, "radioButton_DFS");
            this.radioButton_DFS.Name = "radioButton_DFS";
            this.radioButton_DFS.TabStop = true;
            this.radioButton_DFS.UseVisualStyleBackColor = true;
            this.radioButton_DFS.CheckedChanged += new System.EventHandler(this.radioButton_DFS_CheckedChanged);
            // 
            // radioButton_BFS
            // 
            resources.ApplyResources(this.radioButton_BFS, "radioButton_BFS");
            this.radioButton_BFS.Name = "radioButton_BFS";
            this.radioButton_BFS.TabStop = true;
            this.radioButton_BFS.UseVisualStyleBackColor = true;
            this.radioButton_BFS.CheckedChanged += new System.EventHandler(this.radioButton_BFS_CheckedChanged);
            // 
            // comboBox_chooseAccount
            // 
            resources.ApplyResources(this.comboBox_chooseAccount, "comboBox_chooseAccount");
            this.comboBox_chooseAccount.FormattingEnabled = true;
            this.comboBox_chooseAccount.Name = "comboBox_chooseAccount";
            this.comboBox_chooseAccount.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseAccount_SelectedIndexChanged);
            // 
            // labelExploreFriends
            // 
            resources.ApplyResources(this.labelExploreFriends, "labelExploreFriends");
            this.labelExploreFriends.Name = "labelExploreFriends";
            // 
            // comboBox_exploreFriends
            // 
            resources.ApplyResources(this.comboBox_exploreFriends, "comboBox_exploreFriends");
            this.comboBox_exploreFriends.FormattingEnabled = true;
            this.comboBox_exploreFriends.Name = "comboBox_exploreFriends";
            this.comboBox_exploreFriends.SelectedIndexChanged += new System.EventHandler(this.comboBox_exploreFriends_SelectedIndexChanged);
            // 
            // richTextBoxHasil
            // 
            resources.ApplyResources(this.richTextBoxHasil, "richTextBoxHasil");
            this.richTextBoxHasil.Name = "richTextBoxHasil";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxHasil);
            this.Controls.Add(this.comboBox_exploreFriends);
            this.Controls.Add(this.labelExploreFriends);
            this.Controls.Add(this.comboBox_chooseAccount);
            this.Controls.Add(this.radioButton_BFS);
            this.Controls.Add(this.radioButton_DFS);
            this.Controls.Add(this.labelChooseAlgorithm);
            this.Controls.Add(this.labelChooseAccount);
            this.Controls.Add(this.labelGraphVisual);
            this.Controls.Add(this.richTxtBoxFilename);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.labelGraphInput);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.richTxtBoxGraph);
            this.Controls.Add(this.clickMeButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickMeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGraphInput;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.RichTextBox richTxtBoxFilename;
        private System.Windows.Forms.RichTextBox richTxtBoxGraph;
        private System.Windows.Forms.Label labelGraphVisual;
        private System.Windows.Forms.Label labelChooseAccount;
        private System.Windows.Forms.Label labelChooseAlgorithm;
        private System.Windows.Forms.RadioButton radioButton_DFS;
        private System.Windows.Forms.RadioButton radioButton_BFS;
        private System.Windows.Forms.ComboBox comboBox_chooseAccount;
        private System.Windows.Forms.Label labelExploreFriends;
        private System.Windows.Forms.ComboBox comboBox_exploreFriends;
        private System.Windows.Forms.RichTextBox richTextBoxHasil;
    }
}

