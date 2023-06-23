using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Ambacht.Common.Services
{
    public interface IFactory<T>
    {

        T Create(string name);

        IEnumerable<T> All();

    }

    internal class Factory<T> : IFactory<T>
    {
        public Factory(IEnumerable<FactoryEntry<T>> entries)
        {
            _entries = entries.ToArray();
        }

        private readonly FactoryEntry<T>[] _entries;


        public T Create(string name)
        {
            return _entries.Single(e => e.Key == name).Factory();
        }

        public IEnumerable<T> All()
        {
            return _entries.Select(e => e.Factory());
        }
    }

    internal class FactoryEntry<T>
    {
        public string Key { get; init; }
        public Func<T>  Factory { get; init; }
    }


    public static class FactoryExtensions {


        public static FactoryBuilder<T> AddFactory<T>(this IServiceCollection services)
        {
            services.AddSingleton<IFactory<T>, Factory<T>>();
            return new FactoryBuilder<T>(services);
        }

        public static FactoryBuilder<T> ConfigureFactory<T>(this IServiceCollection services)
        {
            return new FactoryBuilder<T>(services);
        }


        public static Func<T> CreateFactory<T>(this IServiceProvider provider, string name)
        {
            var factory = provider.GetRequiredService<IFactory<T>>();
            return () => factory.Create(name);
        }

    }

    public class FactoryBuilder<T>
    {

        public FactoryBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }

        public FactoryBuilder<T> AddImplementation(string name, Func<IServiceProvider, T> factory)
        {
            Services.AddTransient(sp => new FactoryEntry<T>()
            {
                Key = name,
                Factory = () => factory(sp)
            });
            return this;
        }

        public FactoryBuilder<T> AddImplementation<TImplementation>(string name) where TImplementation: class, T
        {
            Services.AddTransient<TImplementation>();
            Services.AddTransient(sp => new FactoryEntry<T>()
            {
                Key = name,
                Factory = () => (T)sp.GetRequiredService<TImplementation>()
            });
            return this;
        }

    }
}
