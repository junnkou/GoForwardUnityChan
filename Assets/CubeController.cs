using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    // Use this for initialization
    private float speed = -0.2f;
    private float daedLine = -10;
    private bool gameover;
    private float coefficient = 0.1f;
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed, 0, 0);
        if (transform.position.x < this.daedLine)
        {
            Destroy(gameObject);
        }
	}
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "GroundTag"||other.gameObject.tag=="CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }

    }
}
