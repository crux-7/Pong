using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody2D ball;
    private Vector2 initialForce = new Vector2(-4f, 0.5f);
    private Vector2 randomInitialForce;
    // Use this for initialization
    void Start () {
        randomInitialForce = new Vector2(-4f, Random.Range(0.5f, 1.5f));
        ball = gameObject.GetComponent<Rigidbody2D>();
        ball.AddForce(randomInitialForce, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
