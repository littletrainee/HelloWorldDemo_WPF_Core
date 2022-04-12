using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Threading;
namespace HelloWorldDemo_WPF_Core.CurrentTimeFolder {
  /// <summary>
  /// CT.xaml 的互動邏輯
  /// </summary>
  public partial class CT : UserControl {
    DispatcherTimer Timer {get;set;}
    public CT() {
      InitializeComponent();
      Timer = new();
#pragma warning disable CS8622 // 參數類型中參考型別是否可為 Null 的情況，與目標委派不相符 (可能的原因是屬性可為 Null)。
      Timer.Tick += CurrentTime;
#pragma warning restore CS8622 // 參數類型中參考型別是否可為 Null 的情況，與目標委派不相符 (可能的原因是屬性可為 Null)。
      Timer.Start();
    }

    private void CurrentTime(object sender, EventArgs e) =>
      Print.Content = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
  }
}
