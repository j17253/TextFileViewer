﻿using System;
using System.ComponentModel;
using System.Windows;

namespace TextFileViewer
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private string _text;
        
        public ViewModel()
        {
            _text = GetText();
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Text))); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private string GetText()
        {
            try
            {
                var args = Environment.GetCommandLineArgs();
                if (args != null && args.Length > 1)
                {
                    return args[1];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return string.Empty;
        }
    }
}
