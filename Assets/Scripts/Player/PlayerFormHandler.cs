/// <summary>�v���C���[�̌`�Ԃ��Ǘ�����N���X</summary>
public class PlayerFormHandler
{
    /// <summary>�v���C���[�̌��݂̌`��</summary>
    private static PlayerForm _currentForm = PlayerForm.Robot;

    /// <summary>�v���C���[�̌`�Ԃ��擾����</summary>
    public PlayerForm GetPlayerForm()
    {
        return _currentForm;
    }

    /// <summary>�v���C���[�̌`�Ԃ�؂�ւ���</summary>
    public void SwitchPlayerForm()
    {
        _currentForm = _currentForm == PlayerForm.Robot ? PlayerForm.Jett : PlayerForm.Robot;
    }
}