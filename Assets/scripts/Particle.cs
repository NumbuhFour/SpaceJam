using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {
	public float pull = 5f;
	
	private Transform fluidCenter;
	private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
		fluidCenter = GameObject.FindWithTag("FluidCenter").transform;
		rigid = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = fluidCenter.position - this.transform.position;
		dir.Normalize();
		this.rigid.AddForce(dir * pull * Time.deltaTime*1000); 
	}
}