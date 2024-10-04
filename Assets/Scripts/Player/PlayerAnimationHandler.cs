using System.Collections;
using UnityEngine;

/// <summary>�v���C���[�̃A�j���[�V�������Ǘ�����N���X</summary>
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
    // �ėp����
    //-------------------------------------------------------------------------------

    /// <summary>�A�j���[�V�������Đ�����ėp���\�b�h</summary>
    /// <param name="type">�Đ�����A�j���[�V�����̎��</param>
    private void PlayAnimation(PlayerAnimationType type)
    {
        _animator.Play($"{_formHandler.GetCurrentForm().ToString()}" + " " + $"{type.ToString()}");
    }

    /// <summary>Float�^�̃p�����[�^�[��ݒ肷��ėp���\�b�h�i�����Ȃ��j</summary>
    /// <param name="param">�ݒ肷��p�����[�^�[</param>
    private void SetFloatParameter(PlayerAnimationParameter param, float value)
    {
        _animator.SetFloat(param.ToString(), value);
    }

    /// <summary>Float�^�̃p�����[�^�[��ݒ肷��ėp���\�b�h�i��������j</summary>
    /// <param name="param">�ݒ肷��p�����[�^�[</param>
    private void SetFloatParameterWithDamp(PlayerAnimationParameter param, float value, float damp)
    {
        _animator.SetFloat(param.ToString(), value, damp, Time.deltaTime);
    }

    /// <summary>���݂̌`�Ԃɉ����ăg���K�[��L��������ėp���\�b�h</summary>
    /// <param name="param">�L��������g���K�[</param>
    private void ActivateTrigger(PlayerAnimationParameter param)
    {
        _animator.SetTrigger($"{_formHandler.GetCurrentForm().ToString()}" + " " + $"{param.ToString()}");
    }

    //-------------------------------------------------------------------------------
    // �`�Ԃ�؂�ւ���A�j���[�V�����̍Đ��Ɋւ��鏈��
    //-------------------------------------------------------------------------------

    /// <summary>�`�Ԃ�؂�ւ���A�j���[�V�������Đ�����</summary>
    public void PlaySwitchAnimation()
    {
        PlayAnimation(PlayerAnimationType.Switch);
    }

    //-------------------------------------------------------------------------------
    // �������ԃA�j���[�V�����̍Đ��Ɋւ��鏈��
    //-------------------------------------------------------------------------------

    /// <summary>�A�C�h���A�j���[�V�������Đ�����</summary>
    public void PlayIdleAnimation()
    {
        
    }

    //-------------------------------------------------------------------------------
    // �ړ��A�j���[�V�����̍Đ��Ɋւ��鏈��
    //-------------------------------------------------------------------------------

    /// <summary>�ړ��A�j���[�V�������Đ�����</summary>
    public void PlayMoveAnimation()
    {
        PlayAnimation(PlayerAnimationType.Move);
    }

    /// <summary>�ړ��Ɋւ���p�����[�^�[��ݒ肷��</summary>
    /// <param name="moveInput">�ړ��̓��͒l</param>
    public void SetMovementParameters(Vector2 moveInput)
    {
        SetFloatParameterWithDamp(PlayerAnimationParameter.InputX, moveInput.x, 0.5f);
        SetFloatParameterWithDamp(PlayerAnimationParameter.InputY, moveInput.y, 0.5f);
        SetFloatParameter(PlayerAnimationParameter.Speed, moveInput.sqrMagnitude);
    }

    //-------------------------------------------------------------------------------
    // �U���A�j���[�V�����̍Đ��Ɋւ��鏈��
    //-------------------------------------------------------------------------------

    public void ActivateMeleeTrigger()
    {
        ActivateTrigger(PlayerAnimationParameter.Melee);
    }
}
