using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.CodeCompletion;
using Microsoft.Win32;

namespace ScriptEditor
{
    public partial class MainWindow : Window
    {
        public bool Saved { get; set; } = true;

        public string ScriptFile { get; set; }

        public string ScriptPath = Path.Combine(Environment.CurrentDirectory, "DefaultScript.txt");

        public void ScriptContents()
        {
            if (File.ReadAllText(ScriptPath).Length == 0 || !File.Exists(ScriptPath))
            {
                DefaultScript = DefaultScriptInternal;
            }
            else
            {
                StreamReader tw = new StreamReader(ScriptPath);
                DefaultScript = tw.ReadToEnd();
                tw.Close();
            }
        }

        public MainWindow()
        {
            if (!File.Exists(ScriptPath))
            {
                File.Create(ScriptPath);
            }
            InitializeComponent();
            Closing += MainWindow_Closing;
            editor.KeyUp += Editor_KeyUp;
            editor.TextArea.TextEntered += TextArea_TextEntered;
            editor.Completion = new CSharpCompletion(null);
            editor.Completion.AddAssembly("RBot.exe");
            bool flag = Directory.Exists("plugins");
            if (flag)
            {
                Directory.GetFiles("plugins", "*.dll").ToList().ForEach(new Action<string>(editor.Completion.AddAssembly));
            }
            Directory.GetFiles(".", "*.dll").ToList().ForEach(new Action<string>(editor.Completion.AddAssembly));
            editor.FontFamily = fontHolder.FontFamily;
            editor.FontSize = 12.0;
            editor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("C#");
            contentPanel.Content = editor;
            Loaded += MainWindow_Loaded;
            ScriptContents();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            bool flag = App.StartupFile != null && File.Exists(App.StartupFile);
            if (flag)
            {
                LoadFile(App.StartupFile);
            }
            bool flag2 = ScriptFile == null;
            if (flag2)
            {
                string text = Path.GetTempFileName() + ".cs";
                File.WriteAllText(text, DefaultScript);
                editor.OpenFile(text);
            }
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = !Saved && MessageBox.Show("Are you sure you would like to close the script editor? Any unsaved changes will be lost!", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.No;
        }

        public void LoadFile(string file)
        {
            ScriptFile = file;
            Saved = true;
            editor.OpenFile(file);
            Title = "Script Editor - " + Path.GetFileName(file);
        }

        private void TextArea_TextEntered(object sender, TextCompositionEventArgs e)
        {
            Saved = false;
            Title = "Script Editor - " + Path.GetFileName(ScriptFile) + "*";
        }

        private void Editor_KeyUp(object sender, KeyEventArgs e)
        {
            bool flag = e.Key == Key.S && Keyboard.IsKeyDown(Key.LeftCtrl);
            if (flag)
            {
                MenuItemSave_Click(null, null);
            }
            else
            {
                bool flag2 = e.Key == Key.O && Keyboard.IsKeyDown(Key.LeftCtrl);
                if (flag2)
                {
                    MenuItemOpen_Click(null, null);
                }
            }
        }

        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            bool flag = Saved || MessageBox.Show("The current file is not saved. Opening another one will cause any unsaved changes to be lost. Are you sure you would like to open another file?", "Open File", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes;
            if (flag)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "RBot Scripts|*.cs|All Files|*.*"
                };
                bool? flag2 = openFileDialog.ShowDialog();
                const bool flag3 = true;
                bool flag4 = flag2.GetValueOrDefault() == flag3 && flag2 != null;
                if (flag4)
                {
                    LoadFile(openFileDialog.FileName);
                }
            }
        }

        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            bool flag = ScriptFile == null;
            if (flag)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "RBot Scripts|*.cs|All Files|*.*"
                };
                bool? flag2 = saveFileDialog.ShowDialog();
                const bool flag3 = true;
                bool flag4 = flag2.GetValueOrDefault() == flag3 && flag2 != null;
                if (!flag4)
                {
                    return;
                }
                ScriptFile = saveFileDialog.FileName;
                MenuItemSave_Click(null, null);
            }
            File.WriteAllText(ScriptFile, editor.Text);
            Saved = true;
            Title = "Script Editor - " + Path.GetFileName(ScriptFile);
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            bool flag = ScriptFile == null || Saved || MessageBox.Show("Are you sure you would like to exit? Any unsaved changes to the current script will not be saved.", "Unsaved Script", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes;
            if (flag)
            {
                Application.Current.Shutdown();
            }
        }

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            bool flag = ScriptFile == null || Saved || MessageBox.Show("Are you sure you would like to create a new script? Any unsaved changes to the current script will not be saved.", "Unsaved Script", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes;
            if (flag)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Scripts"),
                    Filter = "RBot Scripts|*.cs|All Files|*.*"
                };
                bool? flag2 = saveFileDialog.ShowDialog();
                const bool flag3 = true;
                bool flag4 = flag2.GetValueOrDefault() == flag3 && flag2 != null;
                if (flag4)
                {
                    File.WriteAllText(saveFileDialog.FileName, DefaultScript);
                    LoadFile(saveFileDialog.FileName);
                }
            }
        }

        private string DefaultScript;
        private const string DefaultScriptInternal = "using RBot;\r\n\r\npublic class Script\r\n{\r\n\tpublic ScriptInterface bot => ScriptInterface.Instance;\r\n\r\n\tpublic void ScriptMain(ScriptInterface bot)\r\n\t{\r\n\t\tbot.Options.SafeTimings = true;\r\n\t\tbot.Options.RestPackets = true;\r\n\t\t/*\r\n\t\t* Enter Your Code Here\r\n\t\t*/\r\n\t}\r\n}\r\n";

        private CodeTextEditor editor = new CodeTextEditor();
    }
}
