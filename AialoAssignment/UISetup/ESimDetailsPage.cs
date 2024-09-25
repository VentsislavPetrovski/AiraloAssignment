using Microsoft.Playwright;

namespace AiraloAssignment.UISetup
{
    public class ESimDetailsPage
    {
        public const string titleLocator = "sim-detail-operator-title";
        public const string coverageValueLocator = "//ul[@data-testid = 'sim-detail-info-list']//p[@data-testid = 'COVERAGE-value']";
        public const string dataValueLocator = "//ul[@data-testid = 'sim-detail-info-list']//p[@data-testid = 'DATA-value']";
        public const string validityValueLocator = "//ul[@data-testid = 'sim-detail-info-list']//p[@data-testid = 'VALIDITY-value']";
        public const string priceValueLocator = "//ul[@data-testid = 'sim-detail-info-list']//p[@data-testid = 'PRICE-value']";
    }
}
