using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CII3.Models
{
    public class RegModel
    {
        // Fields
        private int id;
        private string fnaln;
        private string passaport;
        private string address;
        private string phone;
        private string email;
        private string jobtitle;
        private string gender;
        private string dateofbirth;
        private string emergency;
        private string insurancetype;
        private string maximumcover;
        private string paymentype;
        private string servicefees;

        // Properties - Validations
        [DisplayName("ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters")]
        public string Fnaln
        {
            get { return fnaln; }
            set { fnaln = value; }
        }
        [DisplayName("NB Passaport")]
        [Required(ErrorMessage = "Passaport is requerid")]
        public string Passaport {
            get { return passaport; }
            set { passaport = value; }

        }
        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is requerid")]
        public string Address {
            get { return address; }
            set { address = value; }
        }
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone is requerid")]
        [RegularExpression(@"^\+?\d{1,3}[- ]?\d{3,4}[- ]?\d{4}$", ErrorMessage = "Please enter a valid phone number")]
        public string Phone {
            get { return phone; }
            set { phone = value; }
        }
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is requerid")]
        public string Email {

            get { return email; }
            set { email = value; }
        }
        [DisplayName("Job Title")]
        [Required(ErrorMessage = "Job Title is requerid")]
        public string Jobtitle {
            get { return jobtitle; }
            set { jobtitle = value; }
        }
        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is requerid")]
        public string Gender {
            get { return gender; }
            set { gender = value; }
        }
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date of birth is requerid")]        
        public string Dateofbirth {
            get { return dateofbirth; }
            set { dateofbirth = value; }

        }
        [DisplayName("Emergency")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter numbers, Emergency")]
        [Required(ErrorMessage = "Emergency is requerid")]
        public string Emergency
        {
            get { return emergency; }
            set { emergency = value; }

        }

        [DisplayName("Maximumcover")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter numbers, Max")]
        [Required(ErrorMessage = "Maximumcover is requerid")]
        public string Maximumcover  {
                get { return maximumcover; }
                set { maximumcover = value; }

            }

        [DisplayName("Payment Type")]
        [Required(ErrorMessage = "Payment Type is requerid")]

        public string Paymentype {
                get { return paymentype; }
                set { paymentype = value; }

            }

        [DisplayName("Service Fees")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter numbers, Service")]
        [Required(ErrorMessage = "Service Fees is requerid")]
        public string Servicefees
        {
            get { return servicefees; }
            set { servicefees = value; }

        }

        [DisplayName("Insurance Type")]
        [Required(ErrorMessage = "Insurance Type is requerid")]
        public string Insurancetype
        {
            get { return insurancetype; }
            set { insurancetype = value; }

        }




    }
}
