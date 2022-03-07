
using System;
using spumpkin.Definitions;

namespace spumpkin.Characters.AI {
	public class N_Sleep : BrainNodeConditional {
		private class N_SleepTask : BrainNode {
			public override Task GetTask() {
				return new Task(
					Defs.tasks["task_sleep"],
					new TargetList(Target.GetRandomTargetInRange(this.character.position))
				);
			}
		}

		public N_Sleep(Func<bool> condition) : base(condition) {
			this.subNodes.Add(new N_SleepTask());
		}
	}
}