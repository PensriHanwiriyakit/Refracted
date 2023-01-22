using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.instance.TestEvent += StartTestDialogue;
    }

    void StartTestDialogue()
    {
        Debug.Log("tested dialogue");
    }

    private void OnDisable()
    {
        EventManager.instance.TestEvent -= StartTestDialogue;

    }
}
