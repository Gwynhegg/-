using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.DataStructure
{
    public class Category : IComparable
    {

        private string name;
        private MessageType message_type;
        private int type_id, topic_id;
        private int hash_code=0;
        private MessageTopic message_topic;

        public Category(string name, MessageType msty, MessageTopic mstp)
        {
            this.name = name;
            message_type = msty;
            message_topic = mstp;

            switch (msty)
            {
                case MessageType.Incoming: type_id = 1; break;
                case MessageType.Outgoing: type_id = 2; break;
                case MessageType.Service: type_id = 3; break;
            }

            switch (mstp)
            {
                case MessageTopic.Subscribe: topic_id = 1; break;
                case MessageTopic.Error: topic_id = 2; break;
                case MessageTopic.Update: topic_id = 3; break;
            }
        }

        //Сделать нормальное сравнение
        public int CompareTo(Object obj)
        {
            Category other_category = obj as Category;
            int temp = this.name.CompareTo(other_category.getName());
            if (temp != 0) return temp; else
            {
                if (this.type_id < other_category.getTypeId()) return -1;
                else if (this.type_id > other_category.getTypeId()) return 1;
                else
                {
                    if (this.topic_id < other_category.getTopicId()) return -1;
                    else if (this.topic_id > other_category.getTopicId()) return 1;
                    else return 0;
                }
            }
        }

        //Переопределеить метод GetHashCode

            public override int GetHashCode()
        {
            if (hash_code == 0)
            {
                hash_code = topic_id;
                hash_code = type_id * 10 + hash_code;
                hash_code = name.GetHashCode() * 100 + hash_code;
                return hash_code;
            } else return hash_code;
        }

        // Переопределить метод Equals
        public bool Equals(Category test)
        {
            if (this.name == test.getName() && this.message_type == test.getType() && this.message_topic == test.getTopic()) return true; else return false;
        }

        //Переопределение операций

        public static bool operator >(Category obj1, Category obj2)
        {

            if (obj1.CompareTo(obj2) == 1) return true; else return false;
        }

        public static bool operator <(Category obj1, Category obj2)
        {
            if (obj1.CompareTo(obj2) == -1) return true; else return false;
        }

        public static bool operator <=(Category obj1, Category obj2)
        {
            if (obj1.CompareTo(obj2) == -1 || obj1.CompareTo(obj2) == 0) return true; else return false;
            return false;
        }

        public static bool operator >=(Category obj1, Category obj2)
        {
            if (obj1.CompareTo(obj2) == 1 || obj1.CompareTo(obj2) == 0) return true; else return false;

        }

        public static bool operator ==(Category obj1, Category obj2)
        {
            if (obj1.Equals(obj2)) return true; else return false;
        }

        public static bool operator !=(Category obj1, Category obj2)
        {
            if (!obj1.Equals(obj2)) return true; else return false;

        }

        //Метод ToString

            public override string ToString()
        {
            return name + "." + this.message_type.ToString() + "." + message_topic.ToString();
        }

        //Геттеры и сеттеры
        public int getTypeId()
        {
            return type_id;
        }

        public int getTopicId()
        {
            return topic_id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setType(MessageType type)
        {
            this.message_type = type;
        }

        public MessageType getType()
        {
            return message_type;
        }

        public void setTopic(MessageTopic topic)
        {
            this.message_topic = topic;
        }

        public MessageTopic getTopic()
        {
            return message_topic;
        }
}
}
