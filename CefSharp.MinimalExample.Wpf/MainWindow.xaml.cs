using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public List<TabViewModel> Tabs { get; }

        public MainWindow()
        {
            InitializeComponent();

            Tabs = ConfigurationManager.AppSettings["tabs"]
                .Split(new[] { '█' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => new TabViewModel(x, x))
                .ToList();

            DataContext = this;
        }
    }
}