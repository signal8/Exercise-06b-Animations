using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private Animator m_Animator;

	void Start()
	{
		m_Animator = gameObject.GetComponent<Animator>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.F)) 
			m_Animator.SetTrigger("Firing");
	}
}
