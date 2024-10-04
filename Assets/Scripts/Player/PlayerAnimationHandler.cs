using System.Collections;
using UnityEngine;

/// <summary>プレイヤーのアニメーションを管理するクラス</summary>
public class PlayerAnimationHandler : MonoBehaviour
{
    private Animator _animator;
    private PlayerFormHandler _formHandler;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _formHandler = new PlayerFormHandler();
    }

    //-------------------------------------------------------------------------------
    // 汎用処理
    //-------------------------------------------------------------------------------

    /// <summary>アニメーションを再生する汎用メソッド</summary>
    /// <param name="type">再生するアニメーションの種類</param>
    private void PlayAnimation(PlayerAnimationType type)
    {
        _animator.Play($"{_formHandler.GetCurrentForm().ToString()}" + " " + $"{type.ToString()}");
    }

    /// <summary>Float型のパラメーターを設定する汎用メソッド（減衰なし）</summary>
    /// <param name="param">設定するパラメーター</param>
    private void SetFloatParameter(PlayerAnimationParameter param, float value)
    {
        _animator.SetFloat(param.ToString(), value);
    }

    /// <summary>Float型のパラメーターを設定する汎用メソッド（減衰あり）</summary>
    /// <param name="param">設定するパラメーター</param>
    private void SetFloatParameterWithDamp(PlayerAnimationParameter param, float value, float damp)
    {
        _animator.SetFloat(param.ToString(), value, damp, Time.deltaTime);
    }

    /// <summary>現在の形態に沿ってトリガーを有効化する汎用メソッド</summary>
    /// <param name="param">有効化するトリガー</param>
    private void ActivateTrigger(PlayerAnimationParameter param)
    {
        _animator.SetTrigger($"{_formHandler.GetCurrentForm().ToString()}" + " " + $"{param.ToString()}");
    }

    //-------------------------------------------------------------------------------
    // 形態を切り替えるアニメーションの再生に関する処理
    //-------------------------------------------------------------------------------

    /// <summary>形態を切り替えるアニメーションを再生する</summary>
    public void PlaySwitchAnimation()
    {
        PlayAnimation(PlayerAnimationType.Switch);
    }

    //-------------------------------------------------------------------------------
    // 無操作状態アニメーションの再生に関する処理
    //-------------------------------------------------------------------------------

    /// <summary>アイドルアニメーションを再生する</summary>
    public void PlayIdleAnimation()
    {
        
    }

    //-------------------------------------------------------------------------------
    // 移動アニメーションの再生に関する処理
    //-------------------------------------------------------------------------------

    /// <summary>移動アニメーションを再生する</summary>
    public void PlayMoveAnimation()
    {
        PlayAnimation(PlayerAnimationType.Move);
    }

    /// <summary>移動に関するパラメーターを設定する</summary>
    /// <param name="moveInput">移動の入力値</param>
    public void SetMovementParameters(Vector2 moveInput)
    {
        SetFloatParameterWithDamp(PlayerAnimationParameter.InputX, moveInput.x, 0.5f);
        SetFloatParameterWithDamp(PlayerAnimationParameter.InputY, moveInput.y, 0.5f);
        SetFloatParameter(PlayerAnimationParameter.Speed, moveInput.sqrMagnitude);
    }

    //-------------------------------------------------------------------------------
    // 攻撃アニメーションの再生に関する処理
    //-------------------------------------------------------------------------------

    public void ActivateMeleeTrigger()
    {
        ActivateTrigger(PlayerAnimationParameter.Melee);
    }
}
