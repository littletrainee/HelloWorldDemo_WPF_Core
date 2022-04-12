using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
namespace HelloWorldDemo_WPF_Core.CountToTen {
  /// <summary>
  /// CTT.xaml 的互動邏輯
  /// </summary>
  public partial class CTT : UserControl {
#pragma warning disable CS8618 // 退出建構函式時，不可為 Null 的欄位必須包含非 Null 值。請考慮宣告為可為 Null。
    public CTT() => InitializeComponent();
#pragma warning restore CS8618 // 退出建構函式時，不可為 Null 的欄位必須包含非 Null 值。請考慮宣告為可為 Null。
    
    // declare
    DispatcherTimer Timer { get; set; }
    private int Duration { get; set; }

    private void CountUp(object sender, RoutedEventArgs e) {
      // instance
      Timer = new();
      Duration = 0;
      PrintLabel.Content = Duration.ToString();
      // subscripttion Count_Up function
#pragma warning disable CS8622 // 參數類型中參考型別是否可為 Null 的情況，與目標委派不相符 (可能的原因是屬性可為 Null)。
      Timer.Tick += Count_Up;
#pragma warning restore CS8622 // 參數類型中參考型別是否可為 Null 的情況，與目標委派不相符 (可能的原因是屬性可為 Null)。
      // set interval
      Timer.Interval = new TimeSpan(0, 0, 1);
      // start the timer
      Timer.Start();
    }

    // make an eventer
    private void Count_Up(object sender, EventArgs e) {
      if (Duration == 10) {
        Timer.Stop();
      } else if (Duration < 10) {
        Duration += 1;
        PrintLabel.Content = Duration.ToString();
      }
    }
  }
}
