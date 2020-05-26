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
    /// Логика взаимодействия для HamburgerIconButton.xaml
    /// </summary>
    public partial class HamburgerIconButton : UserControl
    {
        public static new RoutedEvent MouseEnterEvent = EventManager.RegisterRoutedEvent("MouseEnter", RoutingStrategy.Bubble,
                                                               typeof(RoutedEventHandler), typeof(HamburgerIconButton));

        public static new RoutedEvent MouseLeftButtonDownEvent = EventManager.RegisterRoutedEvent("MouseLeftButtonDown", RoutingStrategy.Bubble,
                                                                  typeof(RoutedEventHandler), typeof(HamburgerIconButton));

        public new event RoutedEventHandler MouseEnter
        {
            add { AddHandler(MouseEnterEvent, value); }
            remove { RemoveHandler(MouseEnterEvent, value); }
        }

        public new event RoutedEventHandler MouseLeftButtonDown
        {
            add { AddHandler(MouseLeftButtonDownEvent, value); }
            remove { RemoveHandler(MouseLeftButtonDownEvent, value); }
        }

        public HamburgerIconButton()
        {
            InitializeComponent();            
        }

        private void HamburgerIconButton_MouseEnter(object sender, MouseEventArgs e)
        {
            RoutedEventArgs routedArgs = new RoutedEventArgs(MouseEnterEvent, this);
            RaiseEvent(routedArgs);
        }

        private void HamburgerIconButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RoutedEventArgs routedArgs = new RoutedEventArgs(MouseLeftButtonDownEvent, this);
            RaiseEvent(routedArgs);
        }

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(HamburgerIconButton), new PropertyMetadata(default(string)));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(HamburgerIconButton), new PropertyMetadata(default(string)));
        
    }
}