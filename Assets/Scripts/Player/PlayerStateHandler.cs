/// <summary>�v���C���[�̏�Ԃ��Ǘ�����N���X</summary>
public class PlayerStateHandler
{
    /// <summary>�v���C���[�̏�Ԃ������񋓌^</summary>
    public enum PlayerState
    {
        Idle, // �A�C�h�����
        Move, // �ړ����
        Attack, // �U�����
        Damage, // ��_���[�W���
        Die, // ���S���
    }

    /// <summary>�v���C���[�̌��݂̏��</summary>
    private static PlayerState _currentState = PlayerState.Idle;

    /// <summary>�v���C���[�̏�Ԃ��擾����</summary>
    public PlayerState GetPlayerState()
    {
         return _currentState;
    }

    /// <summary>�v���C���[�̏�Ԃ�ݒ肷��</summary>
    public void SetPlayerState(PlayerState state)
    {
        _currentState = state;
    }
}
