using UnityEngine;

/// <summary>プレイヤーのアニメーションを管理するクラス</summary>
public class PlayerAnimationHandler : MonoBehaviour
{
    /// <summary>プレイヤーのアニメーターコントローラー</summary>
    Animator _animator;

    /// <summary>プレイヤーの形態管理</summary>
    PlayerFormHandler _formHandler;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _formHandler = new PlayerFormHandler();
    }

    //-------------------------------------------------------------------------------
    // 形態を切り替えるアニメーション
    //-------------------------------------------------------------------------------

    /// <summary>形態を切り替えるアニメーションを再生する</summary>
    public void PlaySwitchAnimation()
    {
        _animator.Play(IsRobot() ? PlayerAnimation.Jett.ToString() : PlayerAnimation.Robot.ToString());
    }

    //-------------------------------------------------------------------------------
    // アニメーションの再生に関する処理
    //-------------------------------------------------------------------------------

    /// <summary>プレイヤーが歩行形態であるか</summary>
    private bool IsRobot()
    {
        if (_formHandler.GetPlayerForm() == PlayerForm.Robot) return true;
        else return false;
    }

    /// <summary>プレイヤーが飛行形態であるか</summary>
    private bool IsJett()
    {
        if (_formHandler.GetPlayerForm() == PlayerForm.Jett) return true;
        else return false;
    }
}
