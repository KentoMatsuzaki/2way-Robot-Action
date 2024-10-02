using UnityEngine;

/// <summary>�v���C���[�̈ړ��������Ǘ�����N���X</summary>
public class PlayerMoveHandler : MonoBehaviour
{
    /// <summary>���{�b�g�`�Ԃ̈ړ����x</summary>
    [SerializeField, Header("���{�b�g�`�Ԃ̈ړ����x")] private float _robotMoveSpeed;

    /// <summary>�W�F�b�g�`�Ԃ̈ړ����x</summary>
    [SerializeField, Header("�W�F�b�g�`�Ԃ̈ړ����x")] private float _jettMoveSpeed;

    /// <summary>�ړ�����</summary>
    private Vector3 moveDirection = Vector3.zero;

    private PlayerFormHandler _formHandler;

    private void Awake()
    {
        _formHandler = new PlayerFormHandler();
    }

    private void Update()
    {
        Move();
    }

    /// <summary>�ړ�����</summary>
    private void Move()
    {
        switch(_formHandler.GetCurrentForm())
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
        moveDirection = new Vector3(moveInput.x, 0, moveInput.y).normalized;
    }
}
