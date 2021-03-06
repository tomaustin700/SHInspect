﻿using SHInspect.Classes;
using SHInspect.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SHInspect.Views
{
    /// <summary>
    /// Interaction logic for AddWindowPopup.xaml
    /// </summary>
    public partial class AddWindowPopup : Window
    {
        public AddWindowPopup(WindowBO selectedWindow)
        {
            DataContext = new AddWindowPopupViewModel() { SelectedWindow = selectedWindow };
            InitializeComponent();
        }
    }
}
