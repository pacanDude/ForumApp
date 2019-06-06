using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ForumService
{
    public class ForumService : IForumService
    {
        /*преобразование байт в картинку
         public BitmapImage ToImage(byte[] array)
{
    using (var ms = new System.IO.MemoryStream(array))
    {
        var image = new BitmapImage();
        image.BeginInit();
        image.CacheOption = BitmapCacheOption.OnLoad; // here
        image.StreamSource = ms;
        image.EndInit();
        return image;
    }
}
             */
        ForumEntities fef = new ForumEntities();
        public bool EditOneUser(OneUserX user, string name)
        {
            if (user.name==name)
            {
                users.Remove(name);
                users.Add(name, user.password);
                return true;
            }
            if (users.ContainsKey(user.name))
            {
                return false;
            }
            users.Remove(name);
            users.Add(user.name, user.password);
            return true;
        }

        public OneUserX GetOneUser(string name)
        {
            return new OneUserX { about = "about", age = 25, name = "name", rating = 5, ratingAnswers = 7, ratingQwery = 9, foto = new byte[] { } };
        }

        public List<QweryX> GetQweryList()
        {
            List<QweryX> list = new List<QweryX>();

            foreach (var item in fef.Qwery)
            {
                list.Add(new QweryX { Id = item.Id, date = item.date, header = item.header, name = item.name, rating = item.rating, text = item.text,category= item.category,code= item.code });
            }
            return list;
        }


        public QweryX GetQueryById(int QueryId)
        {
            QweryX qwery = null;
            foreach (var item in GetQweryList())
            {
                if(item.Id == QueryId)
                {
                    qwery = item;
                }
            }
            return qwery;
        }

        public AllMessageAndQwery GetQweryWithAnsvers(int QueryId)
        {
            AllMessageAndQwery all = new AllMessageAndQwery();
            foreach (var item in fef.Ansver)
            {
                if (item.QweryId == QueryId)
                {
                    all.qwery = GetQueryById(QueryId);
                    AnsverX ansverX = new AnsverX() { Id = item.Id, QweryId = QueryId, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text };
                    all.answers.Add(ansverX);
                }

            }

            return all;
        }

        Dictionary<string, string> users = new Dictionary<string, string>();

        public bool LogIn(string login, string password)
        {
            foreach (var item in fef.GetUserPassword(login))
            {
                if (item.password==password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool RegisterUser(OneUserX user)
        {
            foreach (var item in fef.GetAllUsers())
            {
                if (item.name==user.name)
                {
                    return false;
                }
            }
            fef.RegisterUser(user.name, user.password, user.foto, user.age, user.rating, user.ratingAnswers, user.ratingQwery, user.about);
            return true;
        }

        public bool SendMessage(string login, int QweryId, string message,string code)
        {
            throw new NotImplementedException();
        }

        public List<string> GetCategoryList()
        {
            List<string> list = new List<string>();
            foreach (var item in fef.GetCategoryList())
            {
                list.Add(item.category);
            }
            return list;
        }

        public bool UserRatingUp(string name)
        {
            GetOneUser_Result temp = new GetOneUser_Result();
            foreach (var item in fef.GetOneUser(name))
            {
                temp = item;
            }

            fef.EditUser(temp.name, temp.password, temp.foto, temp.age, temp.rating + 1, temp.ratingAnswers, temp.ratingQwery, temp.about);

            return true;
        }

        public bool UserRatingDown(string name)
        {
            GetOneUser_Result temp = new GetOneUser_Result();
            foreach (var item in fef.GetOneUser(name))
            {
                temp = item;
            }
            
            fef.EditUser(temp.name, temp.password, temp.foto, temp.age, temp.rating - 1, temp.ratingAnswers, temp.ratingQwery, temp.about);
            
            
            return true;
        }

        public bool QweryRatingUp(int QueryId)
        {
            GetQwery_Result temp = new GetQwery_Result();
            foreach (var item in fef.GetQwery(QueryId))
            {
                temp = item;
            }
            fef.SetQweryRating(QueryId, temp.rating+1);

            GetOneUser_Result tempUser = new GetOneUser_Result();
            foreach (var item in fef.GetOneUser(temp.name))
            {
                tempUser = item;
            }
            fef.EditUser(tempUser.name, tempUser.password, tempUser.foto, tempUser.age, tempUser.rating, tempUser.ratingAnswers, tempUser.ratingQwery+1, tempUser.about);

            return true;
        }

        public bool QweryRatingDown(int QueryId)
        {
            GetQwery_Result temp = new GetQwery_Result();
            foreach (var item in fef.GetQwery(QueryId))
            {
                temp = item;
            }
           
            fef.SetQweryRating(QueryId, temp.rating - 1);
            
            
            GetOneUser_Result tempUser = new GetOneUser_Result();
            foreach (var item in fef.GetOneUser(temp.name))
            {
                tempUser = item;
            }
            fef.EditUser(tempUser.name, tempUser.password, tempUser.foto, tempUser.age, tempUser.rating, tempUser.ratingAnswers, tempUser.ratingQwery - 1, tempUser.about);

            return true;
        }

        public bool AnsverRatingUp(int AnsverId)
        {
            GetAnsverById_Result temp = new GetAnsverById_Result();
            foreach (var item in fef.GetAnsverById(AnsverId))
            {
                temp = item;
            }
            fef.SetAnsverRating(AnsverId, temp.rating + 1);

            GetOneUser_Result tempUser = new GetOneUser_Result();
            foreach (var item in fef.GetOneUser(temp.name))
            {
                tempUser = item;
            }
            fef.EditUser(tempUser.name, tempUser.password, tempUser.foto, tempUser.age, tempUser.rating, tempUser.ratingAnswers + 1, tempUser.ratingQwery, tempUser.about);

            return true;
        }

        public bool AnsverRatingDown(int AnsverId)
        {
            GetAnsverById_Result temp = new GetAnsverById_Result();
            foreach (var item in fef.GetAnsverById(AnsverId))
            {
                temp = item;
            }
            fef.SetAnsverRating(AnsverId, temp.rating - 1);

            GetOneUser_Result tempUser = new GetOneUser_Result();
            foreach (var item in fef.GetOneUser(temp.name))
            {
                tempUser = item;
            }
            fef.EditUser(tempUser.name, tempUser.password, tempUser.foto, tempUser.age, tempUser.rating, tempUser.ratingAnswers - 1, tempUser.ratingQwery, tempUser.about);

            return true;
        }
    }

}
