using ArmEditor.UI.ViewModels;
using System.Windows;

namespace ArmEditor.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new TemplateViewModel();
        }
    }
}
