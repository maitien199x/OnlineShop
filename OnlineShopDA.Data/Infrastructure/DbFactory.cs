namespace OnlineShopDA.Data.Infrastructure
{
    internal class DbFactory : Disposable, IDbFactory
    {
        OnlineShopDADbContext dbContext;
        public OnlineShopDADbContext Init()
        {
            return dbContext ?? (dbContext = new OnlineShopDADbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
