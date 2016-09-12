using UnityEngine;
using System.Collections;

public class key : MonoBehaviour {

		void OnTriggerEnter(Collider other)
		{
				if (other.tag == "Player") {
						other.GetComponent<player> ().GetKey ();
						Destroy (this.gameObject);
				}
		}
}
