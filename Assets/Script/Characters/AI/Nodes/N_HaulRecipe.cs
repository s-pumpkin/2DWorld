
using UnityEngine;
using System;
using spumpkin.Definitions;
using spumpkin.World;
using spumpkin.Entities;

namespace spumpkin.Characters.AI {
	public class N_HaulRecipe : BrainNodeConditional {
		private class _HaulRecipe: BrainNode {
			public override Task GetTask() {
				TargetList targets = WorldUtils.RecipesToComplete(10, this.character);
				if (targets != null && targets.targets.Count != 0) {
					return new Task(
						Defs.tasks["haul_recipe"],
						targets
					);
				}
				return null;
			}
		}

		public N_HaulRecipe(Func<bool> condition) : base(condition) {
			this.subNodes.Add(new _HaulRecipe());
		}
	}
}