using UnityEngine;
using GameFramework.Network;
using UnityGameFramework.Runtime;

public class NetWorkManger : Singleton<NetWorkManger> {
    private  NetworkComponent _instance;
    public  NetworkComponent _Instance
    {
        get
        {
            if(_instance==null)
            {
                _instance = GameEntry.GetComponent<NetworkComponent>();
            }
            return _instance;
        }
    }


}
