using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public float Speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( Vector3.up * Speed*Time.deltaTime, Space.Self);
    }
}
