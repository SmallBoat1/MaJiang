/****************************************************************
*   作者：Jason
*   类名：UIViewBase
*   CLR版本：4.0.30319.42000
*   创建时间：2017/10/18 22:08:55
*   版本号：v1.0.0
*   2017
*   描述说明：Assets.Scripts.Frame.Core.UI.Base
*
*   修改历史：2017/10/18 22:08:55
*
*
*****************************************************************/

using System;
using System.Collections.Generic;

public class UIViewBase<T> where T : ViewObject, new()
{
    #region NodeString


    #endregion

    public static T Object;
    public UIViewBase()
    {
        Object = new T();
    }
}

