namespace lab3.Models.Services;
    public interface IContactService
    {
        List<ContactModel> GetAll();
        void Add(ContactModel model);
        void Delete(int id);
        void Update(ContactModel model);    
        ContactModel? GetById(int id);
    }
