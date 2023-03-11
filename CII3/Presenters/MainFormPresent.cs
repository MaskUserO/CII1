using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CII3.Models;
using CII3.Properties;
using CII3.Views;
using CII3._Repositories;


namespace CII3.Presenters
{
     public class MainFormPresent
    {
        private IMainForm mainView;
        private readonly string sqlConnectionString;

        public MainFormPresent(IMainForm mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowMainWindowViews += ShowMainWindowViews;
        }



        private void ShowMainWindowViews(object sender, EventArgs e)
        {
            IMainWindowViews view = MainWindowViews.GetInstace((MainForm)mainView);
            IRegModel repository = new CustomerRepository(sqlConnectionString);
            new RegPresenter(repository, view);
        }

    }
}
