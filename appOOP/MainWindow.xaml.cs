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

namespace appOOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ten;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            List<Student> student = new List<Student>();
            student.Add(new Student ("Kuuga"));
            student.Add(new Student ("Agito"));
            student.Add(new Student ("Faizz"));

            foreach (Student item in student)
            {
               item.Talk();
               txbTen.Items.Add(item.StudentName);
            }

            for (int i = 1; i <= student.Count; i++)
                txbSTT.Items.Add(i.ToString());
        }

    }
}
