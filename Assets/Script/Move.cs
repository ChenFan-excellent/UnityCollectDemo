using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 10f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float move_2 = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float move_1 = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if(Input.GetButton("Horizontal"))
        {
            Vector3 x_move = gameObject.transform.position;
            x_move.x += move_1;
            gameObject.transform.position = x_move;
            Debug.Log("Horizontal按下了，move_1=" + move_1 + "，move_2=" + move_2);
        }
        if (Input.GetButton("Vertical"))
        {
            Vector3 z_move = gameObject.transform.position;
            z_move.z += move_2;
            gameObject.transform.position = z_move;
            Debug.Log("Horizontal按下了，move_1=" + move_1 + "，move_2=" + move_2);
        }
    }
}
