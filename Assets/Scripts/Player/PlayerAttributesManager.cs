/// <summary>プレイヤーの形態と状態を管理するクラス</summary>
public class PlayerAttributesManager
{
    /// <summary>プレイヤーの形態を示す列挙型</summary>
    public enum PlayerForm
    {
        Robot, // ロボット形態
        Jett // 飛行形態
    }

    /// <summary>プレイヤーの状態を示す列挙型</summary>
    public enum PlayerState
    {
        Idle, // アイドル状態
        Move, // 移動状態
        Attack, // 攻撃状態
        Damage, // 被ダメージ状態
        Die, // 死亡状態
    }

    /// <summary>プレイヤーの現在の形態</summary>
    private static PlayerForm _currentForm = PlayerForm.Robot;

    /// <summary>プレイヤーの現在の状態</summary>
    private static PlayerState _currentState = PlayerState.Idle;

    /// <summary>プレイヤーの現在の形態を取得する</summary>
    public PlayerForm GetPlayerForm() => _currentForm;

    /// <summary>プレイヤーの現在の状態を取得する</summary>
    public PlayerState GetPlayerState() => _currentState;

    /// <summary>プレイヤーの現在の形態を設定する</summary>
    public void SetPlayerForm(PlayerForm form)
    {
        _currentForm = form;
    }

    /// <summary>プレイヤーの現在の状態を設定する</summary>
    public void SetPlayerState(PlayerState state)
    {
        _currentState = state;
    }
}