using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CII3.Models;
using CII3.Views;

namespace CII3.Presenters
{
    public class RegPresenter
    {
        //Fields
        private IRegModel repository;
        private IMainWindowViews view;
        private BindingSource customerBindingSource;
        private IEnumerable<RegModel> customerList;


        //Constructor
        public RegPresenter(IRegModel repository, IMainWindowViews view)
        {

            this.customerBindingSource = new BindingSource();
            this.repository = repository;
            this.view = view;
            this.view.SerchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectedCustomer;
            this.view.DeleteEvent += DeleteCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;
            //Set pets binding source 
            this.view.SetCustomerListBindingSource(customerBindingSource);
            //Load pet list view
            LoadAllcustomerList();
            this.view.Show();


        }
        // Methods
        private void LoadAllcustomerList()
        {
            customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveCustomer(object sender, EventArgs e)
        {
            var model = new RegModel();
            model.Id = Convert.ToInt32(view.ID);
            model.Fnaln = view.fnaln;
            model.Passaport = view.passaport;
            model.Address = view.address;
            model.Phone = view.phone;
            model.Email = view.email;
            model.Jobtitle = view.jobtitle;
            model.Gender = view.gender;
            model.Dateofbirth = view.dateofbirth;
            model.Emergency = view.emergency;
            model.Maximumcover = view.maximumcover;
            model.Paymentype = view.paymentype;
            model.Servicefees = view.servicefees;
            model.Insurancetype = view.insurancetype;



            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//edit Model
                {
                    repository.Edit(model);
                    view.Message = " edited succesfuly";
                }
                else
                {
                    repository.Add(model);
                    view.Message = " Added";

                }
                view.IsSuccessful = true;
                LoadAllcustomerList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;

            }
        }

        private void CleanviewFields()
        {

            view.ID = "0";
            view.fnaln = "";
            view.passaport = "";
            view.address = "";
            view.phone = "";
            view.email = "";
            view.jobtitle = "";
            view.gender = "";
            view.dateofbirth = "";
            view.emergency = "";
            view.maximumcover = "";
            view.paymentype="";
            view.servicefees= "";
            view.insurancetype = "";

        }

        private void DeleteCustomer(object sender, EventArgs e)
        {
            try

            {
                var client = (RegModel)customerBindingSource.Current;
                repository.Delete(client.Id);
                view.IsSuccessful = true;
                view.Message = "Delete Succefully";
                LoadAllcustomerList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error";

            }
        }

        private void LoadSelectedCustomer(object sender, EventArgs e)
        {
            var Customer = (RegModel)customerBindingSource.Current;
            view.ID = Customer.Id.ToString();
            view.fnaln = Customer.Fnaln;
            view.passaport = Customer.Passaport;
            view.address = Customer.Address;
            view.phone = Customer.Phone;
            view.email = Customer.Email;
            view.jobtitle = Customer.Jobtitle;
            view.gender = Customer.Gender;
            view.dateofbirth = Customer.Dateofbirth;
            view.emergency = Customer.Emergency;
            view.maximumcover = Customer.Maximumcover;
            view.paymentype = Customer.Paymentype;
            view.servicefees = Customer.Servicefees;
            view.insurancetype = Customer.Insurancetype;
            view.IsEdit = true;

        }

        private void AddNewCustomer(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomer(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SerchValue);
            if (emptyValue == false)
                customerList = repository.GetByValue(this.view.SerchValue);
            else customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }
    }
}
