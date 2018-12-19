using System;
using System.Collections.Generic;
using GameFramework.Scene;
using UnityGameFramework.Runtime;
using GameFramework;

public class A:

public class SceneManger:Singleton<SceneManger>
{
    private SceneComponent _sceneCompent;
    public SceneComponent _SceneCompent
    {
        get
        {
            if(_sceneCompent==null)
            {
                _sceneCompent = GameEntry.GetComponent<SceneComponent>();
            }
            return _sceneCompent;
        }
    }
    public void UnLoadAllScence()
    {
        string[] unsceneName = _SceneCompent.GetLoadedSceneAssetNames();
        foreach (string item in unsceneName)
        {
            SceneManger.Instance._SceneCompent.UnloadScene(item);
        }
    }

}

