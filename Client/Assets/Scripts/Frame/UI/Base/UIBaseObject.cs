using UnityEngine;
using System.Collections.Generic;

public class UIBaseObject{
	public virtual string RootName{get;set;}
	public virtual GameObject GameObject{get;set;}
    public Dictionary<string,GameObject> m_objectMap;

    
	public UIBaseObject()
	{
        m_objectMap = new Dictionary<string,GameObject>();
        Init();
	}

    void Init()
    {
        string type =  GetType().Name;
        UIinterface.InitViewObject(this);
        Open();
    }

    public void Open()
    {
        GameObject.SetActive(true);
    }

    public void Close()
    {
        GameObject.SetActive(false);
    }
}