using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace TestDemo
{

    public class User
    {
        public int Id { get; set; }
        public string Name { get; }
        public List<Money> Money { get; set; } = new List<Money>();
        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public User(string name)
        {
            Name = name;
        }

        public void AddMoney(Money money) => Money.Add(money);

        public void SubstractMoney(Money money)
        {
            if (money.Value > Money.Sum(x => x.Value))
                throw new Exception("Dinero insuficiente");
        }
    }
}
