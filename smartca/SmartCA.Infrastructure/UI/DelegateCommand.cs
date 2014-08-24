using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SmartCA.Infrastructure.UI
{
    public class DelegateCommand: ICommand
    {
        public delegate void SimpleEventHandler(object sender, EventArgs e);

        public SimpleEventHandler hander;
        private bool isEnabled = true;

        public DelegateCommand(SimpleEventHandler handler)
        {
            this.hander = handler;
        }

        public bool CanExecute(object parameter)
        {
            return this.isEnabled;
        }

        public void Execute(object parameter)
        {
            this.hander(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set
            {
                this.isEnabled = value;
                this.OnCanExecuteChanged();
            }
        }

        private void OnCanExecuteChanged()
        {
            if (this.CanExecuteChanged != null)
            {
                this.CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
