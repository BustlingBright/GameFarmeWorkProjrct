using System;
using System.Collections.Generic;
using GameFramework;
using UnityGameFramework.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class FastLoginForm:UIFormLogic
{
    private Button _enter;
    private Button _exit;
    private ProcedureMain proCom;
    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
        _enter = transform.Find("Btns/EnterBtn").GetComponent<Button>();
        _exit = transform.Find("Btns/ExitBtn").GetComponent<Button>();
  }

    protected internal override void OnOpen(object userData)
    {
        base.OnOpen(userData);
        proCom = (ProcedureMain)userData;
        _enter.onClick.AddListener(OnEnterClick);
        _exit.onClick.AddListener(OnExitClick);
    }

    /// <summary>
    /// 返回主界面
    /// </summary>
    private void OnExitClick()
    {
        UIManger.Instance._UIComponent.OpenUIForm(ConfigEnum.StartForm);
        UIManger.Instance._UIComponent.CloseUIForm(UIForm);
    }

    protected internal override void OnClose(object userData)
    {
        base.OnClose(userData);

        _enter.onClick.RemoveAllListeners();
        _exit.onClick.RemoveAllListeners();
    }

    /// <summary>
    /// 确定按键监听事件
    /// </summary>
    private void OnEnterClick()
    {
        UIManger.Instance._UIComponent.CloseUIForm(UIForm);
        proCom.Load();

    }
}

