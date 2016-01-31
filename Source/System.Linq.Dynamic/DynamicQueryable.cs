using ns0;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq.Dynamic
{
	public static class DynamicQueryable
	{
		public static IQueryable<T> Where<T>(this IQueryable<T> source, string predicate, params object[] values)
		{
			return (IQueryable<T>)source.Where(predicate, values);
		}

		public static IQueryable Where(this IQueryable source, string predicate, params object[] values)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			LambdaExpression expression = DynamicExpression.ParseLambda(source.ElementType, typeof(bool), predicate, values);
			return source.Provider.CreateQuery(Expression.Call(typeof(Queryable), "Where", new Type[]
			{
				source.ElementType
			}, new Expression[]
			{
				source.Expression,
				Expression.Quote(expression)
			}));
		}

		public static IQueryable Select(this IQueryable source, string selector, params object[] values)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (selector == null)
			{
				throw new ArgumentNullException("selector");
			}
			LambdaExpression lambdaExpression = DynamicExpression.ParseLambda(source.ElementType, null, selector, values);
			return source.Provider.CreateQuery(Expression.Call(typeof(Queryable), "Select", new Type[]
			{
				source.ElementType,
				lambdaExpression.Body.Type
			}, new Expression[]
			{
				source.Expression,
				Expression.Quote(lambdaExpression)
			}));
		}

		public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string ordering, params object[] values)
		{
			return (IQueryable<T>)source.OrderBy(ordering, values);
		}

		public static IQueryable OrderBy(this IQueryable source, string ordering, params object[] values)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (ordering == null)
			{
				throw new ArgumentNullException("ordering");
			}
			ParameterExpression[] array = new ParameterExpression[]
			{
				Expression.Parameter(source.ElementType, "")
			};
			Class6 @class = new Class6(array, ordering, values);
			IEnumerable<Class3> enumerable = @class.method_4();
			Expression expression = source.Expression;
			string text = "OrderBy";
			string text2 = "OrderByDescending";
			foreach (Class3 current in enumerable)
			{
				expression = Expression.Call(typeof(Queryable), current.bool_0 ? text : text2, new Type[]
				{
					source.ElementType,
					current.expression_0.Type
				}, new Expression[]
				{
					expression,
					Expression.Quote(Expression.Lambda(current.expression_0, array))
				});
				text = "ThenBy";
				text2 = "ThenByDescending";
			}
			return source.Provider.CreateQuery(expression);
		}

		public static IQueryable Take(this IQueryable source, int count)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return source.Provider.CreateQuery(Expression.Call(typeof(Queryable), "Take", new Type[]
			{
				source.ElementType
			}, new Expression[]
			{
				source.Expression,
				Expression.Constant(count)
			}));
		}

		public static IQueryable Skip(this IQueryable source, int count)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return source.Provider.CreateQuery(Expression.Call(typeof(Queryable), "Skip", new Type[]
			{
				source.ElementType
			}, new Expression[]
			{
				source.Expression,
				Expression.Constant(count)
			}));
		}

		public static IQueryable GroupBy(this IQueryable source, string keySelector, string elementSelector, params object[] values)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			if (elementSelector == null)
			{
				throw new ArgumentNullException("elementSelector");
			}
			LambdaExpression lambdaExpression = DynamicExpression.ParseLambda(source.ElementType, null, keySelector, values);
			LambdaExpression lambdaExpression2 = DynamicExpression.ParseLambda(source.ElementType, null, elementSelector, values);
			return source.Provider.CreateQuery(Expression.Call(typeof(Queryable), "GroupBy", new Type[]
			{
				source.ElementType,
				lambdaExpression.Body.Type,
				lambdaExpression2.Body.Type
			}, new Expression[]
			{
				source.Expression,
				Expression.Quote(lambdaExpression),
				Expression.Quote(lambdaExpression2)
			}));
		}

		public static bool Any(this IQueryable source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return (bool)source.Provider.Execute(Expression.Call(typeof(Queryable), "Any", new Type[]
			{
				source.ElementType
			}, new Expression[]
			{
				source.Expression
			}));
		}

		public static int Count(this IQueryable source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return (int)source.Provider.Execute(Expression.Call(typeof(Queryable), "Count", new Type[]
			{
				source.ElementType
			}, new Expression[]
			{
				source.Expression
			}));
		}
	}
}
