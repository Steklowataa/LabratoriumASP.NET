using lab3.Models;

namespace lab3.Models.Services;

public class EfContactService : IContactService
{
    private readonly AppDbContext _dbContext;
    
    public EfContactService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(ContactModel contact)
    {
        _dbContext.Contacts.Add(ContactMapper.ToEntity(contact));
        _dbContext.SaveChanges();
    }

    public void Update(ContactModel contact)
    {
        _dbContext.Contacts.Update(ContactMapper.ToEntity(contact));
        _dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        _dbContext.Contacts.Remove(new ContactEntity(){ Id = id });
        _dbContext.SaveChanges();
    }

    public List<ContactModel> GetAll()
    {
        return _dbContext.Contacts
            .Select(c => ContactMapper.ToModel(c))
            .ToList();
    }

    public ContactModel? GetById(int id)
    {
        var entity = _dbContext.Contacts.Find(id);
        return entity != null ? ContactMapper.ToModel(entity) : null;
    }
}