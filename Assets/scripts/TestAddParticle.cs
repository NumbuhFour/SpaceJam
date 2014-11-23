using UnityEngine;
using System.Collections;

public class TestAddParticle : MonoBehaviour {

	public GameObject particlePrefab;
	public int addAmount = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw("Fire2") != 0){
			for(int i = 0; i < addAmount; i++)
				GameObject.Instantiate(particlePrefab, this.transform.position, this.transform.rotation);
		}
	}
}