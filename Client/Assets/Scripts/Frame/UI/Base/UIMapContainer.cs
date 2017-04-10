using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBaseObject{
	public virtual string RootName{get;set;}
	public virtual GameObject GameObject{get;set;}
	
	public List<Component> Components;

	public UIBaseObject()
	{
		
	}
}

public class UIMapContainer {

	public UIMapContainer()
	{

	}

	private Dictionary<string,UIBaseObject> _map = new Dictionary<string,UIBaseObject>();
}
