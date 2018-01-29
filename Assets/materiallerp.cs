using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materiallerp : MonoBehaviour {

	public Material attempt1;
	public Material attempt2;
	public Material attempt3;
	public Material attempt4;
	public Material attempt5;
	public GameObject fireworks;
	public GameObject smoke;
	public GameObject steam;
	public GameObject stars;

	public float _Skyboxblendfactor = 0.01f;
	public float _Skyboxblendfactor2 = 0.01f;
	public float _Skyboxblendfactor3 = 0.01f;
	public float _Skyboxblendfactor4 = 0.01f;
	public float _Skyboxblendfactor5 = 0.01f;

	public float _Skyboxblendspeed = 0.05f;

	void Start() {

		_Skyboxblendspeed = 0.0275f;

	}
	void Update ()
	{

		firststep ();
		if (_Skyboxblendfactor == 1) {
			secondstep ();
			if (_Skyboxblendfactor2 == 1) {
				thirdstep ();
				if (_Skyboxblendfactor3 == 1) {
					fourthstep ();
					if (_Skyboxblendfactor4 == 1) {
						fifthstep ();
						if (_Skyboxblendfactor5 == 1) {
							sixthstep ();
					
						}
					}
				}
			}
		}
	}

	void firststep ()
	{
		RenderSettings.skybox = attempt1;
		_Skyboxblendfactor += _Skyboxblendspeed * Time.deltaTime;

		RenderSettings.skybox.SetFloat ("_Blend", _Skyboxblendfactor);


		if (_Skyboxblendfactor > 1) {
			_Skyboxblendfactor = 1;
			Destroy (fireworks);
		}
	}


	void secondstep ()
	{
		RenderSettings.skybox = attempt2;

		RenderSettings.skybox.SetFloat ("_Blend", 0);	
		_Skyboxblendfactor2 += _Skyboxblendspeed * Time.deltaTime;

		RenderSettings.skybox.SetFloat ("_Blend", _Skyboxblendfactor2);	

		if (_Skyboxblendfactor2 > 1) {
			_Skyboxblendfactor2 = 1;

		}
	}	
			void thirdstep ()
	{
		smoke.SetActive (true);
		RenderSettings.skybox = attempt3;
		RenderSettings.skybox.SetFloat ("_Blend", 0);	
		_Skyboxblendfactor3 += _Skyboxblendspeed * Time.deltaTime;

		RenderSettings.skybox.SetFloat ("_Blend", _Skyboxblendfactor3);	
		if (_Skyboxblendfactor3 > 1) {
			_Skyboxblendfactor3 = 1;
			smoke.SetActive (false);
		}
	}

			void fourthstep ()
	{
		steam.SetActive (true);
		RenderSettings.skybox = attempt4;
		RenderSettings.skybox.SetFloat ("_Blend", 0);	
		_Skyboxblendfactor4 += _Skyboxblendspeed * Time.deltaTime;

		RenderSettings.skybox.SetFloat ("_Blend", _Skyboxblendfactor4);	
		if (_Skyboxblendfactor4 > 1) {
			_Skyboxblendfactor4 = 1;
			steam.SetActive (false);
		}
	}
		void fifthstep ()
	{
		RenderSettings.skybox = attempt5;
		RenderSettings.skybox.SetFloat ("_Blend", 0);	
		_Skyboxblendfactor5 += _Skyboxblendspeed * Time.deltaTime;

		RenderSettings.skybox.SetFloat ("_Blend", _Skyboxblendfactor5);	
		if (_Skyboxblendfactor5 > 1) {
			_Skyboxblendfactor5 = 1;
		}
	}
	void sixthstep () {

		stars.SetActive (true);
	}

}
