using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDirectionColorChanger : MonoBehaviour {

	public GameObject block;
	public GameObject blueh1;
	public GameObject blueh2;
	public GameObject blueh3;

	public GameObject redh1;
	public GameObject redh2;
	public GameObject redh3;
	public GameObject bluev1;
	public GameObject bluev2;
	public GameObject bluev3;
	public GameObject redv1;
	public GameObject redv2;
	public GameObject redv3;
	public GameObject particles;
	
	private bool b;
	private bool r;
	private bool w;

	public ParticleSystem bubbl;

	public Color white;
	public Color blue;
	public Color red;

	void Update()
	{
		b = block.GetComponent<ChangeColor>().isblue;
		r = block.GetComponent<ChangeColor>().isred;
		w = block.GetComponent<ChangeColor>().iswhite;

		if(w == true)
		{
			particles.SetActive(false);
			blueh1.SetActive(false);
			blueh2.SetActive(false);
			blueh3.SetActive(false);
			redh1.SetActive(false);
			redh2.SetActive(false);
			redh3.SetActive(false);
			bluev1.SetActive(false);
			bluev2.SetActive(false);
			bluev3.SetActive(false);
			redv1.SetActive(false);
			redv2.SetActive(false);
			redv3.SetActive(false);
			bubbl.startColor = white;
		}

		if(b == true && block.GetComponent<ChangeColor>().horizontal == true)
		{
			particles.SetActive(true);
			blueh1.SetActive(true);

			if (block.GetComponent<ChangeColor>().rend.color == block.GetComponent<ChangeColor>().blue[1])
			{
				StartCoroutine(Blueh2());
			}

			if (block.GetComponent<ChangeColor>().rend.color == block.GetComponent<ChangeColor>().blue[2])
			{
				blueh1.SetActive(false);
				blueh2.SetActive(false);
				blueh3.SetActive(true);
			}
		}

		if(r == true && block.GetComponent<ChangeColor>().horizontal == true)
		{
			particles.SetActive(true);
			redh1.SetActive(true);

			if (block.GetComponent<ChangeColor>().rend.color == block.GetComponent<ChangeColor>().red[1])
			{
				StartCoroutine(Redh2());
			}

			if (block.GetComponent<ChangeColor>().rend.color == block.GetComponent<ChangeColor>().red[2])
			{
				redh1.SetActive(false);
				redh2.SetActive(false);
				redh3.SetActive(true);
			}
		}

		if(b == true && block.GetComponent<ChangeColor>().vertical == true)
		{
			particles.SetActive(true);
			bluev1.SetActive(true);

			if (block.GetComponent<ChangeColor>().rend.color == block.GetComponent<ChangeColor>().blue[1])
			{
				StartCoroutine(Bluev2());
			}

			if (block.GetComponent<ChangeColor>().rend.color == block.GetComponent<ChangeColor>().blue[2])
			{
				bluev1.SetActive(false);
				bluev2.SetActive(false);
				bluev3.SetActive(true);
			}
		}

		if(r == true && block.GetComponent<ChangeColor>().vertical == true)
		{
			particles.SetActive(true);
			redv1.SetActive(true);

			if (block.GetComponent<ChangeColor>().rend.color == block.GetComponent<ChangeColor>().red[1])
			{
				StartCoroutine(Redv2());
			}

			if (block.GetComponent<ChangeColor>().rend.color == block.GetComponent<ChangeColor>().red[2])
			{
				redv1.SetActive(false);
				redv2.SetActive(false);
				redv3.SetActive(true);
			}
		}
	}
		IEnumerator Blueh2()
		{
			blueh1.SetActive(false);
			yield return new WaitForSeconds(0.001f);
			blueh2.SetActive(true);
		}
		IEnumerator Redh2()
		{
			redh1.SetActive(false);
			yield return new WaitForSeconds(0.001f);
			redh2.SetActive(true);
		}

		IEnumerator Bluev2()
		{
			bluev1.SetActive(false);
			yield return new WaitForSeconds(0.001f);
			bluev2.SetActive(true);
		}
		IEnumerator Redv2()
		{
			redv1.SetActive(false);
			yield return new WaitForSeconds(0.001f);
			redv2.SetActive(true);
		}


}
