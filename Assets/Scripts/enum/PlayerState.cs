/// <summary>プレイヤーの状態を示す列挙型</summary>
public enum PlayerState
{
    Idle, // アイドル状態
    Move, // 移動状態
    Attack, // 攻撃状態
    Damage, // 被ダメージ状態
    Die, // 死亡状態
}