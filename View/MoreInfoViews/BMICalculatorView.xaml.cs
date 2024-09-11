using System;
using System.Windows;
using Marathone.Data;
using Marathone.ViewModel;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Marathone.View.MoreInfoViews
{
    /// <summary>
    /// Логика взаимодействия для BMICalclulatorView.xaml
    /// </summary>
    public partial class BMICalculatorView : UserControl
    {
        private NavigationVM vm = null;
        private bool _isWoman = false;

        public BMICalculatorView(NavigationVM viewModel)
        {
            vm = viewModel;

            DataContext = viewModel;

            InitializeComponent();
        }

        private void WomanButton_OnIsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (WomanButton.IsChecked == true)
                _isWoman = true;
        }


        private void ManButton_OnIsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (ManButton.IsChecked == true)
                _isWoman = false;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var heightResult = IsValueValid(HeightValue.Text, Constants.MIN_HEIGHT, Constants.MAX_HEIGHT);

            if (heightResult.IsValid == false)
                return;

            var weightResult = IsValueValid(WeightValue.Text, Constants.MIN_WEIGHT, Constants.MAX_WEIGHT);

            if (weightResult.IsValid == false)
                return;

            var index = weightResult.Value / Math.Pow(heightResult.Value / 100, 2);

            IndexResult.Content = String.Format("{0:0.0}", index);

            var triangle = Triangle;

            var triangleTranslateTransform = new TranslateTransform();
            triangle.RenderTransform = triangleTranslateTransform;

            var textTransleteTransform = new TranslateTransform();
            IndexResult.RenderTransform = textTransleteTransform;

            ImageChoose(index);

            if (index < Constants.MIN_INDEX)
            {
                triangleTranslateTransform.X = ArrowField.ActualWidth - ArrowField.ActualWidth;
                textTransleteTransform.X = ArrowField.ActualWidth - ArrowField.ActualWidth;
            }
            else if (index > Constants.MAX_INDEX)
            {
                triangleTranslateTransform.X = ArrowField.ActualWidth;
                textTransleteTransform.X = ArrowField.ActualWidth - ArrowField.ActualWidth;
            }
            else
            {
                triangleTranslateTransform.X = ArrowField.ActualWidth / 25 * (index - 15);
                textTransleteTransform.X = ArrowField.ActualWidth / 25 * (index - 15);
            }
        }

        private void ImageChoose(double index)
        {
            if (index < 18)
            {
                BitmapImage image = new BitmapImage();

                image.BeginInit();
                image.UriSource = new Uri(
                        "C:\\Users\\sanya\\Desktop\\Maraphone1\\Maraphone\\Assets\\Calculator\\bmi-underweight-icon.png", 
                        UriKind.RelativeOrAbsolute);
                image.EndInit();

                HumanStateImage.Source = image;
                HumanState.Text = "Недовес";
            }
            else if (index < 25)
            {
                BitmapImage image = new BitmapImage();

                image.BeginInit();
                image.UriSource = new Uri(
                    @"C:\Users\sanya\Desktop\Maraphone1\Maraphone\Assets\Calculator\bmi-healthy-icon.png", 
                    UriKind.Absolute);
                image.EndInit();

                HumanStateImage.Source = image;
                HumanState.Text = "Здоровый";
            }
            else if (index < 30)
            {
                BitmapImage image = new BitmapImage();

                image.BeginInit();
                image.UriSource = new Uri(
                    "C:\\Users\\sanya\\Desktop\\Maraphone1\\Maraphone\\Assets\\Calculator\\bmi-overweight-icon.png", 
                    UriKind.Absolute);
                image.EndInit();

                HumanStateImage.Source = image;
                HumanState.Text = "Перевес";
            }
            else
            {
                BitmapImage image = new BitmapImage();

                image.BeginInit();
                image.UriSource = new Uri(
                    "C:\\Users\\sanya\\Desktop\\Maraphone1\\Maraphone\\Assets\\Calculator\\bmi-obese-icon.png", 
                    UriKind.Absolute);
                image.EndInit();

                HumanStateImage.Source = image;
                HumanState.Text = "Ожирение";
            }
        }

        private (bool IsValid, double Value) IsValueValid(string value, double minArgument, double maxArgument)
        {
            try
            {
                var result = Double.Parse(value);

                if (result > maxArgument || result < minArgument)
                {
                    MessageBox.Show("Введеные вами параметры не возможны");
                    return (false, 0);
                }

                if (ManButton.IsChecked == false && WomanButton.IsChecked == false)
                {
                    MessageBox.Show("Выберете пол");
                    return (false, result);
                }

                return (true, result);
            }
            catch
            {
                MessageBox.Show("Не верный формат ввода роста или веса");
            }
            
            return (false, 0);
        }
    }
}
