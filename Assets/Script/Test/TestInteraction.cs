using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteraction : MonoBehaviour
{
    bool fall = false;
    public Transform point;
    public float fallspeed;

    void Start()
    {
        EventManager.instance.TestInteraction += Falldown;
    }

    void Falldown()
    {
        fall = true;
    }
    void Update()
    {
        if (fall)
        {
            transform.position = Vector3.MoveTowards(transform.position, point.position, fallspeed * Time.deltaTime);
        }
    }

    private void OnDisable()
    {
        EventManager.instance.TestInteraction -= Falldown;
    }
}
