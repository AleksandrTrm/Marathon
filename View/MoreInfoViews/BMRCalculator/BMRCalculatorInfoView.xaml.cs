using System.Windows;
using System.Windows.Input;

namespace Maraphone.View.MoreInfoViews.BMRCalculator
{
    public partial class BMRCalculatorInfoView : Window
    {
        public BMRCalculatorInfoView()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}