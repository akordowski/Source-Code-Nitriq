using System;

namespace Nitriq.Analysis.Models
{
	public interface IBfMethod
	{
		TypeCollection ParameterTypes
		{
			get;
		}

		BfType Type
		{
			get;
		}

		string Name
		{
			get;
		}

		string FullName
		{
			get;
		}

		TypeCollection TypesUsed
		{
			get;
		}

		int MethodId
		{
			get;
		}

		BfType ReturnType
		{
			get;
		}

		int LogicalLineCount
		{
			get;
		}

		int PhysicalLineCount
		{
			get;
		}

		int CommentLineCount
		{
			get;
		}

		int ILCount
		{
			get;
		}

		int Cyclomatic
		{
			get;
		}

		int ILCyclomatic
		{
			get;
		}

		int ParameterCount
		{
			get;
		}

		int OverloadCount
		{
			get;
		}

		bool IsPublic
		{
			get;
		}

		bool IsInternal
		{
			get;
		}

		bool IsProtected
		{
			get;
		}

		bool IsProtectedOrInternal
		{
			get;
		}

		bool IsProtectedAndInternal
		{
			get;
		}

		bool IsPrivate
		{
			get;
		}

		bool IsConstructor
		{
			get;
		}

		bool IsPropertyGetter
		{
			get;
		}

		bool IsPropertySetter
		{
			get;
		}

		bool IsStatic
		{
			get;
		}

		bool IsVirtual
		{
			get;
		}

		bool UsesBoxing
		{
			get;
		}

		bool UsesUnboxing
		{
			get;
		}

		bool IsGeneric
		{
			get;
		}

		bool IsOperator
		{
			get;
		}

		bool IsIndexGetter
		{
			get;
		}

		bool IsIndexSetter
		{
			get;
		}

		bool IsEventAdder
		{
			get;
		}

		bool IsEventRemover
		{
			get;
		}

		bool IsStaticConstructor
		{
			get;
		}

		double PercentComment
		{
			get;
		}

		MethodCollection Calls
		{
			get;
		}

		MethodCollection CalledBy
		{
			get;
		}

		FieldCollection FieldSets
		{
			get;
		}

		FieldCollection FieldGets
		{
			get;
		}

		bool IsInCoreAssembly
		{
			get;
		}

		bool IsProperty
		{
			get;
		}
	}
}
