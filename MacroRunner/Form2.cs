using Microsoft.WindowsAPICodePack.Dialogs;

namespace MacroRunner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var props = Properties.Settings.Default;
            CustomVarTextBox1.Text = props.CustomVar1;
            CustomVarTextBox2.Text = props.CustomVar2;
            ChromeTextBox.Text = props.ChromePATH;
            XModuleTextBox.Text = props.XModulePATH;
            MacroTextBox.Text = props.MacroPATH;
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            var props = Properties.Settings.Default;
            props.CustomVar1 = CustomVarTextBox1.Text;
            props.CustomVar2 = CustomVarTextBox2.Text;
            props.ChromePATH = ChromeTextBox.Text;
            props.XModulePATH = XModuleTextBox.Text;
            props.MacroPATH = MacroTextBox.Text;
            props.Save();
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
