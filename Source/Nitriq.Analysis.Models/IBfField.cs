using System;

namespace Nitriq.Analysis.Models
{
	public interface IBfField
	{
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

		int FieldId
		{
			get;
			set;
		}

		BfType FieldType
		{
			get;
		}

		MethodCollection SetByMethods
		{
			get;
		}

		MethodCollection GotByMethods
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

		bool IsStatic
		{
			get;
		}

		bool IsInCoreAssembly
		{
			get;
		}

		bool IsConstant
		{
			get;
		}
	}
}
