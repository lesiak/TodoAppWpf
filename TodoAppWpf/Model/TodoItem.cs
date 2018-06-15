using System;
using System.ComponentModel;
using JetBrains.Annotations;
using TodoAppWpf.MVVMHelpers;

namespace TodoAppWpf
{
    public class TodoItem : ObservableObject
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

    }
}