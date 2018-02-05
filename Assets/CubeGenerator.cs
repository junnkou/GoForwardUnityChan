﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {
    public GameObject CubePrefab;
    private float delta = 0;
    private float span = 1.0f;
    private float genposx = 12;
    private float offsetY = 0.3f;
    private float spaceY = 6.9f;
    private float offsetX = 0.5f;
    private float spaceX = 0.4f;
    private int maxBlockNum = 4;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;
        if (this.delta > span)
         {
            this.delta = 0;
            int n = Random.Range(1, maxBlockNum + 1);
            for (int a = 0; a < n; a++)
             {
                GameObject go = Instantiate(CubePrefab) as GameObject;
                go.transform.position = new Vector2(this.genposx, this.offsetY + a * this.spaceY);
             }
            this.span = this.offsetX + this.spaceX * n;
            }
        }
	}
    



