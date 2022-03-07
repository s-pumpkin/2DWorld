
using UnityEngine;
using System;
using spumpkin.Definitions;
using spumpkin.World;

namespace spumpkin.Characters.AI {
	public class N_EatVegies : BrainNodeConditional {
		private class N_EatVegiesTaskData : BrainNode {
			public override Task GetTask() {
				BucketResult result = WorldUtils.HasVegetalNutrimentsInBucket(this.character.position);

				if (result.result) {
					return new Task(
						Defs.tasks["task_eat"],
						new TargetList(new Target(result.tilable))
					);
				}
				// We want to order the animal to change region, maybe go back to the spawning region.
				return null;
			}
		}

		public N_EatVegies(Func<bool> condition) : base(condition) {
			this.subNodes.Add(new N_EatVegiesTaskData());
		}
	}
}