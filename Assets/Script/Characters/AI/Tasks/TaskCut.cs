
using spumpkin.Entities;

namespace spumpkin.Characters.AI {
	public class TaskCut : TaskClass {
		public TaskCut(BaseCharacter character, Task task) : base(character, task) {}

		public override bool Perform() {
			Plant plant = (Plant)this.task.targets.current.tilable;
			plant.Cut();
			return true;
		}
	}

	public class TaskDirt : TaskClass {
		public TaskDirt(BaseCharacter character, Task task) : base(character, task) {}

		public override bool Perform() {
			Field field = (Field)this.task.targets.current.tilable;
			field.WorkDirt();
			return true;
		}
	}

	public class TaskSow : TaskClass {
		public TaskSow(BaseCharacter character, Task task) : base(character, task) {}

		public override bool Perform() {
			Field field = (Field)this.task.targets.current.tilable;
			Loki.map.Spawn(this.task.targets.current.position, new Plant(
				field.position, 
				field.area.plantDef, 
				false)
			);
			return true;
		}
	}
}