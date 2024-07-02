using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.DAL
{
    internal class RepositoryProduct : IRepository<Product>
    {
        private string DBName = "Inventario.db";
        private string TableName = "Product";

        public List<Product> Read 
        {
            get
            {
                List<Product> dates = new List<Product>();
                using (var db = new LiteDatabase(DBName))
                {
                    dates = db.GetCollection<Product>(TableName).FindAll().ToList();
                }
                return dates;
            }

        }

        public bool Create(Product entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            try
            {
                using var db = new LiteDatabase(DBName);
                {
                    var coleccion = db.GetCollection<Product>(TableName);
                    coleccion.Insert(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(string id, Product entity)
        {
            try
            {
                using var db = new LiteDatabase(DBName);
                {
                    var coleccion = db.GetCollection<Product>(TableName);
                    coleccion.Delete(entity.Id == id);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(string Id, Product entityModify)
        {
            try
            {
                using var db = new LiteDatabase(DBName);
                {
                    var coleccion = db.GetCollection<Product>(TableName);
                    coleccion.Update(entityModify);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    
}
