
using System.Collections.Generic;
using UnityEngine;
using spumpkin.Characters.AI;

namespace spumpkin.Definitions {
	/// Definition for a plant
	[System.Serializable]
	public class TaskDef : Def {
		public TargetType targetType = TargetType.Tile;
		public TaskType taskType;
		public int ticksToPerform = 55;
	}
}