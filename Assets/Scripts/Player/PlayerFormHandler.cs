/// <summary>プレイヤーの形態を管理するクラス</summary>
public class PlayerFormHandler
{
    /// <summary>プレイヤーの現在の形態</summary>
    private static PlayerForm _currentForm = PlayerForm.Robot;

    /// <summary>プレイヤーの形態を取得する</summary>
    public PlayerForm GetPlayerForm()
    {
        return _currentForm;
    }

    /// <summary>プレイヤーの形態を切り替える</summary>
    public void SwitchPlayerForm()
    {
        _currentForm = _currentForm == PlayerForm.Robot ? PlayerForm.Jett : PlayerForm.Robot;
    }
}