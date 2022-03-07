
using UnityEngine;
using spumpkin.Definitions;

namespace spumpkin.Entities
{
    /// Item tilable	
    public class Item : Tilable {
		public Item(TilableDef def) {
			this.def = def;
		}
	}
}