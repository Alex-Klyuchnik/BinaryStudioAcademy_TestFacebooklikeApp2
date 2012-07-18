using System;
using System.Linq.Expressions;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure
{
    /// <summary>
    /// Used for marking entities which have unique identifier.
    /// </summary>
    public interface IIdentifiable
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        int Id { get; }
    }
    public static class Extension
    {
        public static string GetPath<T, TProperty>(this Expression<Func<T, TProperty>> expression)
        {
            var e = (MemberExpression)expression.Body;
            var stringified = e.ToString().Replace(".get_Item(0)", string.Empty);
            return stringified.Substring(stringified.IndexOf(".") + 1);
        }
    }
}