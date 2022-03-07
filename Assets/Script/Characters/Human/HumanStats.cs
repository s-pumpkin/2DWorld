
using System.Collections.Generic;
using UnityEngine;

namespace spumpkin.Characters {
	// Human stats
	public class HumanStats : CharacterStats {
		public HumanStats() : base() {}

		/// Define all humans attributes.
		protected override void LoadAttributes() {
			base.LoadAttributes();
			
			this.attributes[Attributes.InventorySize].AddModifier(new StatModifier(this.stats[Stats.Strength], 3f));

			foreach (Attribute att in this.attributes.Values) {
				att.Update();
			}
		}

		public override string ToString() {
			string str = "HumanStats(";
			foreach (Stat stat in this.stats.Values) {
				str += stat.name+":"+stat.value+",";
			}
			foreach (Vital stat in this.vitals.Values) {
				str += stat.name+":"+stat.value+",";
			}
			foreach (Attribute stat in this.attributes.Values) {
				str += stat.name+":"+stat.value+",";
			}
			return str+")";
		}
	}
}

