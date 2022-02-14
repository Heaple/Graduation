using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CleantownManager
{

    private static CleantownManager Instance;

    public static CleantownManager instance
    {
        get
        {
            if (Instance == null)
                Instance = new CleantownManager();
            return Instance;
        }
    }

    public bool canMove = true;
    public bool isJihooTalk = false;
    public bool isGunooTalk = false;
    public int trashMax = 0;
    public int trashCount = 0;
    public bool isGameFinished = false;
    public bool isTrash = false;
    public bool isTryGoOutInTrashGame = false;
    public bool isInBoundaryCleanTownGame = false;

}