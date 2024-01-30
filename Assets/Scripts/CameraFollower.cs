using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;
    public Vector3 dist = new Vector3(0, 1, -5);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + dist;
    }
}
