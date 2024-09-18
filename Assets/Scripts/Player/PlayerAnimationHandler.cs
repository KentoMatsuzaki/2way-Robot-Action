using UnityEngine;

/// <summary>�v���C���[�̃A�j���[�V�������Ǘ�����N���X</summary>
public class PlayerAnimationHandler : MonoBehaviour
{
    /// <summary>�v���C���[�̃A�j���[�^�[�R���g���[���[</summary>
    Animator _animator;

    /// <summary>�v���C���[�̌`�ԊǗ�</summary>
    PlayerFormHandler _formHandler;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _formHandler = new PlayerFormHandler();
    }

    //-------------------------------------------------------------------------------
    // �`�Ԃ�؂�ւ���A�j���[�V����
    //-------------------------------------------------------------------------------

    /// <summary>�`�Ԃ�؂�ւ���A�j���[�V�������Đ�����</summary>
    public void PlaySwitchAnimation()
    {
        _animator.Play(IsRobot() ? PlayerAnimation.Jett.ToString() : PlayerAnimation.Robot.ToString());
    }

    //-------------------------------------------------------------------------------
    // �A�j���[�V�����̍Đ��Ɋւ��鏈��
    //-------------------------------------------------------------------------------

    /// <summary>�v���C���[�����s�`�Ԃł��邩</summary>
    private bool IsRobot()
    {
        if (_formHandler.GetPlayerForm() == PlayerForm.Robot) return true;
        else return false;
    }

    /// <summary>�v���C���[����s�`�Ԃł��邩</summary>
    private bool IsJett()
    {
        if (_formHandler.GetPlayerForm() == PlayerForm.Jett) return true;
        else return false;
    }
}
