namespace WordProcessing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pathSourceFile = new System.Windows.Forms.TextBox();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.labelFilePreparation = new System.Windows.Forms.Label();
            this.labelDownloaded = new System.Windows.Forms.Label();
            this.buttonReadWord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pathSourceFile
            // 
            resources.ApplyResources(this.pathSourceFile, "pathSourceFile");
            this.pathSourceFile.Name = "pathSourceFile";
            // 
            // buttonBrowseFile
            // 
            resources.ApplyResources(this.buttonBrowseFile, "buttonBrowseFile");
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.browseFile_Click);
            // 
            // labelFilePreparation
            // 
            resources.ApplyResources(this.labelFilePreparation, "labelFilePreparation");
            this.labelFilePreparation.Name = "labelFilePreparation";
            // 
            // labelDownloaded
            // 
            resources.ApplyResources(this.labelDownloaded, "labelDownloaded");
            this.labelDownloaded.ForeColor = System.Drawing.Color.Green;
            this.labelDownloaded.Name = "labelDownloaded";
            // 
            // buttonReadWord
            // 
            resources.ApplyResources(this.buttonReadWord, "buttonReadWord");
            this.buttonReadWord.Name = "buttonReadWord";
            this.buttonReadWord.UseVisualStyleBackColor = true;
            this.buttonReadWord.Click += new System.EventHandler(this.buttonReadWord_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReadWord);
            this.Controls.Add(this.labelDownloaded);
            this.Controls.Add(this.labelFilePreparation);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.pathSourceFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathSourceFile;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.Label labelFilePreparation;
        private System.Windows.Forms.Label labelDownloaded;
        private System.Windows.Forms.Button buttonReadWord;
        private System.Windows.Forms.Label label2;
    }
}

