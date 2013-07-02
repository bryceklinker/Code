using System;
using System.Linq.Expressions;

namespace Code.Domain.Helpers
{
    public static class ExpressionHelper
    {
        private static string GetPropertyName(this Expression expression)
        {
            var lambdaExpression = expression as LambdaExpression;
            if (lambdaExpression == null)
                throw new ArgumentException("expression must be a lambda expression");

            var memberExpression = lambdaExpression.Body as MemberExpression;
            if (memberExpression == null)
                throw new ArgumentException("expression body must be member expression");

            return memberExpression.Member.Name;
        }

        public static string GetPropertyName<T>(Expression<Func<T, object>> propertyExpression)
        {
            return GetPropertyName(propertyExpression as Expression);
        }

        public static string GetPropertyName<T>(this Expression<Func<T>> propertyExpression)
        {
            return GetPropertyName(propertyExpression as Expression);
        }
    }
}