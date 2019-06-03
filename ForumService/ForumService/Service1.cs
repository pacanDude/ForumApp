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
            fef.EditUser(user.name,user.password,user.foto,user.age,user.rating,user.ratingAnswers,user.ratingQwery,user.about);
            
            return true;
        }

        public OneUserX GetOneUser(string name)
        {
            OneUserX temp = new OneUserX();
            foreach (var item in fef.GetOneUser(name))
            {
                temp = new OneUserX { name = item.name, about = item.about, foto = item.foto, age = (int)item.age, password = item.password, rating = item.rating, ratingAnswers = item.ratingAnswers, ratingQwery = item.ratingQwery };
            }
            return temp;
        }
        
        public AllMessageAndQwery GetQweryWithAnsvers(int QueryId)
        {
            AllMessageAndQwery all = new AllMessageAndQwery();
            foreach (var item in fef.GetQwery(QueryId))
            {
                all.qwery = new QweryX { Id = item.Id, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text, header = item.header,category=item.category };
            }
            all.answers = new List<AnsverX>();
            foreach (var item in fef.GetAnsversIdQwery(QueryId))
            {
                all.answers.Add(new AnsverX() { Id = item.Id, QweryId = QueryId, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text });
            }

            return all;
        }
        
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

        public List<QweryX> GetQweryList()
        {
            List<QweryX> temp = new List<QweryX>();
            foreach (var item in fef.GetAllQwery().ToList())
            {
                temp.Add(new QweryX { Id = item.Id, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text, header = item.header, category = item.category });
            }
            return temp;
        }

        public QweryX GetQueryById(int QueryId)
        {
            QweryX temp = new QweryX();
            foreach (var item in fef.GetQwery(QueryId))
            {
                temp = new QweryX { Id = item.Id, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text, header = item.header, category = item.category };
            }
            return temp;
        }

        public List<QweryX> GetFindQweryList(string findString)
        {
            List<QweryX> temp = new List<QweryX>();
            foreach (var item in fef.GetAllQwery().ToList())
            {
                if (item.header.Contains(findString)||item.text.Contains(findString)||item.code.Contains(findString))
                {
                    temp.Add(new QweryX { Id = item.Id, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text, header = item.header, category = item.category });
                }
            }
            return temp;
        }

        public List<QweryX> GetCategoryQweryList(string category)
        {
            List<QweryX> temp = new List<QweryX>();
            foreach (var item in fef.GetQweryByCategory(category))
            {
                temp.Add(new QweryX { Id = item.Id, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text, header = item.header, category = item.category });
            }
            return temp;
        }

        public bool SendQwery(QweryX qwery)
        {
            fef.AddQwery(qwery.header, qwery.name, qwery.text, DateTime.Now, 0, qwery.category, qwery.code);
            return true;
        }

        public bool SendAnsver(AnsverX ansver)
        {
            fef.AddAnsver(ansver.QweryId, ansver.name, ansver.text, DateTime.Now, 0, ansver.code);
            return true;
        }
    }

}
