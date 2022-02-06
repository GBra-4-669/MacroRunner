namespace MacroRunner
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.WindowTitle = new System.Windows.Forms.Label();
            this.ChromeTextBox = new System.Windows.Forms.TextBox();
            this.chromeTextLabel = new System.Windows.Forms.Label();
            this.XModuleTextLabel = new System.Windows.Forms.Label();
            this.XModuleTextBox = new System.Windows.Forms.TextBox();
            this.MacroPathTextLabel = new System.Windows.Forms.Label();
            this.MacroTextBox = new System.Windows.Forms.TextBox();
            this.labelVariable1 = new System.Windows.Forms.Label();
            this.CustomVarTextBox1 = new System.Windows.Forms.TextBox();
            this.CustomVarTextBox2 = new System.Windows.Forms.TextBox();
            this.labelVariable2 = new System.Windows.Forms.Label();
            this.MacroPathDialog = new FontAwesome.Sharp.IconButton();
            this.XModulePathDialog = new FontAwesome.Sharp.IconButton();
            this.ChromePathDialog = new FontAwesome.Sharp.IconButton();
            this.BtnSaveChanges = new FontAwesome.Sharp.IconButton();
            this.BtnDiscardChanges = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // WindowTitle
            // 
            this.WindowTitle.AutoSize = true;
            this.WindowTitle.Font = new System.Drawing.Font("Gadugi", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document);
            this.WindowTitle.Location = new System.Drawing.Point(245, 9);
            this.WindowTitle.Name = "WindowTitle";
            this.WindowTitle.Size = new System.Drawing.Size(166, 38);
            this.WindowTitle.TabIndex = 0;
            this.WindowTitle.Text = "SETTINGS";
            // 
            // ChromeTextBox
            // 
            this.ChromeTextBox.CausesValidation = false;
            this.ChromeTextBox.Location = new System.Drawing.Point(12, 205);
            this.ChromeTextBox.Name = "ChromeTextBox";
            this.ChromeTextBox.Size = new System.Drawing.Size(570, 27);
            this.ChromeTextBox.TabIndex = 4;
            // 
            // chromeTextLabel
            // 
            this.chromeTextLabel.AutoSize = true;
            this.chromeTextLabel.Location = new System.Drawing.Point(12, 183);
            this.chromeTextLabel.Name = "chromeTextLabel";
            this.chromeTextLabel.Size = new System.Drawing.Size(142, 19);
            this.chromeTextLabel.TabIndex = 2;
            this.chromeTextLabel.Text = "Set Chrome.exe File:";
            // 
            // XModuleTextLabel
            // 
            this.XModuleTextLabel.AutoSize = true;
            this.XModuleTextLabel.Location = new System.Drawing.Point(12, 251);
            this.XModuleTextLabel.Name = "XModuleTextLabel";
            this.XModuleTextLabel.Size = new System.Drawing.Size(151, 19);
            this.XModuleTextLabel.TabIndex = 6;
            this.XModuleTextLabel.Text = "XModule Folder Path:";
            // 
            // XModuleTextBox
            // 
            this.XModuleTextBox.Location = new System.Drawing.Point(12, 273);
            this.XModuleTextBox.Name = "XModuleTextBox";
            this.XModuleTextBox.Size = new System.Drawing.Size(570, 27);
            this.XModuleTextBox.TabIndex = 5;
            // 
            // MacroPathTextLabel
            // 
            this.MacroPathTextLabel.AutoSize = true;
            this.MacroPathTextLabel.Location = new System.Drawing.Point(12, 120);
            this.MacroPathTextLabel.Name = "MacroPathTextLabel";
            this.MacroPathTextLabel.Size = new System.Drawing.Size(206, 19);
            this.MacroPathTextLabel.TabIndex = 10;
            this.MacroPathTextLabel.Text = "Your JSON macro Folder Path:";
            // 
            // MacroTextBox
            // 
            this.MacroTextBox.Location = new System.Drawing.Point(12, 142);
            this.MacroTextBox.Name = "MacroTextBox";
            this.MacroTextBox.Size = new System.Drawing.Size(570, 27);
            this.MacroTextBox.TabIndex = 3;
            // 
            // labelVariable1
            // 
            this.labelVariable1.AutoSize = true;
            this.labelVariable1.Location = new System.Drawing.Point(12, 50);
            this.labelVariable1.Name = "labelVariable1";
            this.labelVariable1.Size = new System.Drawing.Size(210, 19);
            this.labelVariable1.TabIndex = 12;
            this.labelVariable1.Text = "Custom Variable ${!cmd_var2}:";
            // 
            // CustomVarTextBox1
            // 
            this.CustomVarTextBox1.Location = new System.Drawing.Point(12, 81);
            this.CustomVarTextBox1.Name = "CustomVarTextBox1";
            this.CustomVarTextBox1.Size = new System.Drawing.Size(302, 27);
            this.CustomVarTextBox1.TabIndex = 1;
            // 
            // CustomVarTextBox2
            // 
            this.CustomVarTextBox2.Location = new System.Drawing.Point(336, 81);
            this.CustomVarTextBox2.Name = "CustomVarTextBox2";
            this.CustomVarTextBox2.Size = new System.Drawing.Size(301, 27);
            this.CustomVarTextBox2.TabIndex = 2;
            // 
            // labelVariable2
            // 
            this.labelVariable2.AutoSize = true;
            this.labelVariable2.Location = new System.Drawing.Point(336, 50);
            this.labelVariable2.Name = "labelVariable2";
            this.labelVariable2.Size = new System.Drawing.Size(210, 19);
            this.labelVariable2.TabIndex = 15;
            this.labelVariable2.Text = "Custom Variable ${!cmd_var3}:";
            // 
            // MacroPathDialog
            // 
            this.MacroPathDialog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MacroPathDialog.FlatAppearance.BorderSize = 4;
            this.MacroPathDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MacroPathDialog.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.MacroPathDialog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MacroPathDialog.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.MacroPathDialog.IconColor = System.Drawing.Color.Black;
            this.MacroPathDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MacroPathDialog.IconSize = 29;
            this.MacroPathDialog.Location = new System.Drawing.Point(588, 142);
            this.MacroPathDialog.Name = "MacroPathDialog";
            this.MacroPathDialog.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MacroPathDialog.Size = new System.Drawing.Size(58, 27);
            this.MacroPathDialog.TabIndex = 8;
            this.MacroPathDialog.UseVisualStyleBackColor = true;
            this.MacroPathDialog.Click += new System.EventHandler(this.MacroPathDialog_Click);
            // 
            // XModulePathDialog
            // 
            this.XModulePathDialog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.XModulePathDialog.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.XModulePathDialog.IconColor = System.Drawing.Color.Black;
            this.XModulePathDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.XModulePathDialog.IconSize = 30;
            this.XModulePathDialog.Location = new System.Drawing.Point(588, 273);
            this.XModulePathDialog.Name = "XModulePathDialog";
            this.XModulePathDialog.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.XModulePathDialog.Size = new System.Drawing.Size(58, 27);
            this.XModulePathDialog.TabIndex = 10;
            this.XModulePathDialog.UseVisualStyleBackColor = true;
            this.XModulePathDialog.Click += new System.EventHandler(this.XModulePathDialog_Click);
            // 
            // ChromePathDialog
            // 
            this.ChromePathDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChromePathDialog.FlatAppearance.BorderSize = 4;
            this.ChromePathDialog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChromePathDialog.IconChar = FontAwesome.Sharp.IconChar.Chrome;
            this.ChromePathDialog.IconColor = System.Drawing.Color.Black;
            this.ChromePathDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChromePathDialog.IconSize = 26;
            this.ChromePathDialog.Location = new System.Drawing.Point(588, 205);
            this.ChromePathDialog.Name = "ChromePathDialog";
            this.ChromePathDialog.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ChromePathDialog.Size = new System.Drawing.Size(58, 27);
            this.ChromePathDialog.TabIndex = 9;
            this.ChromePathDialog.UseVisualStyleBackColor = true;
            this.ChromePathDialog.Click += new System.EventHandler(this.ChromePathDialog_Click);
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveChanges.BackColor = System.Drawing.Color.Lime;
            this.BtnSaveChanges.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSaveChanges.FlatAppearance.BorderSize = 4;
            this.BtnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSaveChanges.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveChanges.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnSaveChanges.IconColor = System.Drawing.Color.Black;
            this.BtnSaveChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSaveChanges.IconSize = 51;
            this.BtnSaveChanges.Location = new System.Drawing.Point(12, 320);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnSaveChanges.Size = new System.Drawing.Size(302, 71);
            this.BtnSaveChanges.TabIndex = 6;
            this.BtnSaveChanges.Text = "SAVE CHANGES";
            this.BtnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSaveChanges.UseVisualStyleBackColor = false;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // BtnDiscardChanges
            // 
            this.BtnDiscardChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDiscardChanges.BackColor = System.Drawing.Color.Red;
            this.BtnDiscardChanges.FlatAppearance.BorderSize = 4;
            this.BtnDiscardChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDiscardChanges.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDiscardChanges.ForeColor = System.Drawing.Color.White;
            this.BtnDiscardChanges.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnDiscardChanges.IconColor = System.Drawing.Color.White;
            this.BtnDiscardChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDiscardChanges.IconSize = 45;
            this.BtnDiscardChanges.Location = new System.Drawing.Point(344, 320);
            this.BtnDiscardChanges.Name = "BtnDiscardChanges";
            this.BtnDiscardChanges.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnDiscardChanges.Size = new System.Drawing.Size(302, 71);
            this.BtnDiscardChanges.TabIndex = 7;
            this.BtnDiscardChanges.Text = "DISCARD CHANGES";
            this.BtnDiscardChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDiscardChanges.UseVisualStyleBackColor = false;
            this.BtnDiscardChanges.Click += new System.EventHandler(this.BtnDiscardChanges_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.BtnSaveChanges;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.BtnDiscardChanges;
            this.ClientSize = new System.Drawing.Size(658, 403);
            this.Controls.Add(this.BtnDiscardChanges);
            this.Controls.Add(this.BtnSaveChanges);
            this.Controls.Add(this.ChromePathDialog);
            this.Controls.Add(this.XModulePathDialog);
            this.Controls.Add(this.MacroPathDialog);
            this.Controls.Add(this.labelVariable2);
            this.Controls.Add(this.CustomVarTextBox2);
            this.Controls.Add(this.CustomVarTextBox1);
            this.Controls.Add(this.labelVariable1);
            this.Controls.Add(this.MacroPathTextLabel);
            this.Controls.Add(this.MacroTextBox);
            this.Controls.Add(this.XModuleTextBox);
            this.Controls.Add(this.XModuleTextLabel);
            this.Controls.Add(this.chromeTextLabel);
            this.Controls.Add(this.ChromeTextBox);
            this.Controls.Add(this.WindowTitle);
            this.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WindowTitle;
        private TextBox ChromeTextBox;
        private Label chromeTextLabel;
        private Label XModuleTextLabel;
        private TextBox XModuleTextBox;
        private Label MacroPathTextLabel;
        private TextBox MacroTextBox;
        private Label labelVariable1;
        private TextBox CustomVarTextBox1;
        private TextBox CustomVarTextBox2;
        private Label labelVariable2;
        private FontAwesome.Sharp.IconButton MacroPathDialog;
        private FontAwesome.Sharp.IconButton XModulePathDialog;
        private FontAwesome.Sharp.IconButton ChromePathDialog;
        private FontAwesome.Sharp.IconButton BtnSaveChanges;
        private FontAwesome.Sharp.IconButton BtnDiscardChanges;
    }
}