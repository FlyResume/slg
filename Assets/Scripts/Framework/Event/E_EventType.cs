/// <summary>
/// 事件类型 枚举
/// </summary>
public enum E_EventType
{
    /// <summary>
    /// 测试用事件 —— 参数：无
    /// </summary>
    E_Test,

    /// <summary>
    /// 测试用事件 —— 参数：int
    /// </summary>
    E_Test2,
    E_SetResource,
    #region 游戏生命周期
    //整个游戏生命周期事件
    //upinit 主界面
    //preinit 预加载
    //active 游戏中
    //pause 暂停
    //shutdown 关闭
    E_UpInitEnter,
    E_UpInitUpdate,
    E_UpInitFixedUpdate,
    E_UpInitExit,
    E_preInitEnter,
    E_preInitUpdate,
    E_preInitFixedUpdate,
    E_preInitExit,
    E_ActiveEnter,
    E_ActiveUpdate,
    E_ActiveFixedUpdate,
    E_ActiveExit,
    E_PauseEnter,
    E_PauseUpdate,
    E_PauseFixedUpdate,
    E_PauseExit,
    E_ShutdownEnter,
    E_ShutdownUpdate,
    E_ShutdownFixedUpdate,
    E_ShutdownExit,
    #endregion
    #region 战斗生命周期
    //战斗生命周期时间
    E_RoundStartEnter,
    E_RoundStartUpdate,
    E_RoundStartFixedUpdate,
    E_RoundStartExit,
    E_RoundDuringEnter,
    E_RoundDuringUpdate,
    E_RoundDuringFixedUpdate,
    E_RoundDuringExit,
    E_RoundEndEnter,
    E_RoundEndUpdate,
    E_RoundEndFixedUpdate,
    E_RoundEndExit,
    #endregion
}
