using lab3.Models;

namespace lab3.Services {
public class MemoryContactService : IContactService {
    private static Dictionary<int, ContactModel> _contacts = new()
{
    {
        1, new ContactModel
        {
            Category = Category.Family,
            Id = 1,
            FirstName = "Sasza",
            LastName = "Lahodiuk",
            Email = "test@gmail.com",
            PhoneNumber = "444 444 444",
            BirthDay = new DateOnly(2004, 9, 3)
        }   
    },
    {
        2, new ContactModel
        {
            Category = Category.Business,
            Id = 2,
            FirstName = "Masza",
            LastName = "Lahodiuk",
            Email = "test1@gmail.com",
            PhoneNumber = "666 666 666",
            BirthDay = new DateOnly(2000, 10, 3)
        }
    },
    {
        3, new ContactModel
        {
            Category = Category.Family,
            Id = 3,
            FirstName = "Asza",
            LastName = "Ma",
            Email = "test2@gmail.com",
            PhoneNumber = "555 454 445",
            BirthDay = new DateOnly(2005, 11, 27)
        }
    }
};


    private static int _currentId = 4;

    public void Add(ContactModel model) {
        model.Id = _currentId++;
        _contacts[model.Id] = model;
    }

    public void Update(ContactModel contact) {
        if(_contacts.ContainsKey(contact.Id)) {
            _contacts[contact.Id] = contact;
        }
    }

    public void Delete(int id) {
        _contacts.Remove(id);
    }

    public List<ContactModel> GetAll() {
        return _contacts.Values.ToList();
    }

    public ContactModel? GetById(int id) {
        _contacts.TryGetValue(id, out ContactModel contact);
        return contact;
    }
}
}