using UnityEngine;
using System.Collections;

public class Float : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (new Vector3 (0, 5, 10), Vector3.up, 1f);
	}
}
