﻿using Data.Entities;

namespace Laboratorium_3___App.Models
{
    public class ContactMapper
    {
            public static Contact FromEntity(ContactEntity entity)
            {
                return new Contact()
                {
                    ID = entity.Id,
                    Name = entity.Name,
                    Email = entity.Email,
                    Phone = entity.Phone,
                    Birth = entity.Birth,
                };
            }

            public static ContactEntity ToEntity(Contact model)
            {
                return new ContactEntity()
                {
                    Id = model.ID,
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                    Birth = (DateTime)model.Birth,
                };
            }
        
    }
}
