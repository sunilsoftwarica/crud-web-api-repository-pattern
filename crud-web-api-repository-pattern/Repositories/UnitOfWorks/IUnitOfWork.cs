namespace crud_web_api_repository_pattern.Repositories.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        Task CommitAsync();
    }
}
