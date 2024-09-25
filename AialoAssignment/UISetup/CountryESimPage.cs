using Microsoft.Playwright;

namespace AiraloAssignment.UISetup
{
    public class CountryESimPage : HomePage
    {
        private readonly IPage _page;
        private const string pageTitleLocator = "store-title";
        private const string buyButtonsLocator = "esim-button";

        public CountryESimPage(IPage page) : base(page)
        {
            _page = page;
        }

        public async Task<string> GetPageTitleText()
        {
            var pageTitleText = await _page.GetByTestId(pageTitleLocator).TextContentAsync();
            return pageTitleText!;
        }

        public async Task ClickOnFirstBuyButton()
        {
            await _page.GetByTestId(buyButtonsLocator).Nth(0).ClickAsync();
        }
    }
}
