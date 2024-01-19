using Data;
using Data.Entities;

namespace Laboratorium_3___App.Models
{
    public class EFContactService : IContactService
    {
        private readonly AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Contact contact)
        {
            var e = _context.Contacts.Add(ContactMapper.ToEntity(contact));
            int id = e.Entity.Id;
            _context.SaveChanges();
            return id;
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList();
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
            return _context.Organizations.ToList();
        }

        public Contact? FindById(int id)
        {
            var find = _context.Contacts.Find(id);
            return find != null ? ContactMapper.FromEntity(find) : null;
        }

        public void RemoveById(int id)
        {
            var find = _context.Contacts.Find(id);
            if (find != null)
            {
                _context.Contacts.Remove(find);
                _context.SaveChanges();
            }       
        }

        public void Update(Contact contact)
        {
            var entity = ContactMapper.ToEntity(contact);
            _context.Contacts.Update(entity);
            _context.SaveChanges();
        }
    }
}
