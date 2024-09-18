/// <summary>プレイヤーの状態を管理するクラス</summary>
public class PlayerStateHandler
{
    /// <summary>プレイヤーの状態を示す列挙型</summary>
    public enum PlayerState
    {
        Idle, // アイドル状態
        Move, // 移動状態
        Attack, // 攻撃状態
        Damage, // 被ダメージ状態
        Die, // 死亡状態
    }

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
