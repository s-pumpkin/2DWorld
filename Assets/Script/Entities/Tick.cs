
using System.Collections.Generic;

namespace spumpkin.Entities {
	public delegate void TickDelegate();

	/// Quick class for ticking our tilables
	public class Tick {
		public int tick = 0;
		public int speed = 1;

		public Queue<TickDelegate> toAdd = new Queue<TickDelegate>();
		public Queue<TickDelegate> toDel = new Queue<TickDelegate>();
		public List<TickDelegate> updates = new List<TickDelegate>();

		public void DoTick() {
			this.tick++;

			while (this.toDel.Count != 0) {
				this.updates.Remove(this.toDel.Dequeue());
			}
			while (this.toAdd.Count != 0) {
				this.updates.Add(this.toAdd.Dequeue());
			}

			for (int i = 0; i < this.updates.Count; i++) {
				this.updates[i].Invoke();
			}
		}
	}
}