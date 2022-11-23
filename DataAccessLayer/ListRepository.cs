﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ListRepository : IRepository
    {
        private List<AnimalCard> _repo = new List<AnimalCard>();
        public void Add(AnimalCard card)
        {
            _repo.Add(card);
        }

        public bool AddCardType(string cardName, AnimalCard.Type type)
        {
            foreach (var i in _repo)
            {
                if (i.Name == cardName)
                {
                    i.AnimalTypeByEnum = type;
                    return true;
                }
            }
            return false;
        }

        public AnimalCard? Get(string cardName)
        {
            foreach (var i in _repo)
            {
                if (i.Name == cardName)
                {
                    return i;
                }
            }
            return null;
        }

        public string listAll()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var i in _repo)
            {
                sb.Append(i.ToString() + "\n");
            }
            return sb.ToString();
        }

        public bool Remove(string cardName)
        {
            foreach (var i in _repo)
            {
                if (i.Name == cardName)
                {
                    // Will be true all the time.
                    return _repo.Remove(i);
                }
            }
            return false;
        }
    }
}