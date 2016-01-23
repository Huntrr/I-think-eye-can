using UnityEngine;
using System.Collections;
using Vuforia;

public class Loader : MonoBehaviour, ITrackableEventHandler {
	private TrackableBehaviour mTrackableBehaviour;
	private string current_model = "chess";
	private Transform myModelTrf;
	private bool update = false;

	public Transform chess;
	private Vector3 chess_size = new Vector3 (4f, 4f, 4f);
	private Quaternion chess_rotate = Quaternion.identity;
	private Vector3 chess_position = new Vector3(0f, 0f, 0f);

	public Transform skull;
	private Vector3 skull_size = new Vector3 (0.015f, 0.015f, 0.015f);
	private Quaternion skull_rotate = Quaternion.Euler(new Vector3(-90.0f, 0f, 0f));
	private Vector3 skull_pos = new Vector3 (0.08f, 13f, 2.59f);
	//private Vector3 skull_size = new Vector3 (0.005f, 0.005f, 0.005f);
	//private Quaternion skull_rotate = Quaternion.Euler(new Vector3(-90.0f, 0f, 0f));
	//private Vector3 skull_pos = new Vector3 (0.08f, 4.51f, 0.59f);

	public Transform physics;
	private Vector3 physics_size = new Vector3 (1f, 1f, 1f);
	private Quaternion physics_rotate = Quaternion.identity;
	private Vector3 physics_pos = new Vector3 (0f, 0f, 0f);

	public Transform physics2;
	private Vector3 physics2_size = new Vector3 (0.5f, 0.5f, 0.5f);
	private Quaternion physics2_rotate = Quaternion.identity;
	private Vector3 physics2_pos = new Vector3 (1.918f, 3.668f, 0.3180f);

	public Transform glucose;
	private Vector3 glucose_size = new Vector3 (0.5f, 0.5f, 0.5f);
	private Quaternion glucose_rotate = Quaternion.Euler (new Vector3 (-0.9642f, 0.0976f, 1.6003f));
	private Vector3 glucose_pos = new Vector3 (-1.836f, -0.902f, -0.241f);

	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour) {
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	void Update () {
	
		if (Input.anyKeyDown) {
			update = true;
			if (current_model.Equals ("chess")) {
				current_model = "skull";
			} else if (current_model.Equals ("skull")) {
				current_model = "physics2";
			} else if (current_model.Equals ("physics2")) {
				current_model = "physics";
			} else if (current_model.Equals ("physics")) {
				current_model = "glucose";
			} else {
				current_model = "chess";
			}

			OnTrackingFound ();
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus) { 
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED ||
			update)
		{
			OnTrackingFound();
		}
	} 

	private void OnTrackingFound() {
		
		if (current_model != null) {
			if (myModelTrf != null) {
				Destroy (myModelTrf.gameObject);
			}

			switch (current_model) {
			case "chess":
				myModelTrf = GameObject.Instantiate (chess) as Transform;
				myModelTrf.parent = mTrackableBehaviour.transform;
				myModelTrf.localPosition = chess_position;
				myModelTrf.localRotation = chess_rotate;
				myModelTrf.localScale = chess_size;
				break;

			case "skull":
				myModelTrf = GameObject.Instantiate (skull) as Transform;
				myModelTrf.parent = mTrackableBehaviour.transform;
				myModelTrf.localPosition = skull_pos;
				myModelTrf.localRotation = skull_rotate;
				myModelTrf.localScale = skull_size;
				break;
			
			case "physics2":
				myModelTrf = GameObject.Instantiate (physics2) as Transform;
				myModelTrf.parent = mTrackableBehaviour.transform;
				myModelTrf.localPosition = physics2_pos;
				myModelTrf.localRotation = physics2_rotate;
				myModelTrf.localScale = physics2_size;
				break;

			case "physics":
				myModelTrf = GameObject.Instantiate (physics) as Transform;
				myModelTrf.parent = mTrackableBehaviour.transform;
				myModelTrf.localPosition = physics_pos;
				myModelTrf.localRotation = physics_rotate;
				myModelTrf.localScale = physics_size;
				break;

			case "glucose":
				myModelTrf = GameObject.Instantiate (glucose) as Transform;
				myModelTrf.parent = mTrackableBehaviour.transform;
				myModelTrf.localPosition = glucose_pos;
				myModelTrf.localRotation = glucose_rotate;
				myModelTrf.localScale = glucose_size;
				break;
			}

			if (myModelTrf != null) {
				myModelTrf.gameObject.active = true;
			}
		}
	}
}