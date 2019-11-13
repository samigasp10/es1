using System.Windows;

namespace scelta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_ClickM(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d * 0.001;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickM1(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d * 0.01;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickM2(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d * 0.1;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickDi(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d / 0.001;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickDi2(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d / 0.01;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickDi3(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d / 0.1;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d + 0.01;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickAd2(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d + 0.1;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickAdd3(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d + 1;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickSo(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d - 0.01;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickSo1(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d - 0.1;
            txtNumero.Text = r.ToString();
        }

        private void Button_ClickSo2(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d - 1;
            txtNumero.Text = r.ToString();

        }


        





    }
}
