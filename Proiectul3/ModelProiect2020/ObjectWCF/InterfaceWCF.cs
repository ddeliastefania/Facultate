using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProiect2020;
using System.ServiceModel;

namespace ObjectWCF
{
        [ServiceContract]
        interface InterfaceUser
        {
            [OperationContract]
            User CreateUser(string firstName, string lastName, string password, string email, string phone);
            [OperationContract]
            User UpdateUser(int userId, string firstName, string lastName, string password, string email, string phone);
            [OperationContract]
            bool DeleteUser(int userId);
            [OperationContract]
            User GetUserById(int userId);
            [OperationContract]
            List<User> GetAllUsers();
            [OperationContract]
            bool Login(string email, string password);
    }

    [ServiceContract]
        interface InterfaceData
        {
            [OperationContract]
            Data CreateData(string dateType, DateTime creationDate, string eventName, string people, string location, string path);
            [OperationContract]
            Data UpdateData(int dataID, string dateType, DateTime creationDate, string eventName, string people, string location, string path);
            [OperationContract]
            Data GetDataById(int dataID);
            [OperationContract]
            List<Data> GetAllData();
            [OperationContract]
            Data MoveData(int dataID, string path, bool movedData = true);
            [OperationContract]
            Data FavoritesData(int dataID, bool favoriteData = true);
        }

        [ServiceContract]
        interface InterfaceSpecialProperties
        {
            [OperationContract]
            SpecialProperty CreateSpecialProperty(string propertyName, string propertyDescription);
            [OperationContract]
            bool DeleteSpecialProperty(int propertyID);
            [OperationContract]
            SpecialProperty UpdateSpecialProperty(int propertyID, string propertyName, string propertyDescription);
        }

        [ServiceContract]
        interface IProject : InterfaceUser, InterfaceData, InterfaceSpecialProperties
        {
        }
}
