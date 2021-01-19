using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 5f;
	public GameObject gameOver;
	public Rigidbody2D rb;

	Vector2 movement;
	
	// Update is called once per frame
	void Update () 
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
		gameOver.SetActive(true);
    }

    void FixedUpdate()
    {
		rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
