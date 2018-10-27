using System;
using System.Collections.Generic;
using System.Text;
using CodeAndCloud.ViewModel;

namespace CodeAndCloud.Services.ContactService
{
    public class FakeService : IContactService
    {
        public void Add(AddContactViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
