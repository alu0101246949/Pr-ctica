using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    public delegate void MonsterReachedChair();
    public static event MonsterReachedChair OnMonsterReachedChair;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Chair"))
        {
            Debug.Log("wiii");
            OnMonsterReachedChair?.Invoke();
        }
    }
}
