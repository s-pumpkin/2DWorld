
using spumpkin.Entities;

namespace spumpkin.Characters.AI {
	public class TaskEat : TaskClass {
		public TaskEat(BaseCharacter character, Task task) : base(character, task) {}

		public override bool Perform() {
			Tilable tilable = (Tilable)this.task.targets.current.tilable;
			this.character.stats.vitals[Vitals.Hunger].currentValue += tilable.def.nutriments * 100f;
			tilable.Destroy();
			return true;
		}
	}
}