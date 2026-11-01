using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 10f;
    int collected_food = 0;

    public ScoreUI scoreUI;

    public bool isGameOver = false;
    int totallynumber = 0;

    public float minX = -9.5f;
    public float maxX = 9.5f;
    public float minZ = -9.5f;
    public float maxZ = 9.5f;

    // Use this for initialization
    void Start () {
        scoreUI.UpdateScore(collected_food);
        this.totallynumber = scoreUI.totallynumber;
    }
	
	// Update is called once per frame
	void Update () {
        if (isGameOver)
        {
            return;
        }

        float move_2 = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float move_1 = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if(Input.GetButton("Horizontal"))
        {
            Vector3 x_move = gameObject.transform.position;
            x_move.x += move_1;
            x_move.x = Mathf.Clamp(x_move.x, minX, maxX);
            gameObject.transform.position = x_move;
            //Debug.Log("Horizontal按下了，move_1=" + move_1 + "，move_2=" + move_2);
        }
        if (Input.GetButton("Vertical"))
        {
            Vector3 z_move = gameObject.transform.position;
            z_move.z += move_2;
            z_move.z = Mathf.Clamp(z_move.z, minZ, maxZ);
            gameObject.transform.position = z_move;
            //Debug.Log("Horizontal按下了，move_1=" + move_1 + "，move_2=" + move_2);
        }
    }

    private void OnCollisionEnter(Collision collision)//collision：这次碰撞的信息
    {
        if (isGameOver)
        {
            return;
        }
        if (collision.collider.tag == "Food")
        {
            Destroy(collision.collider.gameObject);//从信息里取得对方的碰撞器
            collected_food += 1;
            scoreUI.UpdateScore(collected_food);
            if(collected_food == totallynumber)
            {
                isGameOver = true;
                scoreUI.ShowGameOver("you win");
            }
            Debug.LogFormat("we collect the food: {0}", collected_food);
        }
        if (collision.collider.tag == "Enemy")
        {
            isGameOver = true;
            scoreUI.ShowGameOver();
        }
    }
}
