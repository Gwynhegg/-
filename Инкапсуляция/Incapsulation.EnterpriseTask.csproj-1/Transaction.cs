// ReSharper disable All
#pragma warning disable 649

using System;

namespace Incapsulation.EnterpriseTask
{
    public class Transaction
    {
        //Добавим геттеры и сеттеры и сделаем переменные приватными.
        private double Amount;
        private Guid EnterpriseGuid;

        public void setAmount(double amount)
        {
            Amount = amount;
        }

        public double getAmount()
        {
            return Amount;
        }

        public void setGuid(Guid guid)
        {
            EnterpriseGuid = guid;
        }

        public Guid getGuid()
        {
            return EnterpriseGuid;
        }
    }
}