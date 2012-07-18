using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure;
using BinaryStudioAcademy_TestFacebooklikeApp2.Models;


namespace BinaryStudioAcademy_TestFacebooklikeApp2.DataAccess
{
    public interface IRepository
    {
        /// <summary>
        /// Returns query interface the specified entity.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <param name="eagerlyLoadedProperties">The eagerly loaded properties - not query itself!</param>
        /// <returns>Interface for querying.</returns>
        /// <example>
        /// repository.Query&lt;MyEntity&gt;().Where(x => x.Name == "Entity1")
        /// </example>
        IQueryable<T> Query<T>(params Expression<Func<T, object>>[] eagerlyLoadedProperties) where T : class, IIdentifiable;
        T Get<T>(int id, params Expression<Func<T, object>>[] eagerlyLoadedProperties) where T : class, IIdentifiable;

        void Save<T>(T instance) where T : class, IIdentifiable;
        void Delete<T>(T instance) where T : class, IIdentifiable;
    }
}