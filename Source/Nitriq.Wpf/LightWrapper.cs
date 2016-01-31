using Nitriq.Analysis.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Nitriq.Wpf
{
	public class LightWrapper
	{
		private LightCollection<LightAssembly> lightCollection_0 = new LightCollection<LightAssembly>(new LightAssembly.Comparer());

		private LightCollection<LightNamespace> lightCollection_1 = new LightCollection<LightNamespace>(new LightNamespace.Comparer());

		private LightCollection<LightType> lightCollection_2 = new LightCollection<LightType>(new LightType.Comparer());

		private LightCollection<object> lightCollection_3 = new LightCollection<object>();

		private string string_0;

		[CompilerGenerated]
		private static Func<PropertyInfo, bool> func_0;

		[CompilerGenerated]
		private static Comparison<LightAssembly> comparison_0;

		[CompilerGenerated]
		private static Comparison<LightNamespace> comparison_1;

		[CompilerGenerated]
		private static Comparison<LightType> comparison_2;

		[CompilerGenerated]
		private static Comparison<LightNamespace> comparison_3;

		[CompilerGenerated]
		private static Comparison<LightType> comparison_4;

		[CompilerGenerated]
		private static Comparison<LightType> comparison_5;

		public LightCollection<LightAssembly> Assemblies
		{
			get
			{
				return this.lightCollection_0;
			}
		}

		public LightCollection<LightNamespace> Namespaces
		{
			get
			{
				return this.lightCollection_1;
			}
		}

		public LightCollection<LightType> Types
		{
			get
			{
				return this.lightCollection_2;
			}
		}

		public LightCollection<object> TypesChildren
		{
			get
			{
				return this.lightCollection_3;
			}
		}

		public string LeafType
		{
			get
			{
				return this.string_0;
			}
		}

		public LightWrapper(IEnumerable results, BfCache cache)
		{
			if (results == null)
			{
				Console.WriteLine("no results");
			}
			else
			{
				object obj = results.OfType<object>().FirstOrDefault<object>();
				if (obj == null)
				{
					Console.WriteLine("results are empty");
				}
				else
				{
					IEnumerable<PropertyInfo> arg_A8_0 = obj.GetType().GetProperties();
					if (LightWrapper.func_0 == null)
					{
						LightWrapper.func_0 = new Func<PropertyInfo, bool>(LightWrapper.smethod_0);
					}
					PropertyInfo propertyInfo = arg_A8_0.FirstOrDefault(LightWrapper.func_0);
					if (propertyInfo != null)
					{
						Dictionary<int, object> idToLeaf = new Dictionary<int, object>();
						foreach (object current in results)
						{
							int key = (int)propertyInfo.GetGetMethod().Invoke(current, null);
							if (!idToLeaf.ContainsKey(key))
							{
								idToLeaf.Add(key, current);
							}
						}
						if (string.Compare(propertyInfo.Name, "MethodId", true) == 0)
						{
							var enumerable = from method in cache.Methods
							where idToLeaf.ContainsKey(method.MethodId)
							select new
							{
								Type = method.Type,
								Assembly = method.Type.Assembly,
								Namespace = method.Type.Namespace,
								Leaf = idToLeaf[method.MethodId]
							};
							string childType = "Method";
							foreach (var current2 in enumerable)
							{
								LightAssembly lightAssembly = new LightAssembly(current2.Assembly, childType);
								lightAssembly = this.Assemblies.method_2(lightAssembly);
								LightNamespace lightNamespace = new LightNamespace(current2.Namespace, childType);
								lightNamespace = lightAssembly.Namespaces.method_2(lightNamespace);
								LightNamespace lightNamespace2 = new LightNamespace(current2.Namespace, childType);
								lightNamespace2 = this.Namespaces.method_2(lightNamespace2);
								LightType lightType = new LightType(current2.Type, childType);
								lightType = this.Types.method_2(lightType);
								lightNamespace.Types.method_2(lightType);
								lightNamespace2.Types.method_2(lightType);
								lightType.Children.method_2(current2.Leaf);
								this.TypesChildren.method_2(current2.Leaf);
							}
						}
						if (string.Compare(propertyInfo.Name, "FieldId", true) == 0)
						{
							var enumerable = from field in cache.Fields
							where idToLeaf.ContainsKey(field.FieldId)
							select new
							{
								Type = field.Type,
								Assembly = field.Type.Assembly,
								Namespace = field.Type.Namespace,
								Leaf = idToLeaf[field.FieldId]
							};
							string childType = "Field";
							foreach (var current2 in enumerable)
							{
								LightAssembly lightAssembly = new LightAssembly(current2.Assembly, childType);
								lightAssembly = this.Assemblies.method_2(lightAssembly);
								LightNamespace lightNamespace = new LightNamespace(current2.Namespace, childType);
								lightNamespace = lightAssembly.Namespaces.method_2(lightNamespace);
								LightNamespace lightNamespace2 = new LightNamespace(current2.Namespace, childType);
								lightNamespace2 = this.Namespaces.method_2(lightNamespace2);
								LightType lightType = new LightType(current2.Type, childType);
								lightType = this.Types.method_2(lightType);
								lightNamespace.Types.method_2(lightType);
								lightNamespace2.Types.method_2(lightType);
								lightType.Children.method_2(current2.Leaf);
								this.TypesChildren.method_2(current2.Leaf);
							}
						}
						if (string.Compare(propertyInfo.Name, "EventId", true) == 0)
						{
							var enumerable = from ev in cache.Events
							where idToLeaf.ContainsKey(ev.EventId)
							select new
							{
								Type = ev.Type,
								Assembly = ev.Type.Assembly,
								Namespace = ev.Type.Namespace,
								Leaf = idToLeaf[ev.EventId]
							};
							string childType = "Event";
							foreach (var current2 in enumerable)
							{
								LightAssembly lightAssembly = new LightAssembly(current2.Assembly, childType);
								lightAssembly = this.Assemblies.method_2(lightAssembly);
								LightNamespace lightNamespace = new LightNamespace(current2.Namespace, childType);
								lightNamespace = lightAssembly.Namespaces.method_2(lightNamespace);
								LightNamespace lightNamespace2 = new LightNamespace(current2.Namespace, childType);
								lightNamespace2 = this.Namespaces.method_2(lightNamespace2);
								LightType lightType = new LightType(current2.Type, childType);
								lightType = this.Types.method_2(lightType);
								lightNamespace.Types.method_2(lightType);
								lightNamespace2.Types.method_2(lightType);
								lightType.Children.method_2(current2.Leaf);
								this.TypesChildren.method_2(current2.Leaf);
							}
						}
						if (string.Compare(propertyInfo.Name, "TypeId", true) == 0)
						{
							var enumerable2 = from type in cache.Types
							where idToLeaf.ContainsKey(type.TypeId)
							select new
							{
								type = type,
								Assembly = type.Assembly,
								Namespace = type.Namespace,
								Leaf = idToLeaf[type.TypeId]
							};
							string childType = "Type";
							foreach (var current3 in enumerable2)
							{
								LightAssembly lightAssembly = new LightAssembly(current3.Assembly, childType);
								lightAssembly = this.Assemblies.method_2(lightAssembly);
								LightNamespace lightNamespace = new LightNamespace(current3.Namespace, childType);
								lightNamespace = lightAssembly.Namespaces.method_2(lightNamespace);
								LightNamespace lightNamespace2 = new LightNamespace(current3.Namespace, childType);
								lightNamespace2 = this.Namespaces.method_2(lightNamespace2);
								LightType lightType = new LightType(current3.type, childType);
								lightType = this.Types.method_2(lightType);
								lightNamespace.Types.method_2(lightType);
								lightNamespace2.Types.method_2(lightType);
								lightNamespace.Children.method_2(current3.Leaf);
								lightNamespace2.Children.method_2(current3.Leaf);
								this.TypesChildren.method_2(current3.Leaf);
							}
						}
						if (string.Compare(propertyInfo.Name, "NamespaceId", true) == 0)
						{
							var enumerable3 = from nspace in cache.Namespaces
							where idToLeaf.ContainsKey(nspace.NamespaceId)
							select new
							{
								nspace = nspace,
								Leaf = idToLeaf[nspace.NamespaceId]
							};
							string childType = "GeneralNamespace";
							foreach (var current4 in enumerable3)
							{
								LightNamespace lightNamespace2 = new LightNamespace(current4.nspace, childType);
								lightNamespace2 = this.Namespaces.method_2(lightNamespace2);
								lightNamespace2.Children.method_2(current4.Leaf);
							}
						}
						if (string.Compare(propertyInfo.Name, "AssemblyId", true) == 0)
						{
							var enumerable4 = from assembly in cache.Assemblies
							where idToLeaf.ContainsKey(assembly.AssemblyId)
							select new
							{
								assembly = assembly,
								Leaf = idToLeaf[assembly.AssemblyId]
							};
							string childType = "Assembly";
							foreach (var current5 in enumerable4)
							{
								LightAssembly lightAssembly2 = new LightAssembly(current5.assembly, childType);
								this.Assemblies.method_2(lightAssembly2);
								lightAssembly2.Children.method_2(current5.Leaf);
							}
						}
					}
					LightCollection<LightAssembly> arg_863_0 = this.lightCollection_0;
					if (LightWrapper.comparison_0 == null)
					{
						LightWrapper.comparison_0 = new Comparison<LightAssembly>(LightWrapper.smethod_1);
					}
					arg_863_0.method_1(LightWrapper.comparison_0);
					foreach (LightAssembly lightAssembly in ((IEnumerable<LightAssembly>)this.lightCollection_0))
					{
						LightAssembly lightAssembly;
						LightCollection<LightNamespace> arg_8A8_0 = lightAssembly.Namespaces;
						if (LightWrapper.comparison_1 == null)
						{
							LightWrapper.comparison_1 = new Comparison<LightNamespace>(LightWrapper.smethod_2);
						}
						arg_8A8_0.method_1(LightWrapper.comparison_1);
						foreach (LightNamespace current6 in ((IEnumerable<LightNamespace>)lightAssembly.Namespaces))
						{
							LightCollection<LightType> arg_8EB_0 = current6.Types;
							if (LightWrapper.comparison_2 == null)
							{
								LightWrapper.comparison_2 = new Comparison<LightType>(LightWrapper.smethod_3);
							}
							arg_8EB_0.method_1(LightWrapper.comparison_2);
						}
					}
					LightCollection<LightNamespace> arg_94A_0 = this.lightCollection_1;
					if (LightWrapper.comparison_3 == null)
					{
						LightWrapper.comparison_3 = new Comparison<LightNamespace>(LightWrapper.smethod_4);
					}
					arg_94A_0.method_1(LightWrapper.comparison_3);
					foreach (LightNamespace current6 in ((IEnumerable<LightNamespace>)this.lightCollection_1))
					{
						LightCollection<LightType> arg_98C_0 = current6.Types;
						if (LightWrapper.comparison_4 == null)
						{
							LightWrapper.comparison_4 = new Comparison<LightType>(LightWrapper.smethod_5);
						}
						arg_98C_0.method_1(LightWrapper.comparison_4);
					}
					LightCollection<LightType> arg_9CE_0 = this.lightCollection_2;
					if (LightWrapper.comparison_5 == null)
					{
						LightWrapper.comparison_5 = new Comparison<LightType>(LightWrapper.smethod_6);
					}
					arg_9CE_0.method_1(LightWrapper.comparison_5);
				}
			}
		}

		[CompilerGenerated]
		private static bool smethod_0(PropertyInfo propertyInfo_0)
		{
			return (string.Compare(propertyInfo_0.Name, "MethodId", true) == 0 || string.Compare(propertyInfo_0.Name, "FieldId", true) == 0 || string.Compare(propertyInfo_0.Name, "EventId", true) == 0 || string.Compare(propertyInfo_0.Name, "TypeId", true) == 0 || string.Compare(propertyInfo_0.Name, "NamespaceId", true) == 0 || string.Compare(propertyInfo_0.Name, "AssemblyId", true) == 0) && propertyInfo_0.PropertyType == typeof(int);
		}

		[CompilerGenerated]
		private static int smethod_1(LightAssembly lightAssembly_0, LightAssembly lightAssembly_1)
		{
			return lightAssembly_0.Name.CompareTo(lightAssembly_1.Name);
		}

		[CompilerGenerated]
		private static int smethod_2(LightNamespace lightNamespace_0, LightNamespace lightNamespace_1)
		{
			return lightNamespace_0.Name.CompareTo(lightNamespace_1.Name);
		}

		[CompilerGenerated]
		private static int smethod_3(LightType lightType_0, LightType lightType_1)
		{
			return lightType_0.Name.CompareTo(lightType_1.Name);
		}

		[CompilerGenerated]
		private static int smethod_4(LightNamespace lightNamespace_0, LightNamespace lightNamespace_1)
		{
			return lightNamespace_0.Name.CompareTo(lightNamespace_1.Name);
		}

		[CompilerGenerated]
		private static int smethod_5(LightType lightType_0, LightType lightType_1)
		{
			return lightType_0.Name.CompareTo(lightType_1.Name);
		}

		[CompilerGenerated]
		private static int smethod_6(LightType lightType_0, LightType lightType_1)
		{
			return lightType_0.Name.CompareTo(lightType_1.Name);
		}
	}
}
