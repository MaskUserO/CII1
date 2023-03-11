using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CII3.Views
{
    public interface IMainForm
    {
        event EventHandler ShowMainWindowViews;
        event EventHandler ShowInsurance;
        event EventHandler ShowPolicies;
    }
}
