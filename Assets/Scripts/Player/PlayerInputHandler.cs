using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>���͎��ɌĂ΂��C�x���g���Ǘ�����N���X</summary>
public class PlayerInputHandler : MonoBehaviour
{
    /// <summary>�v���C���[�̌`�ԊǗ�</summary>
    PlayerFormHandler _formHandler;

    PlayerMoveHandler _moveHandler;

    PlayerAnimationHandler _animationHandler;

    private void Start()
    {
        _formHandler = new PlayerFormHandler();
        _moveHandler = GetComponent<PlayerMoveHandler>();
        _animationHandler = GetComponent<PlayerAnimationHandler>();
    }

    /// <summary>�ړ��A�N�V���������͂��ꂽ�ۂɌĂ΂��C�x���g</summary>
    public void OnMove(InputAction.CallbackContext context)
    {
        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        if (context.performed)
        {
            // �ړ��̓��͒l���󂯎��
            Vector2 moveInput = context.ReadValue<Vector2>();

            // �ړ��������Ăяo��
            _moveHandler.SetMoveDirection(moveInput);
        }

        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        else if (context.canceled)
        {
            _moveHandler.SetMoveDirection(Vector2.zero);
        }
    }

    /// <summary>�U���A�N�V�����i���j�����͂��ꂽ�ۂɌĂ΂��C�x���g</summary>
    public void OnAttackLeft(InputAction.CallbackContext context)
    {
        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        if (context.performed)
        {

        }
    }

    /// <summary>�U���A�N�V�����i�E�j�����͂��ꂽ�ۂɌĂ΂��C�x���g</summary>
    public void OnAttackRight(InputAction.CallbackContext context)
    {
        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        if (context.performed)
        {

        }
    }

    /// <summary>�`�Ԃ�؂�ւ���A�N�V���������͂��ꂽ�ۂɌĂ΂��C�x���g</summary>
    public void OnSwitchForm(InputAction.CallbackContext context)
    {
        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        if (context.performed)
        {
            // �`�Ԃ�؂�ւ���
            _formHandler.SwitchPlayerForm();

            // �`�Ԃ�؂�ւ���A�j���[�V�������Đ�����
            _animationHandler.PlaySwitchFormAnimation();
        } 
    }
}
