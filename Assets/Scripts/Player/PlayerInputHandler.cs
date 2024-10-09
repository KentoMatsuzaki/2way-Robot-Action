using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>プレイヤーの入力を制御するクラス</summary>
public class PlayerInputHandler : MonoBehaviour
{
    PlayerFormHandler _formHandler;
    PlayerMoveHandler _moveHandler;
    PlayerAnimationHandler _animationHandler;

    /// <summary>移動の入力値</summary>
    private Vector2 _moveInput = Vector2.zero;

    private void Start()
    {
        _formHandler = new PlayerFormHandler();
        _moveHandler = GetComponent<PlayerMoveHandler>();
        _animationHandler = GetComponent<PlayerAnimationHandler>();
    }

    private void Update()
    {
        // 移動方向を毎フレーム更新する
        _moveHandler.SetMoveDirection(_moveInput);

        // アニメーションパラメーターも毎フレーム更新する
        _animationHandler.SetMovementParameters(_moveInput);
    }

    /// <summary>移動アクションが入力された際に呼ばれるイベント</summary>
    public void OnMove(InputAction.CallbackContext context)
    {
        // ボタンが押された瞬間だけイベントを呼び出す
        if (context.performed)
        {
            // 移動の入力値を保存する
            _moveInput = context.ReadValue<Vector2>();
        }

        // ボタンが離された瞬間だけイベントを呼び出す
        else if (context.canceled)
        {
            // 移動の入力値をリセットする
            _moveInput = Vector2.zero;
        }
    }

    /// <summary>近接攻撃アクションが入力された際に呼ばれるイベント</summary>
    public void OnMeleeAttack(InputAction.CallbackContext context)
    {
        // ボタンが押された瞬間だけイベントを呼び出す
        if (context.performed)
        {
            _animationHandler.ActivateMeleeTrigger();
        }
    }

    /// <summary>遠距離攻撃アクションが入力された際に呼ばれるイベント</summary>
    public void OnRangedAttack(InputAction.CallbackContext context)
    {
        // ボタンが押された瞬間だけイベントを呼び出す
        if (context.performed)
        {
            _animationHandler.SetRangedFlagTrue();
        }

        // ボタンが離された瞬間だけイベントを呼び出す
        else if (context.canceled)
        {
            _animationHandler.SetRangedFlagFalse();
        }
    }

    /// <summary>形態を切り替えるアクションが入力された際に呼ばれるイベント</summary>
    public void OnSwitchForm(InputAction.CallbackContext context)
    {
        // ボタンが押された瞬間だけイベントを呼び出す
        if (context.performed)
        {
            // 形態を切り替える
            _formHandler.SwitchCurrentForm();

            // 形態を切り替えるアニメーションを再生する
            _animationHandler.PlaySwitchAnimation();
        } 
    }
}
