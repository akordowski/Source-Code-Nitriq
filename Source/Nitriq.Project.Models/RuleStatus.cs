using System;

namespace Nitriq.Project.Models
{
	public enum RuleStatus
	{
		None,
		Good = 10,
		Warning = 20,
		Error = 30,
		CompileError = 40,
		RuntimeError = 50
	}
}
