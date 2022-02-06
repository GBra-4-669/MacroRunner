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
            FontAwesome.Sharp.IconButton BtnSetPaths;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroRunner));
            this.LabelWebMacroRunner = new System.Windows.Forms.Label();
            this.LabelLanguages = new System.Windows.Forms.Label();
            this.LabelPickMacro = new System.Windows.Forms.Label();
            this.en = new System.Windows.Forms.RadioButton();
            this.fr = new System.Windows.Forms.RadioButton();
            this.es = new System.Windows.Forms.RadioButton();
            this.ru = new System.Windows.Forms.RadioButton();
            this.zh = new System.Windows.Forms.RadioButton();
            this.ar = new System.Windows.Forms.RadioButton();
            this.langPanel = new System.Windows.Forms.Panel();
            this.MacroListBox = new System.Windows.Forms.ListBox();
            this.BtnRefreshFiles = new FontAwesome.Sharp.IconButton();
            this.BtnExecute = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            BtnSetPaths = new FontAwesome.Sharp.IconButton();
            this.langPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSetPaths
            // 
            BtnSetPaths.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(BtnSetPaths, "BtnSetPaths");
            BtnSetPaths.ForeColor = System.Drawing.Color.Black;
            BtnSetPaths.IconChar = FontAwesome.Sharp.IconChar.Cog;
            BtnSetPaths.IconColor = System.Drawing.Color.Black;
            BtnSetPaths.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSetPaths.IconSize = 30;
            BtnSetPaths.Name = "BtnSetPaths";
            BtnSetPaths.UseVisualStyleBackColor = false;
            BtnSetPaths.Click += new System.EventHandler(this.BtnSetPaths_Click);
            // 
            // LabelWebMacroRunner
            // 
            this.LabelWebMacroRunner.AutoEllipsis = true;
            this.LabelWebMacroRunner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelWebMacroRunner.CausesValidation = false;
            resources.ApplyResources(this.LabelWebMacroRunner, "LabelWebMacroRunner");
            this.LabelWebMacroRunner.ForeColor = System.Drawing.Color.White;
            this.LabelWebMacroRunner.Name = "LabelWebMacroRunner";
            // 
            // LabelLanguages
            // 
            resources.ApplyResources(this.LabelLanguages, "LabelLanguages");
            this.LabelLanguages.Name = "LabelLanguages";
            // 
            // LabelPickMacro
            // 
            resources.ApplyResources(this.LabelPickMacro, "LabelPickMacro");
            this.LabelPickMacro.Name = "LabelPickMacro";
            // 
            // en
            // 
            this.en.Checked = true;
            resources.ApplyResources(this.en, "en");
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
            this.langPanel.Controls.Add(this.en);
            this.langPanel.Controls.Add(this.fr);
            this.langPanel.Controls.Add(this.zh);
            this.langPanel.Controls.Add(this.ar);
            this.langPanel.Controls.Add(this.es);
            this.langPanel.Controls.Add(this.ru);
            resources.ApplyResources(this.langPanel, "langPanel");
            this.langPanel.Name = "langPanel";
            // 
            // MacroListBox
            // 
            this.MacroListBox.FormattingEnabled = true;
            resources.ApplyResources(this.MacroListBox, "MacroListBox");
            this.MacroListBox.Name = "MacroListBox";
            // 
            // BtnRefreshFiles
            // 
            this.BtnRefreshFiles.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRefreshFiles.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnRefreshFiles, "BtnRefreshFiles");
            this.BtnRefreshFiles.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.BtnRefreshFiles.IconColor = System.Drawing.Color.CornflowerBlue;
            this.BtnRefreshFiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRefreshFiles.IconSize = 38;
            this.BtnRefreshFiles.Name = "BtnRefreshFiles";
            this.BtnRefreshFiles.UseVisualStyleBackColor = false;
            this.BtnRefreshFiles.Click += new System.EventHandler(this.BtnRefreshFiles_Click);
            // 
            // BtnExecute
            // 
            this.BtnExecute.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.BtnExecute, "BtnExecute");
            this.BtnExecute.ForeColor = System.Drawing.Color.Black;
            this.BtnExecute.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.BtnExecute.IconColor = System.Drawing.Color.Black;
            this.BtnExecute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExecute.IconSize = 40;
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.UseVisualStyleBackColor = false;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 40;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MacroRunner
            // 
            this.AcceptButton = this.BtnExecute;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(BtnSetPaths);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnRefreshFiles);
            this.Controls.Add(this.MacroListBox);
            this.Controls.Add(this.langPanel);
            this.Controls.Add(this.LabelPickMacro);
            this.Controls.Add(this.LabelLanguages);
            this.Controls.Add(this.LabelWebMacroRunner);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MacroRunner";
            this.Load += new System.EventHandler(this.MacroRunner_Load);
            this.langPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LabelWebMacroRunner;
        private Label LabelLanguages;
        private Label LabelPickMacro;
        public RadioButton en;
        public RadioButton fr;
        public RadioButton es;
        public RadioButton ru;
        public RadioButton zh;
        public RadioButton ar;
        private Panel langPanel;
        private ListBox MacroListBox;
        private FontAwesome.Sharp.IconButton BtnRefreshFiles;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnExecute;
        private FontAwesome.Sharp.IconButton BtnSetPaths;
    }
}