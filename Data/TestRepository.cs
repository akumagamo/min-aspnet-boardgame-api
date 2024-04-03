using Microsoft.EntityFrameworkCore;

namespace MinWebPage.Data
{
    public interface ITestRepository
    {
        void SaveUserGame(string gameId, string gameName, string user);

        void RemoveUserGame(string gameId, string userName);
        IQueryable<UserGame> UserGames(string username);
    }

    public class TestRepository : ITestRepository
    {
        private ApplicationDbContext context;

        public TestRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public void RemoveUserGame(string gameId, string user)
        {
            var game = context.UserGames.First(x => x.GameId == gameId);
            if(game != null)
            {
                context.UserGames.Remove(game);
                context.SaveChanges();
            }
        }

        public void SaveUserGame (string gameId, string gameName, string user)
        {
            context.UserGames.Add(new UserGame() { GameId = gameId, UserName = user, GameName = gameName });
            context.SaveChanges();
        }

        public IQueryable<UserGame> UserGames(string username)
        {
            return context.UserGames.Where(ug => ug.UserName == username);
        }
    }

}
