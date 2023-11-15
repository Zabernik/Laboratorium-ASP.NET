using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Entities
{
    [Table("organizations")]
    public class OrganizationEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Regon { get; set; }
        public string Nip { get; set; }
        public Address? Address { get; set; }
        public ISet<ContactEntity> Contacts { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationEntity? Organization { get; set; }

    }
}
