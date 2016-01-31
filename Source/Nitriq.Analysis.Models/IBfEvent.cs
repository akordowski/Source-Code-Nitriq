using System;

namespace Nitriq.Analysis.Models
{
	public interface IBfEvent
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

		BfType EventType
		{
			get;
		}

		int EventId
		{
			get;
			set;
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
	}
}
