using UnityEngine;
using System.Collections;
using Vuforia;

public class Loader : MonoBehaviour, ITrackableEventHandler {
	private TrackableBehaviour mTrackableBehaviour;
	private Transform currentModel;

	public Transform chess;
	public Transform skull;

	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour) {
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	void Update () { }

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus) { 
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			OnTrackingFound();
		}
	} 

	private void OnTrackingFound() {
		if (myModelPrefab != null)
		{
			Transform myModelTrf = GameObject.Instantiate(myModelPrefab) as Transform;
			myModelTrf.parent = mTrackableBehaviour.transform;
			myModelTrf.localPosition = new Vector3(0f, 0f, 0f);
			myModelTrf.localRotation = Quaternion.identity;
			myModelTrf.localScale = new Vector3(4f, 4f, 4f);
			myModelTrf.gameObject.active = true;
		}
	}
}