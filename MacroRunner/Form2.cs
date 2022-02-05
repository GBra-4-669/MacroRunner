using Microsoft.WindowsAPICodePack.Dialogs;

namespace MacroRunner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CustomVarTextBox1.Text = Properties.Settings.Default.CustomVar1;
            CustomVarTextBox2.Text = Properties.Settings.Default.CustomVar2;
            ChromeTextBox.Text = Properties.Settings.Default.ChromePATH;
            XModuleTextBox.Text = Properties.Settings.Default.XModulePATH;
            MacroTextBox.Text = Properties.Settings.Default.MacroPATH;
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CustomVar1 = CustomVarTextBox1.Text;
            Properties.Settings.Default.CustomVar2 = CustomVarTextBox2.Text;
            Properties.Settings.Default.ChromePATH = ChromeTextBox.Text;
            Properties.Settings.Default.ChromePATH = ChromeTextBox.Text;
            Properties.Settings.Default.MacroPATH = MacroTextBox.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void BtnDiscardChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnTextBoxes_Click(TextBox TB, bool isFolderPicker = true) 
        {
            CommonOpenFileDialog dialog = new();
            dialog.IsFolderPicker = isFolderPicker;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TB.Text = dialog.FileName;
            }
            dialog.Dispose();
            BringToFront();
        }

        private void MacroPathDialog_Click(object sender, EventArgs e)
        {
            OnTextBoxes_Click(MacroTextBox);
        }

        private void ChromePathDialog_Click(object sender, EventArgs e)
        {
            OnTextBoxes_Click(ChromeTextBox, false);
        }

        private void XModulePathDialog_Click(object sender, EventArgs e)
        {
            OnTextBoxes_Click(XModuleTextBox);
        }


    }

}
