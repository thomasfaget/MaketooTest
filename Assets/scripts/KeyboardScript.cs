using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardScript : MonoBehaviour {

	public float press = 0.002f;


	private Material material;

	void Start() {
		material = gameObject.GetComponent<Renderer>().material;
	}
	void OnMouseDown() {
		transform.Translate(0,-press,0);
		GetComponent<AudioSource>().Play(0);
	}

	void OnMouseUp() {
		transform.Translate(0,press,0);
	}

	void OnMouseEnter() {
		material.color = new Color(0.1f,0.1f,0.1f);
	}

	void OnMouseExit() {
		material.color = Color.grey;
	}
}
