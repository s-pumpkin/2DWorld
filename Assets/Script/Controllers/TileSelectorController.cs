
using System.Collections.Generic;
using UnityEngine;
using spumpkin.Characters;
using spumpkin.Helpers;
using spumpkin.UI;

namespace spumpkin.Controllers {
	public class TileSelectorController : MonoBehaviour {
		private Vector2Int currentTilePosition;
		private int currentIndex = 0;
		private Dictionary<BaseCharacter, WindowCharacter> _characterWindows;
		
		private void Awake() {
			this._characterWindows = new Dictionary<BaseCharacter, WindowCharacter>();
		}

		private void Update() {
			if (Loki.manager.ready) {
				int i = 0;
				if (Input.GetMouseButton(0)) { /// Check if we're in building mode;
					foreach (BaseCharacter character in Loki.map[Loki.cameraController.tileMapMousePosition].characters) {
						if (i == this.currentIndex) {
							this.DisplayCharacterData(Loki.cameraController.tileMapMousePosition, character);
						}
						i++;
					}
				}
			}
		}

		private void DisplayCharacterData(Vector2Int position, BaseCharacter character) {
			if (this.currentTilePosition == position) {
				this.currentIndex++;
			} else {
				this.currentIndex = 0;
			}
			
			if (this._characterWindows.ContainsKey(character)) {
				this._characterWindows[character].Show();
			} else {
				this._characterWindows.Add(character, new WindowCharacter(character));
			}
		}
	}
}