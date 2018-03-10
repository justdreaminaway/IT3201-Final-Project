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

namespace IT3201_Final_Project
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

        EncryptAndDecrypt ead = new EncryptAndDecrypt();

        private void EncryptBtn_Click(object sender, RoutedEventArgs e)
        {
            if(Plaintextbox.Text.Length >= 3)
            {
                SHA1LabelEncrypt.Text = ead.Hash(Plaintextbox.Text);
                KeyLabelEncrypt.Text = ead.generateRandomKey(Plaintextbox.Text.Length);

                CiphertextLabel.Text = ead.Encrypt(Plaintextbox.Text, KeyLabelEncrypt.Text.Length, KeyLabelEncrypt.Text);

                Notification.Text = "Text Successfully encrypted.";
            }
            else
            {
                Notification.Text = "Plain text minimum of 3 characters only.";
            }

            
        }
    }
}
