using System.Reflection;
using EasyMeets.Core.DAL.Entities.Interface;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.DAL.Context;

public static class EFFilterExtensions
{
    public static void SetSoftDeleteFilter(this ModelBuilder modelBuilder, Type entityType)
    {
        SetSoftDeleteFilterMethod.MakeGenericMethod(entityType)
            .Invoke(null, new object[] { modelBuilder });
    }

    static readonly MethodInfo SetSoftDeleteFilterMethod = typeof(EFFilterExtensions)
        .GetMethods(BindingFlags.Public | BindingFlags.Static)
        .Single(t => t.IsGenericMethod && t.Name == "SetSoftDeleteFilter");

    public static void SetSoftDeleteFilter<TEntity>(this ModelBuilder modelBuilder)
        where TEntity : class, ISoftDeletable
    {
        modelBuilder.Entity<TEntity>().HasQueryFilter(x => !x.IsDeleted);
    }
}