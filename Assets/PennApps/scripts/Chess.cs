using UnityEngine;
using System.Collections;

public class Chess : MonoBehaviour {

	public GameObject black_pawn;
	public GameObject black_rook;
	public GameObject black_bishop;
	public GameObject black_knight;
	public GameObject black_king;
	public GameObject black_queen;

	public GameObject white_pawn;
	public GameObject white_rook;
	public GameObject white_bishop;
	public GameObject white_knight;
	public GameObject white_king;
	public GameObject white_queen;

	// Use this for initialization
	void Start () {
		print ("AWDWD");
		GameObject o = Instantiate (Resources.Load("Chess_Rock_B1"), new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
		o.transform.parent = transform;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
