using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace System.Linq.Dynamic
{
	public static class DynamicLinqExtensions
	{
		public static IEnumerable<T> Where<T>(this IEnumerable<T> items, string whereClause)
		{
			Func<T, bool> predicate = DynamicLinqExtensions.CreatePredicate<T>(whereClause);
			return items.Where(predicate);
		}

		public static IEnumerable<T> Where<T>(this IEnumerable<T> items, string whereClause, params object[] parameters)
		{
			Func<T, bool> predicate = DynamicLinqExtensions.CreatePredicate<T>(whereClause, parameters);
			return items.Where(predicate);
		}

		public static Func<T, bool> CreatePredicate<T>(string predicate)
		{
			LambdaExpression lambdaExpression = DynamicExpression.ParseLambda(typeof(T), typeof(bool), predicate, new object[1]);
			Delegate @delegate = lambdaExpression.Compile();
			return @delegate as Func<T, bool>;
		}

		public static Func<T, bool> CreatePredicate<T>(string predicate, params object[] parameters)
		{
			LambdaExpression lambdaExpression = DynamicExpression.ParseLambda(typeof(T), typeof(bool), predicate, parameters);
			Delegate @delegate = lambdaExpression.Compile();
			return @delegate as Func<T, bool>;
		}

		public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> items, string property)
		{
			return items.smethod_0(property, true);
		}

		public static IEnumerable<T> OrderByDescending<T>(this IEnumerable<T> items, string property)
		{
			return items.smethod_0(property, false);
		}

		private static IEnumerable<T> smethod_0<T>(this IEnumerable<T> items, string string_0, bool bool_0)
		{
			ComparerWrapper<T> comparer = new ComparerWrapper<T>(DynamicLinqExtensions.CreateComparer<T>(string_0, bool_0));
			return items.OrderBy(new Func<T, T>(DynamicLinqExtensions.smethod_1<T>), comparer);
		}

		public static Func<T, T, int> CreateComparer<T>(string propertyName)
		{
			return DynamicLinqExtensions.CreateComparer<T>(propertyName, true);
		}

		public static Func<T, T, int> CreateComparer<T>(string propertyName, bool ascending)
		{
			string expression;
			if (ascending)
			{
				expression = string.Format("(item1.{0} == item2.{0}) ? 0 : (item1.{0} > item2.{0}) ? 1 : -1", propertyName);
			}
			else
			{
				expression = string.Format("(item2.{0} == item1.{0}) ? 0 : (item2.{0} > item1.{0}) ? 1 : -1", propertyName);
			}
			ParameterExpression[] parameters = new ParameterExpression[]
			{
				Expression.Parameter(typeof(T), "item1"),
				Expression.Parameter(typeof(T), "item2")
			};
			LambdaExpression lambdaExpression = DynamicExpression.ParseLambda(parameters, typeof(int), expression, new object[0]);
			Delegate @delegate = lambdaExpression.Compile();
			return @delegate as Func<T, T, int>;
		}

		public static Func<TInput, TOutput> CreateValueExpression<TInput, TOutput>(string expressionString)
		{
			LambdaExpression lambdaExpression = DynamicExpression.ParseLambda(typeof(TInput), typeof(TOutput), expressionString, new object[1]);
			Delegate @delegate = lambdaExpression.Compile();
			return @delegate as Func<TInput, TOutput>;
		}

		[CompilerGenerated]
		private static T smethod_1<T>(T ix)
		{
			return ix;
		}
	}
}
