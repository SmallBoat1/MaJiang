using System;
using UnityEngine;

public class  UnityGameObject
{
    public GameObject Object;

    public UnityGameObject()
    {

    }

    public UnityGameObject(string name)
    {
        Object = new GameObject(name);
    }

    public int layer{
        get{
            if(Object)
                return Object.layer;
            else
                return 0;
        }
        set{
            if(Object)
                Object.layer = value;
        }
    }

    public bool activeSelf{
        get{
            if(Object)
                return Object.activeSelf;
            else
                return false;
        }
    }

    public bool activeInHierarchy{
        get{
            if(Object)
                return Object.activeInHierarchy;
            else
                return false;
        }
    }

    public bool isStatic{
       get{
            if(Object)
                return Object.isStatic;
            else
                return false;
        }

        set{
            if(Object)
                Object.isStatic = value;
        }
    }

    public void SetActive(bool active)
    {
        if(Object)
            Object.SetActive(active);
    }

    public T GetComponet<T>() where T : Component
    {
        T component = Object.GetComponent<T>();
        if(!component) component = Object.AddComponent<T>();
        return component;
    }

    public Component GetComponent(Type type)
    {
        return Object.GetComponent(type);
    }

    public T AddComponent<T>() where T : Component
    {
        T component = Object.AddComponent<T>();
        return component;
    }

    public T GetComponentInChildren<T>()
    {
        return Object.GetComponent<T>();
    }

   public Component GetComponentInChildren(Type type, bool includeInactive = false){
       return Object.GetComponentInChildren(type,includeInactive);
   }

   public Component GetComponentInParent(Type type)
   {
        return Object.GetComponentInParent(type);
   }

   public T GetComponentInParent<T>()
   {
       return Object.GetComponentInParent<T>();
   }

   public Component[] GetComponents(Type type){
       return Object.GetComponents(type);
   }

   public T[] GetComponents<T>()
   {
       return Object.GetComponents<T>();
   }
}