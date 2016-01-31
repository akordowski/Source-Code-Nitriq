using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Nitriq.Wpf
{
	public class NitriqEditor : UserControl, IComponentConnector
	{
		public static readonly DependencyProperty CodeProperty;

		internal NitriqSyntaxEditor nitriqSyntaxEditor_0;

		internal EditorDocument editorDocument_0;

		private bool bool_0;

		[CompilerGenerated]
		private static Comparison<CompletionItem> comparison_0;

		public string Code
		{
			get
			{
				return (string)base.GetValue(NitriqEditor.CodeProperty);
			}
			set
			{
				base.SetValue(NitriqEditor.CodeProperty, value);
			}
		}

		public NitriqEditor()
		{
			this.InitializeComponent();
			this.editorDocument_0.SetText(this.Code);
			this.editorDocument_0.Language = NitriqEditor.LoadLanguageDefinitionFromResourceStream("Nitriq.Wpf.CSharp.langdef");
			this.editorDocument_0.TextChanging += new EventHandler<TextSnapshotChangingEventArgs>(this.method_0);
			this.editorDocument_0.TextChanged += new EventHandler<TextSnapshotChangedEventArgs>(this.method_1);
		}

		public static ISyntaxLanguage LoadLanguageDefinitionFromResourceStream(string filename)
		{
			ISyntaxLanguage result;
			using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(filename))
			{
				if (manifestResourceStream != null)
				{
					SyntaxLanguageDefinitionSerializer syntaxLanguageDefinitionSerializer = new SyntaxLanguageDefinitionSerializer();
					result = syntaxLanguageDefinitionSerializer.LoadFromStream(manifestResourceStream);
				}
				else
				{
					result = SyntaxLanguage.PlainText;
				}
			}
			return result;
		}

		private void method_0(object sender, TextSnapshotChangingEventArgs e)
		{
			if (e.TextChange.Operations.Count == 1 && e.TextChange.Type == TextChangeTypes.Enter && !e.TextChange.Operations[0].IsProgrammaticTextReplacement)
			{
				SyntaxEditor syntaxEditor = this.nitriqSyntaxEditor_0;
				e.Cancel = true;
				int num = syntaxEditor.ActiveView.CurrentViewLine.FirstNonWhitespaceCharacterIndex;
				if (num > syntaxEditor.Caret.Position.Character)
				{
					num = syntaxEditor.Caret.Position.Character;
				}
				string text = "\n" + syntaxEditor.ActiveView.CurrentViewLine.Text.Substring(0, num);
				syntaxEditor.ActiveView.ReplaceSelectedText(TextChangeTypes.AutoIndent, text);
			}
		}

		private void method_1(object sender, TextSnapshotChangedEventArgs e)
		{
			if (this.Code != e.NewSnapshot.Text)
			{
				this.Code = e.NewSnapshot.Text;
			}
		}

		public void OnEditorDocumentTextChanged(object sender, EditorSnapshotChangedEventArgs e)
		{
			string typedText = e.TypedText;
			if (typedText != null && typedText == ".")
			{
				ITextSnapshotReader reader = this.nitriqSyntaxEditor_0.ActiveView.GetReader();
				reader.ReadCharacterReverseThrough('.');
				IToken token = reader.ReadTokenReverse();
				if (token != null)
				{
					this.method_2(false, reader.TokenText);
				}
			}
		}

		private void method_2(bool bool_1, string string_0)
		{
			CompletionSession completionSession = new CompletionSession();
			completionSession.CanCommitWithoutPopup = true;
			completionSession.CanHighlightMatchedText = true;
			completionSession.MatchOptions = CompletionMatchOptions.None;
			completionSession.MatchOptions |= CompletionMatchOptions.IsCaseInsensitive;
			List<CompletionItem> list = new List<CompletionItem>();
			string text = string_0.ToLowerInvariant();
			if (text.Contains("type") || text == "t")
			{
				list.Add(this.method_3("BaseType", "IType", "The Base Type for this Type"));
				list.Add(this.method_3("Fields", "FieldCollection", "A Collection of this Type's Fields"));
				list.Add(this.method_3("Methods", "MethodCollection", "A Collection of this Type's Methods"));
				list.Add(this.method_3("Events", "EventCollection", "A Collection of this Type's Events"));
				list.Add(this.method_3("Interfaces", "TypeCollection", "A Collection of Interfaces that this Type implements"));
				list.Add(this.method_3("TypesUsing", "TypeCollection", "A Collection of Types that depend on this Type"));
				list.Add(this.method_3("TypesUsed", "TypeCollection", "A Collection of Types that this Type depends on"));
				list.Add(this.method_3("DerivedTypes", "TypeCollection", "A Collection of Types that derive from this Type"));
				list.Add(this.method_3("Assembly", "IAssembly", "The IAssembly that contains this Type"));
				list.Add(this.method_3("FullName", "string", "The full name of this Type"));
				list.Add(this.method_3("GenericParameterCount", "int", "The number of generic parameters on this Type"));
				list.Add(this.method_3("IsAbstract", "bool", "Whether or not this Type is Abstract"));
				list.Add(this.method_3("IsClass", "bool", "Whether or not this Type is a Class"));
				list.Add(this.method_3("IsDelegate", "bool", "Whether or not this Type is a Delegate"));
				list.Add(this.method_3("IsEnum", "bool", "Whether or not this Type is an Enum"));
				list.Add(this.method_3("IsInCoreAssembly", "bool", "Returns whether or not this Type is a Core Assembly. Core Assemblies are the assemblies you are primarily concerned with analyzing."));
				list.Add(this.method_3("IsInterface", "bool", "Whether or not this Type is an Interface"));
				list.Add(this.method_3("IsInternal", "bool", "Whether or not this Type is marked Internal"));
				list.Add(this.method_3("IsNested", "bool", "Whether or not this Type is a Nested Type"));
				list.Add(this.method_3("IsPrivate", "bool", "Whether or not this Type is marked Private"));
				list.Add(this.method_3("IsProtected", "bool", "Whether or not this Type is marked Protected (visible only to derived classes)"));
				list.Add(this.method_3("IsProtectedAndInternal", "bool", "Whether or not this Type is marked Protected and Internal (visible only to derived classes from the same assembly)"));
				list.Add(this.method_3("IsProtectedOrInternal", "bool", "Whether or not this Type is marked Protected or Internal (visible only to derived classes or classes in the same assembly)"));
				list.Add(this.method_3("IsPublic", "bool", "Whether or not this Type is marked Public"));
				list.Add(this.method_3("IsSealed", "bool", "Whether or not this Type is Sealed (doesn't allow for derived classes)"));
				list.Add(this.method_3("IsStatic", "bool", "Whether or not this Type is Static"));
				list.Add(this.method_3("IsValueType", "bool", "Whether or not this Type is a Value Type"));
				list.Add(this.method_3("Name", "string", "The name of this Type"));
				list.Add(this.method_3("Namespace", "INamespace", "The INamespace that contains this Type"));
				list.Add(this.method_3("TypeId", "int", "The Nitriq Unique Id for this Type. You must select this in a query in order for the Treemap and other visualizations to work properly"));
				list.Add(this.method_3("PhysicalLineCount", "int", "The sum of the line count for all Methods in this Type. Does NOT include any lines outside of its methods"));
				list.Add(this.method_3("LogicalLineCount", "int", "The number of breakpoints that could be set inside this type"));
				list.Add(this.method_3("CommentLineCount", "int", "The sum of the comment lines for all Methods in this Type. Does NOT include any lines/comments outside of its methods."));
				list.Add(this.method_3("Cyclomatic", "int", "The sum of the cyclomatic complexity for all Methods in this Type"));
				list.Add(this.method_3("ILCount", "int", "The sum of the IL instructions for all Methods in this Type"));
				list.Add(this.method_3("PercentComment", "double", "The CommentLineCount divided by the PhysicalLineCount. (Only counts lines inside a method)"));
				list.Add(this.method_3("InheritanceDepth", "int", "The Depth of this Type in its Inheritance Tree"));
			}
			else if (text.Contains("method") || text == "m")
			{
				list.Add(this.method_3("IsInCoreAssembly", "bool", "Returns whether or not this Method is a Core Assembly. Core Assemblies are the assemblies you are primarily concerned with analyzing."));
				list.Add(this.method_3("ParameterTypes", "TypeCollection", "A distinct set of the Types of this Method's Parameters"));
				list.Add(this.method_3("Type", "IType", "The Type that Declares this method"));
				list.Add(this.method_3("Name", "string", "The Name of this method"));
				list.Add(this.method_3("FullName", "string", "The Full Name of this method"));
				list.Add(this.method_3("TypesUsed", "TypeCollection", "A Collection of Types that this method depends on"));
				list.Add(this.method_3("MethodId", "int", "The Nitriq Unique Id for this Method. You must select this in a query in order for the Treemap and other visualizations to work properly"));
				list.Add(this.method_3("ReturnType", "IType", "The Type that this Method returns"));
				list.Add(this.method_3("LogicalLineCount", "int", "The number of breakpoints that *could* be set in this Method."));
				list.Add(this.method_3("PhysicalLineCount", "int", "The number of line breaks in the source code for this Method."));
				list.Add(this.method_3("CommentLineCount", "int", "The number of lines with comments in the source code for this Method"));
				list.Add(this.method_3("ILCount", "int", "The number of IL Instructions in this Method"));
				list.Add(this.method_3("Cyclomatic", "int", "The Cyclomatic Complexity (CC) of this Method. CC is the number of individual paths through a method. In C# it is the count the following tokens if, &&, ||, for, foreach, case, default, continue, while, goto, catch, ??, and a ternary expression"));
				list.Add(this.method_3("ILCyclomatic", "int", "The cyclomatic complexity of the IL for a method is the count of the distinct offset targets in a branch/jump instruction"));
				list.Add(this.method_3("ParameterCount", "int", "The number of parameters on this Method"));
				list.Add(this.method_3("OverloadCount", "int", "The number of overloads for this Method (same method name on the same class but with a different set of parameters)"));
				list.Add(this.method_3("IsPublic", "bool", "Whether or not this Method is marked Public"));
				list.Add(this.method_3("IsInternal", "bool", "Whether or not this Method is marked Internal (only visible from the same assembly)"));
				list.Add(this.method_3("IsProtected", "bool", "Whether or not this Method is marked Protected"));
				list.Add(this.method_3("IsProtectedOrInternal", "bool", "Whether or not this Type is marked Protected or Internal (visible only to derived classes or classes in the same assembly)"));
				list.Add(this.method_3("IsProtectedAndInternal", "bool", "Whether or not this Type is marked Protected and Internal (visible only to derived classes from the same assembly)"));
				list.Add(this.method_3("IsPrivate", "bool", "Whether or not this Method is marked Private"));
				list.Add(this.method_3("IsConstructor", "bool", "Whether or not this Method is a Constructor"));
				list.Add(this.method_3("IsPropertyGetter", "bool", "Whether or not this Method is a Property Getter"));
				list.Add(this.method_3("IsPropertySetter", "bool", "Whether or not this Method is a Property Setter"));
				list.Add(this.method_3("IsStatic", "bool", "Whether or not this Method is marked Static"));
				list.Add(this.method_3("IsVirtual", "bool", "Whether or not this Method is marked Virtual"));
				list.Add(this.method_3("UsesBoxing", "bool", "Whether or not this Method uses Boxing"));
				list.Add(this.method_3("UsesUnboxing", "bool", "Whether or not this Method uses Unboxing"));
				list.Add(this.method_3("IsGeneric", "bool", "Whether or not this Method is has generic parameters"));
				list.Add(this.method_3("IsOperator", "bool", "Whether or not this Method is an Operator"));
				list.Add(this.method_3("IsIndexGetter", "bool", "Whether or not this Method is an Index Getter (ie this[int index])"));
				list.Add(this.method_3("IsIndexSetter", "bool", "Whether or not this Method is an Index Setter (ie this[int index])"));
				list.Add(this.method_3("IsEventAdder", "bool", "Whether or not this Method is an Event Adder"));
				list.Add(this.method_3("IsEventRemover", "bool", "Whether or not this Method is an Index Remover"));
				list.Add(this.method_3("IsStaticConstructor", "bool", "Whether or not this Method is a Static Constructor"));
				list.Add(this.method_3("PercentComment", "double", "The percent of lines in this Method that are comments (100 * CommentLineCount / PhysicalLineCount)"));
				list.Add(this.method_3("Calls", "MethodCollection", "Methods that this Method Calls"));
				list.Add(this.method_3("CalledBy", "MethodCollection", "Methods that call this Method"));
				list.Add(this.method_3("FieldSets", "FieldCollection", "Fields that this Method Sets"));
				list.Add(this.method_3("FieldGets", "FieldCollection", "Fields that this Method Gets (reads from)"));
			}
			else if (text.Contains("event") || text == "e" || text == "ev")
			{
				list.Add(this.method_3("IsInCoreAssembly", "bool", "Returns whether or not this Event is a Core Assembly. Core Assemblies are the assemblies you are primarily concerned with analyzing."));
				list.Add(this.method_3("Type", "IType", "The Type that Declares this Event"));
				list.Add(this.method_3("Name", "string", "The Name of this Event"));
				list.Add(this.method_3("FullName", "string", "The Full Name of this Event"));
				list.Add(this.method_3("TypesUsed", "TypeCollection", "A Collection of Types that this Event depends on"));
				list.Add(this.method_3("EventType", "IType", "The Type of this Event"));
				list.Add(this.method_3("EventId", "int", "The Nitriq Unique Id for this Event. You must select this in a query in order for the Treemap and other visualizations to work properly"));
				list.Add(this.method_3("IsPublic", "bool", "Whether or not this Event is marked Public"));
				list.Add(this.method_3("IsInternal", "bool", "Whether or not this Event is marked Internal"));
				list.Add(this.method_3("IsProtected", "bool", "Whether or not this Event is marked Protected"));
				list.Add(this.method_3("IsPrivate", "bool", "Whether or not this Event is marked Private"));
				list.Add(this.method_3("IsStatic", "bool", "Whether or not this Event is marked Static"));
			}
			else if (text.Contains("field") || text == "f")
			{
				list.Add(this.method_3("IsInCoreAssembly", "bool", "Returns whether or not this Field is a Core Assembly. Core Assemblies are the assemblies you are primarily concerned with analyzing."));
				list.Add(this.method_3("Type", "IType", "The Type that Declares this Field"));
				list.Add(this.method_3("Name", "string", "The Name of this Field"));
				list.Add(this.method_3("FullName", "string", "The Full Name of this Field"));
				list.Add(this.method_3("TypesUsed", "TypeCollection", "A Collection of Types that this Field depends on"));
				list.Add(this.method_3("FieldId", "int", "The Nitriq Unique Id for this Field. You must select this in a query in order for the Treemap and other visualizations to work properly"));
				list.Add(this.method_3("FieldType", "IType", "The Type of this Field"));
				list.Add(this.method_3("SetByMethods", "MethodCollection", "A Collection of Methods that assign values to this Field"));
				list.Add(this.method_3("GotByMethods", "MethodCollection", "A Collection of Methods that retrieve values from this Field"));
				list.Add(this.method_3("IsPublic", "bool", "Whether or not this Field is marked Public"));
				list.Add(this.method_3("IsInternal", "bool", "Whether or not this Field is marked Internal"));
				list.Add(this.method_3("IsProtected", "bool", "Whether or not this Field is marked Protected"));
				list.Add(this.method_3("IsProtectedOrInternal", "bool", "Whether or not this Field is marked Protected or Internal"));
				list.Add(this.method_3("IsProtectedAndInternal", "bool", "Whether or not this Field is marked Protected and Internal"));
				list.Add(this.method_3("IsPrivate", "bool", "Whether or not this Field is marked Private"));
				list.Add(this.method_3("IsStatic", "bool", "Whether or not this Field is marked Static"));
				list.Add(this.method_3("IsConstant", "bool", "Whether or not this Field is marked const"));
			}
			else if (text.Contains("assembly") || text.Contains("assem") || text == "a")
			{
				list.Add(this.method_3("AssemblyId", "int", "The Nitriq Unique Id given to this Assembly. You must select this in a query in order for the Treemap and other visualizations to work properly."));
				list.Add(this.method_3("Version", "string", "The Version of this Assembly"));
				list.Add(this.method_3("Namespaces", "NamespaceCollection", "The INamespace array of Namespaces in this Assembly"));
				list.Add(this.method_3("Name", "string", "The name of this Assembly"));
				list.Add(this.method_3("IsCoreAssembly", "bool", "Returns whether or not this Assembly is a Core Assembly. Core Assemblies are the assemblies you are primarily concerned with analyzing - typically excludes Microsoft and 3rd Party Assemblies."));
			}
			else if (text.Contains("namespace") || text == "n" || text == "ns")
			{
				list.Add(this.method_3("FullName", "string", "The FullName of this Namespace"));
				list.Add(this.method_3("Types", "TypeCollection", "A Collection of Types that are contained in this Namespace"));
				list.Add(this.method_3("NamespaceId", "int", "The Nitriq Unique Id given to this Namespace. You must select this in a query in order for the Treemap and other visualizations to work properly."));
			}
			List<CompletionItem> arg_D81_0 = list;
			if (NitriqEditor.comparison_0 == null)
			{
				NitriqEditor.comparison_0 = new Comparison<CompletionItem>(NitriqEditor.smethod_2);
			}
			arg_D81_0.Sort(NitriqEditor.comparison_0);
			foreach (CompletionItem current in list)
			{
				completionSession.Items.Add(current);
			}
			completionSession.Open(this.nitriqSyntaxEditor_0.ActiveView);
		}

		private CompletionItem method_3(string string_0, string string_1, string string_2)
		{
			return new CompletionItem(string_0, new CommonImageSourceProvider(CommonImage.PropertyPublic), new PropertyQuickInfoProvider
			{
				Name = string_0,
				PropertyType = string_1,
				Summary = string_2
			});
		}

		private static object smethod_0(DependencyObject dependencyObject_0, string string_0)
		{
			NitriqEditor nitriqEditor = dependencyObject_0 as NitriqEditor;
			object result;
			if (nitriqEditor != null)
			{
				result = nitriqEditor.OnCoerceCode((string)string_0);
			}
			else
			{
				result = string_0;
			}
			return result;
		}

		private static void smethod_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			NitriqEditor nitriqEditor = dependencyObject_0 as NitriqEditor;
			if (nitriqEditor != null)
			{
				nitriqEditor.OnCodeChanged((string)dependencyPropertyChangedEventArgs_0.OldValue, (string)dependencyPropertyChangedEventArgs_0.NewValue);
			}
		}

		protected virtual string OnCoerceCode(string value)
		{
			return value;
		}

		protected virtual void OnCodeChanged(string oldValue, string newValue)
		{
			if (this.nitriqSyntaxEditor_0.Text != newValue)
			{
				this.nitriqSyntaxEditor_0.Text = newValue;
			}
		}

		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Nitriq.Wpf;component/nitriqeditor.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[DebuggerNonUserCode]
		internal Delegate method_4(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.nitriqSyntaxEditor_0 = (NitriqSyntaxEditor)target;
				break;
			case 2:
				this.editorDocument_0 = (EditorDocument)target;
				break;
			default:
				this.bool_0 = true;
				break;
			}
		}

		[CompilerGenerated]
		private static int smethod_2(CompletionItem completionItem_0, CompletionItem completionItem_1)
		{
			return completionItem_0.Text.CompareTo(completionItem_1.Text);
		}

		static NitriqEditor()
		{
			NitriqEditor.CodeProperty = DependencyProperty.Register("Code", typeof(string), typeof(NitriqEditor), new UIPropertyMetadata(null, new PropertyChangedCallback(NitriqEditor.smethod_1), new CoerceValueCallback(NitriqEditor.smethod_0)));
		}
	}
}
