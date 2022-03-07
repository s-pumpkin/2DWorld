
using UnityEngine;
using System.Collections.Generic;
using spumpkin.Helpers;
using spumpkin.Definitions;

namespace spumpkin.Entities {
	public class GrowArea : Area {
		public static List<GrowArea> areas = new List<GrowArea>();
		public TilableDef plantDef { get; protected set; }
		public HashSet<Field> fields { get; protected set; }

		public GrowArea(TilableDef plantDef) {
			this.fields = new HashSet<Field>();
			this.plantDef = plantDef;
			this.color = new Color(0, 1f, 0, .4f);
			GrowArea.areas.Add(this);
		}

		protected override void AddTilable(Vector2Int position) {
			// Add the field tialble, here we should check if we already have a field on this position.
			Field field = new Field(position, Defs.empty, this);
			Loki.map.Spawn(
				position,
				field
			);
			this.fields.Add(field);
			base.AddTilable(position);
			
		}

		protected override void DelTilable(Vector2Int position) {
			// Remove titlable,  here we should check if we already have a field on this position.
			base.DelTilable(position);
			// @TODO: Remove field from field hashset;
		}
	}
}