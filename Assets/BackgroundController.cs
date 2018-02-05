using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {
    private float speed = -0.2f;
    private float deadLine = -16;
    private float startLine = 15.8f;

    // Use this for initialization
    void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed, 0, 0);
        if (transform.position.x < deadLine)
        {
            transform.position = new Vector2(this.startLine, 0);
        }
    }
}
