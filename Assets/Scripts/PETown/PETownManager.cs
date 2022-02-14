using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PETownManager
{
    private static PETownManager Instance;

    public static PETownManager instance
    {
        get
        {
            if (Instance == null)
                Instance = new PETownManager();
            return Instance;
        }
    }

    public bool canMove = true;
    public bool isFirst = true;
    public bool isGaveMap = false;
}
