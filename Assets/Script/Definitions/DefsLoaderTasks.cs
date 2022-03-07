
using System.Collections.Generic;
using UnityEngine;
using spumpkin.Characters.AI;

namespace spumpkin.Definitions {
	// A static class to load our definitions
	// Everything will be loaded from code or JSON files. 
	public static partial  class Defs {
		/// Add a plant definition to our plant dictionary
		public static void AddTask(TaskDef def) {
			Defs.tasks.Add(def.uid, def);
		}

		/// Load all tasks definitions
		public static void LoadTasksFromCode() {
			Defs.tasks = new Dictionary<string, TaskDef>();

			Defs.AddTask(new TaskDef{
				uid = "task_sleep",
				taskType = TaskType.Sleep
			});

			Defs.AddTask(new TaskDef{
				uid = "task_cut",
				taskType = TaskType.Cut,
				targetType = TargetType.Adjacent,
			});

			Defs.AddTask(new TaskDef{
				uid = "task_harvest",
				taskType = TaskType.Harvest,
				targetType = TargetType.Adjacent,
			});

			Defs.AddTask(new TaskDef{
				uid = "task_dirt",
				taskType = TaskType.Dirt,
				targetType = TargetType.Adjacent,
			});

			Defs.AddTask(new TaskDef{
				uid = "task_sow",
				taskType = TaskType.Sow,
				targetType = TargetType.Adjacent,
			});

			Defs.AddTask(new TaskDef{
				uid = "haul_recipe",
				taskType = TaskType.HaulRecipe,
				targetType = TargetType.Adjacent,
			});

			Defs.AddTask(new TaskDef{
				uid = "task_idle",
				taskType = TaskType.Idle
			});

			Defs.AddTask(new TaskDef{
				uid = "task_eat",
				taskType = TaskType.Eat
			});
		}
	}
}