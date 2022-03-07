using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStats : MonoBehaviour
{
    public GridDataBase Data = new GridDataBase();
}

[System.Serializable]
public struct GridDataBase
{
    public int Row;
    public int Column;
    public bool isUse;
}