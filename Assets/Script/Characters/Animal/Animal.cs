
using UnityEngine;
using spumpkin.Definitions;
using spumpkin.Characters.AI;

namespace spumpkin.Characters {
	public class Animal : BaseCharacter {
		public Animal(Vector2Int position, AnimalDef def) : base(position, def) {}

		public override BrainNodePriority GetBrainNode() {
			BrainNodePriority brainNode = new BrainNodePriority();

			brainNode.AddSubnode(new N_Sleep(() => (this.stats.vitals[Vitals.Energy].ValueInfToPercent(.15f))));
			brainNode.AddSubnode(new N_EatVegies(() => (this.stats.vitals[Vitals.Hunger].ValueInfToPercent(.25f))));
			brainNode.AddSubnode(new N_Idle());
			return brainNode;
		}
	}
}