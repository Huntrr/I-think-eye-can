using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	// Use this for initialization
	void Start () {
		print ("hi");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.tag.Equals("Visible")) {
			transform.Rotate (Vector3.right * 1);
		}
	}
}
