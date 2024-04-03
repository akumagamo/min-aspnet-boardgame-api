using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MinWebPage.Data;
using MinWebPage.Data.Migrations;
using MinWebPage.Services;
using System.Diagnostics;
using UserGame = MinWebPage.Data.UserGame;

namespace MinWebPage.Pages
{
    public class IndexModel : PageModel
    {
        public string SearchText = String.Empty;
        public List<Game> Games { get; set; }

        public BoardGameService BoardGameService { get; set; }

        private ITestRepository context;

        public IndexModel(BoardGameService boardgameService, ITestRepository ctx)
        {
            BoardGameService = boardgameService;
            context = ctx;
            Games = new List<Game>();
        }

        public void OnGet() {
            this.ShowItemsInCollections();
        }

        public IActionResult OnPost(string searchtext)
        {
            this.ShowItemsInCollections();
            if (searchtext != null)
            {
                SearchText = searchtext;
                Games = BoardGameService.SearchForGame(searchtext, Games);
            }

            return Page();
        }

        public IActionResult OnPostAddButton(string gameId, string gameName)
        {
            if (User.Identity?.IsAuthenticated == true)
            {
                string userName = User.Identity.Name!;
                context.SaveUserGame(gameId, gameName, userName);
                this.ShowItemsInCollections();
            }
            return Page();
        }

        public IActionResult OnPostRemoveButton(string gameId, string gameName)
        {
            if (User.Identity?.IsAuthenticated == true)
            {
                string userName = User.Identity.Name!;
                context.RemoveUserGame(gameId, userName);
                this.ShowItemsInCollections();
            }
            return Page();
        }

        private void ShowItemsInCollections() {

            if (User.Identity?.IsAuthenticated == true)
            {
                string userName = User.Identity.Name!;
                Games = context.UserGames(userName)
                    .Select(ug => new Game() { Id = ug.GameId, Name = ug.GameName, inCollection = true })
                    .ToList<Game>();
            } 
            else
            {
                Games = new List<Game>();
            }
        }
    }
}
