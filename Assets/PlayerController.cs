using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 500;
	public float rotationSpeed = 3;
	public float dist = 0.5f;
	public float radius = 0.5f;

	private bool wasFirePressed = false;
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
			this.rigid.AddTorque(rotationSpeed * -horiz * Time.deltaTime * 1000);
			//this.transform.Rotate(new Vector3(0,0,rotationSpeed*horiz));
		}
		if(vert != 0){
			Debug.Log("W");
			//Vector3 position = this.transform.position;
			//position += this.transform.up*speed*vert;
			//this.transform.position = position;
			rigid.AddForce((Vector2)this.transform.up * speed * vert * Time.deltaTime * 1000);
		}

		bool fire = Input.GetAxisRaw("Fire1") != 0;
		if(fire && !wasFirePressed){
			Collider2D[] particles = Physics2D.OverlapCircleAll(this.transform.position + this.transform.up*dist, radius, 1 << LayerMask.NameToLayer("particle"));
			foreach(Collider2D c in particles){
				GameObject.Destroy(c.gameObject);
			}
		}
		wasFirePressed = fire;
	}
}
