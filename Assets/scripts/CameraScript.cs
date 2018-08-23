using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	
public class CameraScript : MonoBehaviour {

	public GameObject chair;

    public float speed;

	public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 90.0f;
    private float pitch = 0.0f;

	private Rigidbody rb;
 

    void Update()
    {
		if (Input.GetMouseButton(2)) {
			yaw += speedH * Input.GetAxis("Mouse X");
			pitch -= speedV * Input.GetAxis("Mouse Y");

			transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
			chair.transform.eulerAngles = new Vector3(0, yaw-90, 0.0f);;
		}
     	if (Input.GetKey(KeyCode.Q)) {
         	transform.position += 0.01f * Vector3.forward * speed * Time.deltaTime;
			chair.transform.position += 0.01f * Vector3.forward * speed * Time.deltaTime;
     	}
     	if (Input.GetKey(KeyCode.D)) {
     	    transform.position += 0.01f * Vector3.back * speed * Time.deltaTime;
			chair.transform.position += 0.01f * Vector3.back * speed * Time.deltaTime;
     	}
    	if (Input.GetKey(KeyCode.S)) {
      	   transform.position += 0.01f * Vector3.left * speed * Time.deltaTime;
		chair.transform.position += 0.01f * Vector3.left * speed * Time.deltaTime;
    	}
    	if (Input.GetKey(KeyCode.Z)) {
     	    transform.position += 0.01f * Vector3.right * speed * Time.deltaTime;
			chair.transform.position += 0.01f * Vector3.right * speed * Time.deltaTime;
    	}
    }
}
