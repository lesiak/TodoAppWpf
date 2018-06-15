using System;
using System.ComponentModel;
using JetBrains.Annotations;

namespace TodoAppWpf
{
    public class TodoItem : INotifyPropertyChanged
    {
        private string title;
        private string details;

        public string Title
        {
            get => title;
            set
            {
                if (value == title)
                {
                    return;
                }

                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Details
        {
            get => details;
            set
            {
                if (value == details)
                {
                    return;
                }

                details = value;
                OnPropertyChanged(nameof(Details));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}