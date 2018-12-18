using System;
using GameFramework.Entity;
using UnityGameFramework.Runtime;

public class ModelManger:Singleton<ModelManger>
{
    private EntityComponent _entityComponent;
    public EntityComponent _EntityComponent
    {
        get
        {
            if (_entityComponent == null)
                _entityComponent = GameEntry.GetComponent<EntityComponent>();
            return _entityComponent;
        }
    }
}

