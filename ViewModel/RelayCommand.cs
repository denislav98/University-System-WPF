using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace StudentInfoSystem
{
    class RelayCommand<T> : ICommand
    {
        private readonly Action _action;
        private Action<T> loadStudentData;

        public RelayCommand(Action action)
        {
           _action = action;
        }

        public RelayCommand(Action<T> loadStudentData)
        {
            this.loadStudentData = loadStudentData;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }
    }
}