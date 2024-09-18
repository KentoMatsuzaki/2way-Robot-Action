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

    /// <summary>形態を切り替えるアニメーションを再生する</summary>
    public void PlaySwitchFormAnimation()
    {
        if (_formHandler.GetPlayerForm() == PlayerForm.Robot)
        {
            _animator.Play("Robot Form");
        }
        else if (_formHandler.GetPlayerForm() == PlayerForm.Jett)
        {
            _animator.Play("Jett Form");
        }
    }
}
