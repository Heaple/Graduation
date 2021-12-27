using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmourStand : MonoBehaviour
{
    public GameObject e;
    void Start()
    {
        e.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.name == "ArmorStand")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("boom");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "ArmorStand")
        {
            e.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.name == "ArmorStand")
        {
            e.SetActive(false);
        }
    }
}
