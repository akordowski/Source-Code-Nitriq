using System;
using System.Runtime.InteropServices;

[Attribute0(
 = true, 
 = true, 
 = true), AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false), ComVisible(true)]
internal sealed class Attribute0 : Attribute
{
	private bool bool_0 = true;

	private bool bool_1 = true;

	private bool bool_2 = true;

	public bool method_0()
	{
		return this.bool_0;
	}

	public void method_1(bool bool_3)
	{
		this.bool_0 = bool_3;
	}

	public bool method_2()
	{
		return this.bool_1;
	}

	public void method_3(bool bool_3)
	{
		this.bool_1 = bool_3;
	}

	public bool method_4()
	{
		return this.bool_2;
	}

	public void method_5(bool bool_3)
	{
		this.bool_2 = bool_3;
	}
}
