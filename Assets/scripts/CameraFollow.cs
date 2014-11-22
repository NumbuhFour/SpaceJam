using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothTime = 0.3f;

	private Vector3 vel = Vector3.zero;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPos = new Vector3(target.position.x, target.position.y, this.transform.position.z);
		this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPos, ref vel, smoothTime);
	}
}
