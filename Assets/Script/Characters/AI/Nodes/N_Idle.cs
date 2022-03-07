
using System;
using spumpkin.Definitions;

namespace spumpkin.Characters.AI {
	public class N_Idle : BrainNode {
		public override Task GetTask() {
			return new Task(
				Defs.tasks["task_idle"],
				new TargetList(Target.GetRandomTargetInRange(this.character.position)),
				UnityEngine.Random.Range(100, 250)
			);
		}
	}
}