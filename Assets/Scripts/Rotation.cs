using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	[SerializeField] private bool isRotation = true;
	[SerializeField] private float speed = 30.0f;

	void Update () {

		if (isRotation) {
			Vector3 r = transform.rotation.eulerAngles;
			r.y += speed * Time.deltaTime;
			transform.rotation = Quaternion.Euler(r);
		}
		
	}
}
