using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoScript : MonoBehaviour {

 	private bool dirRight = true;
	private bool isMoving = false;

    public float speed = 0.01f;

	public Transform transform1;
	public Transform transform2;

	
	private Material material;

	void Start() {
		material = gameObject.GetComponent<Renderer>().material;
	}

    void Update () {
		if (isMoving) {
			if (dirRight)
				transform.Translate (-Vector2.right * speed * Time.deltaTime);
			else
				transform.Translate (Vector2.right * speed * Time.deltaTime);
			
			if(transform.position.x <= transform2.position.x) {
				dirRight = false;
				isMoving = false;
			}
			
			if(transform.position.x >= transform1.position.x) {
				dirRight = true;
				isMoving = false;
			}
		}
    }

	void OnMouseDown() {
		isMoving = true;
		GetComponent<AudioSource>().Play(0);
	}

	void OnMouseEnter() {
		material.color = new Color(0.1f,0.1f,0.1f);
	}

	void OnMouseExit() {
		material.color = Color.grey;
	}

	


}
