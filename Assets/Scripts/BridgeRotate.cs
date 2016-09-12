using UnityEngine;
using System.Collections;

public class BridgeRotate : MonoBehaviour {
	public Animator anim;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame e.g. 30fps
	void Update () {
	
	}

		void OnTriggerEnter(Collider other) {
				if (other.tag == "Player" && other.GetComponent<player>().hasKey) 
						anim.SetTrigger("Rotate");
	}
}