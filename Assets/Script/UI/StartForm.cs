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
    object _userData;

    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
        _userData = userData;
        _registerBtn = transform.Find("Btns/ResigerBtn").GetComponent<Button>();
        _nameEnterBtn = transform.Find("Btns/LoginBtn").GetComponent<Button>();
        _exitBtn = transform.Find("Btns/ExitBtn").GetComponent<Button>();
        _fastBtn = transform.Find("Btns/FastBtn").GetComponent<Button>();
    }
    protected internal override void OnOpen(object userData)
    {
        base.OnOpen(userData);
		_registerBtn.onClick.AddListener(OnResigerClick);
		_nameEnterBtn.onClick.AddListener (OnNameLoginClick);
        _exitBtn.onClick.AddListener(OnExitClick);
        _fastBtn.onClick.AddListener(OnFastGameClick);
    }

    private void OnFastGameClick()
    {
        UIManger.Instance._UIComponent.CloseUIForm(UIForm);
        UIManger.Instance._UIComponent.OpenUIForm(ConfigEnum.FastLoginForm,_userData);
    }


    /// <summary>
    /// 退出游戏
    /// </summary>
    private void OnExitClick()
    {
        UIManger.Instance._UIComponent.CloseUIForm(UIForm);
        Application.Quit();
    }

    /// <summary>
    /// 打开注册UI
	/// </summary>
	private void OnResigerClick()
    {
        UIManger.Instance._UIComponent.CloseUIForm(UIForm);
        UIManger.Instance._UIComponent.OpenUIForm(ConfigEnum.ResigerForm);
    }
    /// <summary>
    /// 打开账号密码登录UI
    /// </summary>
	private void OnNameLoginClick()
    {
        UIManger.Instance._UIComponent.CloseUIForm(UIForm);
        UIManger.Instance._UIComponent.OpenUIForm(ConfigEnum.NameLoginForm);
    }


    protected  internal override void OnClose(object userData)
    {
        _registerBtn.onClick.RemoveListener(OnResigerClick);
        _nameEnterBtn.onClick.RemoveListener(OnNameLoginClick);
        _exitBtn.onClick.RemoveListener(OnExitClick);
        _fastBtn.onClick.RemoveListener(OnFastGameClick);
    }

}
