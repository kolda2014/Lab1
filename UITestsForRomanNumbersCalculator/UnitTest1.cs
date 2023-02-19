using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var MainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(200);

            string need_text = "I";
            var button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "addI");
            var button_clear = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");
            var box = MainWindow.GetVisualDescendants().OfType<TextBlock>().First();

            button.Command.Execute(button.CommandParameter);
            await Task.Delay(100);
            var box_text = box.Text;
            Assert.True(box_text.Equals(need_text), "Press button 'I' but string in textBlock != 'I' ");

            button_clear.Command.Execute(button_clear.CommandParameter);
            button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "addL");
            need_text = "L";

            button.Command.Execute(button.CommandParameter);
            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text), "Press button 'L' but string in textBlock != 'L' ");

            button_clear.Command.Execute(button_clear.CommandParameter);
            button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "addPL");
            var button2 = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "addI");
            need_text = "I+I";

            button2.Command.Execute(button2.CommandParameter);
            button.Command.Execute(button.CommandParameter);
            button2.Command.Execute(button2.CommandParameter);

            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text), "String in textBlock != 'I+I' ");

            button_clear.Command.Execute(button_clear.CommandParameter);
            button = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "addMU");
            button2 = MainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "addX");
            need_text = "X*X";

            button2.Command.Execute(button2.CommandParameter);
            button.Command.Execute(button.CommandParameter);
            button2.Command.Execute(button2.CommandParameter);

            await Task.Delay(100);
            box_text = box.Text;
            Assert.True(box_text.Equals(need_text), "String in textBlock != 'X*X' ");
        }
    }
}