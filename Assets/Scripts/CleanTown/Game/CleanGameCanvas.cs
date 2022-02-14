using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanGameCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CleantownManager.instance.canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            CleantownManager.instance.canMove = true;
            this.gameObject.SetActive(false);
        }
    }
}
