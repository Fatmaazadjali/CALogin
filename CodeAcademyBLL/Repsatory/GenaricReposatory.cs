using CodeAcademyBLL.Interfaces;
using CodeAcademyDAL.Context;
using CodeAcademyDAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyBLL.Repsatory
{

    public class GenaricReposatory<T> : IGeneric<T> where T :class
    {
            private readonly ApplicationDbContext _context;

                 public GenaricReposatory(ApplicationDbContext context)
                  {
      
                 _context = context; 
                    }
          public int Create(T item)
          {
            _context.Set<T>().Add(item);
            return _context.SaveChanges();
           }

        public int Delete(T item)
        {
           _context?.Set<T>().Remove(item);
            return _context.SaveChanges();
        }

        public T Get(int id) => _context.Set<T>().Find(id);


        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();
      

        public int Update(T item)
        {
            
                _context.Set<T>().Update(item);
                return _context.SaveChanges();
            
        }
    }

}
