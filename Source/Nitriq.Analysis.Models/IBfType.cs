using System;

namespace Nitriq.Analysis.Models
{
	public interface IBfType
	{
		BfType BaseType
		{
			get;
		}

		FieldCollection Fields
		{
			get;
		}

		MethodCollection Methods
		{
			get;
		}

		EventCollection Events
		{
			get;
		}

		TypeCollection Interfaces
		{
			get;
		}

		TypeCollection TypesUsing
		{
			get;
		}

		TypeCollection TypesUsed
		{
			get;
		}

		TypeCollection DerivedTypes
		{
			get;
		}

		BfAssembly Assembly
		{
			get;
		}

		string FullName
		{
			get;
		}

		int GenericParameterCount
		{
			get;
		}

		bool IsAbstract
		{
			get;
		}

		bool IsClass
		{
			get;
		}

		bool IsDelegate
		{
			get;
		}

		bool IsEnum
		{
			get;
		}

		bool IsInCoreAssembly
		{
			get;
		}

		bool IsInterface
		{
			get;
		}

		bool IsInternal
		{
			get;
		}

		bool IsNested
		{
			get;
		}

		bool IsPrivate
		{
			get;
		}

		bool IsProtected
		{
			get;
		}

		bool IsProtectedAndInternal
		{
			get;
		}

		bool IsProtectedOrInternal
		{
			get;
		}

		bool IsPublic
		{
			get;
		}

		bool IsSealed
		{
			get;
		}

		bool IsStatic
		{
			get;
		}

		bool IsValueType
		{
			get;
		}

		string Name
		{
			get;
		}

		BfNamespace Namespace
		{
			get;
		}

		int TypeId
		{
			get;
		}

		int PhysicalLineCount
		{
			get;
		}

		int LogicalLineCount
		{
			get;
		}

		int CommentLineCount
		{
			get;
		}

		int Cyclomatic
		{
			get;
		}

		int ILCount
		{
			get;
		}

		double PercentComment
		{
			get;
		}

		int InheritanceDepth
		{
			get;
		}
	}
}
