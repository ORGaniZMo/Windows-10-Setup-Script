﻿using System;
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

namespace Power_App.Controls
{
    /// <summary>
    /// Логика взаимодействия для HamburgerPathButton.xaml
    /// </summary>
    public partial class HamburgerPathButton : UserControl
    {
        public static RoutedEvent HamburgerMouseEnterEvent = EventManager.RegisterRoutedEvent("HamburgerMouseEnter", RoutingStrategy.Bubble,
                                                                                        typeof(RoutedEventHandler), typeof(HamburgerPathButton));

        public event RoutedEventHandler HamburgerMouseEnter
        {
            add { AddHandler(HamburgerMouseEnterEvent, value); }
            remove { RemoveHandler(HamburgerMouseEnterEvent, value); }
        }

        public HamburgerPathButton()
        {
            InitializeComponent();
        }

        private void Hamburger_MouseEnter(object sender, MouseEventArgs e)
        {
            RoutedEventArgs routedArgs = new RoutedEventArgs(HamburgerMouseEnterEvent, this);
            RaiseEvent(routedArgs);
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(HamburgerPathButton), new PropertyMetadata(default(string)));

        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Geometry), typeof(HamburgerPathButton), new PropertyMetadata(default(Geometry)));        
    }
}
