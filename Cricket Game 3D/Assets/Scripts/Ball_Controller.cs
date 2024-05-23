using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{


	Vector3 StartPos;
	Vector3 EndPos;
	public Transform pitchTheBall; 
	public float ballSpeed = 5f;
    Rigidbody rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Start is called before the first frame update
	void Start()
    {
		StartPos = gameObject.transform.position;
		EndPos = pitchTheBall.transform.position;

		Vector3 direction = (EndPos - StartPos).normalized;

		rb.AddForce(direction * ballSpeed, ForceMode.Impulse);
	}

}
