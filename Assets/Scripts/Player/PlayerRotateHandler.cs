using UnityEngine;

/// <summary>�v���C���[�̉�]�𐧌䂷��N���X</summary>
public class PlayerRotateHandler : MonoBehaviour
{
    /// <summary>�}�E�X�̑��슴�x</summary>
    [SerializeField, Header("�}�E�X�̑��슴�x")] private float _mouseSensitivity;

    public float MouseSensitivity => _mouseSensitivity;

    /// <summary>�}�E�X�̓��͂�ۑ�����ϐ�</summary>
    private float _mouseX;

    private void Update()
    {
        // �}�E�X�̓��͂��󂯎��
        _mouseX += Input.GetAxis("Mouse X") * _mouseSensitivity;

        // �v���C���[����]������
        transform.rotation = Quaternion.Euler(0, _mouseX, 0);
    }
}
