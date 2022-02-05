using System.Diagnostics;

namespace MacroRunner
{
    public partial class MacroRunner : Form
    {
        public MacroRunner()
        {
            InitializeComponent();
        }

        private void MacroRunner_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Properties.Settings.Default.MacroPATH, "*.json")
                .Select(file => Path.GetFileName(file)).ToArray();
            MacroListBox.DataSource = files;
            int index = MacroListBox.FindString(Properties.Settings.Default.LastSelectedMacro);
            if (MacroListBox.Items.Count > 0)
            {
                MacroListBox.SetSelected(index == -1 ? 0 : index, true);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRefreshFiles_Click(object sender, EventArgs e)
        {
            MacroRunner_Load(sender, e);
        }

        private void BtnSetPaths_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new();
            settingsForm.Show();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            if (MacroListBox.Items.Count == 0)
            {
                MessageBox.Show("Please select a valid Macro folder that cointains valid JSON for UI Vision Macro");
                return;
            }

            Properties.Settings.Default.LastSelectedMacro = MacroListBox.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            string HTMLFileName = "autostart.html";
            string Lang = (langPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) ?? en).Name;
            string XModulePath = Properties.Settings.Default.XModulePATH;
            string ChromePath = Properties.Settings.Default.ChromePATH ?? "explorer.exe";
            string MacroPath = Properties.Settings.Default.MacroPATH;
            string CustomVar1 = Properties.Settings.Default.CustomVar1;
            string CustomVar2 = Properties.Settings.Default.CustomVar2;
            File.WriteAllText(HTMLFileName, @$"<!doctype html> <html lang='en'> <head> <title>UI.Vision Shortcut Page </title> </head><body> <h3>Command line:</h3> <a id='run' href='ui.vision.html?direct=1&macro={MacroListBox.SelectedItem}&cmd_var1={Lang}{CustomVar1}{CustomVar2}&storage=xfile&continueInLastUsedTab=0'>Click here</a><script> window.location.href = document.getElementById('run').getAttribute('href'); </script> </body></html>");
            string fullPathSource = @$"{MacroPath}\{MacroListBox.SelectedItem}";
            string fullPathTarget = @$"{XModulePath}\{MacroListBox.SelectedItem}";
            if (fullPathSource != fullPathTarget)
            {
                try
                {
                    File.Copy(fullPathSource, fullPathTarget, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            Process.Start(ChromePath, $"{AppDomain.CurrentDomain.BaseDirectory}{HTMLFileName}");
        }
    }
}