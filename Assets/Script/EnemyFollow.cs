using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {
    public float speed = 2f;

    public Player player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (player.isGameOver == true)
            return;
        Vector3 direction = player.transform.position - transform.position;
        transform.position += direction.normalized * speed * Time.deltaTime;
    }
}
