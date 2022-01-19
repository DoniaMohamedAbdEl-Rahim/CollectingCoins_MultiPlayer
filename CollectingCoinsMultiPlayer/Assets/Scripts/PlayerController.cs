using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    [SerializeField]
    float movementSpeed = 10;
    Rigidbody rb;
    GameplayUI gameplayUIScript;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameplayUIScript = GameObject.Find("GameplayUI").GetComponent<GameplayUI>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        rb.AddForce(Vector3.forward * verticalInput * movementSpeed);
        rb.AddForce(Vector3.right * horizontalInput * movementSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            gameplayUIScript.UpdateScore();
        }
    }
}
