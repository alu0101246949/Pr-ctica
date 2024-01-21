using UnityEngine;

public class SpiderScript : MonoBehaviour
{
    public Transform monster;
    public float speed = 5.0f;

    private bool moveTowardsMonster = false;

    private void OnEnable()
    {
        MonsterScript.OnMonsterReachedChair += StartMovingTowardsMonster;
    }

    private void OnDisable()
    {
        MonsterScript.OnMonsterReachedChair -= StartMovingTowardsMonster;
    }

    private void StartMovingTowardsMonster()
    {
        moveTowardsMonster = true;
    }

    private void Update()
    {
        if (moveTowardsMonster)
        {
            MoveTowards(monster.position);
        }
    }

    private void MoveTowards(Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
