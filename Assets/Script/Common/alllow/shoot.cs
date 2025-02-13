using UnityEngine;
using UnityEngine.InputSystem;

public class shoot : MonoBehaviour
{
    [SerializeField] public InputActionReference shootButton;
    public GameObject arrowPrefab; // ���Prefab���C���X�y�N�^�[�Őݒ�
    public Transform shootPoint;   // �ˏo�ʒu�i�����K�v�ł���ΐݒ�j
    public float shootForce = 10f; // ����ˏo�����

    // ����ˏo����������C���X�y�N�^�[�Œ����\�ɂ��邽�߂̕ϐ�
    [SerializeField] private Vector3 shootDirection = Vector3.forward;

    private void Update()
    {
        if (shootButton.action.WasPerformedThisFrame())
        {
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        // ����ˏo�ʒu���琶��
        GameObject arrow = Instantiate(arrowPrefab, shootPoint.position, shootPoint.rotation);

        // ���Rigidbody������Η͂�������
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // shootDirection���g���Ė���ˏo
            rb.AddForce(shootDirection.normalized * shootForce, ForceMode.Impulse);  // �����𒲐�
        }
    }

    // �C���X�y�N�^�[�ŕ�����ݒ肵�₷�����邽�߂�get, set��񋟁i�I�v�V�����j
    public Vector3 ShootDirection
    {
        get { return shootDirection; }
        set { shootDirection = value; }
    }
}
