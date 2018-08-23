using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScript : MonoBehaviour {

	public GameObject screenToActivate;
	private bool isOn = false;

	private AudioSource AudioSource;
	public AudioClip on;
	public AudioClip off;

	private Material material;

	void Start() {
		material = gameObject.GetComponent<Renderer>().material;
		AudioSource = GetComponent<AudioSource>();
	}

	void OnMouseDown() {
		if (isOn) {
			material.color = new Color(255,0,0);
			SwitchOff();
		}
		else {
			material.color = new Color(0,255,0);
			SwitchOn();
		}
		isOn = !isOn;
	}

	private void SwitchOn() {
		screenToActivate.GetComponent<Renderer>().materials[1].color = Color.white;
		AudioSource.PlayOneShot(on);
	}

	private void SwitchOff() {
		screenToActivate.GetComponent<Renderer>().materials[1].color = Color.black;
		AudioSource.PlayOneShot(off);
	}
}
