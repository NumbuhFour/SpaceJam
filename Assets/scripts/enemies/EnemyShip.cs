using UnityEngine;
using System.Collections;

public class EnemyShip : MonoBehaviour {

	public float speed = 0.5f;
	public float rotationSpeed = 2f;
	private GameObject player;

	private Rigidbody2D rigid;

	// Just for testing
	private float goalAngle = 0f;

	// Use this for initialization
	void Start () {
		rigid = this.GetComponent<Rigidbody2D>();
		player = (GameObject)GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {

		//float goalAngle = Vector3.Angle (this.transform.position, );
		// For testing:

		//float turn = turnTowards (this.transform.rotation.eulerAngles, goalAngle, rotationSpeed);;

		//Vector3 position = this.transform.position;
		//position
		Vector3 dir = player.transform.position - transform.position;
		float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg - 90;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);

		//transform.LookAt (Vector3.forward, Vector3.Cross (Vector3.forward, Vector3.Angle(transform.position, player.transform.position)));

			//Vector3 position = this.transform.position;
			//position += this.transform.up*speed*vert;
			//this.transform.position = position;

		//this.rigid.addTorque(rotationSpeed *  * Time.deltaTime * 1000);

		this.rigid.AddForce((Vector2)this.transform.up * speed * Time.deltaTime * 1000);


		
	}
}

/*
 * using UnityEngine;
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
			this.rigid.AddForce((Vector2)this.transform.up * speed * vert * Time.deltaTime * 1000 * -1);
		}
	}
}

 * 
 */ 
