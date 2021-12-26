using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private static Character Instance;

    public static Character instance
    {
        get
        {
            if (Instance == null)
                Instance = new Character();
            return Instance;
        }
    }

    [HideInInspector] public GameObject CharacterFront;
    [HideInInspector] public GameObject CharacterBack;
    [HideInInspector] public GameObject CharacterLeft;
    [HideInInspector] public GameObject CharacterRight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
