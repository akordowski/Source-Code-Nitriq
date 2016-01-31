using ns0;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq.Dynamic
{
	public static class DynamicExpression
	{
		public static Expression Parse(Type resultType, string expression, params object[] values)
		{
			Class6 @class = new Class6(null, expression, values);
			return @class.method_3(resultType);
		}

		public static LambdaExpression ParseLambda(Type itType, Type resultType, string expression, params object[] values)
		{
			return DynamicExpression.ParseLambda(new ParameterExpression[]
			{
				Expression.Parameter(itType, "")
			}, resultType, expression, values);
		}

		public static LambdaExpression ParseLambda(ParameterExpression[] parameters, Type resultType, string expression, params object[] values)
		{
			Class6 @class = new Class6(parameters, expression, values);
			return Expression.Lambda(@class.method_3(resultType), parameters);
		}

		public static Expression<Func<T, S>> ParseLambda<T, S>(string expression, params object[] values)
		{
			return (Expression<Func<T, S>>)DynamicExpression.ParseLambda(typeof(T), typeof(S), expression, values);
		}

		public static Type CreateClass(params DynamicProperty[] properties)
		{
			return Class5.class5_0.method_0(properties);
		}

		public static Type CreateClass(IEnumerable<DynamicProperty> properties)
		{
			return Class5.class5_0.method_0(properties);
		}
	}
}
