using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable
{

    private static Variable Instance;

    public static Variable instance
    {
        get
        {
            if (Instance == null)
                Instance = new Variable();
            return Instance;
        }
    }
    public bool isClothChanged = false;
    public bool canMove = true;
}
