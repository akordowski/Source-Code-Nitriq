using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Pdb;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("Method: {Name}")]
	[Serializable]
	public class BfMethod : BfMember, IHaveUniqueName, IBfMethod
	{
		[DebuggerDisplay("CMatch: {Index} - {Value}")]
		private class CMatch
		{
			internal int int_0;

			internal string string_0;

			public CMatch()
			{
			}

			public CMatch(Match match_0)
			{
				this.int_0 = match_0.Index;
				this.string_0 = match_0.Value;
			}
		}

		[DebuggerDisplay("Range: {Token} -> {MatchedText}")]
		private class Range
		{
			internal int int_0;

			internal int int_1;

			internal string string_0;

			internal string string_1;
		}

		[Flags]
		public enum MethodBools
		{
			None = 0,
			IsPublic = 1,
			IsInternal = 2,
			IsProtected = 4,
			IsProtectedOrInternal = 8,
			IsProtectedAndInternal = 16,
			IsPrivate = 32,
			IsConstructor = 64,
			IsPropertyGetter = 128,
			IsPropertySetter = 256,
			IsStatic = 512,
			IsVirtual = 1024,
			UsesBoxing = 2048,
			UsesUnboxing = 4096,
			IsGeneric = 8192,
			IsUsingPointers = 16384,
			IsOperator = 32768,
			IsIndexGetter = 65536,
			IsIndexSetter = 131072,
			IsEventAdder = 262144,
			IsEventRemover = 524288,
			IsStaticConstructor = 1048576
		}

		private int int_0;

		private TypeCollection typeCollection_0 = new TypeCollection();

		[NonSerialized]
		private MethodDefinition methodDefinition_0;

		private string string_0;

		private bool bool_0 = false;

		private BfType bfType_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private BfMethod.MethodBools methodBools_0;

		private MethodCollection methodCollection_0 = new MethodCollection();

		private MethodCollection methodCollection_1 = new MethodCollection();

		private FieldCollection fieldCollection_0 = new FieldCollection();

		private FieldCollection fieldCollection_1 = new FieldCollection();

		public int MethodId
		{
			get
			{
				return this.int_0;
			}
		}

		public TypeCollection ParameterTypes
		{
			get
			{
				return this.typeCollection_0;
			}
		}

		public override BfType Type
		{
			get
			{
				return base.Type;
			}
		}

		public override string Name
		{
			get
			{
				return base.Name;
			}
		}

		public override string FullName
		{
			get
			{
				return base.FullName;
			}
		}

		public override TypeCollection TypesUsed
		{
			get
			{
				return base.TypesUsed;
			}
		}

		public override bool IsInCoreAssembly
		{
			get
			{
				return base.IsInCoreAssembly;
			}
		}

		public BfType ReturnType
		{
			get
			{
				return this.bfType_0;
			}
		}

		public int LogicalLineCount
		{
			get
			{
				return this.int_1;
			}
		}

		public int PhysicalLineCount
		{
			get
			{
				return this.int_2;
			}
		}

		public int CommentLineCount
		{
			get
			{
				return this.int_3;
			}
		}

		public int ILCount
		{
			get
			{
				return this.int_4;
			}
		}

		public int Cyclomatic
		{
			get
			{
				return this.int_5;
			}
		}

		public int ILCyclomatic
		{
			get
			{
				return this.int_6;
			}
		}

		public int ParameterCount
		{
			get
			{
				return this.int_7;
			}
		}

		public int OverloadCount
		{
			get
			{
				return this.int_8;
			}
		}

		public bool IsPublic
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsPublic) == BfMethod.MethodBools.IsPublic;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsPublic;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsPublic;
				}
			}
		}

		public bool IsInternal
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsInternal) == BfMethod.MethodBools.IsInternal;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsInternal;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsInternal;
				}
			}
		}

		public bool IsProtected
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsProtected) == BfMethod.MethodBools.IsProtected;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsProtected;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsProtected;
				}
			}
		}

		public bool IsProtectedOrInternal
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsProtectedOrInternal) == BfMethod.MethodBools.IsProtectedOrInternal;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsProtectedOrInternal;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsProtectedOrInternal;
				}
			}
		}

		public bool IsProtectedAndInternal
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsProtectedAndInternal) == BfMethod.MethodBools.IsProtectedAndInternal;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsProtectedAndInternal;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsProtectedAndInternal;
				}
			}
		}

		public bool IsPrivate
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsPrivate) == BfMethod.MethodBools.IsPrivate;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsPrivate;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsPrivate;
				}
			}
		}

		public bool IsConstructor
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsConstructor) == BfMethod.MethodBools.IsConstructor;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsConstructor;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsConstructor;
				}
			}
		}

		public bool IsPropertyGetter
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsPropertyGetter) == BfMethod.MethodBools.IsPropertyGetter;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsPropertyGetter;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsPropertyGetter;
				}
			}
		}

		public bool IsPropertySetter
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsPropertySetter) == BfMethod.MethodBools.IsPropertySetter;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsPropertySetter;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsPropertySetter;
				}
			}
		}

		public bool IsStatic
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsStatic) == BfMethod.MethodBools.IsStatic;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsStatic;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsStatic;
				}
			}
		}

		public bool IsVirtual
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsVirtual) == BfMethod.MethodBools.IsVirtual;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsVirtual;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsVirtual;
				}
			}
		}

		public bool UsesBoxing
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.UsesBoxing) == BfMethod.MethodBools.UsesBoxing;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.UsesBoxing;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.UsesBoxing;
				}
			}
		}

		public bool UsesUnboxing
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.UsesUnboxing) == BfMethod.MethodBools.UsesUnboxing;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.UsesUnboxing;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.UsesUnboxing;
				}
			}
		}

		public bool IsGeneric
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsGeneric) == BfMethod.MethodBools.IsGeneric;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsGeneric;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsGeneric;
				}
			}
		}

		public bool IsOperator
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsOperator) == BfMethod.MethodBools.IsOperator;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsOperator;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsOperator;
				}
			}
		}

		public bool IsIndexGetter
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsIndexGetter) == BfMethod.MethodBools.IsIndexGetter;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsIndexGetter;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsIndexGetter;
				}
			}
		}

		public bool IsIndexSetter
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsIndexSetter) == BfMethod.MethodBools.IsIndexSetter;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsIndexSetter;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsIndexSetter;
				}
			}
		}

		public bool IsEventAdder
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsEventAdder) == BfMethod.MethodBools.IsEventAdder;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsEventAdder;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsEventAdder;
				}
			}
		}

		public bool IsEventRemover
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsEventRemover) == BfMethod.MethodBools.IsEventRemover;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsEventRemover;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsEventRemover;
				}
			}
		}

		public bool IsStaticConstructor
		{
			get
			{
				return (this.methodBools_0 & BfMethod.MethodBools.IsStaticConstructor) == BfMethod.MethodBools.IsStaticConstructor;
			}
			private set
			{
				if (value)
				{
					this.methodBools_0 |= BfMethod.MethodBools.IsStaticConstructor;
				}
				else
				{
					this.methodBools_0 &= ~BfMethod.MethodBools.IsStaticConstructor;
				}
			}
		}

		public bool IsProperty
		{
			get
			{
				return this.IsPropertyGetter || this.IsPropertySetter;
			}
		}

		public double PercentComment
		{
			get
			{
				return (this.int_3 == 0 || this.int_2 == 0) ? 0.0 : (100.0 * (double)this.int_3 / (double)this.int_2).Round(0);
			}
		}

		public MethodCollection Calls
		{
			get
			{
				return this.methodCollection_0;
			}
		}

		public MethodCollection CalledBy
		{
			get
			{
				return this.methodCollection_1;
			}
		}

		public FieldCollection FieldSets
		{
			get
			{
				return this.fieldCollection_0;
			}
		}

		public FieldCollection FieldGets
		{
			get
			{
				return this.fieldCollection_1;
			}
		}

		public string UniqueName
		{
			get
			{
				return this.method_2();
			}
		}

		internal override int Id
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public override string ToString()
		{
			return "IMethod: " + this.FullName;
		}

		internal BfMethod(BfCache cache, MethodDefinition methodDef, BfType type) : base(cache, methodDef, type)
		{
			this.methodDefinition_0 = methodDef;
			this.int_0 = this._cache.method_18();
			this.string_0 = BfMethod.smethod_0(this.methodDefinition_0);
			if (type.IsInCoreAssembly)
			{
				this.bfType_0 = cache.method_7(methodDef.ReturnType.ReturnType);
				this._typesUsed.method_2(this._cache.method_8(methodDef.ReturnType.ReturnType));
				this._typesUsed.method_1(this.bfType_0);
				this._typesUsed.method_2(this._cache.method_8(this.methodDefinition_0));
				IEnumerator enumerator;
				if (methodDef.Body != null)
				{
					enumerator = methodDef.Body.Variables.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							VariableDefinition variableDefinition = (VariableDefinition)enumerator.Current;
							this._typesUsed.method_2(this._cache.method_8(variableDefinition.VariableType));
							this._typesUsed.method_1(this._cache.method_7(variableDefinition.VariableType));
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
				enumerator = methodDef.Parameters.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ParameterDefinition parameterDefinition = (ParameterDefinition)enumerator.Current;
						this._typesUsed.method_2(this._cache.method_8(parameterDefinition.ParameterType));
						this._typesUsed.method_1(this._cache.method_7(parameterDefinition.ParameterType));
						this.typeCollection_0.method_2(this._cache.method_8(parameterDefinition.ParameterType));
						this.typeCollection_0.method_1(this._cache.method_7(parameterDefinition.ParameterType));
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				this.typeCollection_0.ClearHash();
			}
		}

		internal BfMethod()
		{
		}

		internal void method_0()
		{
			this.methodDefinition_0 = null;
			this.string_0 = null;
		}

		internal MethodDefinition method_1()
		{
			return this.methodDefinition_0;
		}

		internal string method_2()
		{
			return this.string_0;
		}

		internal static string smethod_0(MethodReference methodReference_0)
		{
			int sentinel = methodReference_0.GetSentinel();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(methodReference_0.ReturnType.ReturnType.FullName);
			stringBuilder.Append(" ");
			if (methodReference_0.DeclaringType != null)
			{
				stringBuilder.Append(methodReference_0.DeclaringType.FullName + "::");
			}
			stringBuilder.Append(methodReference_0.Name);
			if (methodReference_0.GenericParameters.Count > 0)
			{
				stringBuilder.Append("<");
			}
			for (int i = 0; i < methodReference_0.GenericParameters.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(methodReference_0.GenericParameters[i].Name);
			}
			if (methodReference_0.GenericParameters.Count > 0)
			{
				stringBuilder.Append(">");
			}
			stringBuilder.Append("(");
			for (int i = 0; i < methodReference_0.Parameters.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				if (i == sentinel)
				{
					stringBuilder.Append("...,");
					Logger.LogInfo("Sentinel");
					Debugger.Break();
				}
				if (methodReference_0.Parameters[i].ParameterType != null)
				{
					stringBuilder.Append(methodReference_0.Parameters[i].ParameterType.FullName);
				}
			}
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}

		private static string smethod_1(TypeReference typeReference_0)
		{
			while (typeReference_0 is TypeSpecification)
			{
				typeReference_0 = (typeReference_0 as TypeSpecification).ElementType;
			}
			return typeReference_0.FullName;
		}

		internal bool method_3()
		{
			return this.bool_0;
		}

		internal void method_4()
		{
			if (this.bool_0)
			{
				Logger.LogWarning("Method.Populate", "shouldn't be calling populate more than once");
			}
			else
			{
				this.bool_0 = true;
				this.IsConstructor = this.methodDefinition_0.IsConstructor;
				this.IsVirtual = this.methodDefinition_0.IsVirtual;
				this.IsGeneric = (this.methodDefinition_0.GenericParameters.Count > 0);
				this.IsInternal = this.methodDefinition_0.IsAssembly;
				this.IsProtected = this.methodDefinition_0.IsFamily;
				this.IsProtectedAndInternal = this.methodDefinition_0.IsFamilyAndAssembly;
				this.IsProtectedOrInternal = this.methodDefinition_0.IsFamilyOrAssembly;
				this.IsPrivate = this.methodDefinition_0.IsPrivate;
				this.IsPublic = this.methodDefinition_0.IsPublic;
				this.IsStatic = this.methodDefinition_0.IsStatic;
				this.int_8 = this.methodDefinition_0.Overrides.Count;
				this.int_7 = this.methodDefinition_0.Parameters.Count;
				this.IsStaticConstructor = (this.methodDefinition_0.IsConstructor && this.methodDefinition_0.IsStatic);
				this.method_6();
				if (this.methodDefinition_0.HasBody)
				{
					if (this._type.Assembly.method_2() != null && !this.IsEventAdder && !this.IsEventRemover)
					{
						try
						{
							IDictionary instructions = PdbReader.GetInstructions(this.methodDefinition_0.Body);
							this._type.Assembly.method_2().Read(this.methodDefinition_0.Body, instructions);
						}
						catch (Exception)
						{
							Logger.LogWarning("SymbolLoadError", "Something went wrong while loading the symbols for the \"" + this._fullName + "\" method");
						}
					}
					this.int_4 = this.methodDefinition_0.Body.Instructions.Count;
					if (this._type.Assembly.IsCoreAssembly)
					{
						HashSet<int> hashSet = new HashSet<int>();
						int num = 0;
						int num2 = 0;
						int num3 = 0;
						bool value = false;
						bool value2 = false;
						SequencePoint sequencePoint = null;
						SequencePoint sequencePoint2 = null;
						foreach (Instruction instruction in this.methodDefinition_0.Body.Instructions)
						{
							if (instruction.SequencePoint != null)
							{
								File file = this._cache.method_3(instruction);
								if (file.Language == "C#" && !file.method_0())
								{
									if (sequencePoint == null && file.method_4(instruction.SequencePoint))
									{
										sequencePoint = instruction.SequencePoint;
									}
									if (file.method_5(instruction.SequencePoint))
									{
										sequencePoint2 = instruction.SequencePoint;
									}
								}
								num3++;
							}
							Code code = instruction.OpCode.Code;
							if (code <= Code.Stsfld)
							{
								switch (code)
								{
								case Code.Jmp:
									Debug.Assert(false, "We're jumping");
									goto IL_542;
								case Code.Call:
									break;
								case Code.Calli:
									num++;
									goto IL_542;
								default:
									switch (code)
									{
									case Code.Callvirt:
									case Code.Newobj:
										break;
									case Code.Cpobj:
									case Code.Ldobj:
									case Code.Ldstr:
									case Code.Castclass:
									case Code.Isinst:
									case Code.Conv_R_Un:
									case Code.Throw:
										goto IL_542;
									case Code.Unbox:
										goto IL_53A;
									case Code.Ldfld:
									case Code.Ldflda:
									case Code.Ldsfld:
									case Code.Ldsflda:
									{
										FieldReference fieldReference = instruction.Operand as FieldReference;
										BfField bfField = this._cache.method_6(fieldReference);
										if (bfField != null)
										{
											this.FieldGets.method_1(bfField);
											bfField.GotByMethods.method_1(this);
											this._typesUsed.method_1(bfField.Type);
											this._typesUsed.method_2(this._cache.method_8(fieldReference.FieldType));
											goto IL_542;
										}
										goto IL_542;
									}
									case Code.Stfld:
									case Code.Stsfld:
									{
										FieldReference fieldReference = instruction.Operand as FieldReference;
										BfField bfField = this._cache.method_6(fieldReference);
										if (bfField != null)
										{
											this.FieldSets.method_1(bfField);
											bfField.SetByMethods.method_1(this);
											this._typesUsed.method_1(bfField.Type);
											this._typesUsed.method_2(this._cache.method_8(fieldReference.FieldType));
											goto IL_542;
										}
										goto IL_542;
									}
									default:
										goto IL_542;
									}
									break;
								}
								num++;
								if (!(instruction.Operand is MethodReference))
								{
									throw new Exception("Ut Oh");
								}
								BfMethod bfMethod;
								if (((MethodReference)instruction.Operand).DeclaringType is GenericInstanceType)
								{
									bfMethod = this.method_5(this, (MethodReference)instruction.Operand);
								}
								else
								{
									bfMethod = this._cache.method_5((MethodReference)instruction.Operand);
								}
								if (bfMethod == null)
								{
									Logger.LogInfo("Can't find: " + instruction.Operand.ToString());
								}
								else
								{
									this._typesUsed.method_1(bfMethod.Type);
									this._typesUsed.method_1(bfMethod.ReturnType);
									this._typesUsed.method_2(bfMethod.ParameterTypes);
									this._typesUsed.method_2(this._cache.method_8((MethodReference)instruction.Operand));
									this.Calls.method_1(bfMethod);
									bfMethod.CalledBy.method_1(this);
								}
							}
							else if (code != Code.Box)
							{
								if (code == Code.Unbox_Any)
								{
									goto IL_53A;
								}
							}
							else
							{
								value = true;
							}
							IL_542:
							switch (instruction.OpCode.FlowControl)
							{
							case FlowControl.Branch:
							case FlowControl.Cond_Branch:
								hashSet.Add(instruction.Offset);
								continue;
							case FlowControl.Break:
								continue;
							case FlowControl.Call:
								num2++;
								continue;
							default:
								continue;
							}
							IL_53A:
							value2 = true;
							goto IL_542;
						}
						this._typesUsed.ClearHash();
						if (sequencePoint != null && sequencePoint2 != null)
						{
							this.int_2 = sequencePoint2.EndLine - sequencePoint.StartLine;
							this.method_7(sequencePoint, sequencePoint2, this._cache.method_4(sequencePoint.Document));
						}
						if (num2 != num)
						{
							Logger.LogWarning("Method.Populate2", "control calls != opcode calls");
						}
						this.int_6 = hashSet.Count;
						this.int_1 = num3;
						this.UsesBoxing = value;
						this.UsesUnboxing = value2;
					}
				}
			}
		}

		private BfMethod method_5(BfMethod bfMethod_0, MethodReference methodReference_0)
		{
			GenericInstanceType genericInstanceType = (GenericInstanceType)methodReference_0.DeclaringType;
			BfType bfType = this._cache.method_7(genericInstanceType.ElementType);
			HashSet<string> hashSet = new HashSet<string>();
			BfMethod result;
			if (bfType == null)
			{
				result = null;
			}
			else
			{
				foreach (GenericParameter genericParameter in bfType.method_2().GenericParameters)
				{
					hashSet.Add(genericParameter.FullName);
				}
				MethodReference methodReference = null;
				List<MethodReference> list = new List<MethodReference>();
				list.AddRange(bfType.method_2().Constructors.Cast<MethodReference>());
				list.AddRange(bfType.method_2().Methods.Cast<MethodReference>());
				using (List<MethodReference>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						MethodDefinition methodDefinition = (MethodDefinition)enumerator2.Current;
						if (methodDefinition.Name == methodReference_0.Name && methodDefinition.Parameters.Count == methodReference_0.Parameters.Count)
						{
							bool flag = true;
							for (int i = 0; i < methodDefinition.Parameters.Count; i++)
							{
								ParameterDefinition parameterDefinition = methodDefinition.Parameters[i];
								ParameterDefinition parameterDefinition2 = methodReference_0.Parameters[i];
								if (hashSet.Contains(BfCache.smethod_3(parameterDefinition.ParameterType).FullName))
								{
									if (!parameterDefinition2.ToString().StartsWith("A_"))
									{
										flag = false;
									}
								}
								else if (!(Regex.Replace(parameterDefinition2.ParameterType.FullName, "<[^>]*>", "") == Regex.Replace(parameterDefinition.ParameterType.FullName, "<[^>]*>", "")))
								{
									flag = false;
								}
							}
							if (flag)
							{
								methodReference = methodDefinition;
							}
						}
					}
				}
				if (methodReference == null)
				{
					Logger.LogWarning("GetMethodRefFromGenericInstance", "Not good " + methodReference_0.ToString());
					result = null;
				}
				else
				{
					BfMethod.smethod_0(methodReference);
					result = this._cache.method_5(methodReference);
				}
			}
			return result;
		}

		private void method_6()
		{
			if (this.methodDefinition_0.IsRuntimeSpecialName && !this.methodDefinition_0.Name.StartsWith(".ctor") && !this.methodDefinition_0.Name.StartsWith(".cctor"))
			{
				Logger.LogDebug("PopulateSpecialNames", "check this out");
			}
			if (this.methodDefinition_0.IsSpecialName)
			{
				if (this.methodDefinition_0.Name.StartsWith("get_Item"))
				{
					this.IsIndexGetter = true;
				}
				else if (this.methodDefinition_0.Name.StartsWith("set_Item"))
				{
					this.IsIndexSetter = true;
				}
				if (this.methodDefinition_0.Name.StartsWith("get_"))
				{
					this.IsPropertyGetter = true;
				}
				else if (this.methodDefinition_0.Name.StartsWith("set_"))
				{
					this.IsPropertySetter = true;
				}
				else if (this.methodDefinition_0.Name.StartsWith(".ctor"))
				{
					this.IsConstructor = true;
				}
				else if (this.methodDefinition_0.Name.StartsWith(".cctor"))
				{
					this.IsConstructor = true;
				}
				else if (this.methodDefinition_0.Name.StartsWith("add_"))
				{
					this.IsEventAdder = true;
				}
				else if (this.methodDefinition_0.Name.StartsWith("remove_"))
				{
					this.IsEventRemover = true;
				}
				else if (this.methodDefinition_0.Name.StartsWith("op_"))
				{
					this.IsOperator = true;
				}
				else if (this.methodDefinition_0.IsNewSlot)
				{
					if (this.methodDefinition_0.Name.Contains("get_Item"))
					{
						this.IsIndexGetter = true;
					}
					else if (this.methodDefinition_0.Name.Contains("set_Item"))
					{
						this.IsIndexSetter = true;
					}
					if (this.methodDefinition_0.Name.Contains("get_"))
					{
						this.IsPropertyGetter = true;
					}
					else if (this.methodDefinition_0.Name.Contains("set_"))
					{
						this.IsPropertySetter = true;
					}
					else if (this.methodDefinition_0.Name.Contains(".ctor"))
					{
						this.IsConstructor = true;
					}
					else if (this.methodDefinition_0.Name.Contains(".cctor"))
					{
						this.IsConstructor = true;
					}
					else if (this.methodDefinition_0.Name.Contains("add_"))
					{
						this.IsEventAdder = true;
					}
					else if (this.methodDefinition_0.Name.Contains("remove_"))
					{
						this.IsEventRemover = true;
					}
					else if (this.methodDefinition_0.Name.Contains("op_"))
					{
						this.IsOperator = true;
					}
				}
				else
				{
					Logger.LogDebug("PopulateSpecialNames2", "yo, check this out");
				}
			}
		}

		private void method_7(SequencePoint sequencePoint_0, SequencePoint sequencePoint_1, File file_0)
		{
			string string_ = file_0.method_6(sequencePoint_0, sequencePoint_1);
			if (file_0.Language == "C#")
			{
				this.method_8(string_);
			}
		}

		internal void method_8(string string_1)
		{
			string b = "/*";
			string b2 = "*/";
			string b3 = "\"";
			string b4 = "@\"";
			string b5 = "//";
			string b6 = "\\";
			string b7 = "\"\"";
			string b8 = "\r\n";
			string b9 = "\n";
			string pattern = "/\\*|\\*/|//|@\"|\"\"|\\\\|\\\\\"|\"|\\r\\n|\\n";
			List<BfMethod.CMatch> list = new List<BfMethod.CMatch>();
			foreach (Match match_ in Regex.Matches(string_1, pattern))
			{
				list.Add(new BfMethod.CMatch(match_));
			}
			if (list.Count == 0)
			{
				this.int_5 = 1;
				this.int_3 = 0;
			}
			else
			{
				try
				{
					List<BfMethod.Range> list2 = new List<BfMethod.Range>();
					BfMethod.Range range = null;
					int i = 0;
					int num = 0;
					string text = list[0].string_0;
					int num2 = 0;
					while (i < list.Count)
					{
						num2++;
						if (num2 == 1000000)
						{
							throw new Exception("I think we've gone infinite");
						}
						text = list[i].string_0;
						if (range == null && (text == b || text == b5 || text == b4 || text == b3))
						{
							range = new BfMethod.Range
							{
								int_0 = list[i].int_0,
								string_0 = text
							};
							list2.Add(range);
							i++;
						}
						else if (range == null && text == b7)
						{
							range = new BfMethod.Range
							{
								int_0 = list[i].int_0,
								int_1 = text.Length,
								string_0 = text,
								string_1 = text
							};
							list2.Add(range);
							range = null;
							i++;
						}
						else if (range == null && (text == b8 || text == b9 || text == b6))
						{
							i++;
						}
						else if (range.string_0 == b && text == b2)
						{
							range.int_1 = list[i].int_0 + text.Length - range.int_0;
							num += string_1.Substring(range.int_0, range.int_1).Split(new char[]
							{
								'\n'
							}).Length;
							range.string_1 = string_1.Substring(range.int_0, range.int_1);
							range = null;
							i++;
						}
						else if (range.string_0 == b5 && (text == b8 || text == b9))
						{
							range.int_1 = list[i].int_0 + text.Length - range.int_0;
							range.string_1 = string_1.Substring(range.int_0, range.int_1);
							num++;
							range = null;
							i++;
						}
						else
						{
							if (range.string_0 == b3 && text == b6)
							{
								if (i + 1 >= list.Count)
								{
									throw new Exception("This shouldn't happen");
								}
								if (list[i].int_0 + 1 != list[i + 1].int_0)
								{
									i++;
									continue;
								}
								string a = list[i + 1].string_0;
								if (a == b6)
								{
									i += 2;
									continue;
								}
								if (a == b3)
								{
									i += 2;
									continue;
								}
								if (a == b7)
								{
									list[i + 1].int_0++;
									list[i + 1].string_0 = b3;
									i++;
									continue;
								}
							}
							if ((range.string_0 == b4 || range.string_0 == b3) && (text == b3 || text == b4))
							{
								range.int_1 = list[i].int_0 + text.Length - range.int_0;
								range.string_1 = string_1.Substring(range.int_0, range.int_1);
								range = null;
								i++;
							}
							else
							{
								i++;
							}
						}
					}
					if (range != null && range.string_0 != b5)
					{
						Logger.LogWarning("BfMethod.AssignSourceValuesCSharp", "Error processing method Cannot Parse Code, bad token sequence");
						this.int_5 = -1;
						this.int_3 = -1;
					}
					string text2 = string_1;
					for (int j = list2.Count - 1; j >= 0; j--)
					{
						text2 = text2.Remove(list2[j].int_0, list2[j].int_1);
					}
					string pattern2 = "\\bif\\b|&&|\\|\\||\\bfor\\b|\\bforeach\\b|\\bcase\\b|\\bdefault\\b|\\bcontinue\\b|\\bwhile\\b|\\bgoto\\b|\\bcatch\\b|(\\?[^;]+:)+|\\?\\?";
					MatchCollection matchCollection = Regex.Matches(text2, pattern2);
					this.int_3 = num;
					this.int_5 = matchCollection.Count + 1;
				}
				catch (Exception ex)
				{
					Logger.LogWarning("BfMethod.AssignSourceValuesCSharp", "Error processing method " + ex.ToString());
					this.int_5 = -1;
					this.int_3 = -1;
				}
			}
		}

		private int method_9()
		{
			return this.int_9;
		}

		internal bool method_24()
		{
			return (this.methodBools_0 & BfMethod.MethodBools.IsUsingPointers) == BfMethod.MethodBools.IsUsingPointers;
		}

		private void method_25(bool value)
		{
			if (value)
			{
				this.methodBools_0 |= BfMethod.MethodBools.IsUsingPointers;
			}
			else
			{
				this.methodBools_0 &= ~BfMethod.MethodBools.IsUsingPointers;
			}
		}

		internal override void vmethod_0(BinaryWriter writer)
		{
			base.vmethod_0(writer);
			writer.Write(this.int_0);
			writer.Write(this.int_1);
			writer.Write(this.int_2);
			writer.Write(this.int_3);
			writer.Write(this.int_4);
			writer.Write(this.int_5);
			writer.Write(this.int_6);
			writer.Write(this.int_7);
			writer.Write(this.int_8);
			writer.Write(this.int_9);
			writer.Write((int)this.methodBools_0);
			this.typeCollection_0.method_5(writer);
			writer.Write((this.bfType_0 != null) ? this.bfType_0.Id : -1);
			this.methodCollection_0.method_5(writer);
			this.methodCollection_1.method_5(writer);
			this.fieldCollection_0.method_5(writer);
			this.fieldCollection_1.method_5(writer);
		}

		internal override void vmethod_1(BinaryReader reader)
		{
			base.vmethod_1(reader);
			this.int_0 = reader.ReadInt32();
			this.int_1 = reader.ReadInt32();
			this.int_2 = reader.ReadInt32();
			this.int_3 = reader.ReadInt32();
			this.int_4 = reader.ReadInt32();
			this.int_5 = reader.ReadInt32();
			this.int_6 = reader.ReadInt32();
			this.int_7 = reader.ReadInt32();
			this.int_8 = reader.ReadInt32();
			this.int_9 = reader.ReadInt32();
			this.methodBools_0 = (BfMethod.MethodBools)reader.ReadInt32();
			this.typeCollection_0.method_6(reader);
			this.bfType_0 = new BfType
			{
				Id = reader.ReadInt32()
			};
			this.methodCollection_0.method_6(reader);
			this.methodCollection_1.method_6(reader);
			this.fieldCollection_0.method_6(reader);
			this.fieldCollection_1.method_6(reader);
		}

		internal override void vmethod_2(BfCache cache)
		{
			base.vmethod_2(cache);
			this.typeCollection_0.method_9(cache);
			this.bfType_0 = ((this.bfType_0.Id == -1) ? null : cache.Types[this.bfType_0.Id]);
			this.methodCollection_0.method_9(cache);
			this.methodCollection_1.method_9(cache);
			this.fieldCollection_0.method_9(cache);
			this.fieldCollection_1.method_9(cache);
		}
	}
}
