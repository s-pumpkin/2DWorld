
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using spumpkin.Helpers;
using spumpkin.World;
using spumpkin.Entities;
using spumpkin.Definitions;

namespace spumpkin.Controllers {
	public class StackableLabelController : MonoBehaviour {
		public static GameObjectPool goPool = new GameObjectPool();

		public List<GameObject> actives = new List<GameObject>();

		private void Awake() {
			if (StackableLabelController.goPool.queue.Count == 0) {
				GameObject go = new GameObject("Label GameObject");
				go.transform.SetParent(this.transform);
				go.AddComponent<LabelComponent>();
				StackableLabelController.goPool.AddFromClone(go, this.transform, 100);
			}
		}

		public void AddLabel(Stackable stackable) {
			GameObject go = StackableLabelController.goPool.GetFromPool();
			go.GetComponent<LabelComponent>().SetStackable(stackable);
		}
	}
}