using CodeGeneration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Common;

namespace CodeGeneration
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
            this.tbs = new TextBox[] { input, output, used, notUsed };
        }

        private ICasesGenerator currentCase = GeneratorsFactory.AllLinq();

        private void GenareButtonClick_Click(object sender, RoutedEventArgs e)
        {
            var lines = input.Text.SplitAllLines();

            var generation = currentCase.Generate(lines);

            this.output.Text = generation.Output;
            this.notUsed.Text = string.Join("\n", generation.NotProcessesed);
            this.used.Text = string.Join("\n", generation.Processesed);
            last = input;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var textToStore = output.Text;
            CodeInjector.Inject(currentCase.Source.OutputPath, textToStore);
        }
        private void EmptyBtn_Click(object sender, RoutedEventArgs e)
        {
            var textToStore = output.Text;
            CodeInjector.Inject(currentCase.Source.OutputPath, "\n\n");
        }
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentCase();

            this.input.Text = System.IO.File.ReadAllText(currentCase.Source.InputPath);
        }

        private void cases_comb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetCurrentCase();
        }

        private void SetCurrentCase()
        {
            currentCase = Cases[cases_comb.SelectedIndex];
        }
        public List<ICasesGenerator> Cases => new List<ICasesGenerator>()
        {
            GeneratorsFactory.Current(),
            GeneratorsFactory.AllLinq(),
            GeneratorsFactory.SimpleLinq(),
            GeneratorsFactory.NoGeneric_TSourceLinq(),
            GeneratorsFactory.NoGenericLinq(),
            GeneratorsFactory.NoGeneric_NumericLinq(),
            GeneratorsFactory.GenericRequiredInBody(),
            GeneratorsFactory.CommentsTypesGenerator(),            
            GeneratorsFactory.GenerateCustomTupleExtenstions(),
            GeneratorsFactory.GenerateTupleToEnumerable(),
        };

        private void To_Input_Button_Click(object sender, RoutedEventArgs e)
        {
            this.input.Text = used.Text;
        }
        TextBox last;
        private void TextBoxGotFocus_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            last = sender as TextBox;
        }

        private void Copy_Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(last?.Text);
        }

        private void Paste_Button_Click(object sender, RoutedEventArgs e)
        {
            last.Text = Clipboard.GetText() ?? "";
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var tb in tbs)
            {
                tb.Text = "";
            }
        }
        private TextBox[] tbs;
        private void NoComments_Button_Click(object sender, RoutedEventArgs e)
        {

            foreach (var tb in tbs)
            {
                var lines = tb.Text.SplitAllLines();
                var goodLines = lines.Where(x => !IsLineComment(x));
                tb.Text = string.Join("\r", goodLines);
                bool IsLineComment(string line)
                {
                    line = line?.Trim();
                    if (string.IsNullOrWhiteSpace(line) || line.Length < 2)
                        return true;
                    if (line[0] == '/' && line[1] == '/')
                        return true;

                    return false;
                }

            }
        }

        private void DOEVERY_THINK_BTN_Click(object sender, RoutedEventArgs e)
        {
            GenerateAllTestingCases generator = new GenerateAllTestingCases();
            generator.Generate();
        }
    }
}
