﻿using System;
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
        ForumEntities1 fef = new ForumEntities1();
        public bool EditOneUser(OneUserX user, string name)
        {
            fef.EditUser(user.name, user.password, user.foto, user.age, user.rating, user.ratingAnswers, user.ratingQwery, user.about);

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
                all.qwery = new QweryX { Id = item.Id, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text, header = item.header, category = item.category };
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
                if (item.password == password)
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
                if (item.name == user.name)
                {
                    return false;
                }
            }
            fef.RegisterUser(user.name, user.password, user.foto, user.age, user.rating, user.ratingAnswers, user.ratingQwery, user.about);
            return true;
        }

        public bool SendMessage(string login, int QweryId, string message, string code)
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

        public AnsverX GetAnsverById(int AnswerId)
        {
            AnsverX temp = new AnsverX();
            foreach (var item in fef.GetAnsverById(AnswerId))
            {
                temp = new AnsverX { Id = item.Id, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text, QweryId = item.QweryId };
            }
            return temp;
        }

        public List<QweryX> GetFindQweryList(string findString)
        {
            List<QweryX> temp = new List<QweryX>();
            foreach (var item in fef.GetAllQwery())
            {
                if (item.header.ToUpper().Contains(findString.ToUpper()) || item.text.ToUpper().Contains(findString.ToUpper()) || item.code.ToUpper().Contains(findString.ToUpper()))
                {
                    temp.Add(new QweryX { Id = item.Id, name = item.name, date = item.date, rating = item.rating, header = item.header });
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
            fef.SetQweryRating(QueryId, temp.rating + 1);

            GetOneUser2_Result tempUser = new GetOneUser2_Result();
            foreach (var item in fef.GetOneUser2(temp.name))
            {
                tempUser = item;
            }
            fef.EditUser2(tempUser.name, tempUser.password, tempUser.foto, tempUser.age, tempUser.rating, tempUser.ratingAnswers, tempUser.ratingQwery + 1, tempUser.about);

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

        public bool EditQwery(QweryX qwery)
        {
            fef.EditQwery(qwery.Id, qwery.header, qwery.text, DateTime.Now, qwery.category, qwery.code);
            return true;
        }

        public bool EditAnsver(AnsverX ansver)
        {
            fef.EditAnsver(ansver.Id, ansver.text, DateTime.Now, ansver.code);
            return true;
        }

        public bool EditAnsverAnsver(AnsverAnsverX ansveransver)
        {
            fef.EditAnsverAnsver(ansveransver.Id, ansveransver.text, DateTime.Now, ansveransver.code);
            return true;

        }
        public bool SendAnsverAnsver(int ansverId, string name, string text, string code)
        {
            fef.AddAnsverAnsver(ansverId, name, text, DateTime.Now, 0, code);
            return true;

        }

        public AllMessageAndQweryAndAnsvers GetQweryWithAnsversV2(int QweryId)
        {
            AllMessageAndQweryAndAnsvers all = new AllMessageAndQweryAndAnsvers();

            foreach (var item in fef.GetQwery(QweryId))
            {
                all.qwery = new QweryX { Id = item.Id, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text, header = item.header, category = item.category };
            }
            all.answers = new List<AnsverWithAnsers>();
            foreach (var item in fef.GetAnsversIdQwery(QweryId))
            {
                AnsverWithAnsers temp = new AnsverWithAnsers();
                temp.answers = new List<AnsverAnsverX>();
                temp.ansver = new AnsverX() { Id = item.Id, QweryId = QweryId, name = item.name, code = item.code, date = item.date, rating = item.rating, text = item.text };

                foreach (var itemX in fef.GetAnsverAnsverByIdAnsver(item.Id))
                {
                    temp.answers.Add(new AnsverAnsverX() { Id = itemX.Id, AnsverId = item.Id, name = itemX.name, code = itemX.code, date = itemX.date, rating = itemX.rating, text = itemX.text });
                }
                all.answers.Add(temp);
            }

            return all;
        }
    }

}
