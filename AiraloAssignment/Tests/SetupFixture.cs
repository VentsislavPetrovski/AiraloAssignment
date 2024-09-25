using AiraloAssignment.DIContainer;

namespace AiraloAssignment.Tests
{
    [SetUpFixture]
    public class SetupFixture
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            ContainerSession.Instance.Start();
        }
    }
}
