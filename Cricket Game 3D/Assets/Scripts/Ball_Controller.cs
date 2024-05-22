using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{

    float ballSpeed = 5f;
    Rigidbody rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Start is called before the first frame update
	void Start()
    {
		rb.AddForce(Vector3.right * ballSpeed, ForceMode.Impulse);
    }

}
