using Microsoft.Extensions.DependencyInjection;

namespace AiraloAssignment.DIContainer
{
    public class ContainerSession
    {
        private static readonly Lazy<ContainerSession> InstanceFactory = new(() => new ContainerSession());
        private IServiceProvider _services = null!;

        private ContainerSession() { }
        public static ContainerSession Instance => InstanceFactory.Value;

        public void Start()
        {
            _services = Container.Register();
        }

        public T Resolve<T>() where T : notnull
        {
            if (_services == null)
                throw new InvalidOperationException("The container session is not started!");

            return _services.GetRequiredService<T>();
        }

    }
}
