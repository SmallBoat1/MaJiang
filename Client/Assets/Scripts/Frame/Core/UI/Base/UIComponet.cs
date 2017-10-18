/****************************************************************
*   作者：Jason
*   类名：UIComponet
*   CLR版本：4.0.30319.42000
*   创建时间：2017/10/18 22:39:04
*   版本号：v1.0.0
*   2017
*   描述说明：Assets.Scripts.Frame.Core.UI.Base
*
*   修改历史：2017/10/18 22:39:04
*
*
*****************************************************************/

using UnityEngine;

public class UIComponet
{
    public UIComponet()
    {
       
    }

    public virtual void Init<T>(GameObject obj) where T : Component
    {
        Name = obj.name;
        GameObject = obj;
        Trans = obj.transform;
        Component = obj.GetComponent<T>();
    }

    public string Name { get; private set; }

    public GameObject GameObject { get; private set; }

    public Transform Trans { get; private set; }

    protected Component Component  { get; private set; }

    public U GetComponet<U>() where U : Component
    {
        if (Component is U)
        {
            return (U)Component;
        }
        return GameObject.GetComponent<U>();
    }

    public U AddComponet<U>() where U : Component
    {
        return GameObject.AddComponent<U>();
    }
}

