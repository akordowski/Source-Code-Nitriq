using System;

namespace Nitriq.Analysis.Models
{
	public interface INameable
	{
		bool NameIs(string name);

		bool NameLike(string name);

		bool FullNameIs(string name);

		bool FullNameLike(string name);
	}
}
