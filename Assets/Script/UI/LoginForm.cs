using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework;
using UnityGameFramework.Runtime;
using UnityEngine.UI;
using System;

public class LoginForm : UIFormLogic
{

    private Button _enterBtn;
    private Button _exitBtn;
    private Button _registerBt;
    private InputField _nameInput;
    private InputField _passwordInput;
    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);

        _nameInput = transform.Find("Btns/Name").GetComponent<InputField>();
        _passwordInput = transform.Find("Btns/Password").GetComponent<InputField>();

        _enterBtn = transform.Find("Btns/EnterBtn").GetComponent<Button>();
        _exitBtn = transform.Find("Btns/ExitBtn").GetComponent<Button>();
        _registerBt = transform.Find("Btns/ResigerBtn").GetComponent<Button>();
    }
    protected internal override void OnOpen(object userData)
    {
        base.OnOpen(userData);

        _enterBtn.onClick.AddListener(OnEnterClick);
        _exitBtn.onClick.AddListener(OnExitClick);
        _registerBt.onClick.AddListener(OnRegisterClick);
    }

    /// <summary>
    /// 注册按钮响应事件
    /// </summary>
    private void OnRegisterClick()
    {
        UIManger.Instance._UIComponent.CloseUIForm(UIForm);
        UIManger.Instance._UIComponent.OpenUIForm(ConfigEnum.ResigerForm);
    }

    /// <summary>
    /// 退出按钮响应事件
    /// </summary>
    private void OnExitClick()
    {
        UIManger.Instance._UIComponent.CloseUIForm(UIForm);
        UIManger.Instance._UIComponent.OpenUIForm(ConfigEnum.StartForm);
    }


    /// <summary>
    /// 登录按钮响应事件
    /// </summary>
    private void OnEnterClick()
    {
        /////////////
    }
}
