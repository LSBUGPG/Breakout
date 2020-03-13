using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPosition : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        transform.localPosition = player.localPosition;
    }
}
