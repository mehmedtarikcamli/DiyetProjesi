using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProjesi.BL.Interfaces
{
    public interface IRepository<T>
    {
        public void Add(T addItem);

        public void Update();

        public void Remove(T deleteItem);

        public T GetById(int id);

        public List<T> GetAll();
    }
}
