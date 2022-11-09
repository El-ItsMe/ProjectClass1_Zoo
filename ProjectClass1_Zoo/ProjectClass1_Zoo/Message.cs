using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo
{
    public class Message
        //Пояснение класса. Создаем его для того, чтобы методы возвращали не тип string, а письма, чтобы было больше конкретики и наглядности
    {
        public string Text {get; set;} //Вводим текст, который нам должен высветиться в конце
        public string SenderName {get; set;} //Имя Вольера/Животного, от которого будет исходить сообщение
        public string SenderType {get; set;} //Тип Вольер/Животное откуда будет посылаться сообщение
        public MessageType MessageType {get; set;} //Тип сообщения или ошибки

        public override bool Equals(object? obj)
        {
            return obj is Message message &&
                   Text == message.Text &&
                   SenderName == message.SenderName &&
                   SenderType == message.SenderType &&
                   MessageType == message.MessageType;
        }
    }
}
