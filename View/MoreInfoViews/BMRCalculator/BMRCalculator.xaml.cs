using System;
using System.Windows;
using Marathone.ViewModel;
using System.Windows.Controls;
using Maraphone.View.MoreInfoViews.BMRCalculator;
using Marathone.Data;

namespace Marathone.View.MoreInfoViews
{
    public partial class BMRCalculator : UserControl
    {
        private const double SEDENTARY_COEFFICIENT = 1.2;
        private const double LIGHT_ACTIVITY_COEFFICIENT = 1.375;
        private const double MODERATE_ACTIVITY_COEFFICIENT = 1.55;
        private const double VIGOROUS_ACTIVITY_COEFFICIENT = 1.725;
        private const double VERY_VIGOROUS_ACTIVITY_COEFFICIENT = 1.9;


        public BMRCalculator(NavigationVM context)
        {
            this.DataContext = context;

            InitializeComponent();
        }

        private void GetInfo_OnClick(object sender, RoutedEventArgs e)
        {
            BMRCalculatorInfoView infoView = new BMRCalculatorInfoView();

            infoView.ShowDialog();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var validationResult = Validate();
            if (validationResult.IsValid)
            {
                var calculateMetabolicRateResult = CalculateMetabolicRate(
                    validationResult.Weight,
                    validationResult.Height,
                    validationResult.Age);

                TotalMetabolicRate.Content = calculateMetabolicRateResult;
                
                SedentaryRateValue.Text = 
                    ToFormat(calculateMetabolicRateResult * SEDENTARY_COEFFICIENT);

                InactiveRateValue.Text = 
                    ToFormat(calculateMetabolicRateResult * LIGHT_ACTIVITY_COEFFICIENT);

                AverageActivityRateValue.Text = 
                    ToFormat(calculateMetabolicRateResult * MODERATE_ACTIVITY_COEFFICIENT);

                StrongActivityRateValue.Text = 
                    ToFormat(calculateMetabolicRateResult * VIGOROUS_ACTIVITY_COEFFICIENT);

                VeryStrongActivityRateValue.Text = 
                    ToFormat(calculateMetabolicRateResult * VERY_VIGOROUS_ACTIVITY_COEFFICIENT);
            }
        }

        private (bool IsValid, double Weight, double Height, int Age) Validate()
        {
            if (IsGenderSelected() == false)
                return (false, 0, 0, 0);

            var weightResult = ValidateWeight();
            if (weightResult.IsValid == false)
                return (false, 0, 0, 0);

            var heightResult = ValidateHeight();
            if (heightResult.IsValid == false)
                return (false, 0, 0, 0);

            var ageResult = ValidateAge();
            if (ageResult.IsValid == false)
                return (false, 0, 0, 0);

            return (true, weightResult.Value, heightResult.Value, ageResult.Value);
        }

        private bool IsGenderSelected()
        {
            if (ManButton.IsChecked == false && WomanButton.IsChecked == false)
            {
                MessageBox.Show("Пол не выбран");
                return false;
            }

            return true;
        }

        private (bool IsValid, double Value) ValidateWeight()
        {
            var result = Double.TryParse(WeightValue.Text, out var weight);
            if (result == false)
            {
                MessageBox.Show("Вес введен некорректно");
                return (false, 0);
            }

            if (weight < Constants.MIN_WEIGHT || weight > Constants.MAX_WEIGHT)
            {
                MessageBox.Show("Не возможный вес");
                return (false, 0);
            }

            return (true, weight);
        }

        private (bool IsValid, double Value) ValidateHeight()
        {
            var result = Double.TryParse(HeightValue.Text, out var height);
            if (result == false)
            {
                MessageBox.Show("Рост введен некорректно");
                return (false, 0);
            }

            if (height < Constants.MIN_HEIGHT || height > Constants.MAX_HEIGHT)
            {
                MessageBox.Show("Не возможный рост");
                return (false, 0);
            }

            return (true, height);
        }

        private (bool IsValid, int Value) ValidateAge()
        {
            var result = Int32.TryParse(AgeValue.Text, out var age);
            if (result == false)
            {
                MessageBox.Show("Возраст введен некорректно");
                return (false, 0);
            }

            if (age < Constants.MIN_AGE || age > Constants.MAX_AGE)
            {
                MessageBox.Show("Не возможный возраст");
                return (false, 0);
            }

            return (true, age);
        }

        private double CalculateMetabolicRate(double weight, double height, int age)
        {
            var result = ManButton.IsChecked.Value
                ? 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age)
                : 447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age);

            return result;
        }

        private string ToFormat(double value)
        {
            return $"{value:0}";
        }
    }
}