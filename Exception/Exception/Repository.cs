using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Repository<T> where T : BaseEntity
    {
        private  T[] _datas;
        public Repository()
        {
            _datas = Array.Empty<T>();
        }

        public void Add(T item)
        {
            Array.Resize(ref _datas, _datas.Length+1);
            _datas[^1] = item;
        }


        public T[] GetById(int id)
        {
            return _datas.Where(x => x.Id == id).ToArray();
        }

        public T[] Delete(int id)
        {
            return _datas.Where(x => x.Id != id).ToArray();
            
        }
    }
}
