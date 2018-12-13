using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using UnityEngine.UI;
using System;

public class ResigerForm :  UIFormLogic{

    private Button _exitBtn;
    private Button _enterBtn;
    private InputField _name;
    private InputField _password;
    private InputField _password2;
    UIComponent _ui;

    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);

        _exitBtn = transform.Find("Btns/ExitBtn").GetComponent<Button>();
        _enterBtn = transform.Find("Btns/EnterBtn").GetComponent<Button>();
        _name = transform.Find("Btns/Name").GetComponent<InputField>();
        _password = transform.Find("Btns/Password").GetComponent<InputField>();
        _password2 = transform.Find("Btns/PasswordTwo").GetComponent<InputField>();
        _ui = GameEntry.GetComponent<UIComponent>();
    }

    protected internal override void OnOpen (object userData)
	{
		base.OnOpen (userData);

        _enterBtn.onClick.AddListener(OnEnterClick);
        _exitBtn.onClick.AddListener(OnExitClick);
        
	}

    private void OnExitClick()
    {
        _ui.CloseUIForm(UIForm);
        //_ui.OpenUIForm()
    }

    private void OnEnterClick()
    {
        
    }
}
