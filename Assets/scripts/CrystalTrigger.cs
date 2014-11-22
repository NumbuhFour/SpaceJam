using UnityEngine;
using System.Collections;

public class CrystalTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D coll){
		GameObject.Destroy(this.gameObject);
		GameObject.Find("Main").GetComponent<Main>().Score += 100;
	}
}
