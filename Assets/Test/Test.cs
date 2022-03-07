using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Test : MonoBehaviour
{
    public const int a = 5;
    public Vector3 aa;
    public Vector3 bb;
    void Start()
    {
        Debug.Log("SqrMagnitude : " + Vector3.SqrMagnitude(new Vector3(3, 4, 5)));
        Debug.Log("Magnitude : " + Vector3.Magnitude(new Vector3(3, 4, 5)));
        Debug.Log("dic :" + Vector3.Distance(new Vector3(3, 4, 5), Vector3.zero));
    }

    // Update is called once per frame
    void Update()
    {
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("aa----> " + aa + "   bb-----> " + bb + "  aa-bb----->  " + (aa - bb));
        transform.Translate((aa - bb));
    }
}