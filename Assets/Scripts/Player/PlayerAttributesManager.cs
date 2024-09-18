/// <summary>�v���C���[�̌`�ԂƏ�Ԃ��Ǘ�����N���X</summary>
public class PlayerAttributesManager
{
    /// <summary>�v���C���[�̌`�Ԃ������񋓌^</summary>
    public enum PlayerForm
    {
        Robot, // ���{�b�g�`��
        Jett // ��s�`��
    }

    /// <summary>�v���C���[�̏�Ԃ������񋓌^</summary>
    public enum PlayerState
    {
        Idle, // �A�C�h�����
        Move, // �ړ����
        Attack, // �U�����
        Damage, // ��_���[�W���
        Die, // ���S���
    }

    /// <summary>�v���C���[�̌��݂̌`��</summary>
    private static PlayerForm _currentForm = PlayerForm.Robot;

    /// <summary>�v���C���[�̌��݂̏��</summary>
    private static PlayerState _currentState = PlayerState.Idle;

    /// <summary>�v���C���[�̌��݂̌`�Ԃ��擾����</summary>
    public PlayerForm GetPlayerForm() => _currentForm;

    /// <summary>�v���C���[�̌��݂̏�Ԃ��擾����</summary>
    public PlayerState GetPlayerState() => _currentState;

    /// <summary>�v���C���[�̌��݂̌`�Ԃ�ݒ肷��</summary>
    public void SetPlayerForm(PlayerForm form)
    {
        _currentForm = form;
    }

    /// <summary>�v���C���[�̌��݂̏�Ԃ�ݒ肷��</summary>
    public void SetPlayerState(PlayerState state)
    {
        _currentState = state;
    }
}