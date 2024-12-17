using crud_web_api_repository_pattern.Data;

namespace crud_web_api_repository_pattern.Repositories.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
