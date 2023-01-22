using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    public GameObject ghost;
    private void Start()
    {
        EventManager.instance.TestEvent += Spring;
    }

    void Spring()
    {
        ghost.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EventManager.instance.StartTestEvent();
    }

  
   
}
