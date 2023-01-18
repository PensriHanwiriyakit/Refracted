using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.instance.TestEvent += TestDialogue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EventManager.instance.StartTestEvent();
    }

    void TestDialogue()
    {
        Debug.Log("tested");
    }
}
