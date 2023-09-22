using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float time = 4;
    private float spawnTime = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (time >= spawnTime && Input.GetKeyDown(KeyCode.Space))
        {
            time = 0;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }

        time += Time.deltaTime;
    }
}
