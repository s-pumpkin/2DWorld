
using System.Collections.Generic;
using UnityEngine;
using spumpkin.Characters;
using spumpkin.Helpers;

namespace spumpkin.Controllers {
	public class WindowController : MonoBehaviour {
		private void Start() {
			UI.WindowComponents.LoadComponents();
		}
		private void OnGUI() {
			foreach (UI.Window window in UI.Window.windows) {
				window.OnGUI();
			}
		}
	}
}