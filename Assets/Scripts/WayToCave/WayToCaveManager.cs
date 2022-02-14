using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayToCaveManager
{
    private static WayToCaveManager Instance;

    public static WayToCaveManager instance
    {
        get
        {
            if (Instance == null)
                Instance = new WayToCaveManager();
            return Instance;
        }
    }
    public bool canMove = true;
}
