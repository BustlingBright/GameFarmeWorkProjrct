using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using GameFramework;
using UnityEngine.UI;

public class StartForm :UIFormLogic
{
    private Button _registerBtn;
    private Button _nameEnterBtn;
    private Button _exitBtn;
    private Button _fastBtn;
    private UIComponent _ui;

    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
        _registerBtn = transform.Find("Btns/ResigerBtn").GetComponent<Button>();
        _nameEnterBtn = transform.Find("Btns/LoginBtn").GetComponent<Button>();
        _exitBtn = transform.Find("Btns/ExitBtn").GetComponent<Button>();
        _fastBtn = transform.Find("Btns/FastBtn").GetComponent<Button>();
        _ui = GameEntry.GetComponent<UIComponent>();
    }
    protected internal override void OnOpen(object userData)
    {
        base.OnOpen(userData);
		_registerBtn.onClick.AddListener(OnResigerClick);
		_nameEnterBtn.onClick.AddListener (OnNameLoginClick);
        _exitBtn.onClick.AddListener(OnExitClick);
        //////////////////////////快速游戏

    }

    /// <summary>
    /// 退出游戏
    /// </summary>
    private void OnExitClick()
    {
        _ui.CloseUIForm(UIForm);
        Application.Quit();
    }

    /// <summary>
    /// 打开注册UI
	/// </summary>
	private void OnResigerClick()
	{
		_ui.CloseUIForm (UIForm);
        _ui.OpenUIForm(ConfigEnum.ResigerForm);
	}
    /// <summary>
    /// 打开账号密码登录UI
    /// </summary>
	private void OnNameLoginClick()
	{
		_ui.CloseUIForm (UIForm);
        FormConfig _formConfig = ConfigManger.GetConfig<FormConfig>((int)ConfigEnum.NameLoginForm);
        _ui.OpenUIForm(_formConfig.ScenePosition + _formConfig.SceneName, _formConfig.SceneGroup);
	}


    protected  internal override void OnClose(object userData)
    {
        _registerBtn.onClick.RemoveListener(OnResigerClick);
        _nameEnterBtn.onClick.RemoveListener(OnNameLoginClick);
        _exitBtn.onClick.RemoveListener(OnExitClick);
    }

}
