using UnityEngine;

public class FireworkManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem _firework1;
    [SerializeField] private ParticleSystem _firework2;
    [SerializeField] private ParticleSystem _firework3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            PlayFirework(_firework1);
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            PlayFirework(_firework2);
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            PlayFirework(_firework3);
    }

    private void PlayFirework(ParticleSystem firework)
    {
        firework.Play();
    }
}
