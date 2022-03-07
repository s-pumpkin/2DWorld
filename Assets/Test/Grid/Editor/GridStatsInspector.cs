using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridStats))]
public class GridStatsInspector : Editor
{
    GridStats m_target;

    Vector3 changeV3;

    public override void OnInspectorGUI()
    {
        m_target = (GridStats)target;
        base.OnInspectorGUI();
        EditorGUI.BeginChangeCheck();

        changeV3 = m_target.gameObject.transform.position;

        m_target.Data.Row = Mathf.FloorToInt(changeV3.x);
        m_target.Data.Column = Mathf.FloorToInt(changeV3.z);

        if (EditorGUI.EndChangeCheck())
            EditorUtility.SetDirty(m_target);
    }

}
