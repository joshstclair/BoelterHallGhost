using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Jumpscare : MonoBehaviour {


	public AudioMixerSnapshot normal;
	public AudioMixerSnapshot scared;


	private float m_TransitionIn;
	private float m_TransitionOut;
	private float m_QuarterNote;

	// Use this for initialization
	void Start () {
		m_QuarterNote = .5f;
		m_TransitionIn = m_QuarterNote;
		m_TransitionOut = m_QuarterNote * 32;
	
	}

	void onTriggerEnter(Collider other)
	{
		if (other.CompareTag ("MonsterArea")) {
			scared.TransitionTo(m_TransitionIn);
		}

	}
	void onTriggerExit(Collider other)
	{
		if (other.CompareTag ("MonsterArea")) {
			normal.TransitionTo(m_TransitionOut); 
		}
	}

}
