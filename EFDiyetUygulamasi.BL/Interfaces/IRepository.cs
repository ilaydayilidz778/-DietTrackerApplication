using EFDiyetUygulamasi.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetUygulamasi.BL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public void Ekle(T eklenecekOge);

        public void Guncelle(T guncellenecekOge);

        public void Sil(int id);

        public T IdYeGoreGetir(int id);

        public List<T> HepsiniGetir();

        public DbSet<T> HepsiniEgarLoadingleGetir();

    }
}
