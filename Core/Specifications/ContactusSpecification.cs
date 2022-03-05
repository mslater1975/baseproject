using System;
using System.Linq.Expressions;
using Core.Models;

namespace Core.Specifications
{
    public class ContactusSpecification : BaseSpecification<ContactUs>
    {
        public ContactusSpecification(int id) : base(x => x.Id == id)
        {
            AddOrderBy(x => x.Id);
        }

        public ContactusSpecification(ContactusSpecParams contactusParams) : base(x => 
            (string.IsNullOrEmpty(contactusParams.Name) || 
                x.Name.ToLower().Contains(contactusParams.Name)))
        {
            AddOrderBy(x => x.Id);
        }
    }
}