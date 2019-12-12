using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public interface IRepository
    {
        void Add(Book book);
        int Count { get; }
    }
}
