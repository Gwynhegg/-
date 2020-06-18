using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.EnterpriseTask
{
    public class Enterprise
    {
        //В целях инкапсуляции необходимо сделать переменные приватными.
        private Guid guid;
        private string inn;
        private string name;
        private DateTime establishDate;

        public Enterprise(Guid guid)
        {
            this.guid = guid;
        }

        public Guid getGuid() { return guid; }


        public string getName() { return name; }

        public void setName(string name) { this.name = name; }

        public string getINN() { return inn; }

        public void setINN(string inn)
        {
            if (inn.Length != 10 || !inn.All(z => char.IsDigit(z)))
                throw new ArgumentException();
            this.inn = inn;
        }

        public DateTime getEstablishDate()
        {
            return establishDate;
        }

        public void setEstablishDate(DateTime establishDate)
        {
            this.establishDate = establishDate;
        }

        public TimeSpan getActiveTimeSpan()
        {
            return DateTime.Now - establishDate;
        }


        //Необходимо убрать обращение к паблик-переменным и создать геттеры и сеттеры.
        public double getTotalTransactionsAmount()
        {
            DataBase.OpenConnection();
            var amount = 0.0;
            foreach (Transaction t in DataBase.Transactions().Where(z => z.getGuid() == guid))
                amount += t.getAmount();
            return amount;
        }
    }
}
