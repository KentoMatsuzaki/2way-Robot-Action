/// <summary>�v���C���[�̌`�Ԃ��Ǘ�����N���X</summary>
public class PlayerFormHandler
{
    /// <summary>���݂̌`��</summary>
    private static PlayerForm _currentForm = PlayerForm.Robot;

    /// <summary>���݂̌`�Ԃ��擾����</summary>
    public PlayerForm GetCurrentForm()
    {
        return _currentForm;
    }

    /// <summary>���݂̌`�Ԃ�؂�ւ���</summary>
    public void SwitchCurrentForm()
    {
        _currentForm = _currentForm == PlayerForm.Robot ? PlayerForm.Jett : PlayerForm.Robot;
    }
}