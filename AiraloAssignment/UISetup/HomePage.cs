using Microsoft.Playwright;

namespace AiraloAssignment.UISetup
{
    public class HomePage
    {
        private readonly IPage _page;
        private const string baseUrl = "https://www.airalo.com/";
        private const string searchFieldLocator = "search-input";

        public HomePage(IPage page)
        {
            _page = page;
        }

        public async Task NavigateToHomePage()
        {
            await _page.GotoAsync(baseUrl);
        }

        public async Task TypeInSearchBox(string input)
        {
            await _page.GetByTestId(searchFieldLocator).FillAsync(input);
        }

        public async Task ClickOnCountryFromList(string country)
        {
            await _page.ClickAsync($"//span[contains(@data-testid, '{country}')]");
        }
    }
}
