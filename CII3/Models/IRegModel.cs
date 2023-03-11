using CII3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CII3.Models
{
    public interface IRegModel
    {
        void Add(RegModel regModel);
        void Edit(RegModel regModel);
        void Delete(int id);
        IEnumerable<RegModel> GetAll();
        IEnumerable<RegModel> GetByValue(string value);//Searchs
    }
}
