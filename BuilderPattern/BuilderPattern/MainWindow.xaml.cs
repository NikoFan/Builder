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

namespace BuilderPattern
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void buildObject(object sender, RoutedEventArgs e)
        {
            Body.Children.Clear();
            IBuilder topCube = new TopCubeDeveloper();
            Builder builderChief = new Builder(topCube);
            switch ((sender as Button).Name.ToString())
            {
                case ("buildTop"):
                    Cube cubeTop = builderChief.createTopCube();
                    Body.Children.Add(cubeTop.cubeInformation());
                    break;
                case ("buildBottom"):
                    IBuilder bottomCube = new BottomCubeDeveloper();
                    builderChief.setBuilder(bottomCube);
                    Cube cubeBottom = builderChief.createBottomCube();
                    Body.Children.Add(cubeBottom.cubeInformation());
                    break;
            }
            Console.WriteLine("Создание");
            
            

            
            
        }
    }
}
