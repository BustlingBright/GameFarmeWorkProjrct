using System;
using System.Collections.Generic;
using GameFramework;
using UnityGameFramework.Runtime;

public class UIManger
{
    private static UIManger _instance;
    private UIComponent _ui;

    public UIComponent _UIComponent
    {
        get
        { 
            return _ui;
        }
    }

    public static UIManger Instance
    {
        get
        {
            if (_instance == null)
                _instance = new UIManger();
            return _instance;
        }
    }

    private UIManger() {
        _ui = GameEntry.GetComponent<UIComponent>();
    }

}

