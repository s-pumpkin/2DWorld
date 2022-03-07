using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private static GridManager instance;
    public static GridManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<GridManager>();
            return instance;
        }
    }

    public GameObject[,] gridArray;

    public Dictionary<GameObject, GridStats> GridStatsDictionary = new Dictionary<GameObject, GridStats>();

    public int Row, Column;

    private void Awake()
    {
        instance = Instance;
    }

    private void Update()
    {
       
    }

}
