

using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using LiteDB;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.DAL
{
    internal class RepositoryEmployee : IRepository<Employee>
    {
        private string DBName = "Inventario.db";
        private string TableName = "Empleados";

        public List<Employee> Read {
            get
            {
                List<Employee> dates = new List<Employee>();
                using (var db = new LiteDatabase(DBName) )
                {
                    dates=db.GetCollection<Employee>(TableName).FindAll().ToList();
                }
                return dates;
            } 
        }

        public bool Create(Employee entity)
        {
           entity.Id = Guid.NewGuid().ToString();
            try
            {
                using var db = new LiteDatabase(DBName);
                {
                    var coleccion = db.GetCollection<Employee>(TableName);
                    coleccion.Insert(entity);
                }
                return true;
            }
            catch (Exception) 
            { 
                return false;
            }
        } 

        public bool Delete(string id, Employee entity)
        {
            try
            {
                using var db = new LiteDatabase(DBName);
                {
                    var coleccion = db.GetCollection<Employee>(TableName);
                    coleccion.Delete(entity.Id == id );
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
            
        public bool Update(string Id, Employee entityModify)
        {
            try
            {
                using var db = new LiteDatabase(DBName);
                {
                    var coleccion = db.GetCollection<Employee>(TableName);
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
