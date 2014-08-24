using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCA.SmartClient.App.Views
{
    public interface IView
    {
        void Show();
        void Close();
    }
}
