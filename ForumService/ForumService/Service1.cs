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

        public AllMessageAndQwery GetQweryWithAnsvers(int QweryId)
        {
            AllMessageAndQwery all = new AllMessageAndQwery();
            all.qwery = new QweryX() { Id = 123, category = "category", date = DateTime.Now, header = "header заголовок название темы", name = "Имя пользователя", rating = 5, text = "весь текст вопроса" };
            for (int i = 0; i < 10; i++)
            {
                all.answers.Add(new AnsverX() { Id = 123 + i, date = DateTime.Now, name = "Имя пользователя" + i.ToString(), rating = i, text = "весь текст ответа" + i.ToString() });
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
    }

}
