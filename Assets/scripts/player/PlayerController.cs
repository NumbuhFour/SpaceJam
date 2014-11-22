using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horiz = Input.GetAxisRaw("Horizontal");
		float vert = Input.GetAxisRaw("Vertical");

		if(horiz != 0){
			Vector3 position = this.transform.position;
			position.x += horiz*speed;
			this.transform.position = position;
		}
		if(vert != 0){
			Vector3 position = this.transform.position;
			position.y += vert*speed;
			this.transform.position = position;
		}
	}
}
