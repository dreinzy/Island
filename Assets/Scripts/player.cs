using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
		public bool hasKey;

		// Use this for initialization
	void Start () {
				hasKey = false;
	}
	
	public void GetKey()
	{
			hasKey = true;
	}
}
