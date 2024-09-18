using UnityEngine;

/// <summary>プレイヤーの移動処理を管理するクラス</summary>
public class PlayerMoveHandler : MonoBehaviour
{
    /// <summary>歩行形態の移動速度</summary>
    [SerializeField, Header("歩行形態の移動速度")] private float _robotMoveSpeed;

    [SerializeField, Header("飛行形態の移動速度")] private float _jettMoveSpeed;

    /// <summary>移動方向</summary>
    private Vector3 moveDirection;

    private PlayerFormHandler _formHandler;

    private PlayerStateHandler _stateHandler;

    private void Awake()
    {
        _formHandler = new PlayerFormHandler();
        _stateHandler = new PlayerStateHandler();
    }

    private void Update()
    {
        Move();
    }

    /// <summary>移動処理</summary>
    private void Move()
    {
        switch(_formHandler.GetPlayerForm())
        {
            case PlayerForm.Robot:
                 transform.Translate(moveDirection * _robotMoveSpeed * Time.deltaTime); break;
            
            case PlayerForm.Jett:
                 transform.Translate(moveDirection * _jettMoveSpeed * Time.deltaTime); break;   
        }
    }

    /// <summary>移動方向を設定する</summary>
    /// <param name="moveInput">移動の入力値</param>
    public void SetMoveDirection(Vector2 moveInput)
    {
        moveDirection = new Vector3(moveInput.x, 0, moveInput.y);
    }
}
