using UnityEngine;

/// <summary>�v���C���[�̈ړ��������Ǘ�����N���X</summary>
public class PlayerMoveHandler : MonoBehaviour
{
    /// <summary>���s�`�Ԃ̈ړ����x</summary>
    [SerializeField, Header("���s�`�Ԃ̈ړ����x")] private float _robotMoveSpeed;

    [SerializeField, Header("��s�`�Ԃ̈ړ����x")] private float _jettMoveSpeed;

    /// <summary>�ړ�����</summary>
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

    /// <summary>�ړ�����</summary>
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

    /// <summary>�ړ�������ݒ肷��</summary>
    /// <param name="moveInput">�ړ��̓��͒l</param>
    public void SetMoveDirection(Vector2 moveInput)
    {
        moveDirection = new Vector3(moveInput.x, 0, moveInput.y);
    }
}
