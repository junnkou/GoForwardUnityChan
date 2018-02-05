using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private GameObject runlenghttext;
    private GameObject gameovertext;
    private float scoer = 0;
    private float speed = 0.03f;
    private bool gameover = false;

    // Use this for initialization
    void Start()
    {
        this.runlenghttext = GameObject.Find("RunLenght");
        this.gameovertext = GameObject.Find("GamoOver");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover == false)
        {
            this.scoer += speed;
            this.runlenghttext.GetComponent<Text>().text = "Distance:  " + scoer.ToString("F2") + "m";
        }
        if (this.gameover)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
    public void GameOver()
    {
        this.gameovertext.GetComponent<Text>().text = "GameOver";

        this.gameover = true;
    }
}
	

