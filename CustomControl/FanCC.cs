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

namespace CustomControl
{
    public class FanCC : Control
    {


        public bool FanOn
        {
            get { return (bool)GetValue(FanOnProperty); }
            set { SetValue(FanOnProperty, value); }
        }

        public static readonly DependencyProperty FanOnProperty = DependencyProperty.Register("FanOn", typeof(bool), typeof(FanCC), new PropertyMetadata(false));


        static FanCC()
        {
       
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FanCC), new FrameworkPropertyMetadata(typeof(FanCC)));
        }
    }
}
