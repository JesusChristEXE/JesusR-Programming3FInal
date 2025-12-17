using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionFollow : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.WorldToScreenPoint(player.position);
    }
}
