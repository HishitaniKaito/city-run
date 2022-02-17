using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveL : MonoBehaviour
{
    private float leftBound = -15;
    public float speed = 30f;
    private Player playerController;
    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<Player>();
    }
    void Update()
    {
        if (playerController.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Score"))
        {
            Destroy(gameObject);
        }
    }
}
