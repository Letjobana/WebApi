using my_books.Data.Models;
using System;
using System.Linq;

namespace my_books.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _contex;
        public PublishersService(AppDbContext context)
        {
            _contex = context;
        }
        public void AddPubliser(PublisherVm publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };
            _contex.Add(_publisher);
            _contex.SaveChanges();

            
        }

       public void DeletePublisherById(int id)
        {
            var _publisher = _contex.Publishers.FirstOrDefault(n => n.Id == id);
            if(_publisher != null)
            {
                _contex.Publishers.Remove(_publisher);
                _contex.SaveChanges();
            }
        }
    }
}
