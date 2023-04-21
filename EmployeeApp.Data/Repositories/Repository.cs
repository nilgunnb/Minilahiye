using EmployeeApp.Core.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Data.Repositories
{
    public class Repository<T> where T : BaseModel
    {
        private readonly List<T> _items = new List<T>();

        public void Create(T model)
        {
            _items.Add(model);
        }

        public void Delete (T model)
        {
            _items.Remove(model);
        }

        
       

        public T Get (int id)
        {
            foreach (var  item in _items)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }

        public List<T> GetAll()
        {
              return _items;
        }
    }
}
