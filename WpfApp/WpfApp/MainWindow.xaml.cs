using System;
using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Money money1 = new Money(int.Parse(Money1Rubles.Text), int.Parse(Money1Kopecks.Text));
                Money money2 = new Money(int.Parse(Money2Rubles.Text), int.Parse(Money2Kopecks.Text));
                Money result = (Money)money1.Add(money2);
                MoneyResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubtractMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Money money1 = new Money(int.Parse(Money1Rubles.Text), int.Parse(Money1Kopecks.Text));
                Money money2 = new Money(int.Parse(Money2Rubles.Text), int.Parse(Money2Kopecks.Text));
                Money result = (Money)money1.Subtract(money2);
                MoneyResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MultiplyMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Money money1 = new Money(int.Parse(Money1Rubles.Text), int.Parse(Money1Kopecks.Text));
                Money money2 = new Money(int.Parse(Money2Rubles.Text), int.Parse(Money2Kopecks.Text));
                Money result = (Money)money1.Multiply(money2);
                MoneyResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DivideMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Money money1 = new Money(int.Parse(Money1Rubles.Text), int.Parse(Money1Kopecks.Text));
                Money money2 = new Money(int.Parse(Money2Rubles.Text), int.Parse(Money2Kopecks.Text));
                Money result = (Money)money1.Divide(money2);
                MoneyResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddFractionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Fraction fraction1 = new Fraction(int.Parse(Fraction1Numerator.Text), int.Parse(Fraction1Denominator.Text));
                Fraction fraction2 = new Fraction(int.Parse(Fraction2Numerator.Text), int.Parse(Fraction2Denominator.Text));
                Fraction result = (Fraction)fraction1.Add(fraction2);
                FractionResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubtractFractionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Fraction fraction1 = new Fraction(int.Parse(Fraction1Numerator.Text), int.Parse(Fraction1Denominator.Text));
                Fraction fraction2 = new Fraction(int.Parse(Fraction2Numerator.Text), int.Parse(Fraction2Denominator.Text));
                Fraction result = (Fraction)fraction1.Subtract(fraction2);
                FractionResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MultiplyFractionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Fraction fraction1 = new Fraction(int.Parse(Fraction1Numerator.Text), int.Parse(Fraction1Denominator.Text));
                Fraction fraction2 = new Fraction(int.Parse(Fraction2Numerator.Text), int.Parse(Fraction2Denominator.Text));
                Fraction result = (Fraction)fraction1.Multiply(fraction2);
                FractionResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DivideFractionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Fraction fraction1 = new Fraction(int.Parse(Fraction1Numerator.Text), int.Parse(Fraction1Denominator.Text));
                Fraction fraction2 = new Fraction(int.Parse(Fraction2Numerator.Text), int.Parse(Fraction2Denominator.Text));
                Fraction result = (Fraction)fraction1.Divide(fraction2);
                FractionResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
