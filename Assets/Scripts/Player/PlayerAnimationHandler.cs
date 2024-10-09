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

    /// <summary>���݂̌`�Ԃɉ����ăA�j���[�V�������Đ�����ėp���\�b�h</summary>
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

    /// <summary>���݂̌`�Ԃɉ����ăt���O��true�ɂ���ėp���\�b�h</summary>
    /// <param name="param">true�ɂ���t���O</param>
    private void SetFlagTrue(PlayerAnimationParameter param)
    {
        _animator.SetBool($"{_formHandler.GetCurrentForm().ToString()}" + " " + $"{param.ToString()}", true);
    }

    /// <summary>���݂̌`�Ԃɉ����ăt���O��false�ɂ���ėp���\�b�h</summary>
    /// <param name="param">false�ɂ���t���O</param>
    private void SetFlagFalse(PlayerAnimationParameter param)
    {
        _animator.SetBool($"{_formHandler.GetCurrentForm().ToString()}" + " " + $"{param.ToString()}", false);
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

    /// <summary>�ߐڍU���̃g���K�[��L��������</summary>
    public void ActivateMeleeTrigger()
    {
        if (_formHandler.GetCurrentForm() != PlayerForm.Robot) return;
        ActivateTrigger(PlayerAnimationParameter.Melee);
    }

    /// <summary>�������U���̃t���O��true�ɂ���</summary>
    public void SetRangedFlagTrue()
    {
        SetFlagTrue(PlayerAnimationParameter.Ranged);
    }

    /// <summary>�������U���̃t���O��false�ɂ���</summary>
    public void SetRangedFlagFalse()
    {
        SetFlagFalse(PlayerAnimationParameter.Ranged);
    }
}
