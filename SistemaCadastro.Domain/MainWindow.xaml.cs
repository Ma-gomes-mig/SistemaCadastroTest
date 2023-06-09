﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace SistemaCadastro.Domain
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

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
                {
                    lstNames.Items.Add(txtName.Text);
                    txtName.Clear();                    
                }
                else if(lstNames.Items.Contains(txtName.Text))
                {
                    throw new Exception();
                }
                
                
                
            }
            catch (Exception)
            {
                txtName.Clear();
                txtName.AppendText("O nome já existe, digite outro nome...");
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
