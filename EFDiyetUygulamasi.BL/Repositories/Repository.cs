using EFDiyetUygulamasi.BL.Interfaces;
using Microsoft.EntityFrameworkCore;
using EFDiyetUygulamasi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDiyetUygulamasi.DAL.Entities;

namespace EFDiyetUygulamasi.BL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private static UygulamaDbContext _db = new UygulamaDbContext();
        private DbSet<T> varliklar;
        public Repository()
        {
            varliklar = _db.Set<T>();
        }

        public void Ekle(T eklenecekOge)
        
        {
            var varolanEntity = _db.Set<T>().Local.FirstOrDefault(k => k == eklenecekOge);
            if (varolanEntity != null)
            {
                return;
            }

            varliklar.Add(eklenecekOge);
            _db.SaveChanges();
        }

        public void Guncelle(T guncellenecekOge)
        {
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty == null)
            {
                throw new InvalidOperationException("Varlık tipi 'Id' özelliğine sahip değil.");
            }

            object idValue = idProperty.GetValue(guncellenecekOge);
            if (idValue != null)
            {
                T varlik = varliklar.Find(idValue);
                if (idValue != null)
                {
                    _db.Entry(varlik).CurrentValues.SetValues(guncellenecekOge);
                    _db.SaveChanges();
                }
            }
        }
        public DbSet<T> HepsiniEgarLoadingleGetir()
        {
            return varliklar;
        }

        public List<T> HepsiniGetir()
        {
            return varliklar.ToList();
        }

        public T IdYeGoreGetir(int id)
        {
            return varliklar.Find(id)!;
        }

        public void Sil(int id)
        {
            T varlik = IdYeGoreGetir(id);

            varliklar.Remove(varlik);
            _db.SaveChanges();

        }

        
    }
}

           


