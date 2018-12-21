
public enum CreateRole
{
    无双= 50001,
    上官欢= 50101
}

public enum Error
{
   玩家昵称不能为空,
   玩家昵称不能少于3个字符,
   玩家昵称不能包含敏感字符
}

public enum ConfigEnum
{
    StartForm = 10001,
    NameLoginForm,
    ResigerForm,
    FastLoginForm,
    LoadingForm,
    CreateRoleForm,
    SeceltRoleForm,
    MainForm
}
public enum SceneLoadEnum
{
    StartScene,
    CreateRoleScene,
    MainScene
}