﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditorDemo : ContentPage
    {
        public EditorDemo()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var MyEditor = new Editor { Text = "I'm an Editor" };
            stack.Children.Add(MyEditor);
            Content = stack;
        }
    }
}