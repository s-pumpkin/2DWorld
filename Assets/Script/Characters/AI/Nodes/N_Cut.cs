
using UnityEngine;
using System;
using spumpkin.Definitions;
using spumpkin.World;
using spumpkin.Entities;

namespace spumpkin.Characters.AI {
	public class N_Cut : BrainNodeConditional {
		private class CutPlantAtPosition: BrainNode {
			public override Task GetTask() {
				// Closest plant to cut to the character position
				Tilable tilable = WorldUtils.NextToCut(this.character.position);
				if (tilable != null) {
					return new Task(
						Defs.tasks["task_cut"],
						new TargetList(new Target(tilable))
					);
				}

				return null;
			}
		}


		public N_Cut(Func<bool> condition) : base(condition) {
			this.subNodes.Add(new CutPlantAtPosition());
		}
	}
}