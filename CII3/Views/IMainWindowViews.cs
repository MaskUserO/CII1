using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CII3.Views
{
    public interface IMainWindowViews
    {
        // Properties - Fields
        string ID { get; set; }
        string fnaln { get; set; }
        string passaport { get; set; }
        string address { get; set; }
        string phone { get; set; }
        string email { get; set; }
        string jobtitle { get; set; }
        string gender { get; set; }
        string dateofbirth { get; set; }
        string emergency { get; set; }
        string insurancetype { get; set; }
        string paymentype { get; set; }
        string maximumcover { get; set; }
        string servicefees { get; set; }


        string SerchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }


        // Events

        event EventHandler SerchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetCustomerListBindingSource(BindingSource customerList);
        void Show(); 




    }
}
