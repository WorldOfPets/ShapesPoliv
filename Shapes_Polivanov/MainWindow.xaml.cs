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
using ShapesLib;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes;

namespace Shapes_Polivanov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RadioButton radio = new RadioButton();
        public MainWindow()
        {
            InitializeComponent();
            radio = StRB;
        }

        private void RBClick(object sender, RoutedEventArgs e)
        {
            var RB = sender as RadioButton;
            radio = RB;
            switch (StcRadioBatton.Children.IndexOf(RB))
            {
                case 0: 
                    TbHead.Text = RB.Content.ToString();
                    ClearTb();
                    break;
                case 1:
                    TbHead.Text = RB.Content.ToString();
                    ClearTb();
                    
                    HintAssist.SetHint(TBznachThree, "Угол");
                    break;
                case 2:
                    TbHead.Text = RB.Content.ToString();
                    ClearTb();
                    TBznachThree.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    TbHead.Text = RB.Content.ToString();
                    ClearTb();
                    
                    HintAssist.SetHint(TBznachOne, "Радиус");
                    TBznachThree.Visibility = Visibility.Hidden;
                    TBznachTwo.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (StcRadioBatton.Children.IndexOf(radio))
            {
                case 0:
                    ProverkaTextBox(new string[] { TBznachOne.Text, TBznachTwo.Text, TBznachThree.Text });
                    TbResult.Text = ShapesClass.ShapesTiangle(Convert.ToDouble(TBznachOne.Text), Convert.ToDouble(TBznachTwo.Text), Convert.ToDouble(TBznachThree.Text)).ToString();
                    break;
                case 1:
                    ProverkaTextBox(new string[] { TBznachOne.Text, TBznachTwo.Text, TBznachThree.Text });
                    TbResult.Text = ShapesClass.ShapesTiangle2(Convert.ToDouble(TBznachOne.Text), Convert.ToDouble(TBznachTwo.Text), float.Parse(TBznachThree.Text)).ToString();
                    break;
                case 2:
                    ProverkaTextBox(new string[] { TBznachOne.Text, TBznachTwo.Text});
                    TbResult.Text = ShapesClass.ShapesRectangle(Convert.ToDouble(TBznachOne.Text), Convert.ToDouble(TBznachTwo.Text)).ToString();
                    break;
                case 3:
                    ProverkaTextBox(new string[] { TBznachOne.Text });
                    TbResult.Text = ShapesClass.ShapesCircle(Convert.ToDouble(TBznachOne.Text)).ToString();
                    break;
                default:
                    break;
            }
            ProverkaTextBox(new string[]{TBznachOne.Text});
            //TbResult.Text = (ShapesClass.ShapesTiangle());
        }

        private void ClearTb()
        {
            TBznachOne.Text = "";
            TBznachTwo.Text = "";
            TBznachThree.Text = "";
            TbResult.Text = "";
            TBznachOne.Visibility = Visibility.Visible;
            TBznachTwo.Visibility = Visibility.Visible;
            TBznachThree.Visibility = Visibility.Visible;
            HintAssist.SetHint(TBznachThree, "Сторона С");
            HintAssist.SetHint(TBznachOne, "Сторона A");

        }

        private void ProverkaTextBox(string[] znach)
        {
            try
            {
                double proverka = 0;
                for (int i = 0; i < znach.Length; i++)
                {
                    if (!double.TryParse(znach[i], out proverka))
                    {
                        throw new Exception("Данные в полях ");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
