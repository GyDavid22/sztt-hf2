﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class DBRepository : IRepository
    {
        public void Add(AnimalCard card)
        {
            
        }

        public bool AddCardType(string cardName, AnimalCard.Type type)
        {
            return true;
        }

        public AnimalCard? Get(string cardName)
        {
            return null;
        }

        public string listAll()
        {
            return "";
        }

        public bool Remove(string cardName)
        {
            return true;
        }
    }
}
