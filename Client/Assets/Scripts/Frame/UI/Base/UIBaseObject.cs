using UnityEngine;
using System.Collections.Generic;

public class UIBaseObject{
	public virtual string RootName{get;set;}
	public virtual UnityGameObject GameObject{get;set;}
    public Dictionary<string,UnityGameObject> m_objectMap;

	public UIBaseObject()
	{
        m_objectMap = new Dictionary<string,UnityGameObject>();
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