using UnityEngine;

public class Level : MonoBehaviour
{
    private Enemy [] _enemies;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }
    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies) 
        {
            if (enemy!= null)
                {
                    return;
                }

            Debug.Log("You killed all Enemies");

            //string nextlevelName = ""
        }
    }
}
