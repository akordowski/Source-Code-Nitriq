using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0
{
	internal class Class6
	{
		private struct Struct0
		{
			public Class6.Enum1 enum1_0;

			public string string_0;

			public int int_0;
		}

		private enum Enum1
		{

		}

		private interface Interface0
		{
			void imethod_0(bool bool_0, bool bool_1);

			void imethod_1(bool? x, bool? y);
		}

		private interface Interface1
		{
			void imethod_0(int int_0, int int_1);

			void imethod_1(uint uint_0, uint uint_1);

			void imethod_2(long long_0, long long_1);

			void imethod_3(ulong ulong_0, ulong ulong_1);

			void imethod_4(float float_0, float float_1);

			void imethod_5(double double_0, double double_1);

			void imethod_6(decimal decimal_0, decimal decimal_1);

			void imethod_7(int? x, int? y);

			void imethod_8(uint? x, uint? y);

			void imethod_9(long? x, long? y);

			void imethod_10(ulong? x, ulong? y);

			void imethod_11(float? x, float? y);

			void imethod_12(double? x, double? y);

			void imethod_13(decimal? x, decimal? y);
		}

		private interface Interface2 : Class6.Interface1
		{
			void imethod_14(string string_0, string string_1);

			void imethod_15(char char_0, char char_1);

			void imethod_16(DateTime dateTime_0, DateTime dateTime_1);

			void imethod_17(TimeSpan timeSpan_0, TimeSpan timeSpan_1);

			void imethod_18(char? x, char? y);

			void imethod_19(DateTime? x, DateTime? y);

			void imethod_20(TimeSpan? x, TimeSpan? y);
		}

		private interface Interface3 : Class6.Interface1, Class6.Interface2
		{
			void imethod_21(bool bool_0, bool bool_1);

			void imethod_22(bool? x, bool? y);
		}

		private interface Interface4 : Class6.Interface1
		{
			void imethod_14(DateTime dateTime_0, TimeSpan timeSpan_0);

			void imethod_15(TimeSpan timeSpan_0, TimeSpan timeSpan_1);

			void imethod_16(DateTime? x, TimeSpan? y);

			void imethod_17(TimeSpan? x, TimeSpan? y);
		}

		private interface Interface5 : Class6.Interface1, Class6.Interface4
		{
			void imethod_18(DateTime dateTime_0, DateTime dateTime_1);

			void imethod_19(DateTime? x, DateTime? y);
		}

		private interface Interface6
		{
			void imethod_0(int int_0);

			void imethod_1(long long_0);

			void imethod_2(float float_0);

			void imethod_3(double double_0);

			void imethod_4(decimal decimal_0);

			void imethod_5(int? x);

			void imethod_6(long? x);

			void imethod_7(float? x);

			void imethod_8(double? x);

			void imethod_9(decimal? x);
		}

		private interface Interface7
		{
			void imethod_0(bool bool_0);

			void imethod_1(bool? x);
		}

		private interface Interface8
		{
			void imethod_0(bool bool_0);

			void imethod_1();

			void imethod_2(bool bool_0);

			void imethod_3(bool bool_0);

			void imethod_4();

			void imethod_5(bool bool_0);

			void imethod_6(object object_0);

			void imethod_7(object object_0);

			void imethod_8(int int_0);

			void imethod_9(int? selector);

			void imethod_10(long long_0);

			void imethod_11(long? selector);

			void imethod_12(float float_0);

			void imethod_13(float? selector);

			void imethod_14(double double_0);

			void imethod_15(double? selector);

			void imethod_16(decimal decimal_0);

			void imethod_17(decimal? selector);

			void imethod_18(int int_0);

			void imethod_19(int? selector);

			void imethod_20(long long_0);

			void imethod_21(long? selector);

			void imethod_22(float float_0);

			void imethod_23(float? selector);

			void imethod_24(double double_0);

			void imethod_25(double? selector);

			void imethod_26(decimal decimal_0);

			void imethod_27(decimal? selector);
		}

		private class Class7
		{
			public MethodBase methodBase_0;

			public ParameterInfo[] parameterInfo_0;

			public Expression[] expression_0;
		}

		private static readonly Type[] type_0;

		private static readonly Expression expression_0;

		private static readonly Expression expression_1;

		private static readonly Expression expression_2;

		private static readonly string string_0;

		private static readonly string string_1;

		private static readonly string string_2;

		private static Dictionary<string, object> dictionary_0;

		private Dictionary<string, object> dictionary_1;

		private IDictionary<string, object> idictionary_0;

		private Dictionary<Expression, string> dictionary_2;

		private ParameterExpression parameterExpression_0;

		private string string_3;

		private int int_0;

		private int int_1;

		private char char_0;

		private Class6.Struct0 struct0_0;

		[CompilerGenerated]
		private static Func<PropertyInfo, MethodBase> func_0;

		[CompilerGenerated]
		private static Func<MethodBase, bool> func_1;

		[CompilerGenerated]
		private static Func<MethodBase, Class6.Class7> func_2;

		public Class6(ParameterExpression[] parameterExpression_1, string string_4, object[] object_0)
		{
			if (string_4 == null)
			{
				throw new ArgumentNullException("expression");
			}
			if (Class6.dictionary_0 == null)
			{
				Class6.dictionary_0 = Class6.smethod_18();
			}
			this.dictionary_1 = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
			this.dictionary_2 = new Dictionary<Expression, string>();
			if (parameterExpression_1 != null)
			{
				this.method_0(parameterExpression_1);
			}
			if (object_0 != null)
			{
				this.method_1(object_0);
			}
			this.string_3 = string_4;
			this.int_1 = this.string_3.Length;
			this.method_52(0);
			this.method_54();
		}

		private void method_0(ParameterExpression[] parameterExpression_1)
		{
			for (int i = 0; i < parameterExpression_1.Length; i++)
			{
				ParameterExpression parameterExpression = parameterExpression_1[i];
				if (!string.IsNullOrEmpty(parameterExpression.Name))
				{
					this.method_2(parameterExpression.Name, parameterExpression);
				}
			}
			if (parameterExpression_1.Length == 1 && string.IsNullOrEmpty(parameterExpression_1[0].Name))
			{
				this.parameterExpression_0 = parameterExpression_1[0];
			}
		}

		private void method_1(object[] object_0)
		{
			for (int i = 0; i < object_0.Length; i++)
			{
				object obj = object_0[i];
				if (i == object_0.Length - 1 && obj is IDictionary<string, object>)
				{
					this.idictionary_0 = (IDictionary<string, object>)obj;
				}
				else
				{
					this.method_2("@" + i.ToString(CultureInfo.InvariantCulture), obj);
				}
			}
		}

		private void method_2(string string_4, object object_0)
		{
			if (this.dictionary_1.ContainsKey(string_4))
			{
				throw this.method_60("The identifier '{0}' was defined more than once", new object[]
				{
					string_4
				});
			}
			this.dictionary_1.Add(string_4, object_0);
		}

		public Expression method_3(Type type_1)
		{
			int int_ = this.struct0_0.int_0;
			Expression expression = this.method_5();
			if (type_1 != null && (expression = this.method_40(expression, type_1, true)) == null)
			{
				throw this.method_61(int_, "Expression of type '{0}' expected", new object[]
				{
					Class6.smethod_4(type_1)
				});
			}
			this.method_58((Class6.Enum1)1, "Syntax error");
			return expression;
		}

		public IEnumerable<Class3> method_4()
		{
			List<Class3> list = new List<Class3>();
			while (true)
			{
				Expression expression = this.method_5();
				bool bool_ = true;
				if (this.method_55("asc") || this.method_55("ascending"))
				{
					this.method_54();
				}
				else if (this.method_55("desc") || this.method_55("descending"))
				{
					this.method_54();
					bool_ = false;
				}
				list.Add(new Class3
				{
					expression_0 = expression,
					bool_0 = bool_
				});
				if (this.struct0_0.enum1_0 != (Class6.Enum1)13)
				{
					break;
				}
				this.method_54();
			}
			this.method_58((Class6.Enum1)1, "Syntax error");
			return list;
		}

		private Expression method_5()
		{
			int int_ = this.struct0_0.int_0;
			Expression expression = this.method_6();
			if (this.struct0_0.enum1_0 == (Class6.Enum1)21)
			{
				this.method_54();
				Expression expression_ = this.method_5();
				this.method_58((Class6.Enum1)17, "':' expected");
				this.method_54();
				Expression expression_2 = this.method_5();
				expression = this.method_22(expression, expression_, expression_2, int_);
			}
			return expression;
		}

		private Expression method_6()
		{
			Expression expression = this.method_7();
			while (this.struct0_0.enum1_0 == (Class6.Enum1)31 || this.method_55("or"))
			{
				Class6.Struct0 @struct = this.struct0_0;
				this.method_54();
				Expression right = this.method_7();
				this.method_33(typeof(Class6.Interface0), @struct.string_0, ref expression, ref right, @struct.int_0);
				expression = Expression.OrElse(expression, right);
			}
			return expression;
		}

		private Expression method_7()
		{
			Expression expression = this.method_8();
			while (this.struct0_0.enum1_0 == (Class6.Enum1)26 || this.method_55("and"))
			{
				Class6.Struct0 @struct = this.struct0_0;
				this.method_54();
				Expression right = this.method_8();
				this.method_33(typeof(Class6.Interface0), @struct.string_0, ref expression, ref right, @struct.int_0);
				expression = Expression.AndAlso(expression, right);
			}
			return expression;
		}

		private Expression method_8()
		{
			Expression expression = this.method_9();
			while (this.struct0_0.enum1_0 == (Class6.Enum1)19 || this.struct0_0.enum1_0 == (Class6.Enum1)29 || this.struct0_0.enum1_0 == (Class6.Enum1)25 || this.struct0_0.enum1_0 == (Class6.Enum1)28 || this.struct0_0.enum1_0 == (Class6.Enum1)20 || this.struct0_0.enum1_0 == (Class6.Enum1)30 || this.struct0_0.enum1_0 == (Class6.Enum1)18 || this.struct0_0.enum1_0 == (Class6.Enum1)27)
			{
				Class6.Struct0 @struct = this.struct0_0;
				this.method_54();
				Expression expression2 = this.method_9();
				bool flag;
				if ((flag = (@struct.enum1_0 == (Class6.Enum1)19 || @struct.enum1_0 == (Class6.Enum1)29 || @struct.enum1_0 == (Class6.Enum1)25 || @struct.enum1_0 == (Class6.Enum1)28)) && !expression.Type.IsValueType && !expression2.Type.IsValueType)
				{
					if (expression.Type != expression2.Type)
					{
						if (expression.Type.IsAssignableFrom(expression2.Type))
						{
							expression2 = Expression.Convert(expression2, expression.Type);
						}
						else
						{
							if (!expression2.Type.IsAssignableFrom(expression.Type))
							{
								throw this.method_34(@struct.string_0, expression, expression2, @struct.int_0);
							}
							expression = Expression.Convert(expression, expression2.Type);
						}
					}
				}
				else if (Class6.smethod_9(expression.Type) || Class6.smethod_9(expression2.Type))
				{
					if (expression.Type != expression2.Type)
					{
						Expression expression3;
						if ((expression3 = this.method_40(expression2, expression.Type, true)) != null)
						{
							expression2 = expression3;
						}
						else
						{
							if ((expression3 = this.method_40(expression, expression2.Type, true)) == null)
							{
								throw this.method_34(@struct.string_0, expression, expression2, @struct.int_0);
							}
							expression = expression3;
						}
					}
				}
				else
				{
					this.method_33(flag ? typeof(Class6.Interface3) : typeof(Class6.Interface2), @struct.string_0, ref expression, ref expression2, @struct.int_0);
				}
				switch (@struct.enum1_0)
				{
				case (Class6.Enum1)18:
					expression = this.method_45(expression, expression2);
					break;
				case (Class6.Enum1)19:
				case (Class6.Enum1)29:
					expression = this.method_41(expression, expression2);
					break;
				case (Class6.Enum1)20:
					expression = this.method_43(expression, expression2);
					break;
				case (Class6.Enum1)25:
				case (Class6.Enum1)28:
					expression = this.method_42(expression, expression2);
					break;
				case (Class6.Enum1)27:
					expression = this.method_46(expression, expression2);
					break;
				case (Class6.Enum1)30:
					expression = this.method_44(expression, expression2);
					break;
				}
			}
			return expression;
		}

		private Expression method_9()
		{
			Expression expression = this.method_10();
			while (this.struct0_0.enum1_0 == (Class6.Enum1)12 || this.struct0_0.enum1_0 == (Class6.Enum1)14 || this.struct0_0.enum1_0 == (Class6.Enum1)8)
			{
				Class6.Struct0 @struct = this.struct0_0;
				this.method_54();
				Expression expression2 = this.method_10();
				Class6.Enum1 enum1_ = @struct.enum1_0;
				if (enum1_ != (Class6.Enum1)8)
				{
					switch (enum1_)
					{
					case (Class6.Enum1)12:
						if (expression.Type != typeof(string) && expression2.Type != typeof(string))
						{
							this.method_33(typeof(Class6.Interface4), @struct.string_0, ref expression, ref expression2, @struct.int_0);
							expression = this.method_47(expression, expression2);
							continue;
						}
						break;
					case (Class6.Enum1)13:
						continue;
					case (Class6.Enum1)14:
						this.method_33(typeof(Class6.Interface5), @struct.string_0, ref expression, ref expression2, @struct.int_0);
						expression = this.method_48(expression, expression2);
						continue;
					default:
						continue;
					}
				}
				expression = this.method_49(expression, expression2);
			}
			return expression;
		}

		private Expression method_10()
		{
			Expression expression = this.method_11();
			while (this.struct0_0.enum1_0 == (Class6.Enum1)11 || this.struct0_0.enum1_0 == (Class6.Enum1)16 || this.struct0_0.enum1_0 == (Class6.Enum1)7 || this.method_55("mod"))
			{
				Class6.Struct0 @struct = this.struct0_0;
				this.method_54();
				Expression right = this.method_11();
				this.method_33(typeof(Class6.Interface1), @struct.string_0, ref expression, ref right, @struct.int_0);
				Class6.Enum1 enum1_ = @struct.enum1_0;
				if (enum1_ <= (Class6.Enum1)7)
				{
					if (enum1_ == (Class6.Enum1)2 || enum1_ == (Class6.Enum1)7)
					{
						expression = Expression.Modulo(expression, right);
					}
				}
				else if (enum1_ != (Class6.Enum1)11)
				{
					if (enum1_ == (Class6.Enum1)16)
					{
						expression = Expression.Divide(expression, right);
					}
				}
				else
				{
					expression = Expression.Multiply(expression, right);
				}
			}
			return expression;
		}

		private Expression method_11()
		{
			Expression result;
			if (this.struct0_0.enum1_0 == (Class6.Enum1)14 || this.struct0_0.enum1_0 == (Class6.Enum1)6 || this.method_55("not"))
			{
				Class6.Struct0 @struct = this.struct0_0;
				this.method_54();
				if (@struct.enum1_0 == (Class6.Enum1)14 && (this.struct0_0.enum1_0 == (Class6.Enum1)4 || this.struct0_0.enum1_0 == (Class6.Enum1)5))
				{
					this.struct0_0.string_0 = "-" + this.struct0_0.string_0;
					this.struct0_0.int_0 = @struct.int_0;
					result = this.method_12();
				}
				else
				{
					Expression expression = this.method_11();
					if (@struct.enum1_0 == (Class6.Enum1)14)
					{
						this.method_32(typeof(Class6.Interface6), @struct.string_0, ref expression, @struct.int_0);
						expression = Expression.Negate(expression);
					}
					else
					{
						this.method_32(typeof(Class6.Interface7), @struct.string_0, ref expression, @struct.int_0);
						expression = Expression.Not(expression);
					}
					result = expression;
				}
			}
			else
			{
				result = this.method_12();
			}
			return result;
		}

		private Expression method_12()
		{
			Expression expression = this.method_13();
			while (true)
			{
				if (this.struct0_0.enum1_0 == (Class6.Enum1)15)
				{
					this.method_54();
					expression = this.method_27(null, expression);
				}
				else
				{
					if (this.struct0_0.enum1_0 != (Class6.Enum1)22)
					{
						break;
					}
					expression = this.method_31(expression);
				}
			}
			return expression;
		}

		private Expression method_13()
		{
			switch (this.struct0_0.enum1_0)
			{
			case (Class6.Enum1)2:
			{
				Expression result = this.method_19();
				return result;
			}
			case (Class6.Enum1)3:
			{
				Expression result = this.method_14();
				return result;
			}
			case (Class6.Enum1)4:
			{
				Expression result = this.method_15();
				return result;
			}
			case (Class6.Enum1)5:
			{
				Expression result = this.method_16();
				return result;
			}
			case (Class6.Enum1)9:
			{
				Expression result = this.method_18();
				return result;
			}
			}
			throw this.method_60("Expression expected", new object[0]);
		}

		private Expression method_14()
		{
			this.method_59((Class6.Enum1)3);
			char c = this.struct0_0.string_0[0];
			string text = this.struct0_0.string_0.Substring(1, this.struct0_0.string_0.Length - 2);
			int startIndex = 0;
			while (true)
			{
				int num = text.IndexOf(c, startIndex);
				if (num < 0)
				{
					break;
				}
				text = text.Remove(num, 1);
				startIndex = num + 1;
			}
			Expression result;
			if (c == '\'')
			{
				if (text.Length != 1)
				{
					throw this.method_60("Character literal must contain exactly one character", new object[0]);
				}
				this.method_54();
				result = this.method_17(text[0], text);
			}
			else
			{
				this.method_54();
				result = this.method_17(text, text);
			}
			return result;
		}

		private Expression method_15()
		{
			this.method_59((Class6.Enum1)4);
			string text = this.struct0_0.string_0;
			Expression result;
			if (text[0] != '-')
			{
				ulong num;
				if (!ulong.TryParse(text, out num))
				{
					throw this.method_60("Invalid integer literal '{0}'", new object[]
					{
						text
					});
				}
				this.method_54();
				if (num <= 2147483647uL)
				{
					result = this.method_17((int)num, text);
				}
				else if (num <= 4294967295uL)
				{
					result = this.method_17((uint)num, text);
				}
				else if (num <= 9223372036854775807uL)
				{
					result = this.method_17((long)num, text);
				}
				else
				{
					result = this.method_17(num, text);
				}
			}
			else
			{
				long num2;
				if (!long.TryParse(text, out num2))
				{
					throw this.method_60("Invalid integer literal '{0}'", new object[]
					{
						text
					});
				}
				this.method_54();
				if (num2 >= -2147483648L && num2 <= 2147483647L)
				{
					result = this.method_17((int)num2, text);
				}
				else
				{
					result = this.method_17(num2, text);
				}
			}
			return result;
		}

		private Expression method_16()
		{
			this.method_59((Class6.Enum1)5);
			string text = this.struct0_0.string_0;
			object obj = null;
			char c = text[text.Length - 1];
			double num2;
			if (c == 'F' || c == 'f')
			{
				float num;
				if (float.TryParse(text.Substring(0, text.Length - 1), out num))
				{
					obj = num;
				}
			}
			else if (double.TryParse(text, out num2))
			{
				obj = num2;
			}
			if (obj == null)
			{
				throw this.method_60("Invalid real literal '{0}'", new object[]
				{
					text
				});
			}
			this.method_54();
			return this.method_17(obj, text);
		}

		private Expression method_17(object object_0, string string_4)
		{
			ConstantExpression constantExpression = Expression.Constant(object_0);
			this.dictionary_2.Add(constantExpression, string_4);
			return constantExpression;
		}

		private Expression method_18()
		{
			this.method_58((Class6.Enum1)9, "'(' expected");
			this.method_54();
			Expression result = this.method_5();
			this.method_58((Class6.Enum1)10, "')' or operator expected");
			this.method_54();
			return result;
		}

		private Expression method_19()
		{
			this.method_59((Class6.Enum1)2);
			object obj;
			Expression result;
			if (Class6.dictionary_0.TryGetValue(this.struct0_0.string_0, out obj))
			{
				if (obj is Type)
				{
					result = this.method_25((Type)obj);
				}
				else if (obj == Class6.string_0)
				{
					result = this.method_20();
				}
				else if (obj == Class6.string_1)
				{
					result = this.method_21();
				}
				else if (obj == Class6.string_2)
				{
					result = this.method_23();
				}
				else
				{
					this.method_54();
					result = (Expression)obj;
				}
			}
			else if (this.dictionary_1.TryGetValue(this.struct0_0.string_0, out obj) || (this.idictionary_0 != null && this.idictionary_0.TryGetValue(this.struct0_0.string_0, out obj)))
			{
				Expression expression = obj as Expression;
				if (expression == null)
				{
					expression = Expression.Constant(obj);
				}
				else
				{
					LambdaExpression lambdaExpression = expression as LambdaExpression;
					if (lambdaExpression != null)
					{
						result = this.method_24(lambdaExpression);
						return result;
					}
				}
				this.method_54();
				result = expression;
			}
			else
			{
				if (this.parameterExpression_0 == null)
				{
					throw this.method_60("Unknown identifier '{0}'", new object[]
					{
						this.struct0_0.string_0
					});
				}
				result = this.method_27(null, this.parameterExpression_0);
			}
			return result;
		}

		private Expression method_20()
		{
			if (this.parameterExpression_0 == null)
			{
				throw this.method_60("No 'it' is in scope", new object[0]);
			}
			this.method_54();
			return this.parameterExpression_0;
		}

		private Expression method_21()
		{
			int int_ = this.struct0_0.int_0;
			this.method_54();
			Expression[] array = this.method_29();
			if (array.Length != 3)
			{
				throw this.method_61(int_, "The 'iif' function requires three arguments", new object[0]);
			}
			return this.method_22(array[0], array[1], array[2], int_);
		}

		private Expression method_22(Expression expression_3, Expression expression_4, Expression expression_5, int int_2)
		{
			if (expression_3.Type != typeof(bool))
			{
				throw this.method_61(int_2, "The first expression must be of type 'Boolean'", new object[0]);
			}
			if (expression_4.Type != expression_5.Type)
			{
				Expression expression = (expression_5 != Class6.expression_2) ? this.method_40(expression_4, expression_5.Type, true) : null;
				Expression expression2 = (expression_4 != Class6.expression_2) ? this.method_40(expression_5, expression_4.Type, true) : null;
				if (expression != null && expression2 == null)
				{
					expression_4 = expression;
				}
				else if (expression2 != null && expression == null)
				{
					expression_5 = expression2;
				}
				else
				{
					string text = (expression_4 != Class6.expression_2) ? expression_4.Type.Name : "null";
					string text2 = (expression_5 != Class6.expression_2) ? expression_5.Type.Name : "null";
					if (expression != null && expression2 != null)
					{
						throw this.method_61(int_2, "Both of the types '{0}' and '{1}' convert to the other", new object[]
						{
							text,
							text2
						});
					}
					throw this.method_61(int_2, "Neither of the types '{0}' and '{1}' converts to the other", new object[]
					{
						text,
						text2
					});
				}
			}
			return Expression.Condition(expression_3, expression_4, expression_5);
		}

		private Expression method_23()
		{
			this.method_54();
			this.method_58((Class6.Enum1)9, "'(' expected");
			this.method_54();
			List<DynamicProperty> list = new List<DynamicProperty>();
			List<Expression> list2 = new List<Expression>();
			int int_;
			while (true)
			{
				int_ = this.struct0_0.int_0;
				Expression expression = this.method_5();
				string name;
				if (this.method_55("as"))
				{
					this.method_54();
					name = this.method_56();
					this.method_54();
				}
				else
				{
					MemberExpression memberExpression = expression as MemberExpression;
					if (memberExpression == null)
					{
						break;
					}
					name = memberExpression.Member.Name;
				}
				list2.Add(expression);
				list.Add(new DynamicProperty(name, expression.Type));
				if (this.struct0_0.enum1_0 != (Class6.Enum1)13)
				{
					goto IL_CB;
				}
				this.method_54();
			}
			throw this.method_61(int_, "Expression is missing an 'as' clause", new object[0]);
			IL_CB:
			this.method_58((Class6.Enum1)10, "')' or ',' expected");
			this.method_54();
			Type type = DynamicExpression.CreateClass(list);
			MemberBinding[] array = new MemberBinding[list.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Expression.Bind(type.GetProperty(list[i].Name), list2[i]);
			}
			return Expression.MemberInit(Expression.New(type), array);
		}

		private Expression method_24(LambdaExpression lambdaExpression_0)
		{
			int int_ = this.struct0_0.int_0;
			this.method_54();
			Expression[] array = this.method_29();
			MethodBase methodBase;
			if (this.method_36(lambdaExpression_0.Type, "Invoke", false, array, out methodBase) != 1)
			{
				throw this.method_61(int_, "Argument list incompatible with lambda expression", new object[0]);
			}
			return Expression.Invoke(lambdaExpression_0, array);
		}

		private Expression method_25(Type type_1)
		{
			int int_ = this.struct0_0.int_0;
			this.method_54();
			if (this.struct0_0.enum1_0 == (Class6.Enum1)21)
			{
				if (!type_1.IsValueType || Class6.smethod_2(type_1))
				{
					throw this.method_61(int_, "Type '{0}' has no nullable form", new object[]
					{
						Class6.smethod_4(type_1)
					});
				}
				type_1 = typeof(Nullable<>).MakeGenericType(new Type[]
				{
					type_1
				});
				this.method_54();
			}
			Expression result;
			if (this.struct0_0.enum1_0 == (Class6.Enum1)9)
			{
				Expression[] array = this.method_29();
				MethodBase methodBase;
				switch (this.method_38(type_1.GetConstructors(), array, out methodBase))
				{
				case 0:
					if (array.Length != 1)
					{
						throw this.method_61(int_, "No matching constructor in type '{0}'", new object[]
						{
							Class6.smethod_4(type_1)
						});
					}
					result = this.method_26(array[0], type_1, int_);
					break;
				case 1:
					result = Expression.New((ConstructorInfo)methodBase, array);
					break;
				default:
					throw this.method_61(int_, "Ambiguous invocation of '{0}' constructor", new object[]
					{
						Class6.smethod_4(type_1)
					});
				}
			}
			else
			{
				this.method_58((Class6.Enum1)15, "'.' or '(' expected");
				this.method_54();
				result = this.method_27(type_1, null);
			}
			return result;
		}

		private Expression method_26(Expression expression_3, Type type_1, int int_2)
		{
			Type type = expression_3.Type;
			Expression result;
			if (type == type_1)
			{
				result = expression_3;
			}
			else
			{
				if (type.IsValueType && type_1.IsValueType)
				{
					if ((Class6.smethod_2(type) || Class6.smethod_2(type_1)) && Class6.smethod_3(type) == Class6.smethod_3(type_1))
					{
						result = Expression.Convert(expression_3, type_1);
						return result;
					}
					if (((Class6.smethod_5(type) || Class6.smethod_9(type)) && Class6.smethod_5(type_1)) || Class6.smethod_9(type_1))
					{
						result = Expression.ConvertChecked(expression_3, type_1);
						return result;
					}
				}
				if (!type.IsAssignableFrom(type_1) && !type_1.IsAssignableFrom(type) && !type.IsInterface && !type_1.IsInterface)
				{
					throw this.method_61(int_2, "A value of type '{0}' cannot be converted to type '{1}'", new object[]
					{
						Class6.smethod_4(type),
						Class6.smethod_4(type_1)
					});
				}
				result = Expression.Convert(expression_3, type_1);
			}
			return result;
		}

		private Expression method_27(Type type_1, Expression expression_3)
		{
			if (expression_3 != null)
			{
				type_1 = expression_3.Type;
			}
			int int_ = this.struct0_0.int_0;
			string text = this.method_56();
			this.method_54();
			Expression result;
			if (this.struct0_0.enum1_0 == (Class6.Enum1)9)
			{
				if (expression_3 != null && type_1 != typeof(string))
				{
					Type type = Class6.smethod_0(typeof(IEnumerable<>), type_1);
					if (type != null)
					{
						Type type_2 = type.GetGenericArguments()[0];
						result = this.method_28(expression_3, type_2, text, int_);
						return result;
					}
				}
				Expression[] array = this.method_29();
				MethodBase methodBase;
				switch (this.method_36(type_1, text, expression_3 == null, array, out methodBase))
				{
				case 0:
					throw this.method_61(int_, "No applicable method '{0}' exists in type '{1}'", new object[]
					{
						text,
						Class6.smethod_4(type_1)
					});
				case 1:
				{
					MethodInfo methodInfo = (MethodInfo)methodBase;
					if (!Class6.smethod_1(methodInfo.DeclaringType))
					{
						throw this.method_61(int_, "Methods on type '{0}' are not accessible", new object[]
						{
							Class6.smethod_4(methodInfo.DeclaringType)
						});
					}
					if (methodInfo.ReturnType == typeof(void))
					{
						throw this.method_61(int_, "Method '{0}' in type '{1}' does not return a value", new object[]
						{
							text,
							Class6.smethod_4(methodInfo.DeclaringType)
						});
					}
					result = Expression.Call(expression_3, methodInfo, array);
					break;
				}
				default:
					throw this.method_61(int_, "Ambiguous invocation of method '{0}' in type '{1}'", new object[]
					{
						text,
						Class6.smethod_4(type_1)
					});
				}
			}
			else
			{
				MemberInfo memberInfo = this.method_35(type_1, text, expression_3 == null);
				if (memberInfo == null)
				{
					throw this.method_61(int_, "No property or field '{0}' exists in type '{1}'", new object[]
					{
						text,
						Class6.smethod_4(type_1)
					});
				}
				result = ((memberInfo is PropertyInfo) ? Expression.Property(expression_3, (PropertyInfo)memberInfo) : Expression.Field(expression_3, (FieldInfo)memberInfo));
			}
			return result;
		}

		private static Type smethod_0(Type type_1, Type type_2)
		{
			Type result;
			while (type_2 != null && type_2 != typeof(object))
			{
				if (!type_2.IsGenericType || type_2.GetGenericTypeDefinition() != type_1)
				{
					if (type_1.IsInterface)
					{
						Type[] interfaces = type_2.GetInterfaces();
						for (int i = 0; i < interfaces.Length; i++)
						{
							Type type_3 = interfaces[i];
							Type type = Class6.smethod_0(type_1, type_3);
							if (type != null)
							{
								result = type;
								return result;
							}
						}
					}
					type_2 = type_2.BaseType;
					continue;
				}
				result = type_2;
				return result;
			}
			result = null;
			return result;
		}

		private Expression method_28(Expression expression_3, Type type_1, string string_4, int int_2)
		{
			ParameterExpression parameterExpression = this.parameterExpression_0;
			ParameterExpression parameterExpression2 = Expression.Parameter(type_1, "");
			this.parameterExpression_0 = parameterExpression2;
			Expression[] array = this.method_29();
			this.parameterExpression_0 = parameterExpression;
			MethodBase methodBase;
			if (this.method_36(typeof(Class6.Interface8), string_4, false, array, out methodBase) != 1)
			{
				throw this.method_61(int_2, "No applicable aggregate method '{0}' exists", new object[]
				{
					string_4
				});
			}
			Type[] typeArguments;
			if (methodBase.Name == "Min" || methodBase.Name == "Max")
			{
				typeArguments = new Type[]
				{
					type_1,
					array[0].Type
				};
			}
			else
			{
				typeArguments = new Type[]
				{
					type_1
				};
			}
			if (array.Length == 0)
			{
				array = new Expression[]
				{
					expression_3
				};
			}
			else
			{
				array = new Expression[]
				{
					expression_3,
					Expression.Lambda(array[0], new ParameterExpression[]
					{
						parameterExpression2
					})
				};
			}
			return Expression.Call(typeof(Enumerable), methodBase.Name, typeArguments, array);
		}

		private Expression[] method_29()
		{
			this.method_58((Class6.Enum1)9, "'(' expected");
			this.method_54();
			Expression[] result = (this.struct0_0.enum1_0 != (Class6.Enum1)10) ? this.method_30() : new Expression[0];
			this.method_58((Class6.Enum1)10, "')' or ',' expected");
			this.method_54();
			return result;
		}

		private Expression[] method_30()
		{
			List<Expression> list = new List<Expression>();
			while (true)
			{
				list.Add(this.method_5());
				if (this.struct0_0.enum1_0 != (Class6.Enum1)13)
				{
					break;
				}
				this.method_54();
			}
			return list.ToArray();
		}

		private Expression method_31(Expression expression_3)
		{
			int int_ = this.struct0_0.int_0;
			this.method_58((Class6.Enum1)22, "'(' expected");
			this.method_54();
			Expression[] array = this.method_30();
			this.method_58((Class6.Enum1)23, "']' or ',' expected");
			this.method_54();
			Expression result;
			if (expression_3.Type.IsArray)
			{
				if (expression_3.Type.GetArrayRank() != 1 || array.Length != 1)
				{
					throw this.method_61(int_, "Indexing of multi-dimensional arrays is not supported", new object[0]);
				}
				Expression expression = this.method_40(array[0], typeof(int), true);
				if (expression == null)
				{
					throw this.method_61(int_, "Array index must be an integer expression", new object[0]);
				}
				result = Expression.ArrayIndex(expression_3, expression);
			}
			else
			{
				MethodBase methodBase;
				switch (this.method_37(expression_3.Type, array, out methodBase))
				{
				case 0:
					throw this.method_61(int_, "No applicable indexer exists in type '{0}'", new object[]
					{
						Class6.smethod_4(expression_3.Type)
					});
				case 1:
					result = Expression.Call(expression_3, (MethodInfo)methodBase, array);
					break;
				default:
					throw this.method_61(int_, "Ambiguous invocation of indexer in type '{0}'", new object[]
					{
						Class6.smethod_4(expression_3.Type)
					});
				}
			}
			return result;
		}

		private static bool smethod_1(Type type_1)
		{
			Type[] array = Class6.type_0;
			bool result;
			for (int i = 0; i < array.Length; i++)
			{
				Type type = array[i];
				if (type == type_1)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		private static bool smethod_2(Type type_1)
		{
			return type_1.IsGenericType && type_1.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		private static Type smethod_3(Type type_1)
		{
			return Class6.smethod_2(type_1) ? type_1.GetGenericArguments()[0] : type_1;
		}

		private static string smethod_4(Type type_1)
		{
			Type type = Class6.smethod_3(type_1);
			string text = type.Name;
			if (type_1 != type)
			{
				text += '?';
			}
			return text;
		}

		private static bool smethod_5(Type type_1)
		{
			return Class6.smethod_8(type_1) != 0;
		}

		private static bool smethod_6(Type type_1)
		{
			return Class6.smethod_8(type_1) == 2;
		}

		private static bool smethod_7(Type type_1)
		{
			return Class6.smethod_8(type_1) == 3;
		}

		private static int smethod_8(Type type_1)
		{
			type_1 = Class6.smethod_3(type_1);
			int result;
			if (type_1.IsEnum)
			{
				result = 0;
			}
			else
			{
				switch (Type.GetTypeCode(type_1))
				{
				case TypeCode.Char:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					result = 1;
					break;
				case TypeCode.SByte:
				case TypeCode.Int16:
				case TypeCode.Int32:
				case TypeCode.Int64:
					result = 2;
					break;
				case TypeCode.Byte:
				case TypeCode.UInt16:
				case TypeCode.UInt32:
				case TypeCode.UInt64:
					result = 3;
					break;
				default:
					result = 0;
					break;
				}
			}
			return result;
		}

		private static bool smethod_9(Type type_1)
		{
			return Class6.smethod_3(type_1).IsEnum;
		}

		private void method_32(Type type_1, string string_4, ref Expression expression_3, int int_2)
		{
			Expression[] array = new Expression[]
			{
				expression_3
			};
			MethodBase methodBase;
			if (this.method_36(type_1, "F", false, array, out methodBase) != 1)
			{
				throw this.method_61(int_2, "Operator '{0}' incompatible with operand type '{1}'", new object[]
				{
					string_4,
					Class6.smethod_4(array[0].Type)
				});
			}
			expression_3 = array[0];
		}

		private void method_33(Type type_1, string string_4, ref Expression expression_3, ref Expression expression_4, int int_2)
		{
			Expression[] array = new Expression[]
			{
				expression_3,
				expression_4
			};
			MethodBase methodBase;
			if (this.method_36(type_1, "F", false, array, out methodBase) != 1)
			{
				throw this.method_34(string_4, expression_3, expression_4, int_2);
			}
			expression_3 = array[0];
			expression_4 = array[1];
		}

		private Exception method_34(string string_4, Expression expression_3, Expression expression_4, int int_2)
		{
			return this.method_61(int_2, "Operator '{0}' incompatible with operand types '{1}' and '{2}'", new object[]
			{
				string_4,
				Class6.smethod_4(expression_3.Type),
				Class6.smethod_4(expression_4.Type)
			});
		}

		private MemberInfo method_35(Type type_1, string string_4, bool bool_0)
		{
			BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | (bool_0 ? BindingFlags.Static : BindingFlags.Instance);
			MemberInfo result;
			foreach (Type current in Class6.smethod_10(type_1))
			{
				MemberInfo[] array = current.FindMembers(MemberTypes.Field | MemberTypes.Property, bindingAttr, Type.FilterNameIgnoreCase, string_4);
				if (array.Length != 0)
				{
					result = array[0];
					return result;
				}
			}
			result = null;
			return result;
		}

		private int method_36(Type type_1, string string_4, bool bool_0, Expression[] expression_3, out MethodBase methodBase_0)
		{
			BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | (bool_0 ? BindingFlags.Static : BindingFlags.Instance);
			int result;
			foreach (Type current in Class6.smethod_10(type_1))
			{
				MemberInfo[] source = current.FindMembers(MemberTypes.Method, bindingAttr, Type.FilterNameIgnoreCase, string_4);
				int num = this.method_38(source.Cast<MethodBase>(), expression_3, out methodBase_0);
				if (num != 0)
				{
					result = num;
					return result;
				}
			}
			methodBase_0 = null;
			result = 0;
			return result;
		}

		private int method_37(Type type_1, Expression[] expression_3, out MethodBase methodBase_0)
		{
			int result;
			foreach (Type current in Class6.smethod_10(type_1))
			{
				MemberInfo[] defaultMembers = current.GetDefaultMembers();
				if (defaultMembers.Length != 0)
				{
					IEnumerable<PropertyInfo> arg_48_0 = defaultMembers.OfType<PropertyInfo>();
					if (Class6.func_0 == null)
					{
						Class6.func_0 = new Func<PropertyInfo, MethodBase>(Class6.smethod_19);
					}
					IEnumerable<MethodBase> arg_6A_0 = arg_48_0.Select(Class6.func_0);
					if (Class6.func_1 == null)
					{
						Class6.func_1 = new Func<MethodBase, bool>(Class6.smethod_20);
					}
					IEnumerable<MethodBase> methods = arg_6A_0.Where(Class6.func_1);
					int num = this.method_38(methods, expression_3, out methodBase_0);
					if (num != 0)
					{
						result = num;
						return result;
					}
				}
			}
			methodBase_0 = null;
			result = 0;
			return result;
		}

		private static IEnumerable<Type> smethod_10(Type type_1)
		{
			IEnumerable<Type> result;
			if (type_1.IsInterface)
			{
				List<Type> list = new List<Type>();
				Class6.smethod_12(list, type_1);
				result = list;
			}
			else
			{
				result = Class6.smethod_11(type_1);
			}
			return result;
		}

		private static IEnumerable<Type> smethod_11(Type type_1)
		{
			Class6.<SelfAndBaseClasses>d__5 <SelfAndBaseClasses>d__ = new Class6.<SelfAndBaseClasses>d__5(-2);
			<SelfAndBaseClasses>d__.<>3__type = type_1;
			return <SelfAndBaseClasses>d__;
		}

		private static void smethod_12(List<Type> types, Type type_1)
		{
			if (!types.Contains(type_1))
			{
				types.Add(type_1);
				Type[] interfaces = type_1.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					Type type_2 = interfaces[i];
					Class6.smethod_12(types, type_2);
				}
			}
		}

		private int method_38(IEnumerable<MethodBase> methods, Expression[] expression_3, out MethodBase methodBase_0)
		{
			Class6.<>c__DisplayClassf <>c__DisplayClassf = new Class6.<>c__DisplayClassf();
			<>c__DisplayClassf.args = expression_3;
			<>c__DisplayClassf.<>4__this = this;
			Class6.<>c__DisplayClassf arg_50_0 = <>c__DisplayClassf;
			if (Class6.func_2 == null)
			{
				Class6.func_2 = new Func<MethodBase, Class6.Class7>(Class6.smethod_21);
			}
			arg_50_0.applicable = (from m in methods.Select(Class6.func_2)
			where <>c__DisplayClassf.<>4__this.method_39(m, <>c__DisplayClassf.args)
			select m).ToArray<Class6.Class7>();
			if (<>c__DisplayClassf.applicable.Length > 1)
			{
				<>c__DisplayClassf.applicable = <>c__DisplayClassf.applicable.Where(delegate(Class6.Class7 m)
				{
					Class6.<>c__DisplayClassf.Class8 class2 = new Class6.<>c__DisplayClassf.Class8();
					class2.<>c__DisplayClassf_0 = <>c__DisplayClassf;
					class2.class7_0 = m;
					return <>c__DisplayClassf.applicable.All(new Func<Class6.Class7, bool>(class2.method_0));
				}).ToArray<Class6.Class7>();
			}
			if (<>c__DisplayClassf.applicable.Length == 1)
			{
				Class6.Class7 @class = <>c__DisplayClassf.applicable[0];
				for (int i = 0; i < <>c__DisplayClassf.args.Length; i++)
				{
					<>c__DisplayClassf.args[i] = @class.expression_0[i];
				}
				methodBase_0 = @class.methodBase_0;
			}
			else
			{
				methodBase_0 = null;
			}
			return <>c__DisplayClassf.applicable.Length;
		}

		private bool method_39(Class6.Class7 class7_0, Expression[] expression_3)
		{
			bool result;
			if (class7_0.parameterInfo_0.Length != expression_3.Length)
			{
				result = false;
			}
			else
			{
				Expression[] array = new Expression[expression_3.Length];
				for (int i = 0; i < expression_3.Length; i++)
				{
					ParameterInfo parameterInfo = class7_0.parameterInfo_0[i];
					if (parameterInfo.IsOut)
					{
						result = false;
						return result;
					}
					Expression expression = this.method_40(expression_3[i], parameterInfo.ParameterType, false);
					if (expression == null)
					{
						result = false;
						return result;
					}
					array[i] = expression;
				}
				class7_0.expression_0 = array;
				result = true;
			}
			return result;
		}

		private Expression method_40(Expression expression_3, Type type_1, bool bool_0)
		{
			Expression result;
			if (expression_3.Type == type_1)
			{
				result = expression_3;
			}
			else
			{
				if (expression_3 is ConstantExpression)
				{
					ConstantExpression constantExpression = (ConstantExpression)expression_3;
					string string_;
					if (constantExpression == Class6.expression_2)
					{
						if (!type_1.IsValueType || Class6.smethod_2(type_1))
						{
							result = Expression.Constant(null, type_1);
							return result;
						}
					}
					else if (this.dictionary_2.TryGetValue(constantExpression, out string_))
					{
						Type type = Class6.smethod_3(type_1);
						object obj = null;
						switch (Type.GetTypeCode(constantExpression.Type))
						{
						case TypeCode.Int32:
						case TypeCode.UInt32:
						case TypeCode.Int64:
						case TypeCode.UInt64:
							obj = Class6.smethod_13(string_, type);
							break;
						case TypeCode.Double:
							if (type == typeof(decimal))
							{
								obj = Class6.smethod_13(string_, type);
							}
							break;
						case TypeCode.String:
							obj = Class6.smethod_14(string_, type);
							break;
						}
						if (obj != null)
						{
							result = Expression.Constant(obj, type_1);
							return result;
						}
					}
				}
				if (Class6.smethod_15(expression_3.Type, type_1))
				{
					if (type_1.IsValueType || bool_0)
					{
						result = Expression.Convert(expression_3, type_1);
					}
					else
					{
						result = expression_3;
					}
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		private static object smethod_13(string string_4, Type type_1)
		{
			object result;
			switch (Type.GetTypeCode(Class6.smethod_3(type_1)))
			{
			case TypeCode.SByte:
			{
				sbyte b;
				if (sbyte.TryParse(string_4, out b))
				{
					result = b;
					return result;
				}
				break;
			}
			case TypeCode.Byte:
			{
				byte b2;
				if (byte.TryParse(string_4, out b2))
				{
					result = b2;
					return result;
				}
				break;
			}
			case TypeCode.Int16:
			{
				short num;
				if (short.TryParse(string_4, out num))
				{
					result = num;
					return result;
				}
				break;
			}
			case TypeCode.UInt16:
			{
				ushort num2;
				if (ushort.TryParse(string_4, out num2))
				{
					result = num2;
					return result;
				}
				break;
			}
			case TypeCode.Int32:
			{
				int num3;
				if (int.TryParse(string_4, out num3))
				{
					result = num3;
					return result;
				}
				break;
			}
			case TypeCode.UInt32:
			{
				uint num4;
				if (uint.TryParse(string_4, out num4))
				{
					result = num4;
					return result;
				}
				break;
			}
			case TypeCode.Int64:
			{
				long num5;
				if (long.TryParse(string_4, out num5))
				{
					result = num5;
					return result;
				}
				break;
			}
			case TypeCode.UInt64:
			{
				ulong num6;
				if (ulong.TryParse(string_4, out num6))
				{
					result = num6;
					return result;
				}
				break;
			}
			case TypeCode.Single:
			{
				float num7;
				if (float.TryParse(string_4, out num7))
				{
					result = num7;
					return result;
				}
				break;
			}
			case TypeCode.Double:
			{
				double num8;
				if (double.TryParse(string_4, out num8))
				{
					result = num8;
					return result;
				}
				break;
			}
			case TypeCode.Decimal:
			{
				decimal num9;
				if (decimal.TryParse(string_4, out num9))
				{
					result = num9;
					return result;
				}
				break;
			}
			}
			result = null;
			return result;
		}

		private static object smethod_14(string string_4, Type type_1)
		{
			object result;
			if (type_1.IsEnum)
			{
				MemberInfo[] array = type_1.FindMembers(MemberTypes.Field, BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public, Type.FilterNameIgnoreCase, string_4);
				if (array.Length != 0)
				{
					result = ((FieldInfo)array[0]).GetValue(null);
					return result;
				}
			}
			result = null;
			return result;
		}

		private static bool smethod_15(Type type_1, Type type_2)
		{
			bool result;
			if (type_1 == type_2)
			{
				result = true;
			}
			else if (!type_2.IsValueType)
			{
				result = type_2.IsAssignableFrom(type_1);
			}
			else
			{
				Type type = Class6.smethod_3(type_1);
				Type type2 = Class6.smethod_3(type_2);
				if (type != type_1 && type2 == type_2)
				{
					result = false;
				}
				else
				{
					TypeCode typeCode = type.IsEnum ? TypeCode.Object : Type.GetTypeCode(type);
					TypeCode typeCode2 = type2.IsEnum ? TypeCode.Object : Type.GetTypeCode(type2);
					switch (typeCode)
					{
					case TypeCode.SByte:
						switch (typeCode2)
						{
						case TypeCode.SByte:
						case TypeCode.Int16:
						case TypeCode.Int32:
						case TypeCode.Int64:
						case TypeCode.Single:
						case TypeCode.Double:
						case TypeCode.Decimal:
							result = true;
							return result;
						}
						break;
					case TypeCode.Byte:
						switch (typeCode2)
						{
						case TypeCode.Byte:
						case TypeCode.Int16:
						case TypeCode.UInt16:
						case TypeCode.Int32:
						case TypeCode.UInt32:
						case TypeCode.Int64:
						case TypeCode.UInt64:
						case TypeCode.Single:
						case TypeCode.Double:
						case TypeCode.Decimal:
							result = true;
							return result;
						}
						break;
					case TypeCode.Int16:
						switch (typeCode2)
						{
						case TypeCode.Int16:
						case TypeCode.Int32:
						case TypeCode.Int64:
						case TypeCode.Single:
						case TypeCode.Double:
						case TypeCode.Decimal:
							result = true;
							return result;
						}
						break;
					case TypeCode.UInt16:
						switch (typeCode2)
						{
						case TypeCode.UInt16:
						case TypeCode.Int32:
						case TypeCode.UInt32:
						case TypeCode.Int64:
						case TypeCode.UInt64:
						case TypeCode.Single:
						case TypeCode.Double:
						case TypeCode.Decimal:
							result = true;
							return result;
						}
						break;
					case TypeCode.Int32:
						switch (typeCode2)
						{
						case TypeCode.Int32:
						case TypeCode.Int64:
						case TypeCode.Single:
						case TypeCode.Double:
						case TypeCode.Decimal:
							result = true;
							return result;
						}
						break;
					case TypeCode.UInt32:
						switch (typeCode2)
						{
						case TypeCode.UInt32:
						case TypeCode.Int64:
						case TypeCode.UInt64:
						case TypeCode.Single:
						case TypeCode.Double:
						case TypeCode.Decimal:
							result = true;
							return result;
						}
						break;
					case TypeCode.Int64:
						switch (typeCode2)
						{
						case TypeCode.Int64:
						case TypeCode.Single:
						case TypeCode.Double:
						case TypeCode.Decimal:
							result = true;
							return result;
						}
						break;
					case TypeCode.UInt64:
						switch (typeCode2)
						{
						case TypeCode.UInt64:
						case TypeCode.Single:
						case TypeCode.Double:
						case TypeCode.Decimal:
							result = true;
							return result;
						}
						break;
					case TypeCode.Single:
						switch (typeCode2)
						{
						case TypeCode.Single:
						case TypeCode.Double:
							result = true;
							return result;
						}
						break;
					default:
						if (type == type2)
						{
							result = true;
							return result;
						}
						break;
					}
					result = false;
				}
			}
			return result;
		}

		private static bool smethod_16(Expression[] expression_3, Class6.Class7 class7_0, Class6.Class7 class7_1)
		{
			bool flag = false;
			bool result;
			for (int i = 0; i < expression_3.Length; i++)
			{
				int num = Class6.smethod_17(expression_3[i].Type, class7_0.parameterInfo_0[i].ParameterType, class7_1.parameterInfo_0[i].ParameterType);
				if (num < 0)
				{
					result = false;
					return result;
				}
				if (num > 0)
				{
					flag = true;
				}
			}
			result = flag;
			return result;
		}

		private static int smethod_17(Type type_1, Type type_2, Type type_3)
		{
			int result;
			if (type_2 == type_3)
			{
				result = 0;
			}
			else if (type_1 == type_2)
			{
				result = 1;
			}
			else if (type_1 == type_3)
			{
				result = -1;
			}
			else
			{
				bool flag = Class6.smethod_15(type_2, type_3);
				bool flag2 = Class6.smethod_15(type_3, type_2);
				if (flag && !flag2)
				{
					result = 1;
				}
				else if (flag2 && !flag)
				{
					result = -1;
				}
				else if (Class6.smethod_6(type_2) && Class6.smethod_7(type_3))
				{
					result = 1;
				}
				else if (Class6.smethod_6(type_3) && Class6.smethod_7(type_2))
				{
					result = -1;
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}

		private Expression method_41(Expression expression_3, Expression expression_4)
		{
			return Expression.Equal(expression_3, expression_4);
		}

		private Expression method_42(Expression expression_3, Expression expression_4)
		{
			return Expression.NotEqual(expression_3, expression_4);
		}

		private Expression method_43(Expression expression_3, Expression expression_4)
		{
			Expression result;
			if (expression_3.Type == typeof(string))
			{
				result = Expression.GreaterThan(this.method_51("Compare", expression_3, expression_4), Expression.Constant(0));
			}
			else
			{
				result = Expression.GreaterThan(expression_3, expression_4);
			}
			return result;
		}

		private Expression method_44(Expression expression_3, Expression expression_4)
		{
			Expression result;
			if (expression_3.Type == typeof(string))
			{
				result = Expression.GreaterThanOrEqual(this.method_51("Compare", expression_3, expression_4), Expression.Constant(0));
			}
			else
			{
				result = Expression.GreaterThanOrEqual(expression_3, expression_4);
			}
			return result;
		}

		private Expression method_45(Expression expression_3, Expression expression_4)
		{
			Expression result;
			if (expression_3.Type == typeof(string))
			{
				result = Expression.LessThan(this.method_51("Compare", expression_3, expression_4), Expression.Constant(0));
			}
			else
			{
				result = Expression.LessThan(expression_3, expression_4);
			}
			return result;
		}

		private Expression method_46(Expression expression_3, Expression expression_4)
		{
			Expression result;
			if (expression_3.Type == typeof(string))
			{
				result = Expression.LessThanOrEqual(this.method_51("Compare", expression_3, expression_4), Expression.Constant(0));
			}
			else
			{
				result = Expression.LessThanOrEqual(expression_3, expression_4);
			}
			return result;
		}

		private Expression method_47(Expression expression_3, Expression expression_4)
		{
			Expression result;
			if (expression_3.Type == typeof(string) && expression_4.Type == typeof(string))
			{
				result = this.method_51("Concat", expression_3, expression_4);
			}
			else
			{
				result = Expression.Add(expression_3, expression_4);
			}
			return result;
		}

		private Expression method_48(Expression expression_3, Expression expression_4)
		{
			return Expression.Subtract(expression_3, expression_4);
		}

		private Expression method_49(Expression expression_3, Expression expression_4)
		{
			return Expression.Call(null, typeof(string).GetMethod("Concat", new Type[]
			{
				typeof(object),
				typeof(object)
			}), new Expression[]
			{
				expression_3,
				expression_4
			});
		}

		private MethodInfo method_50(string string_4, Expression expression_3, Expression expression_4)
		{
			return expression_3.Type.GetMethod(string_4, new Type[]
			{
				expression_3.Type,
				expression_4.Type
			});
		}

		private Expression method_51(string string_4, Expression expression_3, Expression expression_4)
		{
			return Expression.Call(null, this.method_50(string_4, expression_3, expression_4), new Expression[]
			{
				expression_3,
				expression_4
			});
		}

		private void method_52(int int_2)
		{
			this.int_0 = int_2;
			this.char_0 = ((this.int_0 < this.int_1) ? this.string_3[this.int_0] : '\0');
		}

		private void method_53()
		{
			if (this.int_0 < this.int_1)
			{
				this.int_0++;
			}
			this.char_0 = ((this.int_0 < this.int_1) ? this.string_3[this.int_0] : '\0');
		}

		private void method_54()
		{
			while (char.IsWhiteSpace(this.char_0))
			{
				this.method_53();
			}
			int num = this.int_0;
			char c = this.char_0;
			Class6.Enum1 enum1_;
			switch (c)
			{
			case '!':
				this.method_53();
				if (this.char_0 == '=')
				{
					this.method_53();
					enum1_ = (Class6.Enum1)25;
					goto IL_47B;
				}
				enum1_ = (Class6.Enum1)6;
				goto IL_47B;
			case '"':
			case '\'':
			{
				char c2 = this.char_0;
				while (true)
				{
					this.method_53();
					while (this.int_0 < this.int_1 && this.char_0 != c2)
					{
						this.method_53();
					}
					if (this.int_0 == this.int_1)
					{
						break;
					}
					this.method_53();
					if (this.char_0 != c2)
					{
						goto IL_1E6;
					}
				}
				throw this.method_61(this.int_0, "Unterminated string literal", new object[0]);
				IL_1E6:
				enum1_ = (Class6.Enum1)3;
				goto IL_47B;
			}
			case '#':
			case '$':
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case ';':
				break;
			case '%':
				this.method_53();
				enum1_ = (Class6.Enum1)7;
				goto IL_47B;
			case '&':
				this.method_53();
				if (this.char_0 == '&')
				{
					this.method_53();
					enum1_ = (Class6.Enum1)26;
					goto IL_47B;
				}
				enum1_ = (Class6.Enum1)8;
				goto IL_47B;
			case '(':
				this.method_53();
				enum1_ = (Class6.Enum1)9;
				goto IL_47B;
			case ')':
				this.method_53();
				enum1_ = (Class6.Enum1)10;
				goto IL_47B;
			case '*':
				this.method_53();
				enum1_ = (Class6.Enum1)11;
				goto IL_47B;
			case '+':
				this.method_53();
				enum1_ = (Class6.Enum1)12;
				goto IL_47B;
			case ',':
				this.method_53();
				enum1_ = (Class6.Enum1)13;
				goto IL_47B;
			case '-':
				this.method_53();
				enum1_ = (Class6.Enum1)14;
				goto IL_47B;
			case '.':
				this.method_53();
				enum1_ = (Class6.Enum1)15;
				goto IL_47B;
			case '/':
				this.method_53();
				enum1_ = (Class6.Enum1)16;
				goto IL_47B;
			case ':':
				this.method_53();
				enum1_ = (Class6.Enum1)17;
				goto IL_47B;
			case '<':
				this.method_53();
				if (this.char_0 == '=')
				{
					this.method_53();
					enum1_ = (Class6.Enum1)27;
					goto IL_47B;
				}
				if (this.char_0 == '>')
				{
					this.method_53();
					enum1_ = (Class6.Enum1)28;
					goto IL_47B;
				}
				enum1_ = (Class6.Enum1)18;
				goto IL_47B;
			case '=':
				this.method_53();
				if (this.char_0 == '=')
				{
					this.method_53();
					enum1_ = (Class6.Enum1)29;
					goto IL_47B;
				}
				enum1_ = (Class6.Enum1)19;
				goto IL_47B;
			case '>':
				this.method_53();
				if (this.char_0 == '=')
				{
					this.method_53();
					enum1_ = (Class6.Enum1)30;
					goto IL_47B;
				}
				enum1_ = (Class6.Enum1)20;
				goto IL_47B;
			case '?':
				this.method_53();
				enum1_ = (Class6.Enum1)21;
				goto IL_47B;
			default:
				switch (c)
				{
				case '[':
					this.method_53();
					enum1_ = (Class6.Enum1)22;
					goto IL_47B;
				case '\\':
					break;
				case ']':
					this.method_53();
					enum1_ = (Class6.Enum1)23;
					goto IL_47B;
				default:
					if (c == '|')
					{
						this.method_53();
						if (this.char_0 == '|')
						{
							this.method_53();
							enum1_ = (Class6.Enum1)31;
							goto IL_47B;
						}
						enum1_ = (Class6.Enum1)24;
						goto IL_47B;
					}
					break;
				}
				break;
			}
			if (char.IsLetter(this.char_0) || this.char_0 == '@' || this.char_0 == '_')
			{
				do
				{
					this.method_53();
				}
				while (char.IsLetterOrDigit(this.char_0) || this.char_0 == '_');
				enum1_ = (Class6.Enum1)2;
			}
			else if (char.IsDigit(this.char_0))
			{
				enum1_ = (Class6.Enum1)4;
				do
				{
					this.method_53();
				}
				while (char.IsDigit(this.char_0));
				if (this.char_0 == '.')
				{
					enum1_ = (Class6.Enum1)5;
					this.method_53();
					this.method_57();
					do
					{
						this.method_53();
					}
					while (char.IsDigit(this.char_0));
				}
				if (this.char_0 == 'E' || this.char_0 == 'e')
				{
					enum1_ = (Class6.Enum1)5;
					this.method_53();
					if (this.char_0 == '+' || this.char_0 == '-')
					{
						this.method_53();
					}
					this.method_57();
					do
					{
						this.method_53();
					}
					while (char.IsDigit(this.char_0));
				}
				if (this.char_0 == 'F' || this.char_0 == 'f')
				{
					this.method_53();
				}
			}
			else
			{
				if (this.int_0 != this.int_1)
				{
					throw this.method_61(this.int_0, "Syntax error '{0}'", new object[]
					{
						this.char_0
					});
				}
				enum1_ = (Class6.Enum1)1;
			}
			IL_47B:
			this.struct0_0.enum1_0 = enum1_;
			this.struct0_0.string_0 = this.string_3.Substring(num, this.int_0 - num);
			this.struct0_0.int_0 = num;
		}

		private bool method_55(string string_4)
		{
			return this.struct0_0.enum1_0 == (Class6.Enum1)2 && string.Equals(string_4, this.struct0_0.string_0, StringComparison.OrdinalIgnoreCase);
		}

		private string method_56()
		{
			this.method_58((Class6.Enum1)2, "Identifier expected");
			string text = this.struct0_0.string_0;
			if (text.Length > 1 && text[0] == '@')
			{
				text = text.Substring(1);
			}
			return text;
		}

		private void method_57()
		{
			if (!char.IsDigit(this.char_0))
			{
				throw this.method_61(this.int_0, "Digit expected", new object[0]);
			}
		}

		private void method_58(Class6.Enum1 enum1_0, string string_4)
		{
			if (this.struct0_0.enum1_0 != enum1_0)
			{
				throw this.method_60(string_4, new object[0]);
			}
		}

		private void method_59(Class6.Enum1 enum1_0)
		{
			if (this.struct0_0.enum1_0 != enum1_0)
			{
				throw this.method_60("Syntax error", new object[0]);
			}
		}

		private Exception method_60(string string_4, params object[] args)
		{
			return this.method_61(this.struct0_0.int_0, string_4, args);
		}

		private Exception method_61(int int_2, string string_4, params object[] args)
		{
			return new ParseException(string.Format(CultureInfo.CurrentCulture, string_4, args), int_2);
		}

		private static Dictionary<string, object> smethod_18()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
			dictionary.Add("true", Class6.expression_0);
			dictionary.Add("false", Class6.expression_1);
			dictionary.Add("null", Class6.expression_2);
			dictionary.Add(Class6.string_0, Class6.string_0);
			dictionary.Add(Class6.string_1, Class6.string_1);
			dictionary.Add(Class6.string_2, Class6.string_2);
			Type[] array = Class6.type_0;
			for (int i = 0; i < array.Length; i++)
			{
				Type type = array[i];
				dictionary.Add(type.Name, type);
			}
			return dictionary;
		}

		[CompilerGenerated]
		private static MethodBase smethod_19(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.GetGetMethod();
		}

		[CompilerGenerated]
		private static bool smethod_20(MethodBase methodBase_0)
		{
			return methodBase_0 != null;
		}

		[CompilerGenerated]
		private static Class6.Class7 smethod_21(MethodBase methodBase_0)
		{
			return new Class6.Class7
			{
				methodBase_0 = methodBase_0,
				parameterInfo_0 = methodBase_0.GetParameters()
			};
		}

		static Class6()
		{
			Class6.type_0 = new Type[]
			{
				typeof(object),
				typeof(bool),
				typeof(char),
				typeof(string),
				typeof(sbyte),
				typeof(byte),
				typeof(short),
				typeof(ushort),
				typeof(int),
				typeof(uint),
				typeof(long),
				typeof(ulong),
				typeof(float),
				typeof(double),
				typeof(decimal),
				typeof(DateTime),
				typeof(TimeSpan),
				typeof(Guid),
				typeof(Math),
				typeof(Convert)
			};
			Class6.expression_0 = Expression.Constant(true);
			Class6.expression_1 = Expression.Constant(false);
			Class6.expression_2 = Expression.Constant(null);
			Class6.string_0 = "it";
			Class6.string_1 = "iif";
			Class6.string_2 = "new";
		}
	}
}
