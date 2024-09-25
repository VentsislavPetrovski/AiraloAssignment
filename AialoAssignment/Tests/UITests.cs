using AiraloAssignment.UISetup;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace AiraloAssignment.Tests
{
    [TestFixture]
    public class UITests : PageTest
    {
        public override BrowserNewContextOptions ContextOptions()
        {
            return new BrowserNewContextOptions()
            {
                ColorScheme = ColorScheme.Light,
                ViewportSize = new()
                {
                    Width = 1920,
                    Height = 1080
                },
            };
        }

        [Test]
        public async Task UITest()
        {
            var country = "Japan";

            var homePage = new HomePage(Page);
            await homePage.NavigateToHomePage();
            await homePage.TypeInSearchBox(country);
            await homePage.ClickOnCountryFromList(country);

            var countryEsimPage = new CountryESimPage(Page);
            await countryEsimPage.ClickOnFirstBuyButton();

            await Expect(Page.GetByTestId(ESimDetailsPage.titleLocator)).ToContainTextAsync("Moshi Moshi");
            await Expect(Page.Locator(ESimDetailsPage.coverageValueLocator)).ToContainTextAsync(country);
            await Expect(Page.Locator(ESimDetailsPage.dataValueLocator)).ToContainTextAsync("1 GB");
            await Expect(Page.Locator(ESimDetailsPage.validityValueLocator)).ToContainTextAsync("7 Days");
            await Expect(Page.Locator(ESimDetailsPage.priceValueLocator)).ToContainTextAsync("$4.50 USD");
        }
    }
}
