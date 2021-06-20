using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collisiondetect : MonoBehaviour
{

    public int counter;
    public TextMeshPro counterDisp;
    private AudioSource sound;
    // public MeshDestroy meshDestroy;

	public GameObject particle;
	private List<GameObject> onScreenParticles = new List<GameObject>();
	private Transform hitObject;
	private void Awake()
	{
		StartCoroutine("CheckForDeletedParticles");

	}
	private void Start()
    {
        sound = GetComponent<AudioSource>();
		hitObject = particle.transform;

	}
	void OnCollisionEnter(Collision collision)
    {

        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "fallObject")
        {
            int currentVal = int.Parse(counterDisp.text) + 1;
            counter++;
            counterDisp.text = currentVal.ToString();
			hitObject.transform.position = collision.gameObject.transform.position;
			spawnParticle();
			collision.gameObject.GetComponent<MeshDestroy>().DestroyMesh();
            sound.Play();

        }

    
    }


	public GameObject spawnParticle()
	{
		GameObject particles = (GameObject)Instantiate(particle);
		particles.transform.position = hitObject.transform.position;
		particles.SetActive(true);


		if (particles.name.StartsWith("WFX_MF"))
		{
			particles.transform.parent = particle.transform.parent;
			particles.transform.localPosition = particle.transform.localPosition;
			particles.transform.localRotation = particle.transform.localRotation;
		}

		ParticleSystem ps = particles.GetComponent<ParticleSystem>();
#if UNITY_5_5_OR_NEWER
		if (ps != null)
		{
			var main = ps.main;
			if (main.loop)
			{
				ps.gameObject.AddComponent<CFX_AutoStopLoopedEffect>();
				ps.gameObject.AddComponent<CFX_AutoDestructShuriken>();
			}
		}
#else
		if(ps != null && ps.loop)
		{
			ps.gameObject.AddComponent<CFX_AutoStopLoopedEffect>();
			ps.gameObject.AddComponent<CFX_AutoDestructShuriken>();
		}
#endif

		onScreenParticles.Add(particles);

		return particles;
	}
	
	IEnumerator CheckForDeletedParticles()
	{
		while (true)
		{
			yield return new WaitForSeconds(5.0f);
			for (int i = onScreenParticles.Count - 1; i >= 0; i--)
			{
				if (onScreenParticles[i] == null)
				{
					onScreenParticles.RemoveAt(i);
				}
			}
		}
	}
	
}
