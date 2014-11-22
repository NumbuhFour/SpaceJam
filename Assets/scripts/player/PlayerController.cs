using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public float rotationSpeed = 3;

	private Rigidbody2D rigid;
	// Use this for initialization
	void Start () {
		rigid = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float horiz = Input.GetAxisRaw("Horizontal");
		float vert = Input.GetAxisRaw("Vertical");

		if(horiz != 0){
			this.rigid.AddTorque(rotationSpeed * horiz * Time.deltaTime * 1000);
			//this.transform.Rotate(new Vector3(0,0,rotationSpeed*horiz));
		}
		if(vert != 0){
			//Vector3 position = this.transform.position;
			//position += this.transform.up*speed*vert;
			//this.transform.position = position;
			this.rigid.AddForce((Vector2)this.transform.up * speed * vert * Time.deltaTime * 1000);
		}
	}
}
