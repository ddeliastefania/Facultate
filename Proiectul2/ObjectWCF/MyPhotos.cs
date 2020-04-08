using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProiect2020;

namespace ObjectWCF
{
    public class MyPhotos : IProject
    {
        public Data CreateData(string dateType, DateTime creationDate, string eventName, string people, string location, string path)
        {
            return Data.CreateData(dateType, creationDate, eventName, people, location, path);
        }
        public SpecialProperty CreateSpecialProperty(string propertyName, string propertyDescription)
        {
            return SpecialProperty.CreateSpecialProperty(propertyName,propertyDescription);
        }

        public User CreateUser(string firstName, string lastName, string password, string email, string phone)
        {
            return User.CreateUser(firstName,lastName,password,email,phone);        
        }

        public bool DeleteSpecialProperty(int propertyID)
        {
            return new SpecialProperty().DeleteSpecialProperty(propertyID);
        }

        public bool DeleteUser(int userId)
        {
            return new User().DeleteUser(userId);
        }

        public Data FavoritesData(int dataID, bool favoriteData = true)
        {
            return new Data().FavoritesData(dataID, favoriteData);
        }

        public List<Data> GetAllData()
        {
            return new Data().GetAllData();
        }

        public List<User> GetAllUsers()
        {
            return new User().GetAllUsers();
        }

        public Data GetDataById(int dataID)
        {
            return new Data().GetDataById(dataID);
        }

        public User GetUserById(int userId)
        {
            return new User().GetUserById(userId);
        }

        public Data MoveData(int dataID, string path, bool movedData = true)
        {
            return new Data().MoveData(dataID, path, movedData);
        }

        public Data UpdateData(int dataID, string dateType, DateTime creationDate, string eventName, string people, string location, string path)
        {
            return new Data().UpdateData(dataID, dateType, creationDate, eventName, people, location, path);
        }

        public SpecialProperty UpdateSpecialProperty(int propertyID, string propertyName, string propertyDescription)
        {
            return new SpecialProperty().UpdateSpecialProperty(propertyID, propertyName, propertyDescription);
        }

        public User UpdateUser(int userId, string firstName, string lastName, string password, string email, string phone)
        {
            return new User().UpdateUser(userId, firstName, lastName, password, email, phone);
        }
    }
}
