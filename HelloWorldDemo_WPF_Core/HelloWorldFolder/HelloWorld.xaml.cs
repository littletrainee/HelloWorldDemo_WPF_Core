using System;
using System.Windows.Controls;
namespace HelloWorldDemo_WPF_Core.HelloWorldFolder {
  /// <summary>
  /// HelloWorld.xaml 的互動邏輯
  /// </summary>
  public partial class HelloWorld : UserControl {
    public HelloWorld() => InitializeComponent();

    private void Print(object sender, EventArgs e) =>
      PrintLabel.Content = "Hello World!";
  }
}
