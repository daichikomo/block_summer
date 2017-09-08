using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    private float speed = 20.0f; //追加

    // Use this for initialization
    void Start()
    {

        this.GetComponent<Rigidbody>().AddForce(
           (transform.forward + transform.right) * speed,
           ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
