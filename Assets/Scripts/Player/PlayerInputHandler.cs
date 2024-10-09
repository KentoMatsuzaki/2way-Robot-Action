using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>�v���C���[�̓��͂𐧌䂷��N���X</summary>
public class PlayerInputHandler : MonoBehaviour
{
    PlayerFormHandler _formHandler;
    PlayerMoveHandler _moveHandler;
    PlayerAnimationHandler _animationHandler;

    /// <summary>�ړ��̓��͒l</summary>
    private Vector2 _moveInput = Vector2.zero;

    private void Start()
    {
        _formHandler = new PlayerFormHandler();
        _moveHandler = GetComponent<PlayerMoveHandler>();
        _animationHandler = GetComponent<PlayerAnimationHandler>();
    }

    private void Update()
    {
        // �ړ������𖈃t���[���X�V����
        _moveHandler.SetMoveDirection(_moveInput);

        // �A�j���[�V�����p�����[�^�[�����t���[���X�V����
        _animationHandler.SetMovementParameters(_moveInput);
    }

    /// <summary>�ړ��A�N�V���������͂��ꂽ�ۂɌĂ΂��C�x���g</summary>
    public void OnMove(InputAction.CallbackContext context)
    {
        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        if (context.performed)
        {
            // �ړ��̓��͒l��ۑ�����
            _moveInput = context.ReadValue<Vector2>();
        }

        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        else if (context.canceled)
        {
            // �ړ��̓��͒l�����Z�b�g����
            _moveInput = Vector2.zero;
        }
    }

    /// <summary>�ߐڍU���A�N�V���������͂��ꂽ�ۂɌĂ΂��C�x���g</summary>
    public void OnMeleeAttack(InputAction.CallbackContext context)
    {
        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        if (context.performed)
        {
            _animationHandler.ActivateMeleeTrigger();
        }
    }

    /// <summary>�������U���A�N�V���������͂��ꂽ�ۂɌĂ΂��C�x���g</summary>
    public void OnRangedAttack(InputAction.CallbackContext context)
    {
        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        if (context.performed)
        {
            _animationHandler.SetRangedFlagTrue();
        }

        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        else if (context.canceled)
        {
            _animationHandler.SetRangedFlagFalse();
        }
    }

    /// <summary>�`�Ԃ�؂�ւ���A�N�V���������͂��ꂽ�ۂɌĂ΂��C�x���g</summary>
    public void OnSwitchForm(InputAction.CallbackContext context)
    {
        // �{�^���������ꂽ�u�Ԃ����C�x���g���Ăяo��
        if (context.performed)
        {
            // �`�Ԃ�؂�ւ���
            _formHandler.SwitchCurrentForm();

            // �`�Ԃ�؂�ւ���A�j���[�V�������Đ�����
            _animationHandler.PlaySwitchAnimation();
        } 
    }
}
