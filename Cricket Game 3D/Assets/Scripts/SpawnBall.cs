using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{

    public GameObject ballObject;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ThrowBall", 2f);
    }

    void ThrowBall()
	{
        Instantiate(ballObject, ballObject.transform.position, Quaternion.identity);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
