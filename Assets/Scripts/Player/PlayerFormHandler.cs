/// <summary>プレイヤーの形態を管理するクラス</summary>
public class PlayerFormHandler
{
    /// <summary>現在の形態</summary>
    private static PlayerForm _currentForm = PlayerForm.Robot;

    /// <summary>現在の形態を取得する</summary>
    public PlayerForm GetCurrentForm()
    {
        return _currentForm;
    }

    /// <summary>現在の形態を切り替える</summary>
    public void SwitchCurrentForm()
    {
        _currentForm = _currentForm == PlayerForm.Robot ? PlayerForm.Jett : PlayerForm.Robot;
    }
}