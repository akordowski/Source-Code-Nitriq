using Nitriq.Analysis.Models;
using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Nitriq.Wpf
{
	public class TreemapMetricCollection
	{
		private ObservableCollection<TreemapMetric> observableCollection_0 = new ObservableCollection<TreemapMetric>();

		[CompilerGenerated]
		private static Func<object, double> func_0;

		[CompilerGenerated]
		private static Func<object, double> func_1;

		[CompilerGenerated]
		private static Func<object, double> func_2;

		[CompilerGenerated]
		private static Func<object, double> func_3;

		[CompilerGenerated]
		private static Func<object, double> func_4;

		[CompilerGenerated]
		private static Func<object, double> func_5;

		[CompilerGenerated]
		private static Func<object, double> func_6;

		[CompilerGenerated]
		private static Func<object, double> func_7;

		[CompilerGenerated]
		private static Func<object, double> func_8;

		[CompilerGenerated]
		private static Func<object, double> func_9;

		[CompilerGenerated]
		private static Func<object, double> func_10;

		[CompilerGenerated]
		private static Func<object, double> func_11;

		[CompilerGenerated]
		private static Func<object, double> func_12;

		[CompilerGenerated]
		private static Func<object, double> func_13;

		[CompilerGenerated]
		private static Func<object, double> func_14;

		[CompilerGenerated]
		private static Func<object, double> func_15;

		[CompilerGenerated]
		private static Func<object, double> func_16;

		[CompilerGenerated]
		private static Func<object, double> func_17;

		[CompilerGenerated]
		private static Func<object, double> func_18;

		[CompilerGenerated]
		private static Func<object, double> func_19;

		public ObservableCollection<TreemapMetric> TypeMetrics
		{
			get
			{
				return this.observableCollection_0;
			}
		}

		public TreemapMetricCollection()
		{
			Collection<TreemapMetric> arg_57_0 = this.observableCollection_0;
			TreemapMetric treemapMetric = new TreemapMetric();
			treemapMetric.Level = "Method";
			treemapMetric.Name = "IL Instruction Count";
			TreemapMetric arg_51_0 = treemapMetric;
			if (TreemapMetricCollection.func_0 == null)
			{
				TreemapMetricCollection.func_0 = new Func<object, double>(TreemapMetricCollection.smethod_0);
			}
			arg_51_0.Function = TreemapMetricCollection.func_0;
			arg_57_0.Add(treemapMetric);
			Collection<TreemapMetric> arg_A2_0 = this.observableCollection_0;
			TreemapMetric treemapMetric2 = new TreemapMetric();
			treemapMetric2.Level = "Method";
			treemapMetric2.Name = "Physical Lines of Code";
			TreemapMetric arg_9C_0 = treemapMetric2;
			if (TreemapMetricCollection.func_1 == null)
			{
				TreemapMetricCollection.func_1 = new Func<object, double>(TreemapMetricCollection.smethod_1);
			}
			arg_9C_0.Function = TreemapMetricCollection.func_1;
			arg_A2_0.Add(treemapMetric2);
			Collection<TreemapMetric> arg_F2_0 = this.observableCollection_0;
			TreemapMetric treemapMetric3 = new TreemapMetric();
			treemapMetric3.Level = "Method";
			treemapMetric3.Name = "Cyclomatic Complexity";
			TreemapMetric arg_EB_0 = treemapMetric3;
			if (TreemapMetricCollection.func_2 == null)
			{
				TreemapMetricCollection.func_2 = new Func<object, double>(TreemapMetricCollection.smethod_2);
			}
			arg_EB_0.Function = TreemapMetricCollection.func_2;
			arg_F2_0.Add(treemapMetric3);
			Collection<TreemapMetric> arg_142_0 = this.observableCollection_0;
			TreemapMetric treemapMetric4 = new TreemapMetric();
			treemapMetric4.Level = "Method";
			treemapMetric4.Name = "Percent Comment";
			TreemapMetric arg_13B_0 = treemapMetric4;
			if (TreemapMetricCollection.func_3 == null)
			{
				TreemapMetricCollection.func_3 = new Func<object, double>(TreemapMetricCollection.smethod_3);
			}
			arg_13B_0.Function = TreemapMetricCollection.func_3;
			arg_142_0.Add(treemapMetric4);
			Collection<TreemapMetric> arg_192_0 = this.observableCollection_0;
			TreemapMetric treemapMetric5 = new TreemapMetric();
			treemapMetric5.Level = "Method";
			treemapMetric5.Name = "Logical Lines of Code";
			TreemapMetric arg_18B_0 = treemapMetric5;
			if (TreemapMetricCollection.func_4 == null)
			{
				TreemapMetricCollection.func_4 = new Func<object, double>(TreemapMetricCollection.smethod_4);
			}
			arg_18B_0.Function = TreemapMetricCollection.func_4;
			arg_192_0.Add(treemapMetric5);
			Collection<TreemapMetric> arg_1E2_0 = this.observableCollection_0;
			TreemapMetric treemapMetric6 = new TreemapMetric();
			treemapMetric6.Level = "Method";
			treemapMetric6.Name = "Called By Count";
			TreemapMetric arg_1DB_0 = treemapMetric6;
			if (TreemapMetricCollection.func_5 == null)
			{
				TreemapMetricCollection.func_5 = new Func<object, double>(TreemapMetricCollection.smethod_5);
			}
			arg_1DB_0.Function = TreemapMetricCollection.func_5;
			arg_1E2_0.Add(treemapMetric6);
			Collection<TreemapMetric> arg_232_0 = this.observableCollection_0;
			TreemapMetric treemapMetric7 = new TreemapMetric();
			treemapMetric7.Level = "Method";
			treemapMetric7.Name = "Calls Count";
			TreemapMetric arg_22B_0 = treemapMetric7;
			if (TreemapMetricCollection.func_6 == null)
			{
				TreemapMetricCollection.func_6 = new Func<object, double>(TreemapMetricCollection.smethod_6);
			}
			arg_22B_0.Function = TreemapMetricCollection.func_6;
			arg_232_0.Add(treemapMetric7);
			Collection<TreemapMetric> arg_282_0 = this.observableCollection_0;
			TreemapMetric treemapMetric8 = new TreemapMetric();
			treemapMetric8.Level = "Method";
			treemapMetric8.Name = "Parameter Count";
			TreemapMetric arg_27B_0 = treemapMetric8;
			if (TreemapMetricCollection.func_7 == null)
			{
				TreemapMetricCollection.func_7 = new Func<object, double>(TreemapMetricCollection.smethod_7);
			}
			arg_27B_0.Function = TreemapMetricCollection.func_7;
			arg_282_0.Add(treemapMetric8);
			Collection<TreemapMetric> arg_2D2_0 = this.observableCollection_0;
			TreemapMetric treemapMetric9 = new TreemapMetric();
			treemapMetric9.Level = "Method";
			treemapMetric9.Name = "Overload Count";
			TreemapMetric arg_2CB_0 = treemapMetric9;
			if (TreemapMetricCollection.func_8 == null)
			{
				TreemapMetricCollection.func_8 = new Func<object, double>(TreemapMetricCollection.smethod_8);
			}
			arg_2CB_0.Function = TreemapMetricCollection.func_8;
			arg_2D2_0.Add(treemapMetric9);
			Collection<TreemapMetric> arg_322_0 = this.observableCollection_0;
			TreemapMetric treemapMetric10 = new TreemapMetric();
			treemapMetric10.Level = "Method";
			treemapMetric10.Name = "Types Used Count";
			TreemapMetric arg_31B_0 = treemapMetric10;
			if (TreemapMetricCollection.func_9 == null)
			{
				TreemapMetricCollection.func_9 = new Func<object, double>(TreemapMetricCollection.smethod_9);
			}
			arg_31B_0.Function = TreemapMetricCollection.func_9;
			arg_322_0.Add(treemapMetric10);
			Collection<TreemapMetric> arg_372_0 = this.observableCollection_0;
			TreemapMetric treemapMetric11 = new TreemapMetric();
			treemapMetric11.Level = "Field";
			treemapMetric11.Name = "Got By Methods Count";
			TreemapMetric arg_36B_0 = treemapMetric11;
			if (TreemapMetricCollection.func_10 == null)
			{
				TreemapMetricCollection.func_10 = new Func<object, double>(TreemapMetricCollection.smethod_10);
			}
			arg_36B_0.Function = TreemapMetricCollection.func_10;
			arg_372_0.Add(treemapMetric11);
			Collection<TreemapMetric> arg_3BD_0 = this.observableCollection_0;
			TreemapMetric treemapMetric12 = new TreemapMetric();
			treemapMetric12.Level = "Field";
			treemapMetric12.Name = "Set By Methods Count";
			TreemapMetric arg_3B7_0 = treemapMetric12;
			if (TreemapMetricCollection.func_11 == null)
			{
				TreemapMetricCollection.func_11 = new Func<object, double>(TreemapMetricCollection.smethod_11);
			}
			arg_3B7_0.Function = TreemapMetricCollection.func_11;
			arg_3BD_0.Add(treemapMetric12);
			Collection<TreemapMetric> arg_408_0 = this.observableCollection_0;
			TreemapMetric treemapMetric13 = new TreemapMetric();
			treemapMetric13.Level = "Field";
			treemapMetric13.Name = "Types Used Count";
			TreemapMetric arg_402_0 = treemapMetric13;
			if (TreemapMetricCollection.func_12 == null)
			{
				TreemapMetricCollection.func_12 = new Func<object, double>(TreemapMetricCollection.smethod_12);
			}
			arg_402_0.Function = TreemapMetricCollection.func_12;
			arg_408_0.Add(treemapMetric13);
			Collection<TreemapMetric> arg_458_0 = this.observableCollection_0;
			TreemapMetric treemapMetric14 = new TreemapMetric();
			treemapMetric14.Level = "Event";
			treemapMetric14.Name = "Types Used Count";
			TreemapMetric arg_451_0 = treemapMetric14;
			if (TreemapMetricCollection.func_13 == null)
			{
				TreemapMetricCollection.func_13 = new Func<object, double>(TreemapMetricCollection.smethod_13);
			}
			arg_451_0.Function = TreemapMetricCollection.func_13;
			arg_458_0.Add(treemapMetric14);
			Collection<TreemapMetric> arg_4A8_0 = this.observableCollection_0;
			TreemapMetric treemapMetric15 = new TreemapMetric();
			treemapMetric15.Level = "Type";
			treemapMetric15.Name = "Types Used Count";
			TreemapMetric arg_4A1_0 = treemapMetric15;
			if (TreemapMetricCollection.func_14 == null)
			{
				TreemapMetricCollection.func_14 = new Func<object, double>(TreemapMetricCollection.smethod_14);
			}
			arg_4A1_0.Function = TreemapMetricCollection.func_14;
			arg_4A8_0.Add(treemapMetric15);
			Collection<TreemapMetric> arg_4F8_0 = this.observableCollection_0;
			TreemapMetric treemapMetric16 = new TreemapMetric();
			treemapMetric16.Level = "Type";
			treemapMetric16.Name = "Types Using Count";
			TreemapMetric arg_4F1_0 = treemapMetric16;
			if (TreemapMetricCollection.func_15 == null)
			{
				TreemapMetricCollection.func_15 = new Func<object, double>(TreemapMetricCollection.smethod_15);
			}
			arg_4F1_0.Function = TreemapMetricCollection.func_15;
			arg_4F8_0.Add(treemapMetric16);
			Collection<TreemapMetric> arg_548_0 = this.observableCollection_0;
			TreemapMetric treemapMetric17 = new TreemapMetric();
			treemapMetric17.Level = "Type";
			treemapMetric17.Name = "Method Count";
			TreemapMetric arg_541_0 = treemapMetric17;
			if (TreemapMetricCollection.func_16 == null)
			{
				TreemapMetricCollection.func_16 = new Func<object, double>(TreemapMetricCollection.smethod_16);
			}
			arg_541_0.Function = TreemapMetricCollection.func_16;
			arg_548_0.Add(treemapMetric17);
			Collection<TreemapMetric> arg_598_0 = this.observableCollection_0;
			TreemapMetric treemapMetric18 = new TreemapMetric();
			treemapMetric18.Level = "Type";
			treemapMetric18.Name = "Field Count";
			TreemapMetric arg_591_0 = treemapMetric18;
			if (TreemapMetricCollection.func_17 == null)
			{
				TreemapMetricCollection.func_17 = new Func<object, double>(TreemapMetricCollection.smethod_17);
			}
			arg_591_0.Function = TreemapMetricCollection.func_17;
			arg_598_0.Add(treemapMetric18);
			Collection<TreemapMetric> arg_5E8_0 = this.observableCollection_0;
			TreemapMetric treemapMetric19 = new TreemapMetric();
			treemapMetric19.Level = "Type";
			treemapMetric19.Name = "Event Count";
			TreemapMetric arg_5E1_0 = treemapMetric19;
			if (TreemapMetricCollection.func_18 == null)
			{
				TreemapMetricCollection.func_18 = new Func<object, double>(TreemapMetricCollection.smethod_18);
			}
			arg_5E1_0.Function = TreemapMetricCollection.func_18;
			arg_5E8_0.Add(treemapMetric19);
			Collection<TreemapMetric> arg_638_0 = this.observableCollection_0;
			TreemapMetric treemapMetric20 = new TreemapMetric();
			treemapMetric20.Level = "Type";
			treemapMetric20.Name = "Member Count";
			TreemapMetric arg_631_0 = treemapMetric20;
			if (TreemapMetricCollection.func_19 == null)
			{
				TreemapMetricCollection.func_19 = new Func<object, double>(TreemapMetricCollection.smethod_19);
			}
			arg_631_0.Function = TreemapMetricCollection.func_19;
			arg_638_0.Add(treemapMetric20);
		}

		[CompilerGenerated]
		private static double smethod_0(BfMethod bfMethod_0)
		{
			return (double)((BfMethod)bfMethod_0).ILCount;
		}

		[CompilerGenerated]
		private static double smethod_1(BfMethod bfMethod_0)
		{
			return (double)((BfMethod)bfMethod_0).PhysicalLineCount;
		}

		[CompilerGenerated]
		private static double smethod_2(BfMethod bfMethod_0)
		{
			return (double)((BfMethod)bfMethod_0).Cyclomatic;
		}

		[CompilerGenerated]
		private static double smethod_3(BfMethod bfMethod_0)
		{
			return ((BfMethod)bfMethod_0).PercentComment;
		}

		[CompilerGenerated]
		private static double smethod_4(BfMethod bfMethod_0)
		{
			return (double)((BfMethod)bfMethod_0).LogicalLineCount;
		}

		[CompilerGenerated]
		private static double smethod_5(BfMethod bfMethod_0)
		{
			return (double)((BfMethod)bfMethod_0).CalledBy.Count;
		}

		[CompilerGenerated]
		private static double smethod_6(BfMethod bfMethod_0)
		{
			return (double)((BfMethod)bfMethod_0).Calls.Count;
		}

		[CompilerGenerated]
		private static double smethod_7(BfMethod bfMethod_0)
		{
			return (double)((BfMethod)bfMethod_0).ParameterCount;
		}

		[CompilerGenerated]
		private static double smethod_8(BfMethod bfMethod_0)
		{
			return (double)((BfMethod)bfMethod_0).OverloadCount;
		}

		[CompilerGenerated]
		private static double smethod_9(BfMethod bfMethod_0)
		{
			return (double)((BfMethod)bfMethod_0).TypesUsed.Count;
		}

		[CompilerGenerated]
		private static double smethod_10(BfField bfField_0)
		{
			return (double)((BfField)bfField_0).GotByMethods.Count;
		}

		[CompilerGenerated]
		private static double smethod_11(BfField bfField_0)
		{
			return (double)((BfField)bfField_0).SetByMethods.Count;
		}

		[CompilerGenerated]
		private static double smethod_12(BfField bfField_0)
		{
			return (double)((BfField)bfField_0).TypesUsed.Count;
		}

		[CompilerGenerated]
		private static double smethod_13(BfEvent bfEvent_0)
		{
			return (double)((BfEvent)bfEvent_0).TypesUsed.Count;
		}

		[CompilerGenerated]
		private static double smethod_14(BfType bfType_0)
		{
			return (double)((BfType)bfType_0).TypesUsed.Count;
		}

		[CompilerGenerated]
		private static double smethod_15(BfType bfType_0)
		{
			return (double)((BfType)bfType_0).TypesUsing.Count;
		}

		[CompilerGenerated]
		private static double smethod_16(BfType bfType_0)
		{
			return (double)((BfType)bfType_0).Methods.Count;
		}

		[CompilerGenerated]
		private static double smethod_17(BfType bfType_0)
		{
			return (double)((BfType)bfType_0).Fields.Count;
		}

		[CompilerGenerated]
		private static double smethod_18(BfType bfType_0)
		{
			return (double)((BfType)bfType_0).Events.Count;
		}

		[CompilerGenerated]
		private static double smethod_19(BfType bfType_0)
		{
			BfType bfType = (BfType)bfType_0;
			return (double)(bfType.Methods.Count + bfType.Events.Count + bfType.Fields.Count);
		}
	}
}
