using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using spumpkin.Definitions;
using spumpkin.Helpers;

namespace spumpkin.UI {
	public class InfoController : MonoBehaviour {
		public Text title;
		public Text desc;

		void Awake() {
			this.title = this.GetComponentsInChildren<Text>()[0];
			this.desc = this.GetComponentsInChildren<Text>()[1];
			this.Reset();
		}

		public void Reset() {
			this.title.text = "Did you know ?";
			this.desc.text = "42";
		}
	}
}