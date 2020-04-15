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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kybs0.UI
{
    /// <summary>
    /// WindowHeaderView.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHeaderView : UserControl
    {
        public WindowHeaderView(DefinedWindowType definedWindowType)
        {
            InitializeComponent();
            if (definedWindowType==DefinedWindowType.GrayTitleDialog)
            {
                MinimizeButton.Visibility = Visibility.Collapsed;
            }
        }

        private void HeaderGridOnMouseLeftButtonDown(object sender, MouseButtonEventArgs args)
        {
            if (args.ButtonState == MouseButtonState.Pressed)
            {
                Window.GetWindow(this)?.DragMove();
            }
        }
        private void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            if (window != null)
            {
                window.WindowState = WindowState.Minimized;
            }
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this)?.Close();
        }
    }
}
