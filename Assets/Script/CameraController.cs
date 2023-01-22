using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour

{
    public float yOffset;
    public float FollowSpeed;
    private Vector3 velocity = Vector3.zero;

    private Transform Target;

    void Start()
    {
        Target = GameObject.Find("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(Target.position.x, Target.position.y + yOffset, -10f);
       // transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);

       transform.position = Vector3.SmoothDamp(transform.position, newPos ,ref velocity,0.2f);
    }
}
