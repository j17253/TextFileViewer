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

namespace TextFileViewer
{
    /// <summary>
    /// Interaction logic for TextViewer.xaml
    /// </summary>
    public partial class TextViewer : UserControl
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TextViewer), new PropertyMetadata(TextPropertyPropertyChanged));

        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        public TextViewer()
        {
            InitializeComponent();
        }

        private static void TextPropertyPropertyChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            TextViewer textViewer = (TextViewer)source;
            textViewer.TextBoxControl.Text = (string)e.NewValue;
        }
    }
}
