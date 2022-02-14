using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Variable.instance.canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Variable.instance.canMove = true;
            this.gameObject.SetActive(false);
        }
    }
}
