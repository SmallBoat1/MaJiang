using System;
using UnityEngine;

public class UnityTransform
{
    public Transform Trans;

    public UnityTransform(){}

    public UnityTransform(Transform trans)
    {
        Trans = trans;
    }

    public Vector3 localPosition { 
        get{
            return Trans.localPosition;
        } 
        set{
            Trans.localPosition = value;
        }
    }

    
    public Vector3 eulerAngles { 
        get{
            return Trans.eulerAngles;
        } 
        set{
            Trans.eulerAngles = value;
        }
    }

    
    public Vector3 localEulerAngles { 
        get{
            return Trans.localEulerAngles;
        } 
        set{
            Trans.localEulerAngles = value;
        }
    }

    
    public Vector3 right { 
        get{
            return Trans.right;
        } 
        set{
            Trans.right = value;
        }
    }
    
    public Vector3 up { 
        get{
            return Trans.up;
        } 
        set{
            Trans.up = value;
        }
    }
    
    public Vector3 forward { 
        get{
            return Trans.forward;
        } 
        set{
            Trans.forward = value;
        }
    }

    public Quaternion rotation { 
        get{
            return Trans.rotation;
        } 
        set{
            Trans.rotation = value;
        }
    }
    public Vector3 position { 
        get{
            return Trans.position;
        } 
        set{
            Trans.position = value;
        }
    }

    
    public Transform parent { 
        get{
            return Trans.parent;
        } 
        set{
            Trans.parent = value;
        }
    }
    
    public Vector3 localScale { 
        get{
            return Trans.localScale;
        } 
        set{
            Trans.localScale = value;
        }
    }

    public int childCount { 
        get{
            return Trans.childCount;
        } 
    }

    public Transform FindChild(string name){
        if(Trans)
            return Trans.FindChild(name);
        else
            return null;
    }

    public Transform GetChild(int index){
         if(Trans)
            return Trans.GetChild(index);
        else
            return null;
    }

    public void LookAt(Transform target){
        if(Trans)
        {
            Trans.LookAt(target);
        }
    }

    public void LookAt(Vector3 worldPosition){
        if(Trans)
        {
            Trans.LookAt(worldPosition);
        }
    }

    public void SetParent(Transform parent)
    {
        if(Trans)
        {
            Trans.SetParent(parent);
        }
    }

    public void SetSiblingIndex(int index){
        if(Trans)
        {
            Trans.SetSiblingIndex(index);
        }
    }
}