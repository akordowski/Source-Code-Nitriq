using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Nitriq.Project.Models
{
	[Serializable]
	public class RuleSet
	{
		private ObservableCollection<RuleCategory> observableCollection_0 = new ObservableCollection<RuleCategory>();

		public ObservableCollection<RuleCategory> RuleCategories
		{
			get
			{
				return this.observableCollection_0;
			}
		}

		public IEnumerable<Rule> RulesEnumerator()
		{
			RuleSet.<RulesEnumerator>d__0 <RulesEnumerator>d__ = new RuleSet.<RulesEnumerator>d__0(-2);
			<RulesEnumerator>d__.<>4__this = this;
			return <RulesEnumerator>d__;
		}

		public IEnumerable<RuleCategory> RuleCategoryEnumerator()
		{
			RuleSet.<RuleCategoryEnumerator>d__9 <RuleCategoryEnumerator>d__ = new RuleSet.<RuleCategoryEnumerator>d__9(-2);
			<RuleCategoryEnumerator>d__.<>4__this = this;
			return <RuleCategoryEnumerator>d__;
		}

		public void Remove(RuleCategory removeThis)
		{
			foreach (RuleCategory current in this.observableCollection_0)
			{
				current.Remove(removeThis);
			}
			this.observableCollection_0.Remove(removeThis);
		}

		public void Remove(Rule removeThis)
		{
			foreach (RuleCategory current in this.observableCollection_0)
			{
				current.Remove(removeThis);
			}
		}
	}
}
