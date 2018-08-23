using System.Collections;
using UnityEngine;
 
class MouseScript : MonoBehaviour {

    private bool dragging = false;
    private Material material;
  
    private double x;
    private double z;
	public double speedH = 2;
    public double speedV = 2;
    
    void Start() {
        material = GetComponent<Renderer>().material;
    }

	void OnMouseEnter() {
		material.color = new Color(0.1f,0.1f,0.1f);
	}

	void OnMouseExit() {
		if (!dragging) {
			material.color = Color.black;
		}
	}
      
    void OnMouseDown(){
        dragging = true;
        GetComponent<AudioSource>().Play(0);
    }
  
    void OnMouseUp() {
        dragging = false;
		material.color = Color.black;
    }
  
    void Update()
    {
        if (dragging) {
			x = 0.01 * speedH * Input.GetAxis("Mouse X");
			z = 0.01 * speedV * Input.GetAxis("Mouse Y");
			transform.Translate((float)z,0,(float) -x);
        }

    }
}