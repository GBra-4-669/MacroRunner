namespace MacroRunner
{
    partial class MacroRunner
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
            FontAwesome.Sharp.IconButton btnClose;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroRunner));
            this.webMacroRunner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.en = new System.Windows.Forms.RadioButton();
            this.fr = new System.Windows.Forms.RadioButton();
            this.es = new System.Windows.Forms.RadioButton();
            this.ru = new System.Windows.Forms.RadioButton();
            this.zh = new System.Windows.Forms.RadioButton();
            this.ar = new System.Windows.Forms.RadioButton();
            this.langPanel = new System.Windows.Forms.Panel();
            this.MacroListBox = new System.Windows.Forms.ListBox();
            this.BtnRefreshFiles = new FontAwesome.Sharp.IconButton();
            this.btnExecute = new FontAwesome.Sharp.IconButton();
            this.btnSetPaths = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            this.langPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.BackColor = System.Drawing.Color.Red;
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnClose.IconColor = System.Drawing.Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 35;
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // webMacroRunner
            // 
            resources.ApplyResources(this.webMacroRunner, "webMacroRunner");
            this.webMacroRunner.AutoEllipsis = true;
            this.webMacroRunner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webMacroRunner.CausesValidation = false;
            this.webMacroRunner.ForeColor = System.Drawing.Color.White;
            this.webMacroRunner.Name = "webMacroRunner";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // en
            // 
            resources.ApplyResources(this.en, "en");
            this.en.Checked = true;
            this.en.Name = "en";
            this.en.TabStop = true;
            this.en.UseVisualStyleBackColor = true;
            // 
            // fr
            // 
            resources.ApplyResources(this.fr, "fr");
            this.fr.Name = "fr";
            this.fr.UseVisualStyleBackColor = true;
            // 
            // es
            // 
            resources.ApplyResources(this.es, "es");
            this.es.Name = "es";
            this.es.UseVisualStyleBackColor = true;
            // 
            // ru
            // 
            resources.ApplyResources(this.ru, "ru");
            this.ru.Name = "ru";
            this.ru.UseVisualStyleBackColor = true;
            // 
            // zh
            // 
            resources.ApplyResources(this.zh, "zh");
            this.zh.Name = "zh";
            this.zh.UseVisualStyleBackColor = true;
            // 
            // ar
            // 
            resources.ApplyResources(this.ar, "ar");
            this.ar.Name = "ar";
            this.ar.UseVisualStyleBackColor = true;
            // 
            // langPanel
            // 
            resources.ApplyResources(this.langPanel, "langPanel");
            this.langPanel.Controls.Add(this.en);
            this.langPanel.Controls.Add(this.fr);
            this.langPanel.Controls.Add(this.zh);
            this.langPanel.Controls.Add(this.ar);
            this.langPanel.Controls.Add(this.es);
            this.langPanel.Controls.Add(this.ru);
            this.langPanel.Name = "langPanel";
            // 
            // MacroListBox
            // 
            resources.ApplyResources(this.MacroListBox, "MacroListBox");
            this.MacroListBox.FormattingEnabled = true;
            this.MacroListBox.Name = "MacroListBox";
            // 
            // BtnRefreshFiles
            // 
            resources.ApplyResources(this.BtnRefreshFiles, "BtnRefreshFiles");
            this.BtnRefreshFiles.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRefreshFiles.FlatAppearance.BorderSize = 0;
            this.BtnRefreshFiles.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.BtnRefreshFiles.IconColor = System.Drawing.Color.CornflowerBlue;
            this.BtnRefreshFiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRefreshFiles.IconSize = 30;
            this.BtnRefreshFiles.Name = "BtnRefreshFiles";
            this.BtnRefreshFiles.UseVisualStyleBackColor = false;
            this.BtnRefreshFiles.Click += new System.EventHandler(this.BtnRefreshFiles_Click);
            // 
            // btnExecute
            // 
            resources.ApplyResources(this.btnExecute, "btnExecute");
            this.btnExecute.BackColor = System.Drawing.Color.Lime;
            this.btnExecute.ForeColor = System.Drawing.Color.Black;
            this.btnExecute.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnExecute.IconColor = System.Drawing.Color.Black;
            this.btnExecute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExecute.IconSize = 40;
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // btnSetPaths
            // 
            resources.ApplyResources(this.btnSetPaths, "btnSetPaths");
            this.btnSetPaths.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSetPaths.ForeColor = System.Drawing.Color.Black;
            this.btnSetPaths.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetPaths.IconColor = System.Drawing.Color.Black;
            this.btnSetPaths.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetPaths.IconSize = 30;
            this.btnSetPaths.Name = "btnSetPaths";
            this.btnSetPaths.UseVisualStyleBackColor = false;
            this.btnSetPaths.Click += new System.EventHandler(this.BtnSetPaths_Click);
            // 
            // MacroRunner
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.btnSetPaths);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(btnClose);
            this.Controls.Add(this.BtnRefreshFiles);
            this.Controls.Add(this.MacroListBox);
            this.Controls.Add(this.langPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webMacroRunner);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MacroRunner";
            this.Load += new System.EventHandler(this.MacroRunner_Load);
            this.langPanel.ResumeLayout(false);
            this.langPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label webMacroRunner;
        private Label label1;
        private Label label2;
        public RadioButton en;
        public RadioButton fr;
        public RadioButton es;
        public RadioButton ru;
        public RadioButton zh;
        public RadioButton ar;
        private Panel langPanel;
        private ListBox MacroListBox;
        private FontAwesome.Sharp.IconButton BtnRefreshFiles;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnExecute;
        private FontAwesome.Sharp.IconButton btnSetPaths;
    }
}