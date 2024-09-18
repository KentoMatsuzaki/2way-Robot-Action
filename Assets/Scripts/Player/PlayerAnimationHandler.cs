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

    /// <summary>�`�Ԃ�؂�ւ���A�j���[�V�������Đ�����</summary>
    public void PlaySwitchFormAnimation()
    {
        if (_formHandler.GetPlayerForm() == PlayerForm.Robot)
        {
            _animator.Play("Robot Form");
        }
        else if (_formHandler.GetPlayerForm() == PlayerForm.Jett)
        {
            _animator.Play("Jett Form");
        }
    }
}
