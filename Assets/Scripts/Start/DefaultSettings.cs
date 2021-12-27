using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultSettings : MonoBehaviour
{
    public static bool isClothesChanged = false;
    GameObject Front;
    // Start is called before the first frame update
    void Start()
    {
        Front = GameObject.Find("Front");
        Front.transform.position = new Vector2(0.4f, -1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
