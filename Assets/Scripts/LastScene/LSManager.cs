using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSManager
{
    private static LSManager Instance;

    public static LSManager instance
    {
        get
        {
            if (Instance == null)
                Instance = new LSManager();
            return Instance;
        } 
    }
    public bool isFir = true;
    public bool isEnd = false;
    public bool canMove = true;
}
