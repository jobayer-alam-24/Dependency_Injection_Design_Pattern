using DependencyInjection.Data;
using DependencyInjection.Models;

namespace DependencyInjection.Interface
{
    public interface IMessege
    {
        void AddMessege(Messege messege);
        void DeleteMessege(int id);
        void UpdateMessege(Messege messege);
        Messege GetMessegeById(int id);
        List<Messege> GetAllMesseges();
    }
    public class MessegeImplementService : IMessege
    {
        private readonly ApplicationDbContext _context;
        public MessegeImplementService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddMessege(Messege messege)
        {
            _context.Add(messege);
            Save();
        }

        public void DeleteMessege(int id)
        {
            var messege = _context.Messeges.Find(id);
            if(messege != null)
            {
                _context.Messeges.Remove(messege);
                Save();
            }
        }

        public List<Messege> GetAllMesseges()
        {
            return _context.Messeges.ToList();
        }

        public Messege GetMessegeById(int id)
        {
            return _context.Messeges.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateMessege(Messege messege)
        {
            if(messege != null)
            {
                _context.Messeges.Update(messege);
                Save();
            }
        }
        private void Save()
        {
            _context.SaveChanges();
        }
    }

}
