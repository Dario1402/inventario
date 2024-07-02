using Inventario.COMMON.Interfaces;
using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Inventario.DAL
{
    internal class RepositoryMovStock : IRepository<MovStock>
    {
        private string DBName = "Inventario.db";
        private string TableName = "MovStock";

        public List<MovStock> Read
        {
            get
            {
                List<MovStock> dates = new List<MovStock>();
                using (var db = new LiteDatabase(DBName))
                {
                    dates = db.GetCollection<MovStock>(TableName).FindAll().ToList();
                }
                return dates;
            }
        }

        public bool Create(MovStock entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            try
            {
                using var db = new LiteDatabase(DBName);
                {
                    var coleccion = db.GetCollection<MovStock>(TableName);
                    coleccion.Insert(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(string id, MovStock entity)
        {
            try
            {
                using var db = new LiteDatabase(DBName);
                {
                    var coleccion = db.GetCollection<MovStock>(TableName);
                    coleccion.Delete(entity.Id == id);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(string Id, MovStock entityModify)
        {
            try
            {
                using var db = new LiteDatabase(DBName);
                {
                    var coleccion = db.GetCollection<MovStock>(TableName);
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
