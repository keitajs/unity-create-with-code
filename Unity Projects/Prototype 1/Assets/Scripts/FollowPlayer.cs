using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -7);
    Vector3 fp = new Vector3(0, 2, 1);
    Vector3 tp = new Vector3(0, 5, -7);
    public bool isFp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (isFp) offset = tp;
            else offset = fp;
            isFp = !isFp;
        }
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        // transform.rotation = player.transform.rotation;
    }
}
