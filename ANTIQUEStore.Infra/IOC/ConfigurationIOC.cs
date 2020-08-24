using ANTIQUEStore.Application.Interfaces;
using ANTIQUEStore.Application.Services;
using ANTIQUEStore.Domain.Core.Interfaces.Repositories;
using ANTIQUEStore.Domain.Core.Interfaces.Services;
using ANTIQUEStore.Domain.Domain;
using ANTIQUEStore.Domain.Services.Services;
using ANTIQUEStore.Domain.Validators;
using ANTIQUEStore.Infra.Data.Repositories;
using Autofac;
using FluentValidation;

namespace ANTIQUEStore.Infra.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ItemApplicationService>().As<IItemApplicationService>();

            builder.RegisterType<ItemService>().As<IItemService>();

            builder.RegisterType<ItemRepository>().As<IItemRepository>();

            builder.RegisterType<ItemValidator>().As<IValidator<Item>>();
        }
    }
}
