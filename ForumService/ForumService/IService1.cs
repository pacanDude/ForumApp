﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ForumService
{
    [ServiceContract]
    public interface IForumService
    {
        [OperationContract]
        bool RegisterUser(OneUserX user);

        [OperationContract]
        bool LogIn(string login, string password);

        [OperationContract]
        OneUserX GetOneUser(string name);//получение информации о пользователе

        [OperationContract]
        bool EditOneUser(OneUserX user, string name);//отправка редактированого профиля

        [OperationContract]
        List<QweryX> GetQweryList();//для заполнения первой страницы

        [OperationContract]
        AllMessageAndQwery GetQweryWithAnsvers(int QweryId);//для открытия ветки форума

        [OperationContract]
        AllMessageAndQweryAndAnsvers GetQweryWithAnsversV2(int QweryId);//для открытия ветки форума V2

        [OperationContract]
        bool SendMessage(string login, int QweryId, string message, string code);

        [OperationContract]
        List<string> GetCategoryList();

        [OperationContract]
        QweryX GetQueryById(int QueryId);

        [OperationContract]
        bool UserRatingUp(string name);

        [OperationContract]
        bool UserRatingDown(string name);

        [OperationContract]
        bool QweryRatingUp(int QueryId);

        [OperationContract]
        bool QweryRatingDown(int QueryId);

        [OperationContract]
        bool AnsverRatingUp(int AnsverId);

        [OperationContract]
        bool AnsverRatingDown(int AnsverId);
        [OperationContract]
        List<QweryX> GetFindQweryList(string findString);
        [OperationContract]
        List<QweryX> GetCategoryQweryList(string category);
        [OperationContract]
        bool SendQwery(QweryX qwery);
        [OperationContract]
        bool SendAnsver(AnsverX ansver);
        [OperationContract]
        bool EditQwery(QweryX qwery);
        [OperationContract]
        bool EditAnsver(AnsverX ansver);
        [OperationContract]
        bool SendAnsverAnsver(int ansverId, string name, string text, string code);
        [OperationContract]
        bool EditAnsverAnsver(AnsverAnsverX ansveransver);
        [OperationContract]
        AnsverX GetAnsverById(int AnswerId);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ChatService.ContractType".

    [DataContract]
    public class AllMessageAndQwery//для открытия ветки форума
    {
        [DataMember]
        public QweryX qwery { get; set; }
        [DataMember]
        public List<AnsverX> answers { get; set; }
    }

    [DataContract]
    public class AllMessageAndQweryAndAnsvers//для открытия ветки форума в.2
    {
        [DataMember]
        public QweryX qwery { get; set; }
        [DataMember]
        public List<AnsverWithAnsers> answers { get; set; }
    }

    [DataContract]
    public class AnsverWithAnsers//вспомогательный клас ответ с ответами
    {
        [DataMember]
        public AnsverX ansver { get; set; }
        [DataMember]
        public List<AnsverAnsverX> answers { get; set; }
    }

    [DataContract]
    public class QweryX//вопрос
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string header { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public DateTime date { get; set; }
        [DataMember]
        public int rating { get; set; }
        [DataMember]
        public string category { get; set; }
        [DataMember]
        public string code { get; set; }
    }

    [DataContract]
    public class AnsverAnsverX//ответ QweryId
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int AnsverId { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public DateTime date { get; set; }
        [DataMember]
        public int rating { get; set; }
        [DataMember]
        public string code { get; set; }
    }

    [DataContract]
    public class AnsverX//ответ QweryId
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int QweryId { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public DateTime date { get; set; }
        [DataMember]
        public int rating { get; set; }
        [DataMember]
        public string code { get; set; }
    }
    [DataContract]
    public class OneUserX//инфа о пользователе
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public byte[] foto { get; set; }
        [DataMember]
        public int age { get; set; }
        [DataMember]
        public int rating { get; set; }
        [DataMember]
        public int ratingAnswers { get; set; }
        [DataMember]
        public int ratingQwery { get; set; }
        [DataMember]
        public string about { get; set; }
    }


}
