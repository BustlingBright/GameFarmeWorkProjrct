using System;
using System.Collections.Generic;
using GameFramework;
using UnityGameFramework.Runtime;

public class UIManger:Singleton<UIManger>
{
    private UIComponent _ui;

    public UIComponent _UIComponent
    {
        get
        {
            if (_ui == null)
            {
                _ui = GameEntry.GetComponent<UIComponent>();
            }
            return _ui;
        }
    }

}

