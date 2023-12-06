﻿using Data;
using Data.Entities;

namespace Laboratorium_3___App.Models
{
    public class MemoryContactService : IContactService
    {
        IDateTimeProvider _timeProvider;

        private readonly Dictionary<int, Contact> _items = new Dictionary<int, Contact>();
        private int id = 1;
        public void Add(Contact contact)
        {
            contact.Created = _timeProvider.GetTime();
            contact.ID = id++;
            _items.Add(contact.ID, contact);
        }

        public MemoryContactService(IDateTimeProvider time)
        {
            _timeProvider = time;
        }

        public List<Contact> FindAll()
        {
            return _items.Values.ToList();
        }

        public Contact? FindById(int id)
        {
            return _items.ContainsKey(id) ? _items[id] : null;
        }

        public void RemoveById(int id)
        {
            _items.Remove(id);
        }

        public void Update(Contact contact)
        {
            if (_items.ContainsKey(contact.ID))
            {
                _items[contact.ID] = contact;
            }
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
            using (var _context = new AppDbContext()) 
            return _context.Organizations.ToList();
        }

        public PagingList<Contact> FindPage(int page, int size)
        {
            throw new NotImplementedException();
        }
    }
}
