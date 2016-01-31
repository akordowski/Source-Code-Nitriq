using System;
using System.Collections.Generic;
using System.Linq.Dynamic;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace ns0
{
	internal class Class5
	{
		public static readonly Class5 class5_0;

		private ModuleBuilder moduleBuilder_0;

		private Dictionary<Class4, Type> dictionary_0;

		private int int_0;

		private ReaderWriterLock readerWriterLock_0;

		static Class5()
		{
			Class5.class5_0 = new Class5();
		}

		private Class5()
		{
			AssemblyName name = new AssemblyName("DynamicClasses");
			AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(name, AssemblyBuilderAccess.Run);
			try
			{
				this.moduleBuilder_0 = assemblyBuilder.DefineDynamicModule("Module");
			}
			finally
			{
			}
			this.dictionary_0 = new Dictionary<Class4, Type>();
			this.readerWriterLock_0 = new ReaderWriterLock();
		}

		public Type method_0(IEnumerable<DynamicProperty> properties)
		{
			this.readerWriterLock_0.AcquireReaderLock(-1);
			Type result;
			try
			{
				Class4 @class = new Class4(properties);
				Type type;
				if (!this.dictionary_0.TryGetValue(@class, out type))
				{
					type = this.method_1(@class.dynamicProperty_0);
					this.dictionary_0.Add(@class, type);
				}
				result = type;
			}
			finally
			{
				this.readerWriterLock_0.ReleaseReaderLock();
			}
			return result;
		}

		private Type method_1(DynamicProperty[] dynamicProperty_0)
		{
			LockCookie lockCookie = this.readerWriterLock_0.UpgradeToWriterLock(-1);
			Type result;
			try
			{
				string name = "DynamicClass" + (this.int_0 + 1);
				try
				{
					TypeBuilder typeBuilder = this.moduleBuilder_0.DefineType(name, TypeAttributes.Public, typeof(DynamicClass));
					FieldInfo[] fieldInfo_ = this.method_2(typeBuilder, dynamicProperty_0);
					this.method_3(typeBuilder, fieldInfo_);
					this.method_4(typeBuilder, fieldInfo_);
					Type type = typeBuilder.CreateType();
					this.int_0++;
					result = type;
				}
				finally
				{
				}
			}
			finally
			{
				this.readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
			}
			return result;
		}

		private FieldInfo[] method_2(TypeBuilder typeBuilder_0, DynamicProperty[] dynamicProperty_0)
		{
			FieldInfo[] array = new FieldBuilder[dynamicProperty_0.Length];
			for (int i = 0; i < dynamicProperty_0.Length; i++)
			{
				DynamicProperty dynamicProperty = dynamicProperty_0[i];
				FieldBuilder fieldBuilder = typeBuilder_0.DefineField("_" + dynamicProperty.Name, dynamicProperty.Type, FieldAttributes.Private);
				PropertyBuilder propertyBuilder = typeBuilder_0.DefineProperty(dynamicProperty.Name, PropertyAttributes.HasDefault, dynamicProperty.Type, null);
				MethodBuilder methodBuilder = typeBuilder_0.DefineMethod("get_" + dynamicProperty.Name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.HideBySig | MethodAttributes.SpecialName, dynamicProperty.Type, Type.EmptyTypes);
				ILGenerator iLGenerator = methodBuilder.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				iLGenerator.Emit(OpCodes.Ldfld, fieldBuilder);
				iLGenerator.Emit(OpCodes.Ret);
				MethodBuilder methodBuilder2 = typeBuilder_0.DefineMethod("set_" + dynamicProperty.Name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.HideBySig | MethodAttributes.SpecialName, null, new Type[]
				{
					dynamicProperty.Type
				});
				ILGenerator iLGenerator2 = methodBuilder2.GetILGenerator();
				iLGenerator2.Emit(OpCodes.Ldarg_0);
				iLGenerator2.Emit(OpCodes.Ldarg_1);
				iLGenerator2.Emit(OpCodes.Stfld, fieldBuilder);
				iLGenerator2.Emit(OpCodes.Ret);
				propertyBuilder.SetGetMethod(methodBuilder);
				propertyBuilder.SetSetMethod(methodBuilder2);
				array[i] = fieldBuilder;
			}
			return array;
		}

		private void method_3(TypeBuilder typeBuilder_0, FieldInfo[] fieldInfo_0)
		{
			MethodBuilder methodBuilder = typeBuilder_0.DefineMethod("Equals", MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig, typeof(bool), new Type[]
			{
				typeof(object)
			});
			ILGenerator iLGenerator = methodBuilder.GetILGenerator();
			LocalBuilder local = iLGenerator.DeclareLocal(typeBuilder_0);
			Label label = iLGenerator.DefineLabel();
			iLGenerator.Emit(OpCodes.Ldarg_1);
			iLGenerator.Emit(OpCodes.Isinst, typeBuilder_0);
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.Emit(OpCodes.Ldloc, local);
			iLGenerator.Emit(OpCodes.Brtrue_S, label);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Ret);
			iLGenerator.MarkLabel(label);
			for (int i = 0; i < fieldInfo_0.Length; i++)
			{
				FieldInfo fieldInfo = fieldInfo_0[i];
				Type fieldType = fieldInfo.FieldType;
				Type type = typeof(EqualityComparer<>).MakeGenericType(new Type[]
				{
					fieldType
				});
				label = iLGenerator.DefineLabel();
				iLGenerator.EmitCall(OpCodes.Call, type.GetMethod("get_Default"), null);
				iLGenerator.Emit(OpCodes.Ldarg_0);
				iLGenerator.Emit(OpCodes.Ldfld, fieldInfo);
				iLGenerator.Emit(OpCodes.Ldloc, local);
				iLGenerator.Emit(OpCodes.Ldfld, fieldInfo);
				iLGenerator.EmitCall(OpCodes.Callvirt, type.GetMethod("Equals", new Type[]
				{
					fieldType,
					fieldType
				}), null);
				iLGenerator.Emit(OpCodes.Brtrue_S, label);
				iLGenerator.Emit(OpCodes.Ldc_I4_0);
				iLGenerator.Emit(OpCodes.Ret);
				iLGenerator.MarkLabel(label);
			}
			iLGenerator.Emit(OpCodes.Ldc_I4_1);
			iLGenerator.Emit(OpCodes.Ret);
		}

		private void method_4(TypeBuilder typeBuilder_0, FieldInfo[] fieldInfo_0)
		{
			MethodBuilder methodBuilder = typeBuilder_0.DefineMethod("GetHashCode", MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig, typeof(int), Type.EmptyTypes);
			ILGenerator iLGenerator = methodBuilder.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			for (int i = 0; i < fieldInfo_0.Length; i++)
			{
				FieldInfo fieldInfo = fieldInfo_0[i];
				Type fieldType = fieldInfo.FieldType;
				Type type = typeof(EqualityComparer<>).MakeGenericType(new Type[]
				{
					fieldType
				});
				iLGenerator.EmitCall(OpCodes.Call, type.GetMethod("get_Default"), null);
				iLGenerator.Emit(OpCodes.Ldarg_0);
				iLGenerator.Emit(OpCodes.Ldfld, fieldInfo);
				iLGenerator.EmitCall(OpCodes.Callvirt, type.GetMethod("GetHashCode", new Type[]
				{
					fieldType
				}), null);
				iLGenerator.Emit(OpCodes.Xor);
			}
			iLGenerator.Emit(OpCodes.Ret);
		}
	}
}
