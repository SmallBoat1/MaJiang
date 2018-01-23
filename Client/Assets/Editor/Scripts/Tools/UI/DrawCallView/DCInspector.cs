using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DCInspector {

    [MenuItem("Tools/UI/DC")]
    static void GetDC()
    {
        GameObject canvas = Selection.activeGameObject;
        if (canvas)
        {
            CanvasRenderer[] renders = canvas.GetComponentsInChildren<CanvasRenderer>();
            for (int i = 0; i < renders.Length; i++)
            {
                //Debug.LogFormat("render {0} Material tex {1} shader {2} ", renders[i].name, 
                //    renders[i].GetMaterial().mainTexture.name, renders[i].GetMaterial().shader.name);
                Debug.LogFormat("render {0} relativeDepth {1} absoluteDepth {2} ", renders[i].name,
                    renders[i].relativeDepth, renders[i].absoluteDepth);
            }
        }
    }
}
