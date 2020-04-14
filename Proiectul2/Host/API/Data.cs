using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProiect2020
{
    public partial class Data
    {
        public bool DeleteData(int dataID)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                var data = context.Datas.FirstOrDefault(d=>d.DataID == dataID);
                context.Datas.Remove(data);
                context.SaveChanges();
                return true;
            };
        }
        public Data UpdateData(int dataID,string dateType, DateTime creationDate, string eventName, string people, string location, string path)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                var data = context.Datas.FirstOrDefault(d=>d.DataID == dataID);
                data.DateType = dateType;
                data.CreationDate = creationDate;
                data.EventName = eventName;
                data.People = people;
                data.Location = location;
                data.Path = path;
                context.SaveChanges();
                return data;
            }
        }

        public Data GetDataById(int dataID)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                var data = context.Datas.FirstOrDefault(d => d.DataID == dataID);
                return data;
            };
        }

        public List<Data> GetAllData()
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                return context.Datas.ToList();
            };
        }

        public Data MoveData(int dataID, string path, bool movedData=true)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                var data = context.Datas.FirstOrDefault(d => d.DataID == dataID);
                data.Path = path;
                data.MovedData = movedData;
                context.SaveChanges();
                return data;
            }
        }

        public Data FavoritesData(int dataID, bool favoriteData = true)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                var data = context.Datas.FirstOrDefault(d => d.DataID == dataID);
                data.FavoriteData = favoriteData;
                context.SaveChanges();
                return data;
            }
        }
    }

}
