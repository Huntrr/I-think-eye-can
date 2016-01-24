using System;

	public class Element
	{
		private string type;
		private int rotate;
		private int zoom;
		private int x;
		private int y;
		private int z;
		private int rotate_rate;
		private string equation;

		public Element(string type, int rotate, int zoom, int x, int y, 
			int z, int rotate_rate, string equation) {
			this.type = type;
			this.rotate = rotate;
			this.zoom = zoom; 
			this.x = x;
			this.y = y;
			this.z = z;
			this.rotate_rate = rotate;
			if(type.Equals("equation")) {
				this.equation = equation;
			}

		}

		public int GetX() {
			return this.x;
		}
		public int GetY() {
			return this.y;
		}
		public int GetZ() {
			return this.z;
		} 
		public string GetType() {
			return this.type;
		}
		public int GetRotate() {
			return this.rotate;
		}
		public int GetZoom() {
			return this.zoom;
		}
		public int GetRotateRate() {
			return this.rotate_rate;
		}
		public string GetEquation() {
			return this.equation;
		}
	}
