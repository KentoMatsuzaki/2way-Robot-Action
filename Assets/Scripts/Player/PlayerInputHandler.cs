using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>入力時に呼ばれるイベントを管理するクラス</summary>
public class PlayerInputHandler : MonoBehaviour
{
    /// <summary>プレイヤーの形態管理</summary>
    PlayerFormHandler _formHandler;

    PlayerMoveHandler _moveHandler;

    PlayerAnimationHandler _animationHandler;

    private void Start()
    {
        _formHandler = new PlayerFormHandler();
        _moveHandler = GetComponent<PlayerMoveHandler>();
        _animationHandler = GetComponent<PlayerAnimationHandler>();
    }

    /// <summary>移動アクションが入力された際に呼ばれるイベント</summary>
    public void OnMove(InputAction.CallbackContext context)
    {
        // ボタンが押された瞬間だけイベントを呼び出す
        if (context.performed)
        {
            // 移動の入力値を受け取る
            Vector2 moveInput = context.ReadValue<Vector2>();

            // 移動処理を呼び出す
            _moveHandler.SetMoveDirection(moveInput);
        }

        // ボタンが離された瞬間だけイベントを呼び出す
        else if (context.canceled)
        {
            _moveHandler.SetMoveDirection(Vector2.zero);
        }
    }

    /// <summary>攻撃アクション（左）が入力された際に呼ばれるイベント</summary>
    public void OnAttackLeft(InputAction.CallbackContext context)
    {
        // ボタンが押された瞬間だけイベントを呼び出す
        if (context.performed)
        {

        }
    }

    /// <summary>攻撃アクション（右）が入力された際に呼ばれるイベント</summary>
    public void OnAttackRight(InputAction.CallbackContext context)
    {
        // ボタンが押された瞬間だけイベントを呼び出す
        if (context.performed)
        {

        }
    }

    /// <summary>形態を切り替えるアクションが入力された際に呼ばれるイベント</summary>
    public void OnSwitchForm(InputAction.CallbackContext context)
    {
        // ボタンが押された瞬間だけイベントを呼び出す
        if (context.performed)
        {
            // 形態を切り替える
            _formHandler.SwitchPlayerForm();

            // 形態を切り替えるアニメーションを再生する
            _animationHandler.PlaySwitchFormAnimation();
        } 
    }
}
