using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace QLThuVien.Repositories
{
    public class MauRepository<T> where T : class
    {
        protected QuanLyThuVienDataContext db;

        public MauRepository()
        {
            string connStr = ConfigurationManager.ConnectionStrings["QLThuVienConn"].ConnectionString;
            db = new QuanLyThuVienDataContext(connStr);
        }

        public List<T> GetAll() => db.GetTable<T>().ToList();

        public void Insert(T entity)
        {
            db.GetTable<T>().InsertOnSubmit(entity);
            db.SubmitChanges();
        }

        public void Update(T entity)
        {
            db.GetTable<T>().Attach(entity, true);
            db.SubmitChanges();
        }

        public void Delete(T entity)
        {
            db.GetTable<T>().DeleteOnSubmit(entity);
            db.SubmitChanges();
        }
    }
}