
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
            this.labelGraph = new System.Windows.Forms.Label();
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
            this.labelGraphInput.Click += new System.EventHandler(this.labelGraphInput_Click);
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
            this.richTxtBoxFilename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTxtBoxFilename, "richTxtBoxFilename");
            this.richTxtBoxFilename.Name = "richTxtBoxFilename";
            // 
            // richTxtBoxGraph
            // 
            resources.ApplyResources(this.richTxtBoxGraph, "richTxtBoxGraph");
            this.richTxtBoxGraph.Name = "richTxtBoxGraph";
            // 
            // labelGraph
            // 
            resources.ApplyResources(this.labelGraph, "labelGraph");
            this.labelGraph.Name = "labelGraph";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelGraph);
            this.Controls.Add(this.richTxtBoxFilename);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.labelGraphInput);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.richTxtBoxGraph);
            this.Controls.Add(this.clickMeButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label labelGraph;
    }
}

