using UnityEngine;
using Unity.MLAgents;

public class Target : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
        var agent = collision.gameObject.GetComponent<Agent>();

        if (agent != null && agent.CompareTag("Prey"))
        {
            agent.AddReward(1f);
            Respawn();
        }
    }

    // Change Y coord
    public void Respawn()
    {
        gameObject.transform.localPosition =
            new Vector3(
                (1 - 2 * Random.value) * 5f,
                2f + Random.value * 5f,
                (1 - 2 * Random.value) * 5f);
    }
}
