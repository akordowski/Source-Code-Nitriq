using System;

namespace Nitriq.Analysis.Models
{
	public interface IBfNamespace
	{
		string FullName
		{
			get;
		}

		TypeCollection Types
		{
			get;
		}

		int NamespaceId
		{
			get;
		}
	}
}
