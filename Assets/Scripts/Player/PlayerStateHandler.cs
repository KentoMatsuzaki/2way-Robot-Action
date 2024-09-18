/// <summary>プレイヤーの状態を管理するクラス</summary>
public class PlayerStateHandler
{
    /// <summary>プレイヤーの現在の状態</summary>
    private static PlayerState _currentState = PlayerState.Idle;

    /// <summary>プレイヤーの状態を取得する</summary>
    public PlayerState GetPlayerState()
    {
         return _currentState;
    }

    /// <summary>プレイヤーの状態を設定する</summary>
    public void SetPlayerState(PlayerState state)
    {
        _currentState = state;
    }
}
