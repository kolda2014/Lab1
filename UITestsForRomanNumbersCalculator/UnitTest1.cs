using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class GUITests
    {
        [Fact]
        public async void ButtonsWithRomanNumerals()
        {
            var app = AvaloniaApp.GetApp();
            var MainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(200);

            string need_text = "I";
            var button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "I");
            var button_clear = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "CE");
            var box = MainWindow.GetVisualDescendants().OfType<TextBlock>().First();

            button.Command.Execute(button.CommandParameter);
            await Task.Delay(100);
            var box_text = box.Text;
            Assert.True(box_text.Equals(need_text));

            button_clear.Command.Execute(button_clear.CommandParameter);
            need_text = "V";
            button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            
            button.Command.Execute(button.CommandParameter);
            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text));

            button_clear.Command.Execute(button_clear.CommandParameter);
            need_text = "X";
            button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "X");
            
            button.Command.Execute(button.CommandParameter);
            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text));

            button_clear.Command.Execute(button_clear.CommandParameter);
            need_text = "L";
            button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "L"); 

            button.Command.Execute(button.CommandParameter);
            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text));

            button_clear.Command.Execute(button_clear.CommandParameter);
            need_text = "C";
            button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "C");

            button.Command.Execute(button.CommandParameter);
            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text));

            button_clear.Command.Execute(button_clear.CommandParameter);
            need_text = "D";
            button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "D");

            button.Command.Execute(button.CommandParameter);
            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text));

            button_clear.Command.Execute(button_clear.CommandParameter);
            need_text = "M";
            button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "M");

            button.Command.Execute(button.CommandParameter);
            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text));
            button_clear.Command.Execute(button_clear.CommandParameter);
        }

        [Fact]

        public async void CalculationsWithRomanNumerals()
        {
            var app = AvaloniaApp.GetApp();
            var MainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(200);

            string need_text = "I+I";
            var button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "I");
            var buttonCal = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "+");
            var button_clear = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "CE");
            var box = MainWindow.GetVisualDescendants().OfType<TextBlock>().First();

            button.Command.Execute(button.CommandParameter);
            buttonCal.Command.Execute(buttonCal.CommandParameter);
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(100);
            var box_text = box.Text;
            Assert.True(box_text.Equals(need_text));

            button_clear.Command.Execute(button_clear.CommandParameter);
            need_text = "I-I";
            buttonCal = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "-");

            button.Command.Execute(button.CommandParameter);
            buttonCal.Command.Execute(buttonCal.CommandParameter);
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text));

            button_clear.Command.Execute(button_clear.CommandParameter);
            need_text = "I*I";
            buttonCal = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "*");

            button.Command.Execute(button.CommandParameter);
            buttonCal.Command.Execute(buttonCal.CommandParameter);
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text));

            button_clear.Command.Execute(button_clear.CommandParameter);
            need_text = "I/I";
            buttonCal = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "/");

            button.Command.Execute(button.CommandParameter);
            buttonCal.Command.Execute(buttonCal.CommandParameter);
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text));
            button_clear.Command.Execute(button_clear.CommandParameter);
        }

        [Fact]
        public async void GoingBeyondTheRangeOfValues()
        {
            var app = AvaloniaApp.GetApp();
            var MainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(200);

            string need_text = "#ERROR";
            var button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "C");
            var buttonCal = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "-");
            var button_clear = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "CE");
            var buttonEqually = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "=");
            var box = MainWindow.GetVisualDescendants().OfType<TextBlock>().First();

            button.Command.Execute(button.CommandParameter);
            buttonCal.Command.Execute(buttonCal.CommandParameter);
            button.Command.Execute(button.CommandParameter);
            buttonEqually.Command.Execute(buttonEqually.CommandParameter);

            await Task.Delay(100);
            var box_text = box.Text;
            Assert.True(box_text.Equals(need_text));

            button_clear.Command.Execute(button_clear.CommandParameter);
            buttonCal = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "*");

            button.Command.Execute(button.CommandParameter);
            buttonCal.Command.Execute(buttonCal.CommandParameter);
            button.Command.Execute(button.CommandParameter);
            buttonEqually.Command.Execute(buttonEqually.CommandParameter);

            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text));
        }
    }
}