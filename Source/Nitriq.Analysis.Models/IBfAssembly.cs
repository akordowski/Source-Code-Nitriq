using System;

namespace Nitriq.Analysis.Models
{
	public interface IBfAssembly
	{
		int AssemblyId
		{
			get;
		}

		string Version
		{
			get;
		}

		NamespaceCollection Namespaces
		{
			get;
		}

		string Name
		{
			get;
		}

		bool IsCoreAssembly
		{
			get;
		}
	}
}
