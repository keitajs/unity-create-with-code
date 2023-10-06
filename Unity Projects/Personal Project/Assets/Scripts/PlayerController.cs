using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody playerRb;

    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddForce(Vector3.forward * Time.deltaTime * speed * verticalInput * 100 + Vector3.right * Time.deltaTime * speed * horizontalInput * 100, ForceMode.Impulse);
    }
}
