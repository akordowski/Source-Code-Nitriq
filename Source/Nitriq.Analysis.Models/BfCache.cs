using Microsoft.Win32;
using Mono.Cecil;
using Mono.Cecil.Binary;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Nitriq.Analysis.Models
{
	[Serializable]
	public class BfCache
	{
		[NonSerialized]
		private SortedDictionary<string, BfField> sortedDictionary_0 = new SortedDictionary<string, BfField>();

		private Dictionary<string, BfAssembly> dictionary_0 = new Dictionary<string, BfAssembly>();

		private Dictionary<string, BfAssembly> dictionary_1 = new Dictionary<string, BfAssembly>();

		private SortedDictionary<string, BfNamespace> sortedDictionary_1 = new SortedDictionary<string, BfNamespace>();

		private Dictionary<string, File> dictionary_2 = new Dictionary<string, File>(StringComparer.InvariantCultureIgnoreCase);

		private static List<string> list_0;

		private AssemblyCollection assemblyCollection_0 = new AssemblyCollection();

		private NamespaceCollection namespaceCollection_0 = new NamespaceCollection();

		private TypeCollection typeCollection_0 = new TypeCollection();

		private MethodCollection methodCollection_0 = new MethodCollection();

		private FieldCollection fieldCollection_0 = new FieldCollection();

		private EventCollection eventCollection_0 = new EventCollection();

		private int int_0 = 0;

		private int int_1 = 0;

		private int int_2 = 0;

		private int int_3 = 0;

		private int int_4 = 0;

		private int int_5 = 0;

		private int int_6 = 0;

		private int int_7 = 0;

		[CompilerGenerated]
		private static Func<BfType, bool> func_0;

		[CompilerGenerated]
		private static Func<BfAssembly, bool> func_1;

		[CompilerGenerated]
		private static Func<BfAssembly, bool> func_2;

		[CompilerGenerated]
		private static Func<BfType, bool> func_3;

		public AssemblyCollection Assemblies
		{
			get
			{
				return this.assemblyCollection_0;
			}
		}

		public NamespaceCollection Namespaces
		{
			get
			{
				return this.namespaceCollection_0;
			}
		}

		public TypeCollection Types
		{
			get
			{
				return this.typeCollection_0;
			}
		}

		public MethodCollection Methods
		{
			get
			{
				return this.methodCollection_0;
			}
		}

		public FieldCollection Fields
		{
			get
			{
				return this.fieldCollection_0;
			}
		}

		public EventCollection Events
		{
			get
			{
				return this.eventCollection_0;
			}
		}

		private BfCache()
		{
		}

		internal BfCache(Dictionary<string, AssemblyTuple> nameToAssemblyTuple)
		{
			new HashSet<AssemblyDefinition>();
			this.method_0(nameToAssemblyTuple);
			Logger.LogInfo("Done Loading Assemblies");
			this.assemblyCollection_0.method_2(new HashSet<BfAssembly>(this.dictionary_0.Values));
			int i = 0;
			while (i < this.typeCollection_0.Count)
			{
				BfType bfType = this.typeCollection_0[i];
				if (bfType.Name == "<Module>")
				{
					i++;
				}
				else
				{
					bfType.method_4();
					this.methodCollection_0.method_2(bfType.Methods);
					this.eventCollection_0.method_2(bfType.Events);
					this.fieldCollection_0.method_2(bfType.Fields);
					i++;
				}
			}
			for (i = 0; i < this.typeCollection_0.Count; i++)
			{
				BfType bfType = this.typeCollection_0[i];
				foreach (BfMethod current in ((IEnumerable<BfMethod>)bfType.Methods))
				{
					current.method_4();
				}
			}
			foreach (BfType bfType in ((IEnumerable<BfType>)this.typeCollection_0))
			{
				BfType bfType;
				bfType.method_5();
			}
			foreach (BfType bfType in ((IEnumerable<BfType>)this.typeCollection_0))
			{
				BfType bfType;
				bfType.method_1();
			}
			foreach (BfAssembly current2 in ((IEnumerable<BfAssembly>)this.assemblyCollection_0))
			{
				current2.method_1();
			}
			this.method_14();
			this.method_1();
			Logger.LogInfo("Done Loading Types");
			this.method_10();
			BaseCollection<BfType>.ClearAllHashes();
			BaseCollection<BfAssembly>.ClearAllHashes();
			BaseCollection<BfMethod>.ClearAllHashes();
			BaseCollection<BfNamespace>.ClearAllHashes();
			BaseCollection<BfField>.ClearAllHashes();
			BaseCollection<BfEvent>.ClearAllHashes();
			this.method_9();
			this.sortedDictionary_0 = null;
			this.dictionary_0 = null;
			this.dictionary_1 = null;
			this.sortedDictionary_1 = null;
			this.dictionary_2 = null;
			GC.Collect();
		}

		static BfCache()
		{
			BfCache.list_0 = new List<string>();
		}

		private static void smethod_0(string string_0)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_0);
			if (registryKey != null)
			{
				string text = (string)registryKey.GetValue("");
				if (!string.IsNullOrEmpty(text))
				{
					BfCache.list_0.Add(text);
				}
			}
		}

		private void method_0(Dictionary<string, AssemblyTuple> nameToAssemblyTuples)
		{
			Dictionary<AssemblyDefinition, BfAssembly> dictionary = new Dictionary<AssemblyDefinition, BfAssembly>();
			foreach (AssemblyTuple assemblyTuple in nameToAssemblyTuples.Values)
			{
				AssemblyTuple assemblyTuple;
				if (!dictionary.ContainsKey(assemblyTuple.Assembly))
				{
					BfAssembly bfAssembly = new BfAssembly(this, assemblyTuple.Assembly, assemblyTuple.IsCoreAssembly, assemblyTuple.Directory);
					dictionary.Add(assemblyTuple.Assembly, bfAssembly);
					foreach (ModuleDefinition moduleDefinition in assemblyTuple.Assembly.Modules)
					{
						if (!this.dictionary_1.ContainsKey(moduleDefinition.Name))
						{
							this.dictionary_1.Add(moduleDefinition.Name, bfAssembly);
						}
						if (assemblyTuple.IsCoreAssembly)
						{
							foreach (TypeDefinition typeDefinition_ in moduleDefinition.Types)
							{
								this.method_12(typeDefinition_, bfAssembly);
							}
						}
					}
				}
			}
			foreach (string current in nameToAssemblyTuples.Keys)
			{
				AssemblyTuple assemblyTuple = nameToAssemblyTuples[current];
				AssemblyDefinition assembly = assemblyTuple.Assembly;
				this.dictionary_0.Add(current, dictionary[assembly]);
			}
		}

		internal static Dictionary<string, AssemblyTuple> smethod_1(IEnumerable<AssemblyFileInfo> coreAssemblyFiles)
		{
			Dictionary<string, AssemblyTuple> dictionary = new Dictionary<string, AssemblyTuple>();
			DefaultAssemblyResolver defaultAssemblyResolver = new DefaultAssemblyResolver();
			foreach (string current in BfCache.list_0)
			{
				if (Directory.Exists(current))
				{
					defaultAssemblyResolver.AddSearchDirectory(current);
				}
			}
			foreach (AssemblyFileInfo current2 in coreAssemblyFiles)
			{
				if (current2.Name == "Search Directory")
				{
					defaultAssemblyResolver.AddSearchDirectory(current2.Path);
				}
				else
				{
					string directoryName = Path.GetDirectoryName(current2.Path);
					defaultAssemblyResolver.AddSearchDirectory(directoryName);
				}
			}
			foreach (AssemblyFileInfo current2 in coreAssemblyFiles)
			{
				if (!(current2.Name == "Search Directory"))
				{
					AssemblyDefinition assembly;
					try
					{
						assembly = AssemblyFactory.GetAssembly(current2.Path);
					}
					catch (ImageFormatException)
					{
						throw new NitriqException("NotManagedAssembly", "The assembly \"" + current2.Name + "\" is not a managed assembly");
					}
					if (!dictionary.ContainsKey(assembly.Name.FullName))
					{
						AssemblyTuple assemblyTuple = new AssemblyTuple(assembly);
						assemblyTuple.IsCoreAssembly = true;
						assemblyTuple.Directory = Path.GetDirectoryName(current2.Path);
						dictionary.Add(assembly.Name.FullName, assemblyTuple);
					}
				}
			}
			List<AssemblyTuple> list = new List<AssemblyTuple>(dictionary.Values);
			foreach (AssemblyTuple current3 in list)
			{
				foreach (ModuleDefinition moduleDefinition in current3.Assembly.Modules)
				{
					foreach (AssemblyNameReference assemblyNameReference in moduleDefinition.AssemblyReferences)
					{
						AssemblyDefinition assemblyDefinition;
						try
						{
							assemblyDefinition = defaultAssemblyResolver.Resolve(assemblyNameReference);
						}
						catch (FileNotFoundException)
						{
							throw new NitriqException("CantResolve", "Nitriq couldn't resolve the below assembly, consider adding a search directory where this assembly can be found \r\n\r\n" + assemblyNameReference.FullName);
						}
						string fullName = assemblyNameReference.FullName;
						string fullName2 = assemblyDefinition.Name.FullName;
						if (fullName2 == fullName)
						{
							if (!dictionary.ContainsKey(fullName))
							{
								dictionary.Add(fullName, new AssemblyTuple(assemblyDefinition)
								{
									Directory = "",
									IsCoreAssembly = false
								});
							}
						}
						else if (dictionary.ContainsKey(fullName) || dictionary.ContainsKey(fullName2))
						{
							if (!dictionary.ContainsKey(fullName))
							{
								dictionary.Add(fullName, dictionary[fullName2]);
							}
							if (!dictionary.ContainsKey(fullName2))
							{
								dictionary.Add(fullName2, dictionary[fullName]);
							}
						}
						else
						{
							AssemblyTuple assemblyTuple2 = new AssemblyTuple(assemblyDefinition);
							assemblyTuple2.Directory = "";
							assemblyTuple2.IsCoreAssembly = false;
							dictionary.Add(fullName, assemblyTuple2);
							dictionary.Add(fullName2, assemblyTuple2);
						}
					}
				}
			}
			return dictionary;
		}

		private void method_1()
		{
			IEnumerable<BfType> arg_23_0 = this.Types;
			if (BfCache.func_0 == null)
			{
				BfCache.func_0 = new Func<BfType, bool>(BfCache.smethod_5);
			}
			BfType bfType = arg_23_0.Where(BfCache.func_0).FirstOrDefault<BfType>();
			if (bfType == null)
			{
				Logger.LogWarning("FindAndSetAllDelegates1", "Could not find System.Delegate Class");
			}
			else
			{
				this.method_2(bfType);
			}
		}

		private void method_2(BfType bfType_0)
		{
			bfType_0.IsDelegate = true;
			foreach (BfType current in ((IEnumerable<BfType>)bfType_0.DerivedTypes))
			{
				this.method_2(current);
			}
		}

		internal File method_3(Instruction instruction_0)
		{
			return this.method_4(instruction_0.SequencePoint.Document);
		}

		internal File method_4(Document document_0)
		{
			File result;
			if (!this.dictionary_2.ContainsKey(document_0.Url))
			{
				File file = new File(document_0);
				this.dictionary_2.Add(document_0.Url, file);
				result = file;
			}
			else
			{
				result = this.dictionary_2[document_0.Url];
			}
			return result;
		}

		internal BfMethod method_5(MethodReference methodReference_0)
		{
			BfAssembly bfAssembly;
			BfMethod result;
			if (methodReference_0.DeclaringType.Scope is AssemblyNameReference)
			{
				bfAssembly = this.dictionary_0[((AssemblyNameReference)methodReference_0.DeclaringType.Scope).FullName];
			}
			else
			{
				if (!(methodReference_0.DeclaringType.Scope is ModuleDefinition))
				{
					Logger.LogWarning("GetBfMethod1", "Couldn't find assembly for method: " + methodReference_0.ToString());
					result = null;
					return result;
				}
				bfAssembly = this.dictionary_0[((ModuleDefinition)methodReference_0.DeclaringType.Scope).Assembly.Name.FullName];
			}
			string text = BfMethod.smethod_0(methodReference_0);
			BfMethod bfMethod;
			bfAssembly.method_5().TryGetValue(text, out bfMethod);
			if (bfMethod == null)
			{
				BfType bfType = this.method_7(methodReference_0.DeclaringType);
				List<MethodDefinition> list = new List<MethodDefinition>();
				list.AddRange(bfType.method_2().Constructors.Cast<MethodDefinition>());
				list.AddRange(bfType.method_2().Methods.Cast<MethodDefinition>());
				foreach (MethodDefinition current in list)
				{
					if (text == BfMethod.smethod_0(current))
					{
						bfMethod = new BfMethod(this, current, bfType);
						this.methodCollection_0.method_1(bfMethod);
						bfType.Methods.method_1(bfMethod);
						bfAssembly.method_5().Add(bfMethod.UniqueName, bfMethod);
						break;
					}
				}
				if (bfMethod == null)
				{
					Logger.LogWarning("GetBfMethod2", "Couldn't find: " + text);
				}
			}
			result = bfMethod;
			return result;
		}

		internal BfField method_6(FieldReference fieldReference_0)
		{
			BfAssembly bfAssembly;
			BfField result;
			if (fieldReference_0.DeclaringType.Scope is AssemblyNameReference)
			{
				bfAssembly = this.dictionary_0[((AssemblyNameReference)fieldReference_0.DeclaringType.Scope).FullName];
			}
			else
			{
				if (!(fieldReference_0.DeclaringType.Scope is ModuleDefinition))
				{
					Logger.LogWarning("GetBfField1", "Couldn't find assembly for field: " + fieldReference_0.ToString());
					result = null;
					return result;
				}
				bfAssembly = this.dictionary_0[((ModuleDefinition)fieldReference_0.DeclaringType.Scope).Assembly.Name.FullName];
			}
			string key = BfCache.smethod_2(fieldReference_0.DeclaringType);
			BfType bfType;
			bfAssembly.method_4().TryGetValue(key, out bfType);
			if (bfType == null)
			{
				Logger.LogWarning("GetBfField2", "Couldn't find type for field: " + fieldReference_0.ToString());
				result = null;
			}
			else
			{
				foreach (BfField bfField in ((IEnumerable<BfField>)bfType.Fields))
				{
					BfField bfField;
					if (fieldReference_0.Name == bfField.Name)
					{
						result = bfField;
						return result;
					}
				}
				foreach (FieldDefinition fieldDefinition in bfType.method_2().Fields)
				{
					if (fieldDefinition.Name == fieldReference_0.Name)
					{
						BfField bfField = new BfField(this, fieldDefinition, bfType);
						this.fieldCollection_0.method_1(bfField);
						bfType.Fields.method_1(bfField);
						result = bfField;
						return result;
					}
				}
				Logger.LogWarning("GetBfField3", "Couldn't find field " + fieldReference_0.ToString() + " in type: " + bfType.FullName);
				result = null;
			}
			return result;
		}

		internal static string smethod_2(TypeReference typeReference_0)
		{
			typeReference_0 = BfCache.smethod_3(typeReference_0);
			return Regex.Replace(typeReference_0.FullName, "<[^>]+>", "");
		}

		internal static TypeReference smethod_3(TypeReference typeReference_0)
		{
			while (typeReference_0 is TypeSpecification)
			{
				typeReference_0 = ((TypeSpecification)typeReference_0).ElementType;
			}
			return typeReference_0;
		}

		internal BfType method_7(TypeReference typeReference_0)
		{
			BfType result;
			if (typeReference_0 == null)
			{
				result = null;
			}
			else
			{
				BfType bfType = null;
				typeReference_0 = BfCache.smethod_3(typeReference_0);
				if (typeReference_0 is GenericParameter)
				{
					IEnumerable<BfAssembly> arg_53_0 = this.dictionary_0.Values;
					if (BfCache.func_1 == null)
					{
						BfCache.func_1 = new Func<BfAssembly, bool>(BfCache.smethod_6);
					}
					BfAssembly bfAssembly = arg_53_0.Where(BfCache.func_1).FirstOrDefault<BfAssembly>();
					if (bfAssembly == null)
					{
						IEnumerable<BfAssembly> arg_8F_0 = this.dictionary_0.Values;
						if (BfCache.func_2 == null)
						{
							BfCache.func_2 = new Func<BfAssembly, bool>(BfCache.smethod_7);
						}
						bfAssembly = arg_8F_0.Where(BfCache.func_2).FirstOrDefault<BfAssembly>();
					}
					if (bfAssembly.method_4().ContainsKey(typeReference_0.FullName))
					{
						bfType = bfAssembly.method_4()[typeReference_0.FullName];
					}
					else
					{
						bfType = this.method_12(new TypeDefinition(typeReference_0.Name, typeReference_0.Namespace, TypeAttributes.Abstract, null), bfAssembly);
					}
					result = bfType;
				}
				else
				{
					BfAssembly bfAssembly2 = null;
					try
					{
						if (typeReference_0.Scope is AssemblyNameReference)
						{
							bfAssembly2 = this.dictionary_0[((AssemblyNameReference)typeReference_0.Scope).FullName];
						}
						else if (typeReference_0.Scope is ModuleDefinition)
						{
							bfAssembly2 = this.dictionary_0[((ModuleDefinition)typeReference_0.Scope).Assembly.Name.FullName];
						}
						else if (typeReference_0.Scope is ModuleReference)
						{
							bfAssembly2 = this.dictionary_1[((ModuleReference)typeReference_0.Scope).Name];
						}
					}
					catch (KeyNotFoundException)
					{
						throw new Exception("Could not find assembly: " + typeReference_0.Scope.ToString());
					}
					bfAssembly2.method_4().TryGetValue(BfCache.smethod_2(typeReference_0), out bfType);
					if (bfType == null)
					{
						foreach (ModuleDefinition moduleDefinition in bfAssembly2.method_3().Modules)
						{
							foreach (TypeDefinition typeDefinition in moduleDefinition.Types)
							{
								if (typeReference_0.FullName == typeDefinition.FullName)
								{
									bfType = this.method_12(typeDefinition, bfAssembly2);
									break;
								}
							}
						}
					}
					if (bfType != null)
					{
						result = bfType;
					}
					else
					{
						Logger.LogInfo("can't find: " + typeReference_0.FullName);
						result = null;
					}
				}
			}
			return result;
		}

		internal TypeCollection method_8(IGenericParameterProvider igenericParameterProvider_0)
		{
			TypeCollection typeCollection = new TypeCollection();
			foreach (GenericParameter genericParameter in igenericParameterProvider_0.GenericParameters)
			{
				typeCollection.method_1(this.method_7(genericParameter));
				typeCollection.method_2(this.method_8(genericParameter));
			}
			return typeCollection;
		}

		private void method_9()
		{
			for (int i = 0; i < this.Assemblies.Count; i++)
			{
				this.assemblyCollection_0[i].AssemblyId = i;
			}
			for (int i = 0; i < this.Namespaces.Count; i++)
			{
				this.namespaceCollection_0[i].NamespaceId = i;
			}
			for (int i = 0; i < this.Types.Count; i++)
			{
				this.typeCollection_0[i].TypeId = i;
			}
			for (int i = 0; i < this.Methods.Count; i++)
			{
				this.methodCollection_0[i].Id = i;
			}
			for (int i = 0; i < this.Fields.Count; i++)
			{
				this.fieldCollection_0[i].Id = i;
			}
			for (int i = 0; i < this.Events.Count; i++)
			{
				this.eventCollection_0[i].Id = i;
			}
		}

		private void method_10()
		{
			IEnumerable<BfType> arg_23_0 = this.Types;
			if (BfCache.func_3 == null)
			{
				BfCache.func_3 = new Func<BfType, bool>(BfCache.smethod_8);
			}
			List<BfType> list = arg_23_0.Where(BfCache.func_3).ToList<BfType>();
			foreach (BfType current in list)
			{
				this.Types.method_3(current);
				this.method_11(current);
			}
		}

		private void method_11(BfType bfType_0)
		{
			foreach (BfField current in ((IEnumerable<BfField>)bfType_0.Fields))
			{
				foreach (BfMethod current2 in ((IEnumerable<BfMethod>)current.GotByMethods))
				{
					current2.FieldGets.method_3(current);
				}
				foreach (BfMethod current2 in ((IEnumerable<BfMethod>)current.SetByMethods))
				{
					current2.FieldSets.method_3(current);
				}
				this.Fields.method_3(current);
			}
			foreach (BfMethod current3 in ((IEnumerable<BfMethod>)bfType_0.Methods))
			{
				foreach (BfMethod current2 in ((IEnumerable<BfMethod>)current3.CalledBy))
				{
					current2.Calls.method_3(current3);
				}
				this.Methods.method_3(current3);
			}
			foreach (BfEvent current4 in ((IEnumerable<BfEvent>)bfType_0.Events))
			{
				this.Events.method_3(current4);
			}
		}

		internal BfType method_12(TypeDefinition typeDefinition_0, BfAssembly bfAssembly_0)
		{
			string text = BfCache.smethod_2(typeDefinition_0);
			BfType result;
			if (!bfAssembly_0.method_4().ContainsKey(text))
			{
				BfType bfType = new BfType(this, typeDefinition_0, bfAssembly_0);
				bfAssembly_0.method_4().Add(BfCache.smethod_2(typeDefinition_0), bfType);
				this.Types.method_1(bfType);
				bfAssembly_0.Namespaces.method_1(bfType.Namespace);
				result = bfType;
			}
			else
			{
				Logger.LogWarning("CreateBfType", "Why the hell is this type already exist " + text);
				result = bfAssembly_0.method_4()[text];
			}
			return result;
		}

		public void Save(string filename)
		{
			using (FileStream fileStream = new FileStream(filename, FileMode.Create))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
				{
					this.assemblyCollection_0.method_4(binaryWriter);
					this.namespaceCollection_0.method_4(binaryWriter);
					this.typeCollection_0.method_4(binaryWriter);
					this.methodCollection_0.method_4(binaryWriter);
					this.fieldCollection_0.method_4(binaryWriter);
					this.eventCollection_0.method_4(binaryWriter);
				}
			}
		}

		public static BfCache Load(string filename)
		{
			BfCache bfCache = new BfCache();
			using (FileStream fileStream = new FileStream(filename, FileMode.Open))
			{
				using (BinaryReader binaryReader = new BinaryReader(fileStream))
				{
					bfCache.assemblyCollection_0.method_8(binaryReader);
					bfCache.namespaceCollection_0.method_8(binaryReader);
					bfCache.typeCollection_0.method_8(binaryReader);
					bfCache.methodCollection_0.method_8(binaryReader);
					bfCache.fieldCollection_0.method_8(binaryReader);
					bfCache.eventCollection_0.method_8(binaryReader);
					bfCache.assemblyCollection_0.method_7(bfCache);
					bfCache.namespaceCollection_0.method_7(bfCache);
					bfCache.typeCollection_0.method_7(bfCache);
					bfCache.methodCollection_0.method_7(bfCache);
					bfCache.fieldCollection_0.method_7(bfCache);
					bfCache.eventCollection_0.method_7(bfCache);
				}
			}
			GC.Collect();
			return bfCache;
		}

		internal BfNamespace method_13(BfType bfType_0)
		{
			BfNamespace bfNamespace = null;
			string text = null;
			BfNamespace result;
			try
			{
				text = BfCache.smethod_4(bfType_0.method_2().FullName);
				if (!this.sortedDictionary_1.ContainsKey(text))
				{
					bfNamespace = new BfNamespace(this, text);
					this.sortedDictionary_1.Add(text, bfNamespace);
					this.namespaceCollection_0.method_1(bfNamespace);
				}
				else
				{
					bfNamespace = this.sortedDictionary_1[text];
				}
				if (bfNamespace.Types == null)
				{
					Logger.LogError("BfNamespace: '" + bfNamespace.FullName + "' had null collection - " + bfType_0.FullName);
					bfNamespace.Types = new TypeCollection();
				}
				bfNamespace.Types.method_1(bfType_0);
				result = bfNamespace;
			}
			catch (Exception)
			{
				Builder builder = new Builder("\r\n");
				try
				{
					builder.Append("type == null => " + (bfType_0 == null));
					builder.Append("type = " + bfType_0.ToString());
				}
				catch
				{
				}
				try
				{
					builder.Append("type.Assembly = " + bfType_0.Assembly.ToString());
				}
				catch
				{
				}
				try
				{
					builder.Append("type.TypeDef.Name = " + bfType_0.method_2().Name);
				}
				catch
				{
				}
				try
				{
					builder.Append("type.TypeDef == null => " + (bfType_0.method_2() == null));
					builder.Append("type.TypeDef = " + bfType_0.method_2().ToString());
				}
				catch
				{
				}
				try
				{
					builder.Append("type.TypeDef.FullName == null => " + (bfType_0.method_2().FullName == null));
					builder.Append("type.TypeDef.FullName = " + bfType_0.method_2().FullName.ToString());
				}
				catch
				{
				}
				try
				{
					builder.Append("myNamespace == null => " + (text == null));
					builder.Append("myNamespace = " + text.ToString());
				}
				catch
				{
				}
				try
				{
					builder.Append("_namespaceDictionary == null => " + (this.sortedDictionary_1 == null));
					builder.Append("_namespaceDictionary = " + this.sortedDictionary_1.Count<KeyValuePair<string, BfNamespace>>());
				}
				catch
				{
				}
				try
				{
					builder.Append("_namespaces == null => " + (this.namespaceCollection_0 == null));
					builder.Append("_namespaces = " + this.namespaceCollection_0.Count<BfNamespace>());
				}
				catch
				{
				}
				try
				{
					builder.Append("bfNamespace == null => " + (bfNamespace == null));
					builder.Append("bfNamespace = " + bfNamespace);
				}
				catch
				{
				}
				try
				{
					builder.Append("bfNamespace.Types == null => " + (bfNamespace.Types == null));
					builder.Append("bfNamespace.Types = " + bfNamespace.Types.Count<BfType>());
				}
				catch
				{
				}
				throw new NitriqException("NamespaceProblems", builder.ToString());
			}
			return result;
		}

		internal static string smethod_4(string string_0)
		{
			string result;
			if (!string_0.Contains('.'))
			{
				result = "";
			}
			else
			{
				result = string_0.Substring(0, string_0.LastIndexOf('.'));
			}
			return result;
		}

		private void method_14()
		{
			foreach (string current in this.sortedDictionary_1.Keys)
			{
				Logger.LogError(string.Concat(new object[]
				{
					"'",
					current,
					"' - '",
					this.sortedDictionary_1[current],
					"'"
				}));
			}
		}

		internal int method_15()
		{
			return this.int_0++;
		}

		internal int method_16()
		{
			return this.int_1++;
		}

		internal int method_17()
		{
			return this.int_2++;
		}

		internal int method_18()
		{
			return this.int_3++;
		}

		internal int method_19()
		{
			return this.int_4++;
		}

		internal int method_20()
		{
			return this.int_5++;
		}

		internal int method_21()
		{
			return this.int_6++;
		}

		internal int method_22()
		{
			return this.int_7++;
		}

		[CompilerGenerated]
		private static bool smethod_5(BfType bfType_0)
		{
			return bfType_0.FullName == "System.Delegate";
		}

		[CompilerGenerated]
		private static bool smethod_6(BfAssembly bfAssembly_0)
		{
			return bfAssembly_0.Name == "mscorlib" && bfAssembly_0.Version.CompareTo("2.0.0.0") > -1;
		}

		[CompilerGenerated]
		private static bool smethod_7(BfAssembly bfAssembly_0)
		{
			return bfAssembly_0.IsCoreAssembly;
		}

		[CompilerGenerated]
		private static bool smethod_8(BfType bfType_0)
		{
			return bfType_0.Name.StartsWith("<PrivateImplementationDetails>");
		}
	}
}
