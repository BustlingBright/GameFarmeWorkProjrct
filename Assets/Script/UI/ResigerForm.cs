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
        _name = transform.Find("Btns/Name/NameInput").GetComponent<InputField>();
        _password = transform.Find("Btns/Password/PasswordInput").GetComponent<InputField>();
        _password2 = transform.Find("Btns/PasswordTwo/PasswordInput").GetComponent<InputField>();
        _ui = GameEntry.GetComponent<UIComponent>();
    }

    protected internal override void OnOpen (object userData)
	{
		base.OnOpen (userData);
        _enterBtn.onClick.AddListener(OnEnterClick);
        _exitBtn.onClick.AddListener(OnExitClick);
        
	}
    protected internal override void OnClose(object userData)
    {
        base.OnClose(userData);

        _enterBtn.onClick.RemoveListener(OnEnterClick);
        _exitBtn.onClick.RemoveListener(OnExitClick);
        
    }

    /// <summary>
    /// 清空所有数据
    /// </summary>
    private void RemoveAllText()
    {
        _name.text = string.Empty;
        _password.text = string.Empty;
        _password2.text = string.Empty;
    }

    private void OnExitClick()
    {
        _ui.CloseUIForm(UIForm);
        RemoveAllText();
        FormConfig _formConfig = ConfigManger.GetConfig<FormConfig>((int)ConfigEnum.StartForm);
        _ui.OpenUIForm(_formConfig.ScenePosition + _formConfig.SceneName, _formConfig.SceneGroup);
    }

    private void OnEnterClick()
    {
        
    }
}
