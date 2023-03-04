using SQLite;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea_3.Models
{
    internal class Controldatos
    {
        readonly SQLiteAsyncConnection connection;
        public Controldatos(string DBPath)
        {
            connection = new SQLiteAsyncConnection(DBPath);
            connection.CreateTableAsync<Models.Base>();

        }
        public Task<int> SaveBasee(Models.Base bas)
        {
            if (bas.Id != 0)
                return connection.UpdateAsync(bas);
            else
                return connection.InsertAsync(bas);
        }
        public Task<Models.Base> GetBase(int pid)
        {
            return connection.Table<Models.Base>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }
        public Task<List<Models.Base>> GetlisBase()
        {
            return connection.Table<Models.Base>().ToListAsync();

        }
        public Task<int> Deletebasee(Models.Base bases)
        {
            return connection.DeleteAsync(bases);
        }

        public class basecontroldatos
        {
            public basecontroldatos(string fullpath)
            {
                Fullpath = fullpath;
            }

            public string Fullpath { get; }

            public int SaveBase(ContentPage contentPage)
            {
                throw new NotImplementedException();
            }

            public Task<List<Base>> GetListbas()
            {
                throw new NotImplementedException();
            }

            public Task<int> SaveBase(object @base)
            {
                throw new NotImplementedException();
            }
        }
    }
}

